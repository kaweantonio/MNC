namespace Raizes {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.plotViewGrafico = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gráfico da função ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plotViewGrafico
            // 
            this.plotViewGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotViewGrafico.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plotViewGrafico.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.plotViewGrafico.Location = new System.Drawing.Point(12, 25);
            this.plotViewGrafico.Name = "plotViewGrafico";
            this.plotViewGrafico.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewGrafico.Size = new System.Drawing.Size(427, 364);
            this.plotViewGrafico.TabIndex = 1;
            this.plotViewGrafico.Text = "plotView";
            this.plotViewGrafico.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewGrafico.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewGrafico.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 401);
            this.Controls.Add(this.plotViewGrafico);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raízes de funções com uma variável real";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private OxyPlot.WindowsForms.PlotView plotViewGrafico;
    }
}