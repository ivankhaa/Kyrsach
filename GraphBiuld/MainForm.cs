using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace GraphBiuld
{
    public partial class MainForm : Form
    {
   
        bool IsShown = false;
        List<double> informGraph1 = new List<double>();
        List<double> informGraph2 = new List<double>();
        static string s1 = "", s2 = "";
        public MainForm()
        {
            InitializeComponent();
            listBox1.SetSelected(0, true);
            compareButton1.Enabled = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.compareButton1, "Добавьте два графа для сравнения");
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Form1_MouseMove);

        }
        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctrl = this.GetChildAtPoint(e.Location);

            if (ctrl != null)
            {
                if (ctrl == this.compareButton1 && !IsShown)
                {
                    string tipstring = this.toolTip1.GetToolTip(this.compareButton1);
                    this.toolTip1.Show(tipstring, this.compareButton1, this.compareButton1.Width / 2, this.compareButton1.Height / 2);
                    IsShown = true;
                }
            }
            else
            {
                this.toolTip1.Hide(this.compareButton1);
                IsShown = false;
            }
        }

        private void addButton1_Click(object sender, EventArgs e)
        {

            int size = 1;
            int edge = 0;
            int[,] _matrix;

            if (Input1.Checked)
            {
                size = (int)nodeGraph.Value;
                edge = (int)edgeGraph.Value; 
                _matrix = MatrixEditing.GetMatrix(size, edge);
            }
            else
            {
                _matrix = MatrixEditing.GetMatrixFI(textFI.Text);
                size = (int)Math.Sqrt(_matrix.Length);
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        if (_matrix[i,j] == 1)
                            edge += 1;
            }

            if (listBox1.GetSelected(0))
            {
                informGraph1 = new List<double>();
                s1 = "";
                s1 += "\t\tГраф 1" + Environment.NewLine + $"Количество вершин: {size}" + Environment.NewLine + $"Количество ребер: {edge}" + Environment.NewLine;
                s1 += "FI = [ " + MatrixEditing.GetFI(MatrixEditing.GetFullMatrix(_matrix)) + " ]" + Environment.NewLine;
                Panel1.Build(_matrix);
                tabl(MatrixEditing.GetFullMatrix(_matrix), dataGridView1);
                List<List<int>> a = MatrixEditing.FindAllCliques(MatrixEditing.GetFullMatrix(_matrix));
                s1 += $"Мощьность графа: {MatrixEditing.Strength(a, edge)}" + Environment.NewLine;
                s1 += "Полные подграфы: " + Environment.NewLine;
                for (int i = 0; i < a.Count; i++)
                    s1 += "G" + $"{i}" + " = { v" + string.Join("; v", a[i]) + " }" + Environment.NewLine;
                s1 += Environment.NewLine;
                informGraph1.Add(size);
                informGraph1.Add(edge);
                informGraph1.Add(MatrixEditing.Strength(a, edge));
                informGraph1.Add(a.Count);


            }
            else
            {
                informGraph2 = new List<double>();
                s2 = "";
                s2 += "\t\tГраф 2" + Environment.NewLine + $"Количество вершин: {size}" + Environment.NewLine + $"Количество ребер: {edge}" + Environment.NewLine;
                s2 += "FI = [ " + MatrixEditing.GetFI(MatrixEditing.GetFullMatrix(_matrix)) + "]" + Environment.NewLine;
                Panel2.Build(_matrix);
                tabl(MatrixEditing.GetFullMatrix(_matrix), dataGridView2);
                List<List<int>> a = MatrixEditing.FindAllCliques(MatrixEditing.GetFullMatrix(_matrix));
                s2 += $"Мощьность графа: {MatrixEditing.Strength(a, edge)}" + Environment.NewLine;
                s2 += "Полные подграфы: " + Environment.NewLine;
                for (int i = 0; i < a.Count; i++)
                    s2 += "G" + $"{i}" + " = { v" + string.Join("; v", a[i]) + " }" + Environment.NewLine;
                s2 += Environment.NewLine;
                informGraph2.Add(size);
                informGraph2.Add(edge);
                informGraph2.Add(MatrixEditing.Strength(a, edge));
                informGraph2.Add(a.Count);
            }
            Output.Text = s1 + s2;
            
            if (s1 != "" && s2 != "")
                compareButton1.Enabled = true;
                

        }
        public void tabl(int[,] array, DataGridView dataGridView)
        {
            int m = array.GetLength(0);
            int n = array.GetLength(1);
            dataGridView.ColumnCount = n;
            dataGridView.RowCount = m;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = array[i, j];
                }
            }
        }

        private void nodeGraph_ValueChanged(object sender, EventArgs e)
        {
            edgeGraph.Maximum = nodeGraph.Value * ((nodeGraph.Value - 1) / 2);
            if (edgeGraph.Maximum > 50)
                edgeGraph.Maximum = 50;
        }

        private void Input1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            nodeGraph.Visible = true;
            edgeGraph.Visible = true;
            textFI.Visible = false;
            label6.Visible = false;
        }

        private void Input2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            nodeGraph.Visible = false;
            edgeGraph.Visible = false;
            textFI.Visible = true;
            label6.Visible = true;
        }

        private void compareButton1_ClicK(object sender, EventArgs e)
        {
            string nEquival = "";
            string Equival = "";
            if (informGraph1[0] == informGraph2[0])
                Equival += "Количеством вершин; " + Environment.NewLine;
            else
                nEquival += "Количеством вершин; " + Environment.NewLine;
            if (informGraph1[1] == informGraph2[1])
                Equival += "Количеством ребер; " + Environment.NewLine;
            else
                nEquival += "Количеством ребер; " + Environment.NewLine;
            if (informGraph1[2] == informGraph2[2])
                Equival += "Мощностью графа; " + Environment.NewLine;
            else
                nEquival += "Мощностью графа; " + Environment.NewLine;
            if (informGraph1[3] == informGraph2[3])
                Equival += "Количеством полных подграфов; " + Environment.NewLine;
            else
                nEquival += "Количеством полных подграфов; " + Environment.NewLine;
            if (nEquival == "")
                Output.Text += "Графы полностью эквивалентны";
            else if (Equival == "")
                Output.Text = s1 + s2 + "Графы полностью неэквивалентны";
            else
                Output.Text = s1 + s2 + "Графы эквивалентны за: " + Environment.NewLine + Equival + Environment.NewLine + "Графы неэквивалентны за: " + Environment.NewLine + nEquival;


        }

        private void textFI_TextChanged(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != ' ' && number != '-') 
            {
                e.Handled = true;
            }
        }
    }
} 