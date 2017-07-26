namespace Raizes {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBuscaInterromper = new System.Windows.Forms.Button();
            this.buttonBuscaGrafico = new System.Windows.Forms.Button();
            this.buttonBuscaLimpar = new System.Windows.Forms.Button();
            this.buttonBuscaCalcular = new System.Windows.Forms.Button();
            this.dataGridViewBuscaIntervalos = new System.Windows.Forms.DataGridView();
            this.textBoxBuscaValorDelta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBuscaValorB = new System.Windows.Forms.TextBox();
            this.textBoxBuscaValorA = new System.Windows.Forms.TextBox();
            this.textBoxBuscaFuncao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPrecisaoCopiar = new System.Windows.Forms.Button();
            this.textBoxPrecisaoValorEpsilon = new System.Windows.Forms.TextBox();
            this.textBoxPrecisaoFuncao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPrecisaoValorB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrecisaoValorA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonMetodoNewtonModificado = new System.Windows.Forms.RadioButton();
            this.radioButtonMetodoNewton = new System.Windows.Forms.RadioButton();
            this.radioButtonMetodoCordasModificado = new System.Windows.Forms.RadioButton();
            this.radioButtonMetodoCordas = new System.Windows.Forms.RadioButton();
            this.radioButtonMetodoBissecao = new System.Windows.Forms.RadioButton();
            this.radioButtonMetodoBuscaUniforme = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonPrecisaoGrafico = new System.Windows.Forms.Button();
            this.buttonPrecisaoInterromper = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxPrecisaoGrafico = new System.Windows.Forms.CheckBox();
            this.buttonPrecisaoLimpar = new System.Windows.Forms.Button();
            this.buttonPrecisaoCalcular = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxPrecisaoValorFuncao = new System.Windows.Forms.TextBox();
            this.textBoxPrecisaoValorX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscaIntervalos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBuscaInterromper);
            this.groupBox1.Controls.Add(this.buttonBuscaGrafico);
            this.groupBox1.Controls.Add(this.buttonBuscaLimpar);
            this.groupBox1.Controls.Add(this.buttonBuscaCalcular);
            this.groupBox1.Controls.Add(this.dataGridViewBuscaIntervalos);
            this.groupBox1.Controls.Add(this.textBoxBuscaValorDelta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxBuscaValorB);
            this.groupBox1.Controls.Add(this.textBoxBuscaValorA);
            this.groupBox1.Controls.Add(this.textBoxBuscaFuncao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Função, intervalo de busca e passo para separar intervalos com indício de conter " +
    "raízes";
            // 
            // buttonBuscaInterromper
            // 
            this.buttonBuscaInterromper.FlatAppearance.BorderSize = 0;
            this.buttonBuscaInterromper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscaInterromper.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscaInterromper.Image")));
            this.buttonBuscaInterromper.Location = new System.Drawing.Point(643, 113);
            this.buttonBuscaInterromper.Name = "buttonBuscaInterromper";
            this.buttonBuscaInterromper.Size = new System.Drawing.Size(30, 23);
            this.buttonBuscaInterromper.TabIndex = 15;
            this.buttonBuscaInterromper.UseVisualStyleBackColor = true;
            this.buttonBuscaInterromper.Click += new System.EventHandler(this.buttonBuscaInterromper_Click);
            // 
            // buttonBuscaGrafico
            // 
            this.buttonBuscaGrafico.FlatAppearance.BorderSize = 0;
            this.buttonBuscaGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscaGrafico.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscaGrafico.Image")));
            this.buttonBuscaGrafico.Location = new System.Drawing.Point(645, 21);
            this.buttonBuscaGrafico.Name = "buttonBuscaGrafico";
            this.buttonBuscaGrafico.Size = new System.Drawing.Size(25, 23);
            this.buttonBuscaGrafico.TabIndex = 11;
            this.buttonBuscaGrafico.UseVisualStyleBackColor = true;
            this.buttonBuscaGrafico.Click += new System.EventHandler(this.buttonBuscaGrafico_Click);
            // 
            // buttonBuscaLimpar
            // 
            this.buttonBuscaLimpar.FlatAppearance.BorderSize = 0;
            this.buttonBuscaLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscaLimpar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscaLimpar.Image")));
            this.buttonBuscaLimpar.Location = new System.Drawing.Point(645, 84);
            this.buttonBuscaLimpar.Name = "buttonBuscaLimpar";
            this.buttonBuscaLimpar.Size = new System.Drawing.Size(25, 23);
            this.buttonBuscaLimpar.TabIndex = 10;
            this.buttonBuscaLimpar.UseVisualStyleBackColor = true;
            this.buttonBuscaLimpar.Click += new System.EventHandler(this.buttonBuscaLimpar_Click);
            // 
            // buttonBuscaCalcular
            // 
            this.buttonBuscaCalcular.FlatAppearance.BorderSize = 0;
            this.buttonBuscaCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscaCalcular.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscaCalcular.Image")));
            this.buttonBuscaCalcular.Location = new System.Drawing.Point(645, 53);
            this.buttonBuscaCalcular.Name = "buttonBuscaCalcular";
            this.buttonBuscaCalcular.Size = new System.Drawing.Size(25, 23);
            this.buttonBuscaCalcular.TabIndex = 9;
            this.buttonBuscaCalcular.UseVisualStyleBackColor = true;
            this.buttonBuscaCalcular.Click += new System.EventHandler(this.buttonBuscaCalcular_Click);
            // 
            // dataGridViewBuscaIntervalos
            // 
            this.dataGridViewBuscaIntervalos.AllowUserToAddRows = false;
            this.dataGridViewBuscaIntervalos.AllowUserToDeleteRows = false;
            this.dataGridViewBuscaIntervalos.AllowUserToResizeColumns = false;
            this.dataGridViewBuscaIntervalos.AllowUserToResizeRows = false;
            this.dataGridViewBuscaIntervalos.ColumnHeadersHeight = 22;
            this.dataGridViewBuscaIntervalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBuscaIntervalos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridViewBuscaIntervalos.EnableHeadersVisualStyles = false;
            this.dataGridViewBuscaIntervalos.Location = new System.Drawing.Point(9, 51);
            this.dataGridViewBuscaIntervalos.MultiSelect = false;
            this.dataGridViewBuscaIntervalos.Name = "dataGridViewBuscaIntervalos";
            this.dataGridViewBuscaIntervalos.ReadOnly = true;
            this.dataGridViewBuscaIntervalos.RowHeadersVisible = false;
            this.dataGridViewBuscaIntervalos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBuscaIntervalos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewBuscaIntervalos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewBuscaIntervalos.Size = new System.Drawing.Size(633, 85);
            this.dataGridViewBuscaIntervalos.TabIndex = 8;
            this.dataGridViewBuscaIntervalos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuscaIntervalos_CellClick);
            // 
            // textBoxBuscaValorDelta
            // 
            this.textBoxBuscaValorDelta.Location = new System.Drawing.Point(580, 23);
            this.textBoxBuscaValorDelta.Name = "textBoxBuscaValorDelta";
            this.textBoxBuscaValorDelta.Size = new System.Drawing.Size(61, 21);
            this.textBoxBuscaValorDelta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Δ =";
            // 
            // textBoxBuscaValorB
            // 
            this.textBoxBuscaValorB.Location = new System.Drawing.Point(489, 23);
            this.textBoxBuscaValorB.Name = "textBoxBuscaValorB";
            this.textBoxBuscaValorB.Size = new System.Drawing.Size(61, 21);
            this.textBoxBuscaValorB.TabIndex = 5;
            // 
            // textBoxBuscaValorA
            // 
            this.textBoxBuscaValorA.Location = new System.Drawing.Point(400, 23);
            this.textBoxBuscaValorA.Name = "textBoxBuscaValorA";
            this.textBoxBuscaValorA.Size = new System.Drawing.Size(61, 21);
            this.textBoxBuscaValorA.TabIndex = 4;
            // 
            // textBoxBuscaFuncao
            // 
            this.textBoxBuscaFuncao.Location = new System.Drawing.Point(48, 23);
            this.textBoxBuscaFuncao.Name = "textBoxBuscaFuncao";
            this.textBoxBuscaFuncao.Size = new System.Drawing.Size(324, 21);
            this.textBoxBuscaFuncao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "f(x) =";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonPrecisaoCopiar);
            this.groupBox2.Controls.Add(this.textBoxPrecisaoValorEpsilon);
            this.groupBox2.Controls.Add(this.textBoxPrecisaoFuncao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxPrecisaoValorB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxPrecisaoValorA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Função, intervalo de busca e precisão para calcular raiz no intervalo";
            // 
            // buttonPrecisaoCopiar
            // 
            this.buttonPrecisaoCopiar.FlatAppearance.BorderSize = 0;
            this.buttonPrecisaoCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrecisaoCopiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrecisaoCopiar.Image")));
            this.buttonPrecisaoCopiar.Location = new System.Drawing.Point(643, 18);
            this.buttonPrecisaoCopiar.Name = "buttonPrecisaoCopiar";
            this.buttonPrecisaoCopiar.Size = new System.Drawing.Size(27, 27);
            this.buttonPrecisaoCopiar.TabIndex = 19;
            this.buttonPrecisaoCopiar.UseVisualStyleBackColor = true;
            this.buttonPrecisaoCopiar.Click += new System.EventHandler(this.buttonPrecisaoCopiar_Click);
            // 
            // textBoxPrecisaoValorEpsilon
            // 
            this.textBoxPrecisaoValorEpsilon.Location = new System.Drawing.Point(580, 23);
            this.textBoxPrecisaoValorEpsilon.Name = "textBoxPrecisaoValorEpsilon";
            this.textBoxPrecisaoValorEpsilon.Size = new System.Drawing.Size(61, 21);
            this.textBoxPrecisaoValorEpsilon.TabIndex = 18;
            // 
            // textBoxPrecisaoFuncao
            // 
            this.textBoxPrecisaoFuncao.Location = new System.Drawing.Point(48, 23);
            this.textBoxPrecisaoFuncao.Name = "textBoxPrecisaoFuncao";
            this.textBoxPrecisaoFuncao.Size = new System.Drawing.Size(324, 21);
            this.textBoxPrecisaoFuncao.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "ε =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "f(x) =";
            // 
            // textBoxPrecisaoValorB
            // 
            this.textBoxPrecisaoValorB.Location = new System.Drawing.Point(489, 23);
            this.textBoxPrecisaoValorB.Name = "textBoxPrecisaoValorB";
            this.textBoxPrecisaoValorB.Size = new System.Drawing.Size(61, 21);
            this.textBoxPrecisaoValorB.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "b =";
            // 
            // textBoxPrecisaoValorA
            // 
            this.textBoxPrecisaoValorA.Location = new System.Drawing.Point(400, 23);
            this.textBoxPrecisaoValorA.Name = "textBoxPrecisaoValorA";
            this.textBoxPrecisaoValorA.Size = new System.Drawing.Size(61, 21);
            this.textBoxPrecisaoValorA.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "a =";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonMetodoNewtonModificado);
            this.groupBox3.Controls.Add(this.radioButtonMetodoNewton);
            this.groupBox3.Controls.Add(this.radioButtonMetodoCordasModificado);
            this.groupBox3.Controls.Add(this.radioButtonMetodoCordas);
            this.groupBox3.Controls.Add(this.radioButtonMetodoBissecao);
            this.groupBox3.Controls.Add(this.radioButtonMetodoBuscaUniforme);
            this.groupBox3.Location = new System.Drawing.Point(12, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Métodos disponíveis";
            // 
            // radioButtonMetodoNewtonModificado
            // 
            this.radioButtonMetodoNewtonModificado.AutoSize = true;
            this.radioButtonMetodoNewtonModificado.Location = new System.Drawing.Point(149, 72);
            this.radioButtonMetodoNewtonModificado.Name = "radioButtonMetodoNewtonModificado";
            this.radioButtonMetodoNewtonModificado.Size = new System.Drawing.Size(178, 17);
            this.radioButtonMetodoNewtonModificado.TabIndex = 5;
            this.radioButtonMetodoNewtonModificado.Text = "Método de Newton (modificado)";
            this.radioButtonMetodoNewtonModificado.UseVisualStyleBackColor = true;
            // 
            // radioButtonMetodoNewton
            // 
            this.radioButtonMetodoNewton.AutoSize = true;
            this.radioButtonMetodoNewton.Location = new System.Drawing.Point(10, 72);
            this.radioButtonMetodoNewton.Name = "radioButtonMetodoNewton";
            this.radioButtonMetodoNewton.Size = new System.Drawing.Size(116, 17);
            this.radioButtonMetodoNewton.TabIndex = 4;
            this.radioButtonMetodoNewton.Text = "Método de Newton";
            this.radioButtonMetodoNewton.UseVisualStyleBackColor = true;
            // 
            // radioButtonMetodoCordasModificado
            // 
            this.radioButtonMetodoCordasModificado.AutoSize = true;
            this.radioButtonMetodoCordasModificado.Location = new System.Drawing.Point(149, 49);
            this.radioButtonMetodoCordasModificado.Name = "radioButtonMetodoCordasModificado";
            this.radioButtonMetodoCordasModificado.Size = new System.Drawing.Size(180, 17);
            this.radioButtonMetodoCordasModificado.TabIndex = 3;
            this.radioButtonMetodoCordasModificado.Text = "Método das Cordas (modificado)";
            this.radioButtonMetodoCordasModificado.UseVisualStyleBackColor = true;
            // 
            // radioButtonMetodoCordas
            // 
            this.radioButtonMetodoCordas.AutoSize = true;
            this.radioButtonMetodoCordas.Location = new System.Drawing.Point(9, 49);
            this.radioButtonMetodoCordas.Name = "radioButtonMetodoCordas";
            this.radioButtonMetodoCordas.Size = new System.Drawing.Size(118, 17);
            this.radioButtonMetodoCordas.TabIndex = 2;
            this.radioButtonMetodoCordas.Text = "Método das Cordas";
            this.radioButtonMetodoCordas.UseVisualStyleBackColor = true;
            // 
            // radioButtonMetodoBissecao
            // 
            this.radioButtonMetodoBissecao.AutoSize = true;
            this.radioButtonMetodoBissecao.Location = new System.Drawing.Point(149, 26);
            this.radioButtonMetodoBissecao.Name = "radioButtonMetodoBissecao";
            this.radioButtonMetodoBissecao.Size = new System.Drawing.Size(120, 17);
            this.radioButtonMetodoBissecao.TabIndex = 1;
            this.radioButtonMetodoBissecao.Text = "Método da Bisseção";
            this.radioButtonMetodoBissecao.UseVisualStyleBackColor = true;
            // 
            // radioButtonMetodoBuscaUniforme
            // 
            this.radioButtonMetodoBuscaUniforme.AutoSize = true;
            this.radioButtonMetodoBuscaUniforme.Checked = true;
            this.radioButtonMetodoBuscaUniforme.Location = new System.Drawing.Point(10, 26);
            this.radioButtonMetodoBuscaUniforme.Name = "radioButtonMetodoBuscaUniforme";
            this.radioButtonMetodoBuscaUniforme.Size = new System.Drawing.Size(99, 17);
            this.radioButtonMetodoBuscaUniforme.TabIndex = 0;
            this.radioButtonMetodoBuscaUniforme.TabStop = true;
            this.radioButtonMetodoBuscaUniforme.Tag = "1";
            this.radioButtonMetodoBuscaUniforme.Text = "Busca Uniforme";
            this.radioButtonMetodoBuscaUniforme.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.buttonPrecisaoGrafico);
            this.groupBox4.Controls.Add(this.buttonPrecisaoInterromper);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.checkBoxPrecisaoGrafico);
            this.groupBox4.Controls.Add(this.buttonPrecisaoLimpar);
            this.groupBox4.Controls.Add(this.buttonPrecisaoCalcular);
            this.groupBox4.Location = new System.Drawing.Point(353, 229);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opções de apresentação";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "0";
            // 
            // buttonPrecisaoGrafico
            // 
            this.buttonPrecisaoGrafico.FlatAppearance.BorderSize = 0;
            this.buttonPrecisaoGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrecisaoGrafico.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrecisaoGrafico.Image")));
            this.buttonPrecisaoGrafico.Location = new System.Drawing.Point(10, 66);
            this.buttonPrecisaoGrafico.Name = "buttonPrecisaoGrafico";
            this.buttonPrecisaoGrafico.Size = new System.Drawing.Size(25, 23);
            this.buttonPrecisaoGrafico.TabIndex = 16;
            this.buttonPrecisaoGrafico.UseVisualStyleBackColor = true;
            this.buttonPrecisaoGrafico.Click += new System.EventHandler(this.buttonPrecisaoGrafico_Click);
            // 
            // buttonPrecisaoInterromper
            // 
            this.buttonPrecisaoInterromper.FlatAppearance.BorderSize = 0;
            this.buttonPrecisaoInterromper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrecisaoInterromper.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrecisaoInterromper.Image")));
            this.buttonPrecisaoInterromper.Location = new System.Drawing.Point(96, 66);
            this.buttonPrecisaoInterromper.Name = "buttonPrecisaoInterromper";
            this.buttonPrecisaoInterromper.Size = new System.Drawing.Size(30, 23);
            this.buttonPrecisaoInterromper.TabIndex = 16;
            this.buttonPrecisaoInterromper.UseVisualStyleBackColor = true;
            this.buttonPrecisaoInterromper.Click += new System.EventHandler(this.buttonPrecisaoInterromper_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Iterações";
            // 
            // checkBoxPrecisaoGrafico
            // 
            this.checkBoxPrecisaoGrafico.AutoSize = true;
            this.checkBoxPrecisaoGrafico.Location = new System.Drawing.Point(10, 46);
            this.checkBoxPrecisaoGrafico.Name = "checkBoxPrecisaoGrafico";
            this.checkBoxPrecisaoGrafico.Size = new System.Drawing.Size(121, 17);
            this.checkBoxPrecisaoGrafico.TabIndex = 13;
            this.checkBoxPrecisaoGrafico.Text = "Gráfico após cálculo";
            this.checkBoxPrecisaoGrafico.UseVisualStyleBackColor = true;
            // 
            // buttonPrecisaoLimpar
            // 
            this.buttonPrecisaoLimpar.FlatAppearance.BorderSize = 0;
            this.buttonPrecisaoLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrecisaoLimpar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPrecisaoLimpar.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrecisaoLimpar.Image")));
            this.buttonPrecisaoLimpar.Location = new System.Drawing.Point(70, 67);
            this.buttonPrecisaoLimpar.Name = "buttonPrecisaoLimpar";
            this.buttonPrecisaoLimpar.Size = new System.Drawing.Size(20, 20);
            this.buttonPrecisaoLimpar.TabIndex = 12;
            this.buttonPrecisaoLimpar.UseVisualStyleBackColor = true;
            this.buttonPrecisaoLimpar.Click += new System.EventHandler(this.buttonPrecisaoLimpar_Click);
            // 
            // buttonPrecisaoCalcular
            // 
            this.buttonPrecisaoCalcular.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPrecisaoCalcular.FlatAppearance.BorderSize = 0;
            this.buttonPrecisaoCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrecisaoCalcular.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPrecisaoCalcular.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrecisaoCalcular.Image")));
            this.buttonPrecisaoCalcular.Location = new System.Drawing.Point(41, 68);
            this.buttonPrecisaoCalcular.Name = "buttonPrecisaoCalcular";
            this.buttonPrecisaoCalcular.Size = new System.Drawing.Size(23, 19);
            this.buttonPrecisaoCalcular.TabIndex = 11;
            this.buttonPrecisaoCalcular.Tag = "";
            this.buttonPrecisaoCalcular.UseVisualStyleBackColor = false;
            this.buttonPrecisaoCalcular.Click += new System.EventHandler(this.buttonPrecisaoCalcular_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxPrecisaoValorFuncao);
            this.groupBox5.Controls.Add(this.textBoxPrecisaoValorX);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(506, 229);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(179, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Solução";
            // 
            // textBoxPrecisaoValorFuncao
            // 
            this.textBoxPrecisaoValorFuncao.Location = new System.Drawing.Point(42, 54);
            this.textBoxPrecisaoValorFuncao.Name = "textBoxPrecisaoValorFuncao";
            this.textBoxPrecisaoValorFuncao.Size = new System.Drawing.Size(127, 21);
            this.textBoxPrecisaoValorFuncao.TabIndex = 14;
            // 
            // textBoxPrecisaoValorX
            // 
            this.textBoxPrecisaoValorX.Location = new System.Drawing.Point(42, 23);
            this.textBoxPrecisaoValorX.Name = "textBoxPrecisaoValorX";
            this.textBoxPrecisaoValorX.Size = new System.Drawing.Size(127, 21);
            this.textBoxPrecisaoValorX.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "f(x) =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "x =";
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "i";
            this.Column1.MinimumWidth = 60;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "1";
            this.Column2.MinimumWidth = 60;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2";
            this.Column3.MinimumWidth = 60;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "3";
            this.Column4.MinimumWidth = 60;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "4";
            this.Column5.MinimumWidth = 60;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "5";
            this.Column6.MinimumWidth = 60;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "6";
            this.Column7.MinimumWidth = 60;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "7";
            this.Column8.MinimumWidth = 60;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 70;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "8";
            this.Column9.MinimumWidth = 60;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 339);
            this.Controls.Add(this.groupBox5);
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
            this.Text = "Raízes de funções com uma variável real";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscaIntervalos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewBuscaIntervalos;
        private System.Windows.Forms.TextBox textBoxBuscaValorDelta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBuscaValorB;
        private System.Windows.Forms.TextBox textBoxBuscaValorA;
        private System.Windows.Forms.TextBox textBoxBuscaFuncao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscaLimpar;
        private System.Windows.Forms.Button buttonBuscaCalcular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPrecisaoValorEpsilon;
        private System.Windows.Forms.TextBox textBoxPrecisaoFuncao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPrecisaoValorB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrecisaoValorA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonMetodoNewtonModificado;
        private System.Windows.Forms.RadioButton radioButtonMetodoNewton;
        private System.Windows.Forms.RadioButton radioButtonMetodoCordasModificado;
        private System.Windows.Forms.RadioButton radioButtonMetodoCordas;
        private System.Windows.Forms.RadioButton radioButtonMetodoBissecao;
        private System.Windows.Forms.RadioButton radioButtonMetodoBuscaUniforme;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBoxPrecisaoGrafico;
        private System.Windows.Forms.Button buttonPrecisaoLimpar;
        private System.Windows.Forms.Button buttonPrecisaoCalcular;
        private System.Windows.Forms.TextBox textBoxPrecisaoValorFuncao;
        private System.Windows.Forms.TextBox textBoxPrecisaoValorX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonPrecisaoCopiar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonBuscaGrafico;
        private System.Windows.Forms.Button buttonBuscaInterromper;
        private System.Windows.Forms.Button buttonPrecisaoInterromper;
        private System.Windows.Forms.Button buttonPrecisaoGrafico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

