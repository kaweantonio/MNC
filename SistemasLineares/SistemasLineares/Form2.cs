using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasLineares {
    public partial class Form2 : Form {

        public Form2(double[,] matrizA, double[] vetorB, double[] vetorX, int n, bool Deter, double det, bool minv, double[,] inversa) {
            InitializeComponent();
            int i, j;

            AlteraDatagGridView(n);

            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    dataGridViewSolucao.Rows[i].Cells[j + 1].Value = matrizA[i, j];
                }
                dataGridViewSolucao.Rows[i].Cells[21].Value = vetorB[i];
                dataGridViewSolucao.Rows[n].Cells[i + 1].Value = vetorX[i];
            }

            if (Deter) {
                label2.Text = label2.Text + "= " + det;
            }
            else
                label2.Text = label2.Text + " - Não solicitado";

            if (minv) {
                AlteraDatagGridViewInversa(n);
                for (i = 0; i < n; i++) {
                    for (j = 0; j < n; j++) {
                        dataGridViewMatrizInversa.Rows[i].Cells[j + 1].Value = inversa[i, j];
                    }
                }
            }
            else
                label3.Text = label3.Text + " - Não solicitado";
        }

        public Form2(double[,] matrizA, double[] vetorB, double[] vetorX, int n, int[] posXs, bool Deter, double det, bool minv, double[,] inversa) {
            InitializeComponent();
            int i, j;

            AlteraDatagGridView(n);

            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    dataGridViewSolucao.Rows[i].Cells[j + 1].Value = matrizA[i, j];
                }
                dataGridViewSolucao.Rows[i].Cells[21].Value = vetorB[i];
                dataGridViewSolucao.Rows[n].Cells[i + 1].Value = vetorX[posXs[i]];
            }

            if (Deter) {
                label2.Text = label2.Text + "= " + det;
            }
            else
                label2.Text = label2.Text + " - Não solicitado";

            if (minv) {
                AlteraDatagGridViewInversa(n);
                for (i = 0; i < n; i++) {
                    for (j = 0; j < n; j++) {
                        dataGridViewMatrizInversa.Rows[i].Cells[j + 1].Value = inversa[i, j];
                    }
                }
            }
            else
                label3.Text = label3.Text + " - Não solicitado";
        }

        void AlteraDatagGridView(int n) {
            dataGridViewSolucao.Rows.Clear();
            dataGridViewSolucao.Rows.Add(n+1);

            for (int i = 1; i <= n; i++) {
                dataGridViewSolucao.Columns[i].Visible = true;
                dataGridViewSolucao.Columns[i].HeaderText = i.ToString();
                dataGridViewSolucao.Rows[i - 1].Cells[0].Value = i.ToString();
            }

            dataGridViewSolucao.Rows[n].Cells[0].Value = "x";

            for (int i = n + 1; i <= 20; i++) {
                dataGridViewSolucao.Columns[i].Visible = false;
            }

            if (n <= 8) {
                dataGridViewSolucao.Height = (n + 2) * 22 + 2;
                dataGridViewSolucao.Width = (n + 2) * 60 + 3;
            }
            else {
                dataGridViewSolucao.Height = (10) * 22 + 2 + Globals.ScrollBarHorizontalAltura;
                dataGridViewSolucao.Width = (10) * 60 + 3 + Globals.ScrollBarVerticalLargura;
            }
        }

        void AlteraDatagGridViewInversa(int n) {
            dataGridViewMatrizInversa.Rows.Clear();
            dataGridViewMatrizInversa.Rows.Add(n);

            for (int i = 1; i <= n; i++) {
                dataGridViewMatrizInversa.Columns[i].Visible = true;
                dataGridViewMatrizInversa.Columns[i].HeaderText = i.ToString();
                dataGridViewMatrizInversa.Rows[i - 1].Cells[0].Value = i.ToString();
            }

            for (int i = n + 1; i <= 20; i++) {
                dataGridViewMatrizInversa.Columns[i].Visible = false;
            }

            if (n <= 9) {
                dataGridViewMatrizInversa.Height = (n + 1) * 22 + 2;
                dataGridViewMatrizInversa.Width = (n + 1) * 60 + 3;
            }
            else {
                dataGridViewMatrizInversa.Height = (10) * 22 + 2 + Globals.ScrollBarHorizontalAltura;
                dataGridViewMatrizInversa.Width = (10) * 60 + 3 + Globals.ScrollBarVerticalLargura;
            }
        }
    }
}
