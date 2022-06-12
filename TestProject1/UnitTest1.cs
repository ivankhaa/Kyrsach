using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        static int size = 6;
        static int edge = 9;
        static int[,] FullMatrx = new int[,] {{0, 1, 1, 0, 0, 1},
                                             {1, 0, 0, 1, 1, 0},
                                             {1, 0, 0, 1, 0, 1},
                                             {0, 1, 1, 0, 1, 1},
                                             {0, 1, 0, 1, 0, 0},
                                             {1, 0, 1, 1, 0, 0}};
        static int[,] Matrx = new int[,]  {{0, 1, 1, 0, 0, 1},
                                           {0, 0, 0, 1, 1, 0},
                                           {0, 0, 0, 1, 0, 1},
                                           {0, 0, 0, 0, 1, 1},
                                           {0, 0, 0, 0, 0, 0},
                                           {0, 0, 0, 0, 0, 0}};
        static string FI = "6 1 2 5 -1 0 3 4 -1 0 3 5 -1 1 2 4 5 -1 1 3 -1 0 2 3 -1";
        static List<List<int>> Cliques = new List<List<int>> { { new List<int>  { 0, 2, 5 }  }, { new List<int> { 1, 3, 4 } } };

        [TestMethod]
        public void _GetFI()
        {
            Assert.AreEqual(FI, MatrixEditing.GetFI(FullMatrx));
        }
        [TestMethod]
        public void _GetMatrixFI()
        {
            CollectionAssert.AreEqual(Matrx, MatrixEditing.GetMatrixFI(FI));
        }
        [TestMethod]
        public void _GetFullMatrix() 
        {
            CollectionAssert.AreEqual(FullMatrx, MatrixEditing.GetFullMatrix(Matrx));
        }
    
        [TestMethod]
        public void _FindAllCliques()
        {

            Assert.AreEqual(true, Cliques[0].SequenceEqual(MatrixEditing.FindAllCliques(FullMatrx)[0]) && 
                Cliques[1].SequenceEqual(MatrixEditing.FindAllCliques(FullMatrx)[1]));
            
        }
        [TestMethod]
        public void _Strength()
        {
            Assert.AreEqual(3, MatrixEditing.Strength(Cliques,edge));
        }
    }

}
