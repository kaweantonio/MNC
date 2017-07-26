using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjusteCurvas {
    public partial class Form1 : Form {
        Globals varGlobal;

        public Form1() {
            InitializeComponent();
        }

        public class Globals {
            public CheckBox ck;
            public string[] DadosXs, DadosYs;

            public Globals(int n) {
                DadosXs = new string[n];
                DadosYs = new string[n];
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            varGlobal = new Globals(int.Parse(TamanhoAmostra.Maximum.ToString()));

            AlteraDataGridViewAmostra();
            CarregaDataGridViewPolinomio();
            CarregaDataGridViewCurvas();
        }

        void CarregaDataGridViewPolinomio() {
            dataGridViewPolinomios.Rows.Add(5);

            for (int i = 0; i < 5; i++) {
                dataGridViewPolinomios.Rows[i].Cells[0].Value = (i + 1);
                dataGridViewPolinomios.Rows[i].Cells[1].Value = (i + 2);
                dataGridViewPolinomios.Rows[i].Cells[2].Value = false;

                for (int j = 3; j <= 10; j++)
                    dataGridViewPolinomios.Rows[i].Cells[j].Value = "";
            }

            Rectangle rect = dataGridViewPolinomios.GetCellDisplayRectangle(2, -1, true);
            rect.Y = 4;
            rect.X = rect.Location.X + (rect.Width / 4) + 1;
            CheckBox checkboxHeader = new CheckBox();
            checkboxHeader.Name = "checkboxHeader";
            checkboxHeader.Size = new Size(18, 18);
            checkboxHeader.Location = rect.Location;
            checkboxHeader.Click += new EventHandler(checkboxHeader_Click);
            dataGridViewPolinomios.Controls.Add(checkboxHeader);
            varGlobal.ck = checkboxHeader;
        }

        private void checkboxHeader_Click(object sender, EventArgs e) {
            CheckBox checkboxHeader = sender as CheckBox;
            
            foreach (DataGridViewRow row in dataGridViewPolinomios.Rows) {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell) row.Cells[2];
                chk.Value = checkboxHeader.Checked;
            }

            dataGridViewPolinomios.EndEdit();
        }

        void CarregaDataGridViewCurvas() {
            dataGridViewCurvas.Rows.Add(5);

            dataGridViewCurvas.Rows[0].Cells[0].Value = "y = a + b.x";
            dataGridViewCurvas.Rows[1].Cells[0].Value = "y = a.e^(b.x)";
            dataGridViewCurvas.Rows[2].Cells[0].Value = "y = a.b^x";
            dataGridViewCurvas.Rows[3].Cells[0].Value = "y = 1/(a+b.x)";
            dataGridViewCurvas.Rows[4].Cells[0].Value = "y = a.x^b";

            for (int i = 0; i < 5; i++)
                for (int j = 1; j <= 3; j++)
                    dataGridViewCurvas.Rows[i].Cells[j].Value = "";

        }

        void AlteraDataGridViewAmostra() {
            int n = int.Parse(TamanhoAmostra.Value.ToString());

            dataGridViewDadosAmostra.Rows.Clear();
            dataGridViewDadosAmostra.Rows.Add(n);

            for (int i = 0; i < n; i++) {
                dataGridViewDadosAmostra.Rows[i].Cells[0].Value = (i+1);
            }

            if (n <= 14) {
                dataGridViewDadosAmostra.Height = (n + 1) * 22 + 2;
            }
            else
                dataGridViewDadosAmostra.Height = 15 * 22 + 2;
        }

        void LimpaDataGridViewPolinomio() {
            for (int i = 0; i < 5; i++) {
                if ((bool) dataGridViewPolinomios.Rows[i].Cells[2].Value == false) {
                    for (int j = 0; j < 8; j++) {
                        dataGridViewPolinomios.Rows[i].Cells[3 + j].Value = "";
                    }
                }
            }
        }

        void LimpaLinhaDataGridViewCurvas(int linha) {
            for (int i = 1; i <= 3; i++) {
                dataGridViewCurvas.Rows[linha].Cells[i].Value = "";
            }
        }

        void LimpaDataGridViewCurvas() {
            if (checkBoxCurva1.Checked == false)
                LimpaLinhaDataGridViewCurvas(0);
            if (checkBoxCurva2.Checked == false)
                LimpaLinhaDataGridViewCurvas(1);
            if (checkBoxCurva3.Checked == false)
                LimpaLinhaDataGridViewCurvas(2);
            if (checkBoxCurva4.Checked == false)
                LimpaLinhaDataGridViewCurvas(3);
            if (checkBoxCurva5.Checked == false)
                LimpaLinhaDataGridViewCurvas(4);
        }

        void SalvaDadosAmostra() {
            int n = int.Parse(TamanhoAmostra.Value.ToString());
            for (int i = 0; i <= n; i++) {
                try {
                    varGlobal.DadosXs[i] = dataGridViewDadosAmostra.Rows[i].Cells[1].Value.ToString();
                }
                catch (ArgumentOutOfRangeException) {}
                catch (Exception) {
                    varGlobal.DadosXs[i] = "";
                }
                try {
                    varGlobal.DadosYs[i] = dataGridViewDadosAmostra.Rows[i].Cells[2].Value.ToString();
                }
                catch (ArgumentOutOfRangeException) { }
                catch (Exception) {
                    varGlobal.DadosYs[i] = "";
                }
            }
        }

        void RestauraDadosAmostra() {
            int n = int.Parse(TamanhoAmostra.Value.ToString());
            for (int i = 0; i < n; i++) {
                dataGridViewDadosAmostra.Rows[i].Cells[1].Value = varGlobal.DadosXs[i];
                dataGridViewDadosAmostra.Rows[i].Cells[2].Value = varGlobal.DadosYs[i];
            }
        }

        private void dataGridViewPolinomios_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            if (dataGridViewPolinomios.IsCurrentCellDirty) {
                dataGridViewPolinomios.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridViewPolinomios_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if ((bool) dataGridViewPolinomios.Rows[0].Cells[2].Value && (bool) dataGridViewPolinomios.Rows[1].Cells[2].Value && (bool) dataGridViewPolinomios.Rows[2].Cells[2].Value
             && (bool) dataGridViewPolinomios.Rows[3].Cells[2].Value && (bool) dataGridViewPolinomios.Rows[4].Cells[2].Value) {
                varGlobal.ck.Checked = true;
            }
            else
                varGlobal.ck.Checked = false;
        }

        private void buttonAlteraGrid_Click(object sender, EventArgs e) {
            SalvaDadosAmostra();
            AlteraDataGridViewAmostra();
            RestauraDadosAmostra();
        }

        void GaussSimples(double[,] A, double[] b, out double[] x, int n) {
            int i, j, k;

            double m, soma;
            x = new double[n];

            for (j = 0; j < n - 1; j++) { // anda pela coluna da matriz A
                for (i = j + 1; i < n; i++) { // anda pela linha da matriz A    
                    try {
                        m = A[i, j] / A[j, j];
                    }
                    catch (DivideByZeroException) {
                        throw new DivideByZeroException("A[" + (j + 1) + "][" + (j + 1) + "] é igual a zero ou foi zerado durante a execução do método." +
                                                                "\n\nTente por Gauss - Pivotamento Parcial ou Total");
                    }

                    if (double.IsNaN(m))
                        throw new DivideByZeroException("A[" + (j + 1) + "][" + (j + 1) + "] é igual a zero ou foi zerado durante a execução do método." +
                                                                "\n\nTente por Gauss - Pivotamento Parcial ou Total");

                    for (k = j; k < n; k++) // anda pela coluna da matriz A, alterando linha da matriz
                        A[i, k] = A[i, k] - m * A[j, k];
                    b[i] = b[i] - m * b[j];
                }
            }

            try {
                x[n - 1] = b[n - 1] / A[n - 1, n - 1];
            }
            catch (DivideByZeroException) {
                throw new DivideByZeroException("A[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução do método." +
                                        "\n\nTente por Gauss - Pivotamento Parcial ou Total");
            }

            if (double.IsNaN(x[n - 1]))
                throw new DivideByZeroException("A[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução do método." +
                                        "\n\nTente por Gauss - Pivotamento Parcial ou Total");

            for (i = n - 2; i >= 0; i--) {
                soma = 0;
                for (j = i + 1; j < n; j++)
                    soma += A[i, j] * x[j];
                try {
                    x[i] = (b[i] - soma) / A[i, i];
                }
                catch (DivideByZeroException) {
                    throw new DivideByZeroException("A[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a execução do método." +
                                    "\n\nTente por Gauss - Pivotamento Parcial ou Total");
                }

                if (double.IsNaN(x[i]))
                    throw new DivideByZeroException("A[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a execução do método." +
                                    "\n\nTente por Gauss - Pivotamento Parcial ou Total");
            }
        }

        void AjustaPolinomio(int m, int n, double[] xGrade, double[] yGrade) {
            int i, j, k;

            double[,] A;
            double[] x, b, a;
            double somaX, somaY, somaY2, somaE2, YChapeu, R2;

            A = new double[m, m];
            x = new double[m];
            b = new double[m];
            a = new double[m];

            for (i = 0; i < m; i++) {
                for (j = i; j < m; j++) {
                    somaX = 0.0;
                    for (k = 0; k < n; k++) {
                        somaX += Math.Pow(xGrade[k], j + i);
                    }

                    A[i, j] = somaX;
                }
            }

            for (i = 0; i < m; i++) {
                somaY = 0.0;
                for (j = 0; j < n; j++) {
                    somaY += Math.Pow(xGrade[j], i) * yGrade[j];
                }

                b[i] = somaY;
            }

            for (i = 1; i < m; i++) {
                for (j = 0; j < i; j++) {
                    A[i, j] = A[j, i];
                }
            }

            somaY = b[0];

            GaussSimples(A, b, out x, m);

            for (i = 0; i < m; i++)
                dataGridViewPolinomios.Rows[m - 3].Cells[i + 3].Value = x[i];

            somaY2 = 0; somaE2 = 0; // somaY já calculado
            x.CopyTo(a, 0);

            for (i = 0; i < n; i++) {
                YChapeu = 0;

                somaY2 += Math.Pow(yGrade[i], 2);
                for (j = 0; j < m; j++)
                    YChapeu += a[j] * Math.Pow(xGrade[i], j); // x[i] eh o coeficiente da funcao yChapeu, e xGrade representa
                                                              // o valor x onde a funcao será calculada.
                somaE2 += Math.Pow(yGrade[i] - YChapeu, 2);
            }

            R2 = 1 - ((n * somaE2) / (n * somaY2 - somaY * somaY));

            dataGridViewPolinomios.Rows[m - 3].Cells["ColunaR2"].Value = R2;
        }

        void AjusteCurva1(int n, double[] xGrade, double[] yGrade) {
            int i, j, k;

            double[,] A;
            double[] x, b, a;
            double somaX, somaY, somaY2, somaE2, YChapeu, R2;

            A = new double[2, 2];
            x = new double[2];
            b = new double[2];
            a = new double[2];

            for (i = 0; i < 2; i++) {
                for (j = i; j < 2; j++) {
                    somaX = 0.0;
                    for (k = 0; k < n; k++) {
                        somaX += Math.Pow(xGrade[k], j + i);
                    }

                    A[i, j] = somaX;
                }
            }

            for (i = 0; i < 2; i++) {
                somaY = 0.0;
                for (j = 0; j < n; j++) {
                    somaY += Math.Pow(xGrade[j], i) * yGrade[j];
                }

                b[i] = somaY;
            }

            for (i = 1; i < 2; i++) {
                for (j = 0; j < i; j++) {
                    A[i, j] = A[j, i];
                }
            }

            somaY = b[0];

            GaussSimples(A, b, out x, 2);
            x.CopyTo(a, 0);

            for (i = 0; i < 2; i++)
                dataGridViewCurvas.Rows[0].Cells[i + 1].Value = x[i];

            somaY2 = 0; somaE2 = 0; // somaY já calculado
            for (i = 0; i < n; i++) {
                YChapeu = 0;

                somaY2 += Math.Pow(yGrade[i], 2);

                YChapeu = a[0] + xGrade[i] * a[1];

                somaE2 += Math.Pow(yGrade[i] - YChapeu, 2);
            }

            R2 = 1 - ((n * somaE2) / (n * somaY2 - somaY * somaY));

            dataGridViewCurvas.Rows[0].Cells["CurvasColunaR2"].Value = R2;
        }

        void AjusteCurva2(int n, double[] xGrade, double[] yGrade) {
            int i, j, k;

            double[,] A;
            double[] x, b, a;
            double somaX, somaY, somaY2, somaE2, YChapeu, R2;

            A = new double[2, 2];
            x = new double[2];
            b = new double[2];
            a = new double[2];

            for (i = 0; i < 2; i++) {
                for (j = i; j < 2; j++) {
                    somaX = 0.0;
                    for (k = 0; k < n; k++) {
                        somaX += Math.Pow(xGrade[k], j + i);
                    }

                    A[i, j] = somaX;
                }
            }

            for (i = 0; i < 2; i++) {
                somaY = 0.0;
                for (j = 0; j < n; j++) {
                    somaY += Math.Pow(xGrade[j], i) * Math.Log(yGrade[j]);
                }

                b[i] = somaY;
            }

            for (i = 1; i < 2; i++) {
                for (j = 0; j < i; j++) {
                    A[i, j] = A[j, i];
                }
            }

            GaussSimples(A, b, out x, 2);

            somaY = b[0];
            x.CopyTo(a, 0);

            x[0] = Math.Exp(x[0]);

            for (i = 0; i < 2; i++)
                dataGridViewCurvas.Rows[1].Cells[i + 1].Value = x[i];

            somaY2 = 0; somaE2 = 0;

            for (i = 0; i < n; i++) {
                YChapeu = 0;

                somaY2 += Math.Pow(Math.Log(yGrade[i]), 2);

                YChapeu = a[0] + xGrade[i] * a[1];

                somaE2 += Math.Pow(Math.Log(yGrade[i]) - YChapeu, 2);
            }

            R2 = 1 - ((n * somaE2) / (n * somaY2 - somaY * somaY));

            dataGridViewCurvas.Rows[1].Cells["CurvasColunaR2"].Value = R2;
        }

        void AjusteCurva3(int n, double[] xGrade, double[] yGrade) {
            int i, j, k;

            double[,] A;
            double[] x, b, a;
            double somaX, somaY, somaY2, somaE2, YChapeu, R2;

            A = new double[2, 2];
            x = new double[2];
            b = new double[2];
            a = new double[2];

            for (i = 0; i < 2; i++) {
                for (j = i; j < 2; j++) {
                    somaX = 0.0;
                    for (k = 0; k < n; k++) {
                        somaX += Math.Pow(xGrade[k], j + i);
                    }

                    A[i, j] = somaX;
                }
            }

            for (i = 0; i < 2; i++) {
                somaY = 0.0;
                for (j = 0; j < n; j++) {
                    somaY += Math.Pow(xGrade[j], i) * Math.Log(yGrade[j]);
                }

                b[i] = somaY;
            }

            for (i = 1; i < 2; i++) {
                for (j = 0; j < i; j++) {
                    A[i, j] = A[j, i];
                }
            }

            GaussSimples(A, b, out x, 2);

            somaY = b[0];
            x.CopyTo(a, 0);

            x[0] = Math.Exp(x[0]);
            x[1] = Math.Exp(x[1]);

            for (i = 0; i < 2; i++)
                dataGridViewCurvas.Rows[2].Cells[i + 1].Value = x[i];

            somaY2 = 0; somaE2 = 0;

            for (i = 0; i < n; i++) {
                YChapeu = 0;

                somaY2 += Math.Pow(Math.Log(yGrade[i]), 2);

                YChapeu = a[0] + xGrade[i] * a[1];

                somaE2 += Math.Pow(Math.Log(yGrade[i]) - YChapeu, 2);
            }

            R2 = 1 - ((n * somaE2) / (n * somaY2 - somaY * somaY));

            dataGridViewCurvas.Rows[2].Cells["CurvasColunaR2"].Value = R2;
        }

        void AjusteCurva4(int n, double[] xGrade, double[] yGrade) {
            int i, j, k;

            double[,] A;
            double[] x, b, a;
            double somaX, somaY, somaY2, somaE2, YChapeu, R2;

            A = new double[2, 2];
            x = new double[2];
            b = new double[2];
            a = new double[2];

            for (i = 0; i < 2; i++) {
                for (j = i; j < 2; j++) {
                    somaX = 0.0;
                    for (k = 0; k < n; k++) {
                        somaX += Math.Pow(xGrade[k], j + i);
                    }

                    A[i, j] = somaX;
                }
            }

            for (i = 0; i < 2; i++) {
                somaY = 0.0;
                for (j = 0; j < n; j++) {
                    somaY += Math.Pow(xGrade[j], i) * (1/yGrade[j]);
                }

                b[i] = somaY;
            }

            for (i = 1; i < 2; i++) {
                for (j = 0; j < i; j++) {
                    A[i, j] = A[j, i];
                }
            }

            GaussSimples(A, b, out x, 2);

            somaY = b[0];
            x.CopyTo(a, 0);

            for (i = 0; i < 2; i++)
                dataGridViewCurvas.Rows[3].Cells[i + 1].Value = x[i];

            somaY2 = 0; somaE2 = 0;

            for (i = 0; i < n; i++) {
                YChapeu = 0;

                somaY2 += Math.Pow(1/yGrade[i], 2);

                YChapeu = a[0] + xGrade[i] * a[1];

                somaE2 += Math.Pow(1/yGrade[i] - YChapeu, 2);
            }

            R2 = 1 - ((n * somaE2) / (n * somaY2 - somaY * somaY));

            dataGridViewCurvas.Rows[3].Cells["CurvasColunaR2"].Value = R2;
        }

        void AjusteCurva5(int n, double[] xGrade, double[] yGrade) {
            int i, j, k;

            double[,] A;
            double[] x, b, a;
            double somaX, somaY, somaY2, somaE2, YChapeu, R2;

            A = new double[2, 2];
            x = new double[2];
            b = new double[2];
            a = new double[2];

            for (i = 0; i < 2; i++) {
                for (j = i; j < 2; j++) {
                    somaX = 0.0;
                    for (k = 0; k < n; k++) {
                        somaX += Math.Pow(Math.Log(xGrade[k]), j + i);
                    }

                    A[i, j] = somaX;
                }
            }

            for (i = 0; i < 2; i++) {
                somaY = 0.0;
                for (j = 0; j < n; j++) {
                    somaY += Math.Pow(Math.Log(xGrade[j]), i) * Math.Log(yGrade[j]);
                }

                b[i] = somaY;
            }

            for (i = 1; i < 2; i++) {
                for (j = 0; j < i; j++) {
                    A[i, j] = A[j, i];
                }
            }

            GaussSimples(A, b, out x, 2);

            somaY = b[0];
            x.CopyTo(a, 0);

            x[0] = Math.Exp(x[0]);

            for (i = 0; i < 2; i++)
                dataGridViewCurvas.Rows[4].Cells[i + 1].Value = x[i];

            somaY2 = 0; somaE2 = 0;

            for (i = 0; i < n; i++) {
                YChapeu = 0;

                somaY2 += Math.Pow(Math.Log(yGrade[i]), 2);

                YChapeu = a[0] + Math.Log(xGrade[i]) * a[1];

                somaE2 += Math.Pow(Math.Log(yGrade[i]) - YChapeu, 2);
            }

            R2 = 1 - ((n * somaE2) / (n * somaY2 - somaY * somaY));

            dataGridViewCurvas.Rows[4].Cells["CurvasColunaR2"].Value = R2;
        }

        void LeGrade(int n, ref double[] xGrade, ref double[] yGrade) {
            for (int i = 0; i < n; i++) {
                try {
                    xGrade[i] = double.Parse(dataGridViewDadosAmostra.Rows[i].Cells[1].Value.ToString());
                } catch (Exception) {
                    dataGridViewDadosAmostra.Rows[i].Cells[1].Selected = true;
                    throw new ErroAoLerGradeAmostra("Valor inválido para x[" + (i + 1) + "].");
                }
                try {
                    yGrade[i] = double.Parse(dataGridViewDadosAmostra.Rows[i].Cells[2].Value.ToString());
                } catch (Exception) {
                    dataGridViewDadosAmostra.Rows[i].Cells[2].Selected = true;
                    throw new ErroAoLerGradeAmostra("Valor inválido para f(x[" + (i + 1) + "]).");
                }
            }
        }

        private void buttonPolinomioCalcula_Click(object sender, EventArgs e) {
            int tamAmostra;
            bool ajuste1, ajuste2, ajuste3, ajuste4, ajuste5;
            double[] xGrade, yGrade;

            tamAmostra = int.Parse(TamanhoAmostra.Value.ToString());

            xGrade = new double[tamAmostra];
            yGrade = new double[tamAmostra];

            try {
                LeGrade(tamAmostra, ref xGrade, ref yGrade);
            } catch (ErroAoLerGradeAmostra erro) {
                MessageBox.Show("Erro na entrada de dados: " + erro.Message, "Ajustes de Curvas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Array.Sort(xGrade, yGrade);

            ajuste1 = (bool) dataGridViewPolinomios.Rows[0].Cells[2].Value;
            ajuste2 = (bool) dataGridViewPolinomios.Rows[1].Cells[2].Value;
            ajuste3 = (bool) dataGridViewPolinomios.Rows[2].Cells[2].Value;
            ajuste4 = (bool) dataGridViewPolinomios.Rows[3].Cells[2].Value;
            ajuste5 = (bool) dataGridViewPolinomios.Rows[4].Cells[2].Value;

            if (!ajuste1 && !ajuste2 && !ajuste3 && !ajuste4 && !ajuste5) {
                MessageBox.Show("Selecione ao menos um tipo de ajuste.", "Ajuste de Curvas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LimpaDataGridViewPolinomio();

            if (ajuste1) {
                try {
                    AjustaPolinomio(2 + 1, tamAmostra, xGrade, yGrade);
                }
                catch (Exception) {
                    dataGridViewPolinomios.Rows[0].Cells[3].Value = "Exceção";
                }

            }
            if (ajuste2) {
                try {
                    AjustaPolinomio(3 + 1, tamAmostra, xGrade, yGrade);
                }
                catch (Exception) {
                    dataGridViewPolinomios.Rows[1].Cells[3].Value = "Exceção";
                }
            }
            if (ajuste3) {
                try {
                    AjustaPolinomio(4 + 1, tamAmostra, xGrade, yGrade);
                }
                catch (Exception) {
                    dataGridViewPolinomios.Rows[2].Cells[3].Value = "Exceção";
                }
            }
            if (ajuste4) {
                try {
                    AjustaPolinomio(5 + 1, tamAmostra, xGrade, yGrade);
                } catch (Exception) {
                    dataGridViewPolinomios.Rows[3].Cells[3].Value = "Exceção";
                }
            }
            if (ajuste5) {
                try {
                    AjustaPolinomio(6 + 1, tamAmostra, xGrade, yGrade);
                }
                catch (Exception) {
                    dataGridViewPolinomios.Rows[4].Cells[3].Value = "Exceção";
                }
            }
        }

        private void buttonPolinomioGrafico_Click(object sender, EventArgs e) {
            int i, tamAmostra, n;

            n = 5;
            tamAmostra = int.Parse(TamanhoAmostra.Value.ToString());

            double[] xGrade = new double[tamAmostra];
            double[] yGrade = new double[tamAmostra];
            double[,] Coeficientes = new double[n, 7];
            bool[] TemAjuste = new bool[n+1];

            for (i = 0; i < n; i++) {
                if (dataGridViewPolinomios.Rows[i].Cells[3].Value.ToString() != ""
                 && dataGridViewPolinomios.Rows[i].Cells[3].Value.ToString() != "Exceção") {
                    TemAjuste[0] = true;
                    TemAjuste[i + 1] = true;
                    Coeficientes[i, 0] = double.Parse(dataGridViewPolinomios.Rows[i].Cells[3].Value.ToString());
                    Coeficientes[i, 1] = double.Parse(dataGridViewPolinomios.Rows[i].Cells[4].Value.ToString());
                    Coeficientes[i, 2] = double.Parse(dataGridViewPolinomios.Rows[i].Cells[5].Value.ToString());
                    if (i == 1) {
                        Coeficientes[i, 3] = double.Parse(dataGridViewPolinomios.Rows[i].Cells[6].Value.ToString());
                    }
                    else if (i == 2) {
                        Coeficientes[i, 3] = double.Parse(dataGridViewPolinomios.Rows[i].Cells[6].Value.ToString());
                        Coeficientes[i, 4] = double.Parse(dataGridViewPolinomios.Rows[i].Cells[7].Value.ToString());
                    }
                    else if (i == 3) {
                        Coeficientes[i, 3] = double.Parse(dataGridViewPolinomios.Rows[i].Cells[6].Value.ToString());
                        Coeficientes[i, 4] = double.Parse(dataGridViewPolinomios.Rows[i].Cells[7].Value.ToString());
                        Coeficientes[i, 5] = double.Parse(dataGridViewPolinomios.Rows[i].Cells[8].Value.ToString());
                    }
                    else if (i == 4) {
                        Coeficientes[i, 3] = double.Parse(dataGridViewPolinomios.Rows[i].Cells[6].Value.ToString());
                        Coeficientes[i, 4] = double.Parse(dataGridViewPolinomios.Rows[i].Cells[7].Value.ToString());
                        Coeficientes[i, 5] = double.Parse(dataGridViewPolinomios.Rows[i].Cells[8].Value.ToString());
                        Coeficientes[i, 6] = double.Parse(dataGridViewPolinomios.Rows[i].Cells[9].Value.ToString());
                    }
                }
            }

            if (TemAjuste[0] == false) {
                MessageBox.Show("Não há curvas ajustadas para desenhar gráficos.", "Ajustes de Curvas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            LeGrade(tamAmostra, ref xGrade, ref yGrade);

            new Form2(tamAmostra, xGrade, yGrade, TemAjuste, 7, Coeficientes).Show();
        }

        private void buttonCurvasCalcula_Click(object sender, EventArgs e) {
            int tamAmostra;
            bool ajuste1, ajuste2, ajuste3, ajuste4, ajuste5;
            double[] xGrade, yGrade;

            tamAmostra = int.Parse(TamanhoAmostra.Value.ToString());

            xGrade = new double[tamAmostra];
            yGrade = new double[tamAmostra];

            try {
                LeGrade(tamAmostra, ref xGrade, ref yGrade);
            } catch (ErroAoLerGradeAmostra erro) {
                MessageBox.Show("Erro na entrada de dados: " + erro.Message, "Ajustes de Curvas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Array.Sort(xGrade, yGrade);

            ajuste1 = checkBoxCurva1.Checked;
            ajuste2 = checkBoxCurva2.Checked;
            ajuste3 = checkBoxCurva3.Checked;
            ajuste4 = checkBoxCurva4.Checked;
            ajuste5 = checkBoxCurva5.Checked;

            if (!ajuste1 && !ajuste2 && !ajuste3 && !ajuste4 && !ajuste5) {
                MessageBox.Show("Selecione ao menos um tipo de ajuste.", "Ajuste de Curvas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LimpaDataGridViewCurvas();

            if (ajuste1) {
                try {
                    AjusteCurva1(tamAmostra, xGrade, yGrade);
                }
                catch (Exception) {
                    dataGridViewCurvas.Rows[0].Cells[1].Value = "Exceção";
                }
            }
            if (ajuste2) {
                try {
                    AjusteCurva2(tamAmostra, xGrade, yGrade);
                }
                catch (Exception) {
                    dataGridViewCurvas.Rows[1].Cells[1].Value = "Exceção";
                }
            }
            if (ajuste3) {
                try {
                    AjusteCurva3(tamAmostra, xGrade, yGrade);
                }
                catch (Exception) {
                    dataGridViewCurvas.Rows[2].Cells[1].Value = "Exceção";
                }
            }
            if (ajuste4) {
                try {
                    AjusteCurva4(tamAmostra, xGrade, yGrade);
                }
                catch (Exception) {
                    dataGridViewCurvas.Rows[3].Cells[1].Value = "Exceção";
                }
            }
            if (ajuste5) {
                try {
                    AjusteCurva5(tamAmostra, xGrade, yGrade);
                }
                catch (Exception) {
                    dataGridViewCurvas.Rows[4].Cells[1].Value = "Exceção";
                }
            }
        }

        private void buttonCurvasGrafico_Click(object sender, EventArgs e) {
            int i, tamAmostra, n;

            n = 5;
            tamAmostra = int.Parse(TamanhoAmostra.Value.ToString());

            double[] xGrade = new double[tamAmostra];
            double[] yGrade = new double[tamAmostra];
            double[,] Coeficientes = new double[n, 2];
            bool[] TemAjuste = new bool[n+1];

            for (i = 0; i < n; i++) {
                if (dataGridViewCurvas.Rows[i].Cells[1].Value.ToString() != ""
                 && dataGridViewCurvas.Rows[i].Cells[1].Value.ToString() != "Exceção") {
                    TemAjuste[0] = true;
                    TemAjuste[i + 1] = true;
                    Coeficientes[i, 0] = double.Parse(dataGridViewCurvas.Rows[i].Cells[1].Value.ToString());
                    Coeficientes[i, 1] = double.Parse(dataGridViewCurvas.Rows[i].Cells[2].Value.ToString());
                }
            }

            if (TemAjuste[0] == false) {
                MessageBox.Show("Não há curvas ajustadas para desenhar gráficos.", "Ajustes de Curvas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            LeGrade(tamAmostra, ref xGrade, ref yGrade);

            new Form2(tamAmostra, xGrade, yGrade, TemAjuste, 2, Coeficientes).Show();
        }

        private void checkBoxCurvaTodos_Click(object sender, EventArgs e) {
            if (checkBoxCurvaTodos.Checked == true) {
                checkBoxCurva1.Checked = true;
                checkBoxCurva2.Checked = true;
                checkBoxCurva3.Checked = true;
                checkBoxCurva4.Checked = true;
                checkBoxCurva5.Checked = true;
            }
            else {
                checkBoxCurva1.Checked = false;
                checkBoxCurva2.Checked = false;
                checkBoxCurva3.Checked = false;
                checkBoxCurva4.Checked = false;
                checkBoxCurva5.Checked = false;
            }
        }

        private void checkBoxCurvaOpcoes_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxCurva1.Checked && checkBoxCurva2.Checked && checkBoxCurva3.Checked
             && checkBoxCurva4.Checked && checkBoxCurva5.Checked) {
                checkBoxCurvaTodos.Checked = true;
            }
            else
                checkBoxCurvaTodos.Checked = false;
        }

        private void TamanhoAmostra_ValueChanged(object sender, EventArgs e) {
            SalvaDadosAmostra();
            AlteraDataGridViewAmostra();
            RestauraDadosAmostra();
        }

        private void dataGridViewCurvas_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }

    public class ErroAoLerGradeAmostra : Exception {
        public ErroAoLerGradeAmostra() : base() { }
        public ErroAoLerGradeAmostra(String message) : base(message) { }
    }
}
