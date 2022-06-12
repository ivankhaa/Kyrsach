namespace GraphBiuld
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.AdjPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Output = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.AdjPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.edgeGraph = new System.Windows.Forms.NumericUpDown();
            this.nodeGraph = new System.Windows.Forms.NumericUpDown();
            this.Input1 = new System.Windows.Forms.RadioButton();
            this.Input2 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textFI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.compareButton1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton1
            // 
            this.AddButton1.Location = new System.Drawing.Point(950, 745);
            this.AddButton1.Name = "AddButton1";
            this.AddButton1.Size = new System.Drawing.Size(88, 27);
            this.AddButton1.TabIndex = 2;
            this.AddButton1.Text = "Добавить";
            this.AddButton1.UseVisualStyleBackColor = true;
            this.AddButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 722);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кл-во вершин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 724);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Кл-во ребер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 690);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Матрица смежности";
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Location = new System.Drawing.Point(12, 8);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(475, 410);
            this.Panel1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(748, 428);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(290, 259);
            this.dataGridView2.TabIndex = 6;
            // 
            // Output
            // 
            this.Output.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output.Location = new System.Drawing.Point(319, 428);
            this.Output.MinimumSize = new System.Drawing.Size(175, 296);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(411, 344);
            this.Output.TabIndex = 6;
            this.Output.WordWrap = false;
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.Location = new System.Drawing.Point(563, 8);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(475, 410);
            this.Panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 428);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(290, 259);
            this.dataGridView1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(829, 690);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Матрица смежности";
            // 
            // edgeGraph
            // 
            this.edgeGraph.Location = new System.Drawing.Point(119, 750);
            this.edgeGraph.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edgeGraph.Name = "edgeGraph";
            this.edgeGraph.Size = new System.Drawing.Size(77, 22);
            this.edgeGraph.TabIndex = 12;
            // 
            // nodeGraph
            // 
            this.nodeGraph.Location = new System.Drawing.Point(12, 750);
            this.nodeGraph.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nodeGraph.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nodeGraph.Name = "nodeGraph";
            this.nodeGraph.Size = new System.Drawing.Size(77, 22);
            this.nodeGraph.TabIndex = 13;
            this.nodeGraph.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nodeGraph.ValueChanged += new System.EventHandler(this.nodeGraph_ValueChanged);
            // 
            // Input1
            // 
            this.Input1.AutoSize = true;
            this.Input1.Checked = true;
            this.Input1.Location = new System.Drawing.Point(748, 718);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(111, 21);
            this.Input1.TabIndex = 14;
            this.Input1.TabStop = true;
            this.Input1.Text = "Ручной ввод";
            this.Input1.UseVisualStyleBackColor = true;
            this.Input1.CheckedChanged += new System.EventHandler(this.Input1_CheckedChanged);
            // 
            // Input2
            // 
            this.Input2.AutoSize = true;
            this.Input2.Location = new System.Drawing.Point(748, 750);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(192, 21);
            this.Input2.TabIndex = 15;
            this.Input2.Text = "Ввод в представлении FI";
            this.Input2.UseVisualStyleBackColor = true;
            this.Input2.CheckedChanged += new System.EventHandler(this.Input2_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.CausesValidation = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.listBox1.Location = new System.Drawing.Point(227, 736);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(75, 36);
            this.listBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 717);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Граф";
            // 
            // textFI
            // 
            this.textFI.Location = new System.Drawing.Point(38, 744);
            this.textFI.Name = "textFI";
            this.textFI.Size = new System.Drawing.Size(158, 22);
            this.textFI.TabIndex = 18;
            this.textFI.Visible = false;
            this.textFI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFI_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 747);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "FI:";
            this.label6.Visible = false;
            // 
            // compareButton1
            // 
            this.compareButton1.Location = new System.Drawing.Point(891, 712);
            this.compareButton1.Name = "compareButton1";
            this.compareButton1.Size = new System.Drawing.Size(147, 27);
            this.compareButton1.TabIndex = 21;
            this.compareButton1.Text = "Эквивалентность";
            this.compareButton1.UseVisualStyleBackColor = true;
            this.compareButton1.Click += new System.EventHandler(this.compareButton1_ClicK);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 789);
            this.Controls.Add(this.compareButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textFI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.nodeGraph);
            this.Controls.Add(this.edgeGraph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.AddButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Курсовая работа";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.AdjPanel Panel2;
        private System.Windows.Forms.Button AddButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.AdjPanel Panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edgeGraph;
        private System.Windows.Forms.NumericUpDown nodeGraph;
        private System.Windows.Forms.RadioButton Input1;
        private System.Windows.Forms.RadioButton Input2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button compareButton1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

