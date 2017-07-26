namespace SistemasNaoLineares {
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
            this.buttonAlteraGrade = new System.Windows.Forms.Button();
            this.OrdemSistema = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonNewtonModificado = new System.Windows.Forms.RadioButton();
            this.radioButtonNewton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CriterioIteracao = new System.Windows.Forms.NumericUpDown();
            this.CriterioEpsilon = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelContadorIteracoes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCalcula = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdemSistema)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CriterioIteracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriterioEpsilon)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAlteraGrade);
            this.groupBox1.Controls.Add(this.OrdemSistema);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordem do Sistema";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // buttonAlteraGrade
            // 
            this.buttonAlteraGrade.Image = global::SistemasNaoLineares.Properties.Resources.grid;
            this.buttonAlteraGrade.Location = new System.Drawing.Point(77, 40);
            this.buttonAlteraGrade.Name = "buttonAlteraGrade";
            this.buttonAlteraGrade.Size = new System.Drawing.Size(24, 24);
            this.buttonAlteraGrade.TabIndex = 2;
            this.buttonAlteraGrade.UseCompatibleTextRendering = true;
            this.buttonAlteraGrade.UseVisualStyleBackColor = true;
            this.buttonAlteraGrade.Click += new System.EventHandler(this.buttonAlteraGrade_Click);
            // 
            // OrdemSistema
            // 
            this.OrdemSistema.Location = new System.Drawing.Point(9, 42);
            this.OrdemSistema.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.OrdemSistema.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.OrdemSistema.Name = "OrdemSistema";
            this.OrdemSistema.Size = new System.Drawing.Size(45, 20);
            this.OrdemSistema.TabIndex = 1;
            this.OrdemSistema.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.OrdemSistema.ValueChanged += new System.EventHandler(this.OrdemSistema_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "2 ≤ n ≤ 10";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonNewtonModificado);
            this.groupBox2.Controls.Add(this.radioButtonNewton);
            this.groupBox2.Location = new System.Drawing.Point(146, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Métodos";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // radioButtonNewtonModificado
            // 
            this.radioButtonNewtonModificado.AutoSize = true;
            this.radioButtonNewtonModificado.Location = new System.Drawing.Point(5, 43);
            this.radioButtonNewtonModificado.Name = "radioButtonNewtonModificado";
            this.radioButtonNewtonModificado.Size = new System.Drawing.Size(114, 19);
            this.radioButtonNewtonModificado.TabIndex = 1;
            this.radioButtonNewtonModificado.Text = "Newton Modificado";
            this.radioButtonNewtonModificado.UseCompatibleTextRendering = true;
            this.radioButtonNewtonModificado.UseVisualStyleBackColor = true;
            // 
            // radioButtonNewton
            // 
            this.radioButtonNewton.AutoSize = true;
            this.radioButtonNewton.Checked = true;
            this.radioButtonNewton.Location = new System.Drawing.Point(5, 17);
            this.radioButtonNewton.Name = "radioButtonNewton";
            this.radioButtonNewton.Size = new System.Drawing.Size(59, 19);
            this.radioButtonNewton.TabIndex = 0;
            this.radioButtonNewton.TabStop = true;
            this.radioButtonNewton.Text = "Newton";
            this.radioButtonNewton.UseCompatibleTextRendering = true;
            this.radioButtonNewton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CriterioIteracao);
            this.groupBox3.Controls.Add(this.CriterioEpsilon);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(288, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Critério de Parada";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // CriterioIteracao
            // 
            this.CriterioIteracao.Location = new System.Drawing.Point(123, 14);
            this.CriterioIteracao.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CriterioIteracao.Name = "CriterioIteracao";
            this.CriterioIteracao.Size = new System.Drawing.Size(43, 20);
            this.CriterioIteracao.TabIndex = 3;
            this.CriterioIteracao.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // CriterioEpsilon
            // 
            this.CriterioEpsilon.DecimalPlaces = 4;
            this.CriterioEpsilon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.CriterioEpsilon.Location = new System.Drawing.Point(107, 41);
            this.CriterioEpsilon.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CriterioEpsilon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.CriterioEpsilon.Name = "CriterioEpsilon";
            this.CriterioEpsilon.Size = new System.Drawing.Size(59, 20);
            this.CriterioEpsilon.TabIndex = 2;
            this.CriterioEpsilon.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "0,01 ≤ ɛ ≤ 0,0001";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "10 ≤ Iterações ≤ 100";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelContadorIteracoes);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.buttonLimpar);
            this.groupBox4.Controls.Add(this.buttonCalcula);
            this.groupBox4.Location = new System.Drawing.Point(470, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(102, 75);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Solução";
            this.groupBox4.UseCompatibleTextRendering = true;
            // 
            // labelContadorIteracoes
            // 
            this.labelContadorIteracoes.AutoSize = true;
            this.labelContadorIteracoes.Location = new System.Drawing.Point(78, 20);
            this.labelContadorIteracoes.Name = "labelContadorIteracoes";
            this.labelContadorIteracoes.Size = new System.Drawing.Size(13, 13);
            this.labelContadorIteracoes.TabIndex = 5;
            this.labelContadorIteracoes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Iterações =";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Image = global::SistemasNaoLineares.Properties.Resources.delete;
            this.buttonLimpar.Location = new System.Drawing.Point(49, 39);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(24, 24);
            this.buttonLimpar.TabIndex = 3;
            this.buttonLimpar.UseCompatibleTextRendering = true;
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCalcula
            // 
            this.buttonCalcula.Image = global::SistemasNaoLineares.Properties.Resources.confirm;
            this.buttonCalcula.Location = new System.Drawing.Point(20, 39);
            this.buttonCalcula.Name = "buttonCalcula";
            this.buttonCalcula.Size = new System.Drawing.Size(24, 24);
            this.buttonCalcula.TabIndex = 4;
            this.buttonCalcula.UseCompatibleTextRendering = true;
            this.buttonCalcula.UseVisualStyleBackColor = true;
            this.buttonCalcula.Click += new System.EventHandler(this.buttonCalcula_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox5.Location = new System.Drawing.Point(10, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(562, 278);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ponto Inicial e Equações";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeight = 22;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(8, 22);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(543, 244);
            this.dataGridView.TabIndex = 0;
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
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "xi Inicial";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 95;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "f[i] (x)";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "xi Final";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 115;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "f[i] (x) Final";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 115;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 377);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemas de Equações Não-Lineares";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdemSistema)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CriterioIteracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriterioEpsilon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAlteraGrade;
        private System.Windows.Forms.NumericUpDown OrdemSistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonNewtonModificado;
        private System.Windows.Forms.RadioButton radioButtonNewton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown CriterioEpsilon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown CriterioIteracao;
        private System.Windows.Forms.Button buttonCalcula;
        private System.Windows.Forms.Label labelContadorIteracoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

