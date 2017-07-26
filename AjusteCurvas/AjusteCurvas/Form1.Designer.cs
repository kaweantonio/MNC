namespace AjusteCurvas {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TamanhoAmostra = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAlteraGrid = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPolinomios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPolinomioGrafico = new System.Windows.Forms.Button();
            this.buttonPolinomioCalcula = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCurvasGrafico = new System.Windows.Forms.Button();
            this.buttonCurvasCalcula = new System.Windows.Forms.Button();
            this.dataGridViewCurvas = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurvasColunaR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxCurvaTodos = new System.Windows.Forms.CheckBox();
            this.checkBoxCurva4 = new System.Windows.Forms.CheckBox();
            this.checkBoxCurva3 = new System.Windows.Forms.CheckBox();
            this.checkBoxCurva5 = new System.Windows.Forms.CheckBox();
            this.checkBoxCurva2 = new System.Windows.Forms.CheckBox();
            this.checkBoxCurva1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDadosAmostra = new System.Windows.Forms.DataGridView();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TamanhoAmostra)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolinomios)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurvas)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDadosAmostra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TamanhoAmostra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAlteraGrid);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamanho da Amostra";
            // 
            // TamanhoAmostra
            // 
            this.TamanhoAmostra.Location = new System.Drawing.Point(157, 17);
            this.TamanhoAmostra.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.TamanhoAmostra.Name = "TamanhoAmostra";
            this.TamanhoAmostra.Size = new System.Drawing.Size(40, 20);
            this.TamanhoAmostra.TabIndex = 2;
            this.TamanhoAmostra.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TamanhoAmostra.ValueChanged += new System.EventHandler(this.TamanhoAmostra_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No máximo 100 elementos";
            // 
            // buttonAlteraGrid
            // 
            this.buttonAlteraGrid.FlatAppearance.BorderSize = 0;
            this.buttonAlteraGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlteraGrid.Image = global::AjusteCurvas.Properties.Resources.grid;
            this.buttonAlteraGrid.Location = new System.Drawing.Point(205, 16);
            this.buttonAlteraGrid.Name = "buttonAlteraGrid";
            this.buttonAlteraGrid.Size = new System.Drawing.Size(26, 22);
            this.buttonAlteraGrid.TabIndex = 3;
            this.buttonAlteraGrid.UseVisualStyleBackColor = true;
            this.buttonAlteraGrid.Click += new System.EventHandler(this.buttonAlteraGrid_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewPolinomios);
            this.groupBox2.Controls.Add(this.buttonPolinomioGrafico);
            this.groupBox2.Controls.Add(this.buttonPolinomioCalcula);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox2.Location = new System.Drawing.Point(259, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 210);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajuste Polinomial";
            // 
            // dataGridViewPolinomios
            // 
            this.dataGridViewPolinomios.AllowUserToAddRows = false;
            this.dataGridViewPolinomios.AllowUserToDeleteRows = false;
            this.dataGridViewPolinomios.AllowUserToResizeColumns = false;
            this.dataGridViewPolinomios.AllowUserToResizeRows = false;
            this.dataGridViewPolinomios.ColumnHeadersHeight = 22;
            this.dataGridViewPolinomios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPolinomios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.ColunaR2});
            this.dataGridViewPolinomios.EnableHeadersVisualStyles = false;
            this.dataGridViewPolinomios.Location = new System.Drawing.Point(6, 53);
            this.dataGridViewPolinomios.MultiSelect = false;
            this.dataGridViewPolinomios.Name = "dataGridViewPolinomios";
            this.dataGridViewPolinomios.RowHeadersVisible = false;
            this.dataGridViewPolinomios.RowHeadersWidth = 42;
            this.dataGridViewPolinomios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPolinomios.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewPolinomios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewPolinomios.Size = new System.Drawing.Size(554, 151);
            this.dataGridViewPolinomios.TabIndex = 6;
            this.dataGridViewPolinomios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPolinomios_CellContentClick);
            this.dataGridViewPolinomios.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewPolinomios_CurrentCellDirtyStateChanged);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Polinômio";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 67;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Grau";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 38;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.NullValue = false;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 30;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "a[0]";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "a[1]";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "a[2]";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "a[3]";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 120;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "a[4]";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 120;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "a[5]";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 120;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "a[6]";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 120;
            // 
            // ColunaR2
            // 
            this.ColunaR2.HeaderText = "R^2";
            this.ColunaR2.Name = "ColunaR2";
            this.ColunaR2.ReadOnly = true;
            this.ColunaR2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColunaR2.Width = 120;
            // 
            // buttonPolinomioGrafico
            // 
            this.buttonPolinomioGrafico.FlatAppearance.BorderSize = 0;
            this.buttonPolinomioGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPolinomioGrafico.Image = global::AjusteCurvas.Properties.Resources.graph;
            this.buttonPolinomioGrafico.Location = new System.Drawing.Point(532, 23);
            this.buttonPolinomioGrafico.Name = "buttonPolinomioGrafico";
            this.buttonPolinomioGrafico.Size = new System.Drawing.Size(24, 22);
            this.buttonPolinomioGrafico.TabIndex = 5;
            this.buttonPolinomioGrafico.UseVisualStyleBackColor = true;
            this.buttonPolinomioGrafico.Click += new System.EventHandler(this.buttonPolinomioGrafico_Click);
            // 
            // buttonPolinomioCalcula
            // 
            this.buttonPolinomioCalcula.FlatAppearance.BorderSize = 0;
            this.buttonPolinomioCalcula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPolinomioCalcula.Image = global::AjusteCurvas.Properties.Resources.function16px;
            this.buttonPolinomioCalcula.Location = new System.Drawing.Point(499, 20);
            this.buttonPolinomioCalcula.Name = "buttonPolinomioCalcula";
            this.buttonPolinomioCalcula.Size = new System.Drawing.Size(28, 25);
            this.buttonPolinomioCalcula.TabIndex = 4;
            this.buttonPolinomioCalcula.UseVisualStyleBackColor = true;
            this.buttonPolinomioCalcula.Click += new System.EventHandler(this.buttonPolinomioCalcula_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(434, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cálculos e gráficos";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(215, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Selecione, individualmente ou não, os ajustes a serem calculados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Grau máximo do polinômio: 6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número máximo de ajustes: 5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCurvasGrafico);
            this.groupBox3.Controls.Add(this.buttonCurvasCalcula);
            this.groupBox3.Controls.Add(this.dataGridViewCurvas);
            this.groupBox3.Controls.Add(this.checkBoxCurvaTodos);
            this.groupBox3.Controls.Add(this.checkBoxCurva4);
            this.groupBox3.Controls.Add(this.checkBoxCurva3);
            this.groupBox3.Controls.Add(this.checkBoxCurva5);
            this.groupBox3.Controls.Add(this.checkBoxCurva2);
            this.groupBox3.Controls.Add(this.checkBoxCurva1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox3.Location = new System.Drawing.Point(259, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 196);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajuste de outras Curvas";
            // 
            // buttonCurvasGrafico
            // 
            this.buttonCurvasGrafico.FlatAppearance.BorderSize = 0;
            this.buttonCurvasGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCurvasGrafico.Image = global::AjusteCurvas.Properties.Resources.graph;
            this.buttonCurvasGrafico.Location = new System.Drawing.Point(537, 17);
            this.buttonCurvasGrafico.Name = "buttonCurvasGrafico";
            this.buttonCurvasGrafico.Size = new System.Drawing.Size(24, 22);
            this.buttonCurvasGrafico.TabIndex = 7;
            this.buttonCurvasGrafico.UseVisualStyleBackColor = true;
            this.buttonCurvasGrafico.Click += new System.EventHandler(this.buttonCurvasGrafico_Click);
            // 
            // buttonCurvasCalcula
            // 
            this.buttonCurvasCalcula.FlatAppearance.BorderSize = 0;
            this.buttonCurvasCalcula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCurvasCalcula.Image = global::AjusteCurvas.Properties.Resources.function16px;
            this.buttonCurvasCalcula.Location = new System.Drawing.Point(503, 16);
            this.buttonCurvasCalcula.Name = "buttonCurvasCalcula";
            this.buttonCurvasCalcula.Size = new System.Drawing.Size(28, 25);
            this.buttonCurvasCalcula.TabIndex = 7;
            this.buttonCurvasCalcula.UseVisualStyleBackColor = true;
            this.buttonCurvasCalcula.Click += new System.EventHandler(this.buttonCurvasCalcula_Click);
            // 
            // dataGridViewCurvas
            // 
            this.dataGridViewCurvas.AllowUserToAddRows = false;
            this.dataGridViewCurvas.AllowUserToDeleteRows = false;
            this.dataGridViewCurvas.AllowUserToResizeColumns = false;
            this.dataGridViewCurvas.AllowUserToResizeRows = false;
            this.dataGridViewCurvas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCurvas.ColumnHeadersHeight = 22;
            this.dataGridViewCurvas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCurvas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column13,
            this.Column14,
            this.CurvasColunaR2});
            this.dataGridViewCurvas.EnableHeadersVisualStyles = false;
            this.dataGridViewCurvas.Location = new System.Drawing.Point(6, 53);
            this.dataGridViewCurvas.MultiSelect = false;
            this.dataGridViewCurvas.Name = "dataGridViewCurvas";
            this.dataGridViewCurvas.RowHeadersVisible = false;
            this.dataGridViewCurvas.RowHeadersWidth = 42;
            this.dataGridViewCurvas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCurvas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewCurvas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewCurvas.Size = new System.Drawing.Size(551, 132);
            this.dataGridViewCurvas.TabIndex = 7;
            this.dataGridViewCurvas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCurvas_CellContentClick);
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column12.HeaderText = "Equação";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column12.Width = 54;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "a";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "b";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CurvasColunaR2
            // 
            this.CurvasColunaR2.HeaderText = "R^2";
            this.CurvasColunaR2.Name = "CurvasColunaR2";
            this.CurvasColunaR2.ReadOnly = true;
            this.CurvasColunaR2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // checkBoxCurvaTodos
            // 
            this.checkBoxCurvaTodos.AutoSize = true;
            this.checkBoxCurvaTodos.Location = new System.Drawing.Point(451, 20);
            this.checkBoxCurvaTodos.Name = "checkBoxCurvaTodos";
            this.checkBoxCurvaTodos.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCurvaTodos.TabIndex = 4;
            this.checkBoxCurvaTodos.Text = "Todos";
            this.checkBoxCurvaTodos.UseVisualStyleBackColor = true;
            this.checkBoxCurvaTodos.Click += new System.EventHandler(this.checkBoxCurvaTodos_Click);
            // 
            // checkBoxCurva4
            // 
            this.checkBoxCurva4.AutoSize = true;
            this.checkBoxCurva4.Location = new System.Drawing.Point(269, 20);
            this.checkBoxCurva4.Name = "checkBoxCurva4";
            this.checkBoxCurva4.Size = new System.Drawing.Size(94, 17);
            this.checkBoxCurva4.TabIndex = 3;
            this.checkBoxCurva4.Text = "y = 1/(a+b.x)";
            this.checkBoxCurva4.UseVisualStyleBackColor = true;
            this.checkBoxCurva4.CheckedChanged += new System.EventHandler(this.checkBoxCurvaOpcoes_CheckedChanged);
            // 
            // checkBoxCurva3
            // 
            this.checkBoxCurva3.AutoSize = true;
            this.checkBoxCurva3.Location = new System.Drawing.Point(189, 20);
            this.checkBoxCurva3.Name = "checkBoxCurva3";
            this.checkBoxCurva3.Size = new System.Drawing.Size(76, 17);
            this.checkBoxCurva3.TabIndex = 2;
            this.checkBoxCurva3.Text = "y = a.b^x";
            this.checkBoxCurva3.UseVisualStyleBackColor = true;
            this.checkBoxCurva3.CheckedChanged += new System.EventHandler(this.checkBoxCurvaOpcoes_CheckedChanged);
            // 
            // checkBoxCurva5
            // 
            this.checkBoxCurva5.AutoSize = true;
            this.checkBoxCurva5.Location = new System.Drawing.Point(370, 20);
            this.checkBoxCurva5.Name = "checkBoxCurva5";
            this.checkBoxCurva5.Size = new System.Drawing.Size(76, 17);
            this.checkBoxCurva5.TabIndex = 2;
            this.checkBoxCurva5.Text = "y = a.x^b";
            this.checkBoxCurva5.UseVisualStyleBackColor = true;
            this.checkBoxCurva5.CheckedChanged += new System.EventHandler(this.checkBoxCurvaOpcoes_CheckedChanged);
            // 
            // checkBoxCurva2
            // 
            this.checkBoxCurva2.AutoSize = true;
            this.checkBoxCurva2.Location = new System.Drawing.Point(96, 20);
            this.checkBoxCurva2.Name = "checkBoxCurva2";
            this.checkBoxCurva2.Size = new System.Drawing.Size(94, 17);
            this.checkBoxCurva2.TabIndex = 1;
            this.checkBoxCurva2.Text = "y = a.e^(b.x)";
            this.checkBoxCurva2.UseVisualStyleBackColor = true;
            this.checkBoxCurva2.CheckedChanged += new System.EventHandler(this.checkBoxCurvaOpcoes_CheckedChanged);
            // 
            // checkBoxCurva1
            // 
            this.checkBoxCurva1.AutoSize = true;
            this.checkBoxCurva1.Location = new System.Drawing.Point(9, 20);
            this.checkBoxCurva1.Name = "checkBoxCurva1";
            this.checkBoxCurva1.Size = new System.Drawing.Size(82, 17);
            this.checkBoxCurva1.TabIndex = 0;
            this.checkBoxCurva1.Text = "y = a + b.x";
            this.checkBoxCurva1.UseVisualStyleBackColor = true;
            this.checkBoxCurva1.CheckedChanged += new System.EventHandler(this.checkBoxCurvaOpcoes_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewDadosAmostra);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox4.Location = new System.Drawing.Point(12, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 361);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados da Amostra";
            // 
            // dataGridViewDadosAmostra
            // 
            this.dataGridViewDadosAmostra.AllowUserToAddRows = false;
            this.dataGridViewDadosAmostra.AllowUserToDeleteRows = false;
            this.dataGridViewDadosAmostra.AllowUserToResizeColumns = false;
            this.dataGridViewDadosAmostra.AllowUserToResizeRows = false;
            this.dataGridViewDadosAmostra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDadosAmostra.ColumnHeadersHeight = 22;
            this.dataGridViewDadosAmostra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDadosAmostra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column16,
            this.Column17,
            this.Column18});
            this.dataGridViewDadosAmostra.EnableHeadersVisualStyles = false;
            this.dataGridViewDadosAmostra.Location = new System.Drawing.Point(10, 20);
            this.dataGridViewDadosAmostra.MultiSelect = false;
            this.dataGridViewDadosAmostra.Name = "dataGridViewDadosAmostra";
            this.dataGridViewDadosAmostra.RowHeadersVisible = false;
            this.dataGridViewDadosAmostra.RowHeadersWidth = 42;
            this.dataGridViewDadosAmostra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDadosAmostra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDadosAmostra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDadosAmostra.Size = new System.Drawing.Size(220, 308);
            this.dataGridViewDadosAmostra.TabIndex = 8;
            // 
            // Column16
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.Column16.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column16.FillWeight = 31.43407F;
            this.Column16.HeaderText = "i";
            this.Column16.MinimumWidth = 28;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column17
            // 
            this.Column17.FillWeight = 108.1332F;
            this.Column17.HeaderText = "x[i]";
            this.Column17.Name = "Column17";
            this.Column17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column18
            // 
            this.Column18.FillWeight = 108.1332F;
            this.Column18.HeaderText = "f(x[i])";
            this.Column18.Name = "Column18";
            this.Column18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 434);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes de Curvas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TamanhoAmostra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolinomios)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurvas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDadosAmostra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown TamanhoAmostra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAlteraGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewPolinomios;
        private System.Windows.Forms.Button buttonPolinomioGrafico;
        private System.Windows.Forms.Button buttonPolinomioCalcula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewCurvas;
        private System.Windows.Forms.CheckBox checkBoxCurvaTodos;
        private System.Windows.Forms.CheckBox checkBoxCurva4;
        private System.Windows.Forms.CheckBox checkBoxCurva3;
        private System.Windows.Forms.CheckBox checkBoxCurva5;
        private System.Windows.Forms.CheckBox checkBoxCurva2;
        private System.Windows.Forms.CheckBox checkBoxCurva1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewDadosAmostra;
        private System.Windows.Forms.Button buttonCurvasGrafico;
        private System.Windows.Forms.Button buttonCurvasCalcula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurvasColunaR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
    }
}

