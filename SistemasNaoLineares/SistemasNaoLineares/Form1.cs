using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace SistemasNaoLineares {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            CarregaDataGridView();
            AlteraDataGridView();
        }

        void CarregaDataGridView() {
            dataGridView.Rows.Clear();
            dataGridView.Rows.Add(10);

            for (int i = 0; i < 10; i++) {
                dataGridView.Rows[i].Cells[0].Value = (i + 1).ToString();
                dataGridView.Rows[i].Cells[0].Style.BackColor = SystemColors.Control;
            }
        }

        void AlteraDataGridView() {
            int i, n;

            n = int.Parse(OrdemSistema.Value.ToString());

            for (i = 0; i < n; i++) {
                dataGridView.Rows[i].ReadOnly = false;
                dataGridView.Rows[i].DefaultCellStyle.BackColor = SystemColors.Window;
                dataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                dataGridView.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            }

            for (i = n; i < 10; i++) {
                dataGridView.Rows[i].ReadOnly = true;
                dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                dataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightGray;
                dataGridView.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;

            }
        }

        // FUNÇÕES PARA CALCULO DE DERIVADAS DE FUNÇÕES DO Rn

        double[] CriaVetor(DataGridView data, int tam) {
            double[] vet = new double[10];
            string s = "";
            for (int i = 1; i <= tam; i++) {
                s = data.Rows[0].Cells[i].Value.ToString();
                s = s.Replace('.', ',');
                double.TryParse(s, out vet[i - 1]);
            }

            return vet;
        }

        void CriaFuncaoRn(out Function f, String Expressao, int numVar) {
            switch (numVar) {
                case 2:
                    f = new Function("f", Expressao, "x1", "x2");
                    break;
                case 3:
                    f = new Function("f", Expressao, "x1", "x2", "x3");
                    break;
                case 4:
                    f = new Function("f", Expressao, "x1", "x2", "x3", "x4");
                    break;
                case 5:
                    f = new Function("f", Expressao, "x1", "x2", "x3", "x4", "x5");
                    break;
                case 6:
                    f = new Function("f", Expressao, "x1", "x2", "x3", "x4", "x5", "x6");
                    break;
                case 7:
                    f = new Function("f", Expressao, "x1", "x2", "x3", "x4", "x5", "x6", "x7");
                    break;
                case 8:
                    f = new Function("f", Expressao, "x1", "x2", "x3", "x4", "x5", "x6", "x7", "x8");
                    break;
                case 9:
                    f = new Function("f", Expressao, "x1", "x2", "x3", "x4", "x5", "x6", "x7", "x8", "x9");
                    break;
                default:
                    f = new Function("f", Expressao, "x1", "x2", "x3", "x4", "x5", "x6", "x7", "x8", "x9", "x10");
                    break;
            }

        }

        double CalculaFuncaoRn(Function f, double[] x, int tam) {
            switch (tam) {
                case 2:
                    return f.calculate(x[0], x[1]);
                case 3:
                    return f.calculate(x[0], x[1], x[2]);
                case 4:
                    return f.calculate(x[0], x[1], x[2], x[3]);
                case 5:
                    return f.calculate(x[0], x[1], x[2], x[3], x[4]);
                case 6:
                    return f.calculate(x[0], x[1], x[2], x[3], x[4], x[5]);
                case 7:
                    return f.calculate(x[0], x[1], x[2], x[3], x[4], x[5], x[6]);
                case 8:
                    return f.calculate(x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7]);
                case 9:
                    return f.calculate(x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7], x[8]);
                case 10:
                    return f.calculate(x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7], x[8], x[9]);
                default:
                    return 0; // nunca vai acontecer
            }
        }

        void DerivadaParcial(Function f, double[] x, double epsilon, int i, int tam, out double d) {
            double h, p, q, xi, f1, f2;

            h = 1000 * epsilon;
            xi = x[i];
            x[i] = xi + h;
            f1 = CalculaFuncaoRn(f, x, tam);

            if (double.IsNaN(f1) || double.IsInfinity(f1))
                throw new ErroAoCalularJacobiano();

            x[i] = xi - h;
            f2 = CalculaFuncaoRn(f, x, tam);

            if (double.IsNaN(f2) || double.IsInfinity(f2))
                throw new ErroAoCalularJacobiano();

            p = (f1 - f2) / (2 * h);
            for (int k = 1; k <= 10; k++) {
                q = p;
                h = h / 2;
                x[i] = xi + h;
                f1 = CalculaFuncaoRn(f, x, tam);

                if (double.IsNaN(f1) || double.IsInfinity(f1))
                    throw new ErroAoCalularJacobiano();

                x[i] = xi - h;
                f2 = CalculaFuncaoRn(f, x, tam);

                if (double.IsNaN(f1) || double.IsInfinity(f1))
                    throw new ErroAoCalularJacobiano();

                p = (f1 - f2) / (2 * h);
                if (Math.Abs((p - q)) < epsilon)
                    break;
            }
            x[i] = xi;
            d = p;
        }

        double[] CalculaJacobiano(Function f, double[] x, double epsilon, int linha, int tam) {
            double[] d;
            d = new double[tam];

            for (int i = 0; i < tam; i++) {
                try {
                    DerivadaParcial(f, x, epsilon, i, tam, out d[i]);
                } catch (ErroAoCalularJacobiano) {
                    throw new ErroAoCalularJacobiano("Não foi possível calcular a linha " + (i + 1) + " do Jacobiano.");
                } catch (Exception erro) {
                    throw new Exception("Alguma coisa deu errado.\n\n Erro:" + erro.Message);
                }
            }
            return d;
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
                        throw new DivideByZeroException("A[" + (j + 1) + "][" + (j + 1) + "] é igual a zero ou foi zerado durante a execução do método.");
                    }

                    if (double.IsNaN(m))
                        throw new DivideByZeroException("A[" + (j + 1) + "][" + (j + 1) + "] é igual a zero ou foi zerado durante a execução do método.");

                    for (k = j; k < n; k++) // anda pela coluna da matriz A, alterando linha da matriz
                        A[i, k] = A[i, k] - m * A[j, k];
                    b[i] = b[i] - m * b[j];
                }
            }

            try {
                x[n - 1] = b[n - 1] / A[n - 1, n - 1];
            }
            catch (DivideByZeroException) {
                throw new DivideByZeroException("A[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução do método.");
            }

            if (double.IsNaN(x[n - 1]))
                throw new DivideByZeroException("A[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução do método.");

            for (i = n - 2; i >= 0; i--) {
                soma = 0;
                for (j = i + 1; j < n; j++)
                    soma += A[i, j] * x[j];
                try {
                    x[i] = (b[i] - soma) / A[i, i];
                }
                catch (DivideByZeroException) {
                    throw new DivideByZeroException("A[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a execução do método.");
                }

                if (double.IsNaN(x[i]))
                    throw new DivideByZeroException("A[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a execução do método.");
            }
        }

        double Norma(int n, double[] h) {
            int i;
            double soma;

            soma = 0;
            for (i = 0; i < n; i++)
                soma += Math.Pow(h[i], 2);

            return Math.Sqrt(soma);
        }

        void MetodoNewton(int n, int maxIt, double Epsilon) {
            int i, j, k = 0;
            double norma, FX;
            double [] aux, X, F, h;
            double[,] Jacobiano;
            string[] expressao;
            Function f;

            X = new double[n];
            F = new double[n];
            h = new double[n];
            aux = new double[n];
            Jacobiano = new double[n, n];
            expressao = new string[n];

            for (i = 0; i < n; i++) {
                try {
                    X[i] = double.Parse(dataGridView.Rows[i].Cells[1].Value.ToString().Replace('.', ','));
                } catch (Exception) {
                    dataGridView.Rows[i].Cells[1].Selected = true;
                    throw new ErroAoLerXi("Digite um valor válido para x" + (i + 1) + ".");
                }
                try {
                    expressao[i] = dataGridView.Rows[i].Cells[2].Value.ToString().Replace(',', '.');
                } catch (Exception) {
                    dataGridView.Rows[i].Cells[2].Selected = true;
                    throw new ErroAoLerFXi("Função f[ " + (i + 1) + "] não informada.");
                }

                if (String.IsNullOrWhiteSpace(expressao[i])) {
                    dataGridView.Rows[i].Cells[2].Selected = true;
                    throw new ErroAoLerFXi("Função f[ " + (i + 1) + "] não informada.");
                }
            }

            while (k < maxIt) {
                k++;
                labelContadorIteracoes.Text = k.ToString();
                labelContadorIteracoes.Update();
                System.Threading.Thread.Sleep(10);

                for (i = 0; i < n; i++) {
                    CriaFuncaoRn(out f, expressao[i], n);

                    if (f.checkSyntax() == false) {
                        dataGridView.Rows[i].Cells[2].Selected = true;
                        throw new ErroAoLerFXi("Verifique se a sintaxe da função f[" + (i + 1) + "].");
                    }

                    F[i] = (-1) * CalculaFuncaoRn(f, X, n); // calcula -F(X)

                    if (double.IsNaN(F[i]) || double.IsInfinity(F[i])) {
                        throw new ErroAoCalcularFXi("Não foi possível calcular F[x" + (i + 1) + "].");
                    }

                    try {
                        aux = CalculaJacobiano(f, X, Epsilon, i, n);
                    } catch (ErroAoCalularJacobiano erro) {
                        throw new ErroAoCalularJacobiano(erro.Message);
                    } catch (Exception erro) {
                        throw new ErroAoCalularJacobiano(erro.Message);
                    }

                    for (j = 0; j < n; j++)
                        Jacobiano[i, j] = aux[j];
                }

                try {
                    GaussSimples(Jacobiano, F, out h, n);
                } catch (DivideByZeroException erro) {
                    throw new ErroAoCalcularGauss(erro.Message);
                } catch (Exception erro) {
                    throw new ErroAoCalcularGauss("Problema interno: " + erro.Message);
                }

                for (i = 0; i < n; i++)
                    X[i] = X[i] + h[i];

                try {
                    norma = Norma(n, h);
                } catch (Exception) {
                    throw new ErroAoCalularNorma("Não foi possível calcular o critério de parada ||xk+1 - xk|| na iteração " + k + ".");
                }

                if (double.IsNaN(norma) || double.IsInfinity(norma))
                    throw new ErroAoCalularNorma("Não foi possível calcular o critério de parada ||xk+1 - xk|| na iteração " + k + ".");

                if (norma <= Epsilon) {
                    for (i = 0; i < n; i++) {
                        dataGridView.Rows[i].Cells[3].Value = X[i];
                        CriaFuncaoRn(out f, expressao[i], n);
                        FX = CalculaFuncaoRn(f, X, n);
                        dataGridView.Rows[i].Cells[4].Value = CalculaFuncaoRn(f, X, n);
                    }
                    return;
                }
            }

            throw new ErroExcedeuNumeroIteracoes();
        }

        void MetodoNewtonModificado(int n, int maxIt, double Epsilon) {
            int i, j, k = 0;
            double norma;
            double [] aux, X, F, h;
            double[,] Jacobiano;
            string[] expressao;
            Function f;

            X = new double[n];
            F = new double[n];
            h = new double[n];
            aux = new double[n];
            Jacobiano = new double[n, n];
            expressao = new string[n];

            for (i = 0; i < n; i++) {
                try {
                    X[i] = double.Parse(dataGridView.Rows[i].Cells[1].Value.ToString().Replace('.', ','));
                }
                catch (Exception) {
                    dataGridView.Rows[i].Cells[1].Selected = true;
                    throw new ErroAoLerXi("Digite um valor válido para x" + (i + 1) + ".");
                }
                try {
                    expressao[i] = dataGridView.Rows[i].Cells[2].Value.ToString().Replace(',', '.');
                }
                catch (Exception) {
                    dataGridView.Rows[i].Cells[2].Selected = true;
                    throw new ErroAoLerFXi("Função f[ " + (i + 1) + "] não informada.");
                }

                if (String.IsNullOrWhiteSpace(expressao[i])) {
                    dataGridView.Rows[i].Cells[2].Selected = true;
                    throw new ErroAoLerFXi("Função f[ " + (i + 1) + "] não informada.");
                }
            }

            for (i = 0; i < n; i++) {
                CriaFuncaoRn(out f, expressao[i], n);

                if (f.checkSyntax() == false) {
                    dataGridView.Rows[i].Cells[2].Selected = true;
                    throw new ErroAoLerFXi("Verifique se a sintaxe da função f[" + (i + 1) + "].");
                }

                try {
                    aux = CalculaJacobiano(f, X, Epsilon, i, n);
                }
                catch (ErroAoCalularJacobiano erro) {
                    throw new ErroAoCalularJacobiano(erro.Message);
                }
                catch (Exception erro) {
                    throw new ErroAoCalularJacobiano(erro.Message);
                }

                for (j = 0; j < n; j++)
                    Jacobiano[i, j] = aux[j];
            }

            while (k < maxIt) {
                k++;
                labelContadorIteracoes.Text = k.ToString();
                labelContadorIteracoes.Update();
                System.Threading.Thread.Sleep(10);

                for (i = 0; i < n; i++) {
                    CriaFuncaoRn(out f, expressao[i], n);

                    F[i] = (-1) * CalculaFuncaoRn(f, X, n); // calcula -F(X)

                    if (double.IsNaN(F[i]) || double.IsInfinity(F[i])) {
                        throw new ErroAoCalcularFXi("Não foi possível calcular F[x" + (i + 1) + "].");
                    }

                    //if (k % n == 0) {
                    //    aux = CalculaJacobiano(f, X, Epsilon, i, n);

                    //    for (j = 0; j < n; j++)
                    //        Jacobiano[i, j] = aux[j];
                    //} 
                }

                try {
                    GaussSimples(Jacobiano, F, out h, n);
                }
                catch (DivideByZeroException erro) {
                    throw new ErroAoCalcularGauss(erro.Message);
                }
                catch (Exception erro) {
                    throw new ErroAoCalcularGauss("Problema interno: " + erro.Message);
                }

                for (i = 0; i < n; i++)
                    X[i] = X[i] + h[i];

                try {
                    norma = Norma(n, h);
                }
                catch (Exception) {
                    throw new ErroAoCalularNorma();
                }

                if (norma <= Epsilon) {
                    for (i = 0; i < n; i++) {
                        dataGridView.Rows[i].Cells[3].Value = Math.Round(X[i], 15);
                        CriaFuncaoRn(out f, expressao[i], n);
                        dataGridView.Rows[i].Cells[4].Value = Math.Round(CalculaFuncaoRn(f, X, n), 15);
                    }
                    return;
                }
            }

            throw new ErroExcedeuNumeroIteracoes();
        }

        private void buttonCalcula_Click(object sender, EventArgs e) {
            int n, maxIt;
            double Epsilon;

            try {
                n = int.Parse(OrdemSistema.Value.ToString());
            } catch (Exception erro) {
                MessageBox.Show("Problema interno ao ler ordem do sistema.\n\nErro: " + erro.Message, "Sistemas de Equações Não-Lineares",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                OrdemSistema.Focus();
                return;
            }

            try {
                Epsilon = double.Parse(CriterioEpsilon.Value.ToString());
            } catch (Exception erro) {
                MessageBox.Show("Problema interno ao ler valor de Epsilon.\n\nErro: " + erro.Message, "Sistemas de Equações Não-Lineares",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                CriterioEpsilon.Focus();
                return;
            }

            try {
                maxIt = int.Parse(CriterioIteracao.Value.ToString());
            } catch (Exception erro) {
                MessageBox.Show("Problema interno ao ler número de iterações.\n\nErro: " + erro.Message, "Sistemas de Equações Não-Lineares",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                CriterioIteracao.Focus();
                return;
            }

            try {
                if (radioButtonNewton.Checked)
                    MetodoNewton(n, maxIt, Epsilon);
                else
                    MetodoNewtonModificado(n, maxIt, Epsilon);
            } catch (ErroAoLerXi erro) {
                MessageBox.Show(erro.Message, "Sistemas de Equações Não-Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpa(n);
            } catch (ErroAoLerFXi erro) {
                MessageBox.Show(erro.Message, "Sistemas de Equações Não-Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpa(n);
            } catch (ErroAoCalcularFXi erro) {
                MessageBox.Show(erro.Message, "Sistemas de Equações Não-Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpa(n);
            } catch (ErroAoCalularJacobiano erro) {
                MessageBox.Show(erro.Message, "Sistemas de Equações Não-Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpa(n);
            } catch (ErroAoCalcularGauss erro) {
                MessageBox.Show("Erro ao triangularizar a matriz do Jacobiano\n\n." + erro.Message, "Sistemas de Equações Não-Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpa(n);
            } catch (ErroAoCalularNorma erro) {
                MessageBox.Show(erro.Message, "Sistemas de Equações Não-Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpa(n);
            } catch (ErroExcedeuNumeroIteracoes) {
                MessageBox.Show("Não convergiu com número de iterações selecionado.", "Sistemas de Equações Não-Lineares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa(n);
            } catch (Exception erro) {
                MessageBox.Show("Problema interno: " + erro.Message, "Sistemas de Equações Não-Lineares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa(n);
            }
        }

        // limpa valores de xi Final e f[i] (x) Final na grade caso acontece algum erro
        void Limpa(int n) {
            for (int i = 0; i < n; i++) {
                dataGridView.Rows[i].Cells[3].Value = "";
                dataGridView.Rows[i].Cells[4].Value = "";
            }
        }

        private void buttonAlteraGrade_Click(object sender, EventArgs e) {
            AlteraDataGridView();
        }

        private void OrdemSistema_ValueChanged(object sender, EventArgs e) {
            AlteraDataGridView();
        }

        private void buttonLimpar_Click(object sender, EventArgs e) {
            CarregaDataGridView();
            labelContadorIteracoes.Text = "0";
        }
    }

    public class ErroAoLerXi : Exception {
        public ErroAoLerXi() : base() { }
        public ErroAoLerXi(String message) : base(message) { }
    }

    public class ErroAoLerFXi : Exception {
        public ErroAoLerFXi() : base() { }
        public ErroAoLerFXi(String message) : base(message) { }
    }

    public class ErroAoCalcularFXi : Exception {
        public ErroAoCalcularFXi() : base() { }
        public ErroAoCalcularFXi(String message) : base(message) { }
    }

    public class ErroAoCalcularGauss : Exception {
        public ErroAoCalcularGauss() : base() { }
        public ErroAoCalcularGauss(String message) : base(message) { }
    }

    public class ErroAoCalularJacobiano : Exception {
        public ErroAoCalularJacobiano() : base() { }
        public ErroAoCalularJacobiano(String message) : base(message) { }
    }

    public class ErroAoCalularNorma : Exception {
        public ErroAoCalularNorma() : base() { }
        public ErroAoCalularNorma(String message) : base(message) { }
    }

    public class ErroExcedeuNumeroIteracoes : Exception {
        public ErroExcedeuNumeroIteracoes() : base() { }
        public ErroExcedeuNumeroIteracoes(String message) : base(message) { }
    }
}
