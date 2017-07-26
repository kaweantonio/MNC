namespace Interpolacao {
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
            this.radioButtonNewtonGregory = new System.Windows.Forms.RadioButton();
            this.radioButtonNewton = new System.Windows.Forms.RadioButton();
            this.radioButtonSistemaLinear = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPontoReferencia = new System.Windows.Forms.TextBox();
            this.GrauPolinomio = new System.Windows.Forms.NumericUpDown();
            this.NumeroPontos = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonAlteraGridView = new System.Windows.Forms.Button();
            this.textBoxPolinomio = new System.Windows.Forms.TextBox();
            this.plotGrafico = new OxyPlot.WindowsForms.PlotView();
            this.dataGridViewPontos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrauPolinomio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroPontos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPontos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNewtonGregory);
            this.groupBox1.Controls.Add(this.radioButtonNewton);
            this.groupBox1.Controls.Add(this.radioButtonSistemaLinear);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Métodos";
            // 
            // radioButtonNewtonGregory
            // 
            this.radioButtonNewtonGregory.AutoSize = true;
            this.radioButtonNewtonGregory.Font = new System.Drawing.Font("Tahoma", 8F);
            this.radioButtonNewtonGregory.Location = new System.Drawing.Point(7, 60);
            this.radioButtonNewtonGregory.Name = "radioButtonNewtonGregory";
            this.radioButtonNewtonGregory.Size = new System.Drawing.Size(188, 17);
            this.radioButtonNewtonGregory.TabIndex = 2;
            this.radioButtonNewtonGregory.Text = "Interpolação por Newton-Gregory";
            this.radioButtonNewtonGregory.UseVisualStyleBackColor = true;
            // 
            // radioButtonNewton
            // 
            this.radioButtonNewton.AutoSize = true;
            this.radioButtonNewton.Font = new System.Drawing.Font("Tahoma", 8F);
            this.radioButtonNewton.Location = new System.Drawing.Point(7, 38);
            this.radioButtonNewton.Name = "radioButtonNewton";
            this.radioButtonNewton.Size = new System.Drawing.Size(145, 17);
            this.radioButtonNewton.TabIndex = 1;
            this.radioButtonNewton.Text = "Interpolação por Newton";
            this.radioButtonNewton.UseVisualStyleBackColor = true;
            // 
            // radioButtonSistemaLinear
            // 
            this.radioButtonSistemaLinear.AutoSize = true;
            this.radioButtonSistemaLinear.Checked = true;
            this.radioButtonSistemaLinear.Font = new System.Drawing.Font("Tahoma", 8F);
            this.radioButtonSistemaLinear.Location = new System.Drawing.Point(7, 17);
            this.radioButtonSistemaLinear.Name = "radioButtonSistemaLinear";
            this.radioButtonSistemaLinear.Size = new System.Drawing.Size(180, 17);
            this.radioButtonSistemaLinear.TabIndex = 0;
            this.radioButtonSistemaLinear.TabStop = true;
            this.radioButtonSistemaLinear.Text = "Interpolação com Sistema Linear";
            this.radioButtonSistemaLinear.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxPontoReferencia);
            this.groupBox2.Controls.Add(this.GrauPolinomio);
            this.groupBox2.Controls.Add(this.NumeroPontos);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox2.Location = new System.Drawing.Point(10, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 105);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabela de dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ponto de referência (z, se k<n)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grau do polinômio (k, se k<n)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de pontos (n+1)";
            // 
            // textBoxPontoReferencia
            // 
            this.textBoxPontoReferencia.Font = new System.Drawing.Font("Tahoma", 8F);
            this.textBoxPontoReferencia.Location = new System.Drawing.Point(180, 74);
            this.textBoxPontoReferencia.Name = "textBoxPontoReferencia";
            this.textBoxPontoReferencia.Size = new System.Drawing.Size(49, 20);
            this.textBoxPontoReferencia.TabIndex = 2;
            // 
            // GrauPolinomio
            // 
            this.GrauPolinomio.Font = new System.Drawing.Font("Tahoma", 8F);
            this.GrauPolinomio.Location = new System.Drawing.Point(180, 48);
            this.GrauPolinomio.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.GrauPolinomio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GrauPolinomio.Name = "GrauPolinomio";
            this.GrauPolinomio.Size = new System.Drawing.Size(50, 20);
            this.GrauPolinomio.TabIndex = 1;
            this.GrauPolinomio.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // NumeroPontos
            // 
            this.NumeroPontos.Font = new System.Drawing.Font("Tahoma", 8F);
            this.NumeroPontos.Location = new System.Drawing.Point(180, 22);
            this.NumeroPontos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumeroPontos.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumeroPontos.Name = "NumeroPontos";
            this.NumeroPontos.Size = new System.Drawing.Size(50, 20);
            this.NumeroPontos.TabIndex = 0;
            this.NumeroPontos.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumeroPontos.ValueChanged += new System.EventHandler(this.NumeroPontos_ValueChanged);
            this.NumeroPontos.Leave += new System.EventHandler(this.NumeroPontos_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonLimpar);
            this.groupBox3.Controls.Add(this.buttonCalcular);
            this.groupBox3.Controls.Add(this.buttonAlteraGridView);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 50);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Solução";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.FlatAppearance.BorderSize = 0;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Image = global::Interpolacao.Properties.Resources.delete;
            this.buttonLimpar.Location = new System.Drawing.Point(59, 20);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(24, 22);
            this.buttonLimpar.TabIndex = 2;
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.FlatAppearance.BorderSize = 0;
            this.buttonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcular.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Image = global::Interpolacao.Properties.Resources.confirm;
            this.buttonCalcular.Location = new System.Drawing.Point(106, 20);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(24, 22);
            this.buttonCalcular.TabIndex = 1;
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonAlteraGridView
            // 
            this.buttonAlteraGridView.FlatAppearance.BorderSize = 0;
            this.buttonAlteraGridView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlteraGridView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlteraGridView.Image = global::Interpolacao.Properties.Resources.grid;
            this.buttonAlteraGridView.Location = new System.Drawing.Point(10, 20);
            this.buttonAlteraGridView.Name = "buttonAlteraGridView";
            this.buttonAlteraGridView.Size = new System.Drawing.Size(24, 22);
            this.buttonAlteraGridView.TabIndex = 0;
            this.buttonAlteraGridView.UseVisualStyleBackColor = true;
            this.buttonAlteraGridView.Click += new System.EventHandler(this.buttonAlteraGridView_Click);
            // 
            // textBoxPolinomio
            // 
            this.textBoxPolinomio.Font = new System.Drawing.Font("Tahoma", 8F);
            this.textBoxPolinomio.Location = new System.Drawing.Point(10, 484);
            this.textBoxPolinomio.Name = "textBoxPolinomio";
            this.textBoxPolinomio.Size = new System.Drawing.Size(893, 20);
            this.textBoxPolinomio.TabIndex = 2;
            // 
            // plotGrafico
            // 
            this.plotGrafico.BackColor = System.Drawing.SystemColors.Control;
            this.plotGrafico.Font = new System.Drawing.Font("Tahoma", 8F);
            this.plotGrafico.Location = new System.Drawing.Point(255, 12);
            this.plotGrafico.Name = "plotGrafico";
            this.plotGrafico.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotGrafico.Size = new System.Drawing.Size(648, 466);
            this.plotGrafico.TabIndex = 3;
            this.plotGrafico.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotGrafico.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotGrafico.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // dataGridViewPontos
            // 
            this.dataGridViewPontos.AllowUserToAddRows = false;
            this.dataGridViewPontos.AllowUserToDeleteRows = false;
            this.dataGridViewPontos.AllowUserToResizeColumns = false;
            this.dataGridViewPontos.AllowUserToResizeRows = false;
            this.dataGridViewPontos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPontos.ColumnHeadersHeight = 22;
            this.dataGridViewPontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPontos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewPontos.EnableHeadersVisualStyles = false;
            this.dataGridViewPontos.Location = new System.Drawing.Point(10, 274);
            this.dataGridViewPontos.MultiSelect = false;
            this.dataGridViewPontos.Name = "dataGridViewPontos";
            this.dataGridViewPontos.RowHeadersVisible = false;
            this.dataGridViewPontos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPontos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPontos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewPontos.Size = new System.Drawing.Size(239, 204);
            this.dataGridViewPontos.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "i";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "x[i]";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "f(x[i])";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(913, 518);
            this.Controls.Add(this.plotGrafico);
            this.Controls.Add(this.textBoxPolinomio);
            this.Controls.Add(this.dataGridViewPontos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interpolação Polinomial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrauPolinomio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroPontos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPontos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxPolinomio;
        private OxyPlot.WindowsForms.PlotView plotGrafico;
        private System.Windows.Forms.RadioButton radioButtonNewtonGregory;
        private System.Windows.Forms.RadioButton radioButtonNewton;
        private System.Windows.Forms.RadioButton radioButtonSistemaLinear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPontoReferencia;
        private System.Windows.Forms.NumericUpDown GrauPolinomio;
        private System.Windows.Forms.NumericUpDown NumeroPontos;
        private System.Windows.Forms.Button buttonAlteraGridView;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.DataGridView dataGridViewPontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

