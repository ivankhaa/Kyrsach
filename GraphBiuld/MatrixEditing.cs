using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

static public class MatrixEditing
{
    static public double Strength(List<List<int>> a, int edge)
    {
        if (a.Count == 1)
        {
            return 0;
        }
        else
        {
            double extraEdge = 0;
            for (int i = 0; i < a.Count; i++)
                extraEdge += a[i].Count * ((a[i].Count - 1.0) / 2.0);
            extraEdge = edge - extraEdge;

            return extraEdge / (a.Count - 1.0);
        }
    }
    static public string GetFI(int[,] mtrx)
    {
        int lenght = (int)Math.Sqrt(mtrx.Length);
        string fi = lenght.ToString();
        for (int i = 0; i < lenght; i++)
        {
            fi += " ";
            for (int j = 0; j < lenght; j++)
                if (mtrx[i, j] == 1)
                    fi += j.ToString()+" ";
            fi += "-1";
        }

        return fi;
    }
    static public int[,] GetMatrix(int size, int edge) 
    {
        int[,] matrx = new int[size, size];
        List<int> randEdge = RandomEdge.EdgeGenerate(size);
        for (int i = 0, j = 0; i < edge; i++)
        {
            if (randEdge[i] >= size)
            {
                j++;
                randEdge[i] = randEdge[i] - size + 1 + j;
                i--;

                continue;
            }
            else
            {
                matrx[j, randEdge[i]] = 1;
                j = 0;
            }
        }
        return matrx;
    }
    static public int[,] GetMatrixFI(string FI)
    {
        try
        {
            int[] fi = FI.Split(' ').Select(Int32.Parse).ToArray();
            int lenght = Convert.ToInt32(fi[0]);
            int[,] matrx = new int[lenght, lenght];

            for (int i = 0, j = 1; i < lenght; i++)
            {
                for (; j <= fi.Length;)
                {
                    if (fi[j] == -1)
                    {
                        j++;
                        break;
                    }
                    matrx[i, fi[j]] = 1;
                    j++;
                }
            }

            for (int i = 0; i < lenght; i++)
                for (int j = 1 + i; j < lenght; j++)
                    matrx[j, i] = 0;

            return matrx;
        }
        catch (FormatException)
        {
            MessageBox.Show("Некорректный ввод FI представления\n\nПравильный пример: 3 1 2 -1 0 2 -1 0 1 -1 ", "Error");
        }
        catch (IndexOutOfRangeException) 
        {
           MessageBox.Show("Размерность матрицы не соотвествует количеству введенных вершин\n\nПравильный Пример: 3 1 2 -1 2 -1 0 -1 ", "Error");
        }
        return new int[,] { { 0 } };
    }
    static public int[,] GetFullMatrix(int[,] matrx) 
    {
            int[,] gmatrix;
            gmatrix = (int[,])matrx.Clone();

            for (int i = 0; i < Math.Sqrt(gmatrix.Length); i++)
            {
                for (int j = 1 + i; j < Math.Sqrt(gmatrix.Length); j++)
                {
                    gmatrix[j, i] = gmatrix[i, j];
                }
            }
            return gmatrix;
    }
    static public List<List<int>> FindAllCliques(int[,] gmatrix)
    {

        List<List<int>> output = new List<List<int>>();

        //сюда помещаются вершины, образующие клику
        List<int> M = new List<int>();
        //список вершин графа
        List<int> K = new List<int>();
        //список "отработанных" вершин
        List<int> P = new List<int>();
            
        //вершина
         int v;
        Stack<int> stackV = new Stack<int>();
        Stack<List<int>> stackM = new Stack<List<int>>();
        Stack<List<int>> stackK = new Stack<List<int>>();
        Stack<List<int>> stackP = new Stack<List<int>>();

        //список несмежных с вершиной вершин
        List<int> GS = new List<int>();

        //заполняем список вершинами графа
        for (int i = 0; i < Math.Sqrt(gmatrix.Length); i++)
            K.Add(i);

        while (K.Count != 0 || M.Count != 0)
        {
            if (K.Count != 0)
            {
                v = K[0];

                stackM.Push(M.GetRange(0, M.Count));
                stackK.Push(K.GetRange(0, K.Count));
                stackP.Push(P.GetRange(0, P.Count));
                stackV.Push(v);

                M.Add(v);

                GS = G(v, gmatrix);

                SubtractSet(K, GS);
                SubtractSet(K, v);
                SubtractSet(P, GS);
            }
            else
            {
                if (P.Count == 0) //клика найдена
                    output.Add(M.GetRange(0, M.Count));

                M = stackM.Pop();
                K = stackK.Pop();
                P = stackP.Pop();
                v = stackV.Pop();

                SubtractSet(K, v);

                P.Add(v);
            }
        }
        return FixClique(output);
    }

    /* вычитает вершину из множества */
    static void SubtractSet(List<int> set, int vert)
    {
        for (int i = 0; i < set.Count; i++)
        {
            if (set[i] == vert)
                set.RemoveAt(i);
        }
    }

    /* вычитает второе множество из первого */
    static void SubtractSet(List<int> set1, List<int> set2)
    {
        for (int i = 0; i < set1.Count; i++)
            for (int j = 0; j < set2.Count; j++)
                if (set1.Count != 0 && i < set1.Count)
                    if (set1[i] == set2[j])
                        set1.RemoveAt(i);
    }

    /* возвращает список вершин, не смежных с vert */
    static List<int> G(int vert, int[,] gmatrix)
    {
         List<int> ret = new List<int>();

         for (int i = 0; i < Math.Sqrt(gmatrix.Length); i++)
             if (gmatrix[i, vert] == 0)
                 ret.Add(i);

         return ret;
    }
    static public List<List<int>> FixClique(List<List<int>> a)
    {
        List<List<int>> b = a;
        List<List<int>> output = new List<List<int>>();
        for (int k = 0; k < b.Count; k++)
        {
            int maxIndex = 0;
            int max = b[0].Count;
            for (int i = 0; i < b.Count; i++)
            {
                if (b[i].Count > max)
                {
                    max = b[i].Count;
                    maxIndex = i;
                }
            }
            output.Add(b[maxIndex]);
            List<int> tmp = new List<int>();
            tmp.AddRange(b[maxIndex]);
            b.RemoveAt(maxIndex);
            k = 0;
            for (int i = 0; i < tmp.Count; i++)
            {
                for (int j = 0; j < b.Count; j++)
                {
                    b[j].Remove(tmp[i]);
                }
            }
        }
        output.AddRange(b);
        for (int i = 0; i < output.Count; i++)
        {
            if (output[i].Count == 0)
            {
                output.RemoveAt(i);
                i = 0;
            }
        }
        return output;
    }
}
public static class RandomEdge
{
    static public List<int> EdgeGenerate(int size)
    {

        List<int> tmp = new List<int>();
        tmp.AddRange(Enumerable.Range(1, (int)(size * ((double)((size - 1.0) / 2.0)))).RandomShuffle());
        return tmp;
    }
    private static IList<T> RandomShuffle<T>(this IEnumerable<T> list)
    {
        var random = new Random();
        var shuffle = new List<T>(list);
        for (var i = 2; i < shuffle.Count; ++i)
        {
            var temp = shuffle[i];
            var nextRandom = random.Next(i - 1);
            shuffle[i] = shuffle[nextRandom];
            shuffle[nextRandom] = temp;
        }
        return shuffle;
    }
}
