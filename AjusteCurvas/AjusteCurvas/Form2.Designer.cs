namespace AjusteCurvas {
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
            this.plotGrafico = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // plotGrafico
            // 
            this.plotGrafico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotGrafico.Font = new System.Drawing.Font("Tahoma", 8F);
            this.plotGrafico.Location = new System.Drawing.Point(0, 0);
            this.plotGrafico.Name = "plotGrafico";
            this.plotGrafico.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotGrafico.Size = new System.Drawing.Size(681, 466);
            this.plotGrafico.TabIndex = 0;
            this.plotGrafico.Text = "plotView1";
            this.plotGrafico.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotGrafico.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotGrafico.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 466);
            this.Controls.Add(this.plotGrafico);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes de Curvas";
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotGrafico;
    }
}