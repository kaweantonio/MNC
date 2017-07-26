namespace SistemasLineares {
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
            this.buttonAlteraGrid = new System.Windows.Forms.Button();
            this.checkBoxPreencherZeros = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownVariaveis = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonIterativoGauss = new System.Windows.Forms.RadioButton();
            this.radioButtonDiretoGaussCompacto = new System.Windows.Forms.RadioButton();
            this.numericUpDownTolerancia = new System.Windows.Forms.NumericUpDown();
            this.radioButtonIterativoJacobi = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonDiretoGaussSimples = new System.Windows.Forms.RadioButton();
            this.numericUpDownIteracao = new System.Windows.Forms.NumericUpDown();
            this.radioButtonDiretoCholesky = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonDiretoGaussPivotamentoParcial = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonDiretoDecomposicaoLU = new System.Windows.Forms.RadioButton();
            this.checkBoxOpcaoInversa = new System.Windows.Forms.CheckBox();
            this.radioButtonDiretoGaussPivotamentoTotal = new System.Windows.Forms.RadioButton();
            this.checkBoxOpcaoDeterminante = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVariaveis)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTolerancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIteracao)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAlteraGrid);
            this.groupBox1.Controls.Add(this.checkBoxPreencherZeros);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownVariaveis);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordem do Sistema";
            // 
            // buttonAlteraGrid
            // 
            this.buttonAlteraGrid.AutoSize = true;
            this.buttonAlteraGrid.FlatAppearance.BorderSize = 0;
            this.buttonAlteraGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlteraGrid.Image = global::SistemasLineares.Properties.Resources.grid;
            this.buttonAlteraGrid.Location = new System.Drawing.Point(82, 36);
            this.buttonAlteraGrid.Name = "buttonAlteraGrid";
            this.buttonAlteraGrid.Size = new System.Drawing.Size(22, 24);
            this.buttonAlteraGrid.TabIndex = 2;
            this.buttonAlteraGrid.UseVisualStyleBackColor = true;
            this.buttonAlteraGrid.Click += new System.EventHandler(this.buttonAlteraGrid_Click);
            // 
            // checkBoxPreencherZeros
            // 
            this.checkBoxPreencherZeros.AutoSize = true;
            this.checkBoxPreencherZeros.Checked = true;
            this.checkBoxPreencherZeros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPreencherZeros.Location = new System.Drawing.Point(6, 69);
            this.checkBoxPreencherZeros.Name = "checkBoxPreencherZeros";
            this.checkBoxPreencherZeros.Size = new System.Drawing.Size(159, 17);
            this.checkBoxPreencherZeros.TabIndex = 3;
            this.checkBoxPreencherZeros.Text = "Preencher vazios com zeros";
            this.checkBoxPreencherZeros.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de variáveis (3 a 20)";
            // 
            // numericUpDownVariaveis
            // 
            this.numericUpDownVariaveis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownVariaveis.Location = new System.Drawing.Point(9, 39);
            this.numericUpDownVariaveis.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownVariaveis.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownVariaveis.Name = "numericUpDownVariaveis";
            this.numericUpDownVariaveis.Size = new System.Drawing.Size(65, 21);
            this.numericUpDownVariaveis.TabIndex = 1;
            this.numericUpDownVariaveis.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownVariaveis.Leave += new System.EventHandler(this.numericUpDownVariaveis_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonIterativoGauss);
            this.groupBox2.Controls.Add(this.radioButtonDiretoGaussCompacto);
            this.groupBox2.Controls.Add(this.numericUpDownTolerancia);
            this.groupBox2.Controls.Add(this.radioButtonIterativoJacobi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.radioButtonDiretoGaussSimples);
            this.groupBox2.Controls.Add(this.numericUpDownIteracao);
            this.groupBox2.Controls.Add(this.radioButtonDiretoCholesky);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.radioButtonDiretoGaussPivotamentoParcial);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.radioButtonDiretoDecomposicaoLU);
            this.groupBox2.Controls.Add(this.checkBoxOpcaoInversa);
            this.groupBox2.Controls.Add(this.radioButtonDiretoGaussPivotamentoTotal);
            this.groupBox2.Controls.Add(this.checkBoxOpcaoDeterminante);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(193, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Métodos";
            // 
            // radioButtonIterativoGauss
            // 
            this.radioButtonIterativoGauss.AutoSize = true;
            this.radioButtonIterativoGauss.Location = new System.Drawing.Point(196, 51);
            this.radioButtonIterativoGauss.Name = "radioButtonIterativoGauss";
            this.radioButtonIterativoGauss.Size = new System.Drawing.Size(86, 17);
            this.radioButtonIterativoGauss.TabIndex = 8;
            this.radioButtonIterativoGauss.TabStop = true;
            this.radioButtonIterativoGauss.Tag = "GaussSeidel";
            this.radioButtonIterativoGauss.Text = "Gauss-Seidel";
            this.radioButtonIterativoGauss.UseVisualStyleBackColor = true;
            this.radioButtonIterativoGauss.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonDiretoGaussCompacto
            // 
            this.radioButtonDiretoGaussCompacto.AutoSize = true;
            this.radioButtonDiretoGaussCompacto.Location = new System.Drawing.Point(9, 84);
            this.radioButtonDiretoGaussCompacto.Name = "radioButtonDiretoGaussCompacto";
            this.radioButtonDiretoGaussCompacto.Size = new System.Drawing.Size(110, 17);
            this.radioButtonDiretoGaussCompacto.TabIndex = 4;
            this.radioButtonDiretoGaussCompacto.TabStop = true;
            this.radioButtonDiretoGaussCompacto.Tag = "GaussCompacto";
            this.radioButtonDiretoGaussCompacto.Text = "Gauss - compacto";
            this.radioButtonDiretoGaussCompacto.UseVisualStyleBackColor = true;
            this.radioButtonDiretoGaussCompacto.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // numericUpDownTolerancia
            // 
            this.numericUpDownTolerancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownTolerancia.DecimalPlaces = 5;
            this.numericUpDownTolerancia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numericUpDownTolerancia.Location = new System.Drawing.Point(330, 112);
            this.numericUpDownTolerancia.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownTolerancia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numericUpDownTolerancia.Name = "numericUpDownTolerancia";
            this.numericUpDownTolerancia.Size = new System.Drawing.Size(65, 21);
            this.numericUpDownTolerancia.TabIndex = 12;
            this.numericUpDownTolerancia.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // radioButtonIterativoJacobi
            // 
            this.radioButtonIterativoJacobi.AutoSize = true;
            this.radioButtonIterativoJacobi.Location = new System.Drawing.Point(196, 31);
            this.radioButtonIterativoJacobi.Name = "radioButtonIterativoJacobi";
            this.radioButtonIterativoJacobi.Size = new System.Drawing.Size(112, 17);
            this.radioButtonIterativoJacobi.TabIndex = 7;
            this.radioButtonIterativoJacobi.TabStop = true;
            this.radioButtonIterativoJacobi.Tag = "Jacobi";
            this.radioButtonIterativoJacobi.Text = "Jacobi-Richardson";
            this.radioButtonIterativoJacobi.UseVisualStyleBackColor = true;
            this.radioButtonIterativoJacobi.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Iterativos";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(327, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tolerância        (0,001 até 0,00001)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Diretos";
            // 
            // radioButtonDiretoGaussSimples
            // 
            this.radioButtonDiretoGaussSimples.AutoSize = true;
            this.radioButtonDiretoGaussSimples.Checked = true;
            this.radioButtonDiretoGaussSimples.Location = new System.Drawing.Point(9, 31);
            this.radioButtonDiretoGaussSimples.Name = "radioButtonDiretoGaussSimples";
            this.radioButtonDiretoGaussSimples.Size = new System.Drawing.Size(98, 17);
            this.radioButtonDiretoGaussSimples.TabIndex = 1;
            this.radioButtonDiretoGaussSimples.TabStop = true;
            this.radioButtonDiretoGaussSimples.Tag = "GaussSimples";
            this.radioButtonDiretoGaussSimples.Text = "Gauss - simples";
            this.radioButtonDiretoGaussSimples.UseVisualStyleBackColor = true;
            this.radioButtonDiretoGaussSimples.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // numericUpDownIteracao
            // 
            this.numericUpDownIteracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownIteracao.Location = new System.Drawing.Point(330, 58);
            this.numericUpDownIteracao.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownIteracao.Name = "numericUpDownIteracao";
            this.numericUpDownIteracao.Size = new System.Drawing.Size(65, 21);
            this.numericUpDownIteracao.TabIndex = 11;
            this.numericUpDownIteracao.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // radioButtonDiretoCholesky
            // 
            this.radioButtonDiretoCholesky.AutoSize = true;
            this.radioButtonDiretoCholesky.Location = new System.Drawing.Point(9, 119);
            this.radioButtonDiretoCholesky.Name = "radioButtonDiretoCholesky";
            this.radioButtonDiretoCholesky.Size = new System.Drawing.Size(68, 17);
            this.radioButtonDiretoCholesky.TabIndex = 6;
            this.radioButtonDiretoCholesky.TabStop = true;
            this.radioButtonDiretoCholesky.Tag = "Cholesky";
            this.radioButtonDiretoCholesky.Text = "Cholesky";
            this.radioButtonDiretoCholesky.UseVisualStyleBackColor = true;
            this.radioButtonDiretoCholesky.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(327, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Número de iterações (10 até 100)";
            // 
            // radioButtonDiretoGaussPivotamentoParcial
            // 
            this.radioButtonDiretoGaussPivotamentoParcial.AutoSize = true;
            this.radioButtonDiretoGaussPivotamentoParcial.Location = new System.Drawing.Point(9, 48);
            this.radioButtonDiretoGaussPivotamentoParcial.Name = "radioButtonDiretoGaussPivotamentoParcial";
            this.radioButtonDiretoGaussPivotamentoParcial.Size = new System.Drawing.Size(158, 17);
            this.radioButtonDiretoGaussPivotamentoParcial.TabIndex = 2;
            this.radioButtonDiretoGaussPivotamentoParcial.TabStop = true;
            this.radioButtonDiretoGaussPivotamentoParcial.Tag = "GaussPivotParcial";
            this.radioButtonDiretoGaussPivotamentoParcial.Text = "Gauss - pivotamento parcial";
            this.radioButtonDiretoGaussPivotamentoParcial.UseVisualStyleBackColor = true;
            this.radioButtonDiretoGaussPivotamentoParcial.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Critérios de parada";
            // 
            // radioButtonDiretoDecomposicaoLU
            // 
            this.radioButtonDiretoDecomposicaoLU.AutoSize = true;
            this.radioButtonDiretoDecomposicaoLU.Location = new System.Drawing.Point(9, 102);
            this.radioButtonDiretoDecomposicaoLU.Name = "radioButtonDiretoDecomposicaoLU";
            this.radioButtonDiretoDecomposicaoLU.Size = new System.Drawing.Size(112, 17);
            this.radioButtonDiretoDecomposicaoLU.TabIndex = 5;
            this.radioButtonDiretoDecomposicaoLU.TabStop = true;
            this.radioButtonDiretoDecomposicaoLU.Tag = "DecompLU";
            this.radioButtonDiretoDecomposicaoLU.Text = "Decomposição L.U";
            this.radioButtonDiretoDecomposicaoLU.UseVisualStyleBackColor = true;
            this.radioButtonDiretoDecomposicaoLU.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // checkBoxOpcaoInversa
            // 
            this.checkBoxOpcaoInversa.AutoSize = true;
            this.checkBoxOpcaoInversa.Location = new System.Drawing.Point(196, 111);
            this.checkBoxOpcaoInversa.Name = "checkBoxOpcaoInversa";
            this.checkBoxOpcaoInversa.Size = new System.Drawing.Size(63, 17);
            this.checkBoxOpcaoInversa.TabIndex = 10;
            this.checkBoxOpcaoInversa.Text = "Inversa";
            this.checkBoxOpcaoInversa.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiretoGaussPivotamentoTotal
            // 
            this.radioButtonDiretoGaussPivotamentoTotal.AutoSize = true;
            this.radioButtonDiretoGaussPivotamentoTotal.Location = new System.Drawing.Point(9, 66);
            this.radioButtonDiretoGaussPivotamentoTotal.Name = "radioButtonDiretoGaussPivotamentoTotal";
            this.radioButtonDiretoGaussPivotamentoTotal.Size = new System.Drawing.Size(149, 17);
            this.radioButtonDiretoGaussPivotamentoTotal.TabIndex = 3;
            this.radioButtonDiretoGaussPivotamentoTotal.TabStop = true;
            this.radioButtonDiretoGaussPivotamentoTotal.Tag = "GaussPivotTotal";
            this.radioButtonDiretoGaussPivotamentoTotal.Text = "Gauss - pivotamento total";
            this.radioButtonDiretoGaussPivotamentoTotal.UseVisualStyleBackColor = true;
            this.radioButtonDiretoGaussPivotamentoTotal.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // checkBoxOpcaoDeterminante
            // 
            this.checkBoxOpcaoDeterminante.AutoSize = true;
            this.checkBoxOpcaoDeterminante.Location = new System.Drawing.Point(196, 93);
            this.checkBoxOpcaoDeterminante.Name = "checkBoxOpcaoDeterminante";
            this.checkBoxOpcaoDeterminante.Size = new System.Drawing.Size(91, 17);
            this.checkBoxOpcaoDeterminante.TabIndex = 9;
            this.checkBoxOpcaoDeterminante.Text = "Determinante";
            this.checkBoxOpcaoDeterminante.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Opções Adicionais";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewDados);
            this.groupBox3.Location = new System.Drawing.Point(12, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 263);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados";
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.AllowUserToDeleteRows = false;
            this.dataGridViewDados.AllowUserToResizeColumns = false;
            this.dataGridViewDados.AllowUserToResizeRows = false;
            this.dataGridViewDados.ColumnHeadersHeight = 22;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22});
            this.dataGridViewDados.EnableHeadersVisualStyles = false;
            this.dataGridViewDados.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewDados.MultiSelect = false;
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.RowHeadersVisible = false;
            this.dataGridViewDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDados.Size = new System.Drawing.Size(303, 90);
            this.dataGridViewDados.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonLimpar);
            this.groupBox4.Controls.Add(this.buttonCalcular);
            this.groupBox4.Location = new System.Drawing.Point(12, 115);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 41);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Solução";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.AutoSize = true;
            this.buttonLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLimpar.FlatAppearance.BorderSize = 0;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Image = global::SistemasLineares.Properties.Resources.delete;
            this.buttonLimpar.Location = new System.Drawing.Point(102, 16);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(22, 22);
            this.buttonLimpar.TabIndex = 1;
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.AutoSize = true;
            this.buttonCalcular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCalcular.FlatAppearance.BorderSize = 0;
            this.buttonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcular.Image = global::SistemasLineares.Properties.Resources.confirm;
            this.buttonCalcular.Location = new System.Drawing.Point(27, 16);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(22, 22);
            this.buttonCalcular.TabIndex = 0;
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "A";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "1";
            this.Column2.MinimumWidth = 60;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2";
            this.Column3.MinimumWidth = 60;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "3";
            this.Column4.MinimumWidth = 60;
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "4";
            this.Column5.MinimumWidth = 60;
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Visible = false;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "5";
            this.Column6.MinimumWidth = 60;
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Visible = false;
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "6";
            this.Column7.MinimumWidth = 60;
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Visible = false;
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "7";
            this.Column8.MinimumWidth = 60;
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Visible = false;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "8";
            this.Column9.MinimumWidth = 60;
            this.Column9.Name = "Column9";
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Visible = false;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "9";
            this.Column10.MinimumWidth = 60;
            this.Column10.Name = "Column10";
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Visible = false;
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "10";
            this.Column11.MinimumWidth = 60;
            this.Column11.Name = "Column11";
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column11.Visible = false;
            this.Column11.Width = 60;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "11";
            this.Column12.MinimumWidth = 60;
            this.Column12.Name = "Column12";
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column12.Visible = false;
            this.Column12.Width = 60;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "12";
            this.Column13.MinimumWidth = 60;
            this.Column13.Name = "Column13";
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column13.Visible = false;
            this.Column13.Width = 60;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "13";
            this.Column14.MinimumWidth = 60;
            this.Column14.Name = "Column14";
            this.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column14.Visible = false;
            this.Column14.Width = 60;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "14";
            this.Column15.MinimumWidth = 60;
            this.Column15.Name = "Column15";
            this.Column15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column15.Visible = false;
            this.Column15.Width = 60;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "15";
            this.Column16.MinimumWidth = 60;
            this.Column16.Name = "Column16";
            this.Column16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column16.Visible = false;
            this.Column16.Width = 60;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "16";
            this.Column17.MinimumWidth = 60;
            this.Column17.Name = "Column17";
            this.Column17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column17.Visible = false;
            this.Column17.Width = 60;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "17";
            this.Column18.MinimumWidth = 60;
            this.Column18.Name = "Column18";
            this.Column18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column18.Visible = false;
            this.Column18.Width = 60;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "18";
            this.Column19.MinimumWidth = 60;
            this.Column19.Name = "Column19";
            this.Column19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column19.Visible = false;
            this.Column19.Width = 60;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "19";
            this.Column20.MinimumWidth = 60;
            this.Column20.Name = "Column20";
            this.Column20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column20.Visible = false;
            this.Column20.Width = 60;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "20";
            this.Column21.MinimumWidth = 60;
            this.Column21.Name = "Column21";
            this.Column21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column21.Visible = false;
            this.Column21.Width = 60;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "b";
            this.Column22.MinimumWidth = 60;
            this.Column22.Name = "Column22";
            this.Column22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column22.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 437);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemas Lineares";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVariaveis)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTolerancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIteracao)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxPreencherZeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownVariaveis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxOpcaoInversa;
        private System.Windows.Forms.CheckBox checkBoxOpcaoDeterminante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownTolerancia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownIteracao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonIterativoGauss;
        private System.Windows.Forms.RadioButton radioButtonIterativoJacobi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.RadioButton radioButtonDiretoGaussCompacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonDiretoGaussSimples;
        private System.Windows.Forms.RadioButton radioButtonDiretoCholesky;
        private System.Windows.Forms.RadioButton radioButtonDiretoGaussPivotamentoParcial;
        private System.Windows.Forms.RadioButton radioButtonDiretoDecomposicaoLU;
        private System.Windows.Forms.RadioButton radioButtonDiretoGaussPivotamentoTotal;
        private System.Windows.Forms.Button buttonAlteraGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
    }
}

