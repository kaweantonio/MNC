namespace Integrais {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLimpa = new System.Windows.Forms.Button();
            this.NumeroPontos = new System.Windows.Forms.NumericUpDown();
            this.textBoxValorB = new System.Windows.Forms.TextBox();
            this.buttonCalcula = new System.Windows.Forms.Button();
            this.textBoxValorA = new System.Windows.Forms.TextBox();
            this.textBoxFuncao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.dataGridViewSolucao = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonNumPontos100 = new System.Windows.Forms.RadioButton();
            this.radioButtonNumPontos64 = new System.Windows.Forms.RadioButton();
            this.radioButtonNumPontos32 = new System.Windows.Forms.RadioButton();
            this.radioButtonNumPontos16 = new System.Windows.Forms.RadioButton();
            this.radioButtonNumPontos8 = new System.Windows.Forms.RadioButton();
            this.radioButtonNumPontos4 = new System.Windows.Forms.RadioButton();
            this.radioButtonNumPontos2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroPontos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolucao)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLimpa);
            this.groupBox1.Controls.Add(this.NumeroPontos);
            this.groupBox1.Controls.Add(this.textBoxValorB);
            this.groupBox1.Controls.Add(this.buttonCalcula);
            this.groupBox1.Controls.Add(this.textBoxValorA);
            this.groupBox1.Controls.Add(this.textBoxFuncao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cálculo da Integral";
            // 
            // buttonLimpa
            // 
            this.buttonLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpa.Image = global::Integrais.Properties.Resources.delete;
            this.buttonLimpa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpa.Location = new System.Drawing.Point(156, 82);
            this.buttonLimpa.Name = "buttonLimpa";
            this.buttonLimpa.Size = new System.Drawing.Size(104, 23);
            this.buttonLimpa.TabIndex = 6;
            this.buttonLimpa.Text = "Limpa Dados";
            this.buttonLimpa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLimpa.UseVisualStyleBackColor = true;
            this.buttonLimpa.Click += new System.EventHandler(this.buttonLimpa_Click);
            // 
            // NumeroPontos
            // 
            this.NumeroPontos.Location = new System.Drawing.Point(278, 49);
            this.NumeroPontos.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumeroPontos.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumeroPontos.Name = "NumeroPontos";
            this.NumeroPontos.Size = new System.Drawing.Size(46, 20);
            this.NumeroPontos.TabIndex = 4;
            this.NumeroPontos.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // textBoxValorB
            // 
            this.textBoxValorB.Location = new System.Drawing.Point(121, 49);
            this.textBoxValorB.Name = "textBoxValorB";
            this.textBoxValorB.Size = new System.Drawing.Size(40, 20);
            this.textBoxValorB.TabIndex = 3;
            // 
            // buttonCalcula
            // 
            this.buttonCalcula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcula.Image = global::Integrais.Properties.Resources.confirm;
            this.buttonCalcula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalcula.Location = new System.Drawing.Point(76, 82);
            this.buttonCalcula.Name = "buttonCalcula";
            this.buttonCalcula.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcula.TabIndex = 5;
            this.buttonCalcula.Text = "Calcula";
            this.buttonCalcula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCalcula.UseVisualStyleBackColor = true;
            this.buttonCalcula.Click += new System.EventHandler(this.buttonCalcula_Click);
            // 
            // textBoxValorA
            // 
            this.textBoxValorA.Location = new System.Drawing.Point(46, 50);
            this.textBoxValorA.Name = "textBoxValorA";
            this.textBoxValorA.Size = new System.Drawing.Size(40, 20);
            this.textBoxValorA.TabIndex = 2;
            // 
            // textBoxFuncao
            // 
            this.textBoxFuncao.Location = new System.Drawing.Point(46, 18);
            this.textBoxFuncao.Name = "textBoxFuncao";
            this.textBoxFuncao.Size = new System.Drawing.Size(278, 20);
            this.textBoxFuncao.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Intervalos (n ≤ 1000)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "f(x) =";
            // 
            // plotView
            // 
            this.plotView.BackColor = System.Drawing.SystemColors.Control;
            this.plotView.Font = new System.Drawing.Font("Tahoma", 8F);
            this.plotView.Location = new System.Drawing.Point(10, 204);
            this.plotView.Name = "plotView";
            this.plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView.Size = new System.Drawing.Size(589, 279);
            this.plotView.TabIndex = 11;
            this.plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // dataGridViewSolucao
            // 
            this.dataGridViewSolucao.AllowUserToAddRows = false;
            this.dataGridViewSolucao.AllowUserToDeleteRows = false;
            this.dataGridViewSolucao.AllowUserToResizeColumns = false;
            this.dataGridViewSolucao.AllowUserToResizeRows = false;
            this.dataGridViewSolucao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSolucao.ColumnHeadersHeight = 22;
            this.dataGridViewSolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSolucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewSolucao.EnableHeadersVisualStyles = false;
            this.dataGridViewSolucao.Location = new System.Drawing.Point(5, 19);
            this.dataGridViewSolucao.MultiSelect = false;
            this.dataGridViewSolucao.Name = "dataGridViewSolucao";
            this.dataGridViewSolucao.RowHeadersVisible = false;
            this.dataGridViewSolucao.RowHeadersWidth = 22;
            this.dataGridViewSolucao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSolucao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewSolucao.Size = new System.Drawing.Size(237, 156);
            this.dataGridViewSolucao.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Método";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 49;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Resultado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewSolucao);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox2.Location = new System.Drawing.Point(350, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 184);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solução";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonNumPontos100);
            this.groupBox3.Controls.Add(this.radioButtonNumPontos64);
            this.groupBox3.Controls.Add(this.radioButtonNumPontos32);
            this.groupBox3.Controls.Add(this.radioButtonNumPontos16);
            this.groupBox3.Controls.Add(this.radioButtonNumPontos8);
            this.groupBox3.Controls.Add(this.radioButtonNumPontos4);
            this.groupBox3.Controls.Add(this.radioButtonNumPontos2);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox3.Location = new System.Drawing.Point(10, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 58);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pontos para o Métodos de Gauss";
            // 
            // radioButtonNumPontos100
            // 
            this.radioButtonNumPontos100.AutoSize = true;
            this.radioButtonNumPontos100.Location = new System.Drawing.Point(278, 24);
            this.radioButtonNumPontos100.Name = "radioButtonNumPontos100";
            this.radioButtonNumPontos100.Size = new System.Drawing.Size(43, 17);
            this.radioButtonNumPontos100.TabIndex = 6;
            this.radioButtonNumPontos100.Text = "100";
            this.radioButtonNumPontos100.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumPontos64
            // 
            this.radioButtonNumPontos64.AutoSize = true;
            this.radioButtonNumPontos64.Location = new System.Drawing.Point(231, 24);
            this.radioButtonNumPontos64.Name = "radioButtonNumPontos64";
            this.radioButtonNumPontos64.Size = new System.Drawing.Size(37, 17);
            this.radioButtonNumPontos64.TabIndex = 5;
            this.radioButtonNumPontos64.Text = "64";
            this.radioButtonNumPontos64.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumPontos32
            // 
            this.radioButtonNumPontos32.AutoSize = true;
            this.radioButtonNumPontos32.Location = new System.Drawing.Point(183, 24);
            this.radioButtonNumPontos32.Name = "radioButtonNumPontos32";
            this.radioButtonNumPontos32.Size = new System.Drawing.Size(37, 17);
            this.radioButtonNumPontos32.TabIndex = 4;
            this.radioButtonNumPontos32.Text = "32";
            this.radioButtonNumPontos32.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumPontos16
            // 
            this.radioButtonNumPontos16.AutoSize = true;
            this.radioButtonNumPontos16.Location = new System.Drawing.Point(137, 24);
            this.radioButtonNumPontos16.Name = "radioButtonNumPontos16";
            this.radioButtonNumPontos16.Size = new System.Drawing.Size(37, 17);
            this.radioButtonNumPontos16.TabIndex = 3;
            this.radioButtonNumPontos16.Text = "16";
            this.radioButtonNumPontos16.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumPontos8
            // 
            this.radioButtonNumPontos8.AutoSize = true;
            this.radioButtonNumPontos8.Checked = true;
            this.radioButtonNumPontos8.Location = new System.Drawing.Point(94, 24);
            this.radioButtonNumPontos8.Name = "radioButtonNumPontos8";
            this.radioButtonNumPontos8.Size = new System.Drawing.Size(31, 17);
            this.radioButtonNumPontos8.TabIndex = 2;
            this.radioButtonNumPontos8.TabStop = true;
            this.radioButtonNumPontos8.Text = "8";
            this.radioButtonNumPontos8.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumPontos4
            // 
            this.radioButtonNumPontos4.AutoSize = true;
            this.radioButtonNumPontos4.Location = new System.Drawing.Point(51, 24);
            this.radioButtonNumPontos4.Name = "radioButtonNumPontos4";
            this.radioButtonNumPontos4.Size = new System.Drawing.Size(31, 17);
            this.radioButtonNumPontos4.TabIndex = 1;
            this.radioButtonNumPontos4.Text = "4";
            this.radioButtonNumPontos4.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumPontos2
            // 
            this.radioButtonNumPontos2.AutoSize = true;
            this.radioButtonNumPontos2.Location = new System.Drawing.Point(8, 24);
            this.radioButtonNumPontos2.Name = "radioButtonNumPontos2";
            this.radioButtonNumPontos2.Size = new System.Drawing.Size(31, 17);
            this.radioButtonNumPontos2.TabIndex = 0;
            this.radioButtonNumPontos2.Text = "2";
            this.radioButtonNumPontos2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 495);
            this.Controls.Add(this.plotView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integrais Numéricas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroPontos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolucao)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLimpa;
        private System.Windows.Forms.Button buttonCalcula;
        private System.Windows.Forms.TextBox textBoxValorB;
        private System.Windows.Forms.TextBox textBoxValorA;
        private System.Windows.Forms.TextBox textBoxFuncao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private OxyPlot.WindowsForms.PlotView plotView;
        private System.Windows.Forms.NumericUpDown NumeroPontos;
        private System.Windows.Forms.DataGridView dataGridViewSolucao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonNumPontos100;
        private System.Windows.Forms.RadioButton radioButtonNumPontos64;
        private System.Windows.Forms.RadioButton radioButtonNumPontos32;
        private System.Windows.Forms.RadioButton radioButtonNumPontos16;
        private System.Windows.Forms.RadioButton radioButtonNumPontos8;
        private System.Windows.Forms.RadioButton radioButtonNumPontos4;
        private System.Windows.Forms.RadioButton radioButtonNumPontos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

