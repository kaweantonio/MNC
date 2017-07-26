using System;
using System.Windows.Forms;
using MathNet.Numerics;
using OxyPlot;
using OxyPlot.Series;

namespace Interpolacao {
    public partial class Form1 : Form {
        Globals varGlobal;

        public Form1() {
            InitializeComponent();
            AlteraDataGridView(3);
            varGlobal = new Globals();
            DesenhaGrafico();
        }

        public class Globals {
            public double[] xTodos, yTodos;
            public string[] xGrade, yGrade;

            public Globals() {
                xTodos = new double[3];
                yTodos = new double[3];
            }
        }

        void SalvaDados() {
            int i, n;

            n = Math.Min(dataGridViewPontos.RowCount, int.Parse(NumeroPontos.Value.ToString()));

            varGlobal.xGrade = new string[n];
            varGlobal.yGrade = new string[n];

            for (i = 0; i < n; i++) {
                try {
                    varGlobal.xGrade[i] = dataGridViewPontos.Rows[i].Cells[1].Value.ToString();
                }
                catch (Exception) {
                    varGlobal.xGrade[i] = "";
                }
                try {
                    varGlobal.yGrade[i] = dataGridViewPontos.Rows[i].Cells[2].Value.ToString();
                }
                catch (Exception) {
                    varGlobal.yGrade[i] = "";
                }
            }
        }

        void RestauraDados() {
            for (int i = 0; i < varGlobal.xGrade.Length; i++) {
                dataGridViewPontos.Rows[i].Cells[1].Value = varGlobal.xGrade[i];
                dataGridViewPontos.Rows[i].Cells[2].Value = varGlobal.yGrade[i];
            }
        }

        void AlteraDataGridView(int n) {
            dataGridViewPontos.Rows.Clear();
            dataGridViewPontos.Rows.Add(n);

            for (int i = 0; i < n; i++) {
                dataGridViewPontos.Rows[i].Cells[0].Value = i.ToString();
            }

            if (n <= 7) {
                dataGridViewPontos.Height = (n + 1) * 22 + 2;
            }
            else
                dataGridViewPontos.Height = 9 * 22 + 2;
        }

        void PontosProximos(double z, int k, int n, double[] x, double[] fx) {
            int i;
            int[] Indices;
            double[] Distancias;

            Indices = new int[n];
            Distancias = new double[n];

            for (i = 0; i < n; i++) {
                Distancias[i] = Math.Abs(z - x[i]);
                Indices[i] = i;
            }

            Array.Sort(Distancias, Indices);

            for (i = 0; i <= k; i++) {
                x[i] = varGlobal.xTodos[Indices[i]];
                fx[i] = varGlobal.yTodos[Indices[i]];
            }
        }

        void DesenhaGrafico() {
            int i, j, n;
            double passo;
            double xGrafico, yGrafico;

            n = varGlobal.xTodos.Length;

            PlotController plotControles = new PlotController();
            PlotModel funcao = new PlotModel();

            LineSeries polinomio = new LineSeries{
                Title = "Polinômio",
                Color = OxyColors.Black,
                StrokeThickness = 1
            };
            ScatterSeries ponto = new ScatterSeries{
                Title = "Pontos dados",
                MarkerFill = OxyColors.Red,
                MarkerType = MarkerType.Square,
                MarkerSize = 5
            };
            ScatterSeries ponto2 = new ScatterSeries{
                Title = "Pontos selecionados",
                MarkerFill = OxyColors.Blue,
                MarkerType = MarkerType.Circle,
                MarkerSize = 4
            };

            plotControles.UnbindAll();

            passo = (varGlobal.xTodos[n - 1] - varGlobal.xTodos[0]) / 100;

            for (i = 0; i < 100; i++) {
                xGrafico = varGlobal.xTodos[0] + i * passo;
                yGrafico = 0;
                for (j = 0; j < n; j++)
                    yGrafico += Math.Pow(xGrafico, j);
                polinomio.Points.Add(new DataPoint(xGrafico, yGrafico));
            }

            funcao.Series.Add(polinomio);
            funcao.Series.Add(ponto);
            funcao.Series.Add(ponto2);

            ////Assign PlotModel to PlotView
            plotGrafico.Model = funcao;
            plotGrafico.Controller = plotControles;
        }

        void DesenhaGrafico(int k, double[] x, double[] fx, double[] Delta) {
            int i, j, n;
            double passo;
            double xGrafico, yGrafico;

            n = varGlobal.xTodos.Length;

            PlotController plotControles = new PlotController();
            PlotModel funcao = new PlotModel();

            LineSeries polinomio = new LineSeries{
                Title = "Polinômio",
                Color = OxyColors.Black,
                StrokeThickness = 1
            };
            ScatterSeries ponto = new ScatterSeries{
                Title = "Pontos dados",
                MarkerFill = OxyColors.Red,
                MarkerType = MarkerType.Square,
                MarkerSize = 5
            };
            ScatterSeries ponto2 = new ScatterSeries{
                Title = "Pontos selecionados",
                MarkerFill = OxyColors.Blue,
                MarkerType = MarkerType.Circle,
                MarkerSize = 4
            };

            plotControles.UnbindAll();

            passo = (varGlobal.xTodos[n - 1] - varGlobal.xTodos[0]) / 100;

            for (i = 0; i < 100; i++) {
                xGrafico = varGlobal.xTodos[0] + i * passo;
                yGrafico = 0;
                for (j = 0; j < n; j++)
                    yGrafico += Delta[j] * Math.Pow(xGrafico, j);
                polinomio.Points.Add(new DataPoint(xGrafico, yGrafico));
            }

            for (i = 0; i < n; i++) {
                ponto.Points.Add(new ScatterPoint(varGlobal.xTodos[i], varGlobal.yTodos[i], double.NaN, double.NaN, null));
            }

            for (i = 0; i <= k; i++) {
                ponto2.Points.Add(new ScatterPoint(x[i], fx[i], double.NaN, double.NaN, null));
            }

            funcao.Series.Add(polinomio);
            funcao.Series.Add(ponto);
            funcao.Series.Add(ponto2);

            ////Assign PlotModel to PlotView
            plotGrafico.Model = funcao;
            plotGrafico.Controller = plotControles;
        }

        void DesenhaGrafico2(int k, double[] x, double[] fx, double[] Delta) {
            int i, j, n;
            double passo;
            double xGrafico, yGrafico;

            n = varGlobal.xTodos.Length;

            PlotController plotControles = new PlotController();
            PlotModel funcao = new PlotModel();

            LineSeries polinomio = new LineSeries{
                Title = "Polinomio",
                Color = OxyColors.Black,
                StrokeThickness = 1
            };
            ScatterSeries ponto = new ScatterSeries{
                Title = "Pontos dados",
                MarkerFill = OxyColors.Red,
                MarkerType = MarkerType.Square,
                MarkerSize = 5
            };
            ScatterSeries ponto2 = new ScatterSeries{
                Title = "Pontos selecionados",
                MarkerFill = OxyColors.Blue,
                MarkerType = MarkerType.Circle,
                MarkerSize = 4
            };

            plotControles.UnbindAll();

            passo = (varGlobal.xTodos[n - 1] - varGlobal.xTodos[0]) / 100;

            for (i = 0; i < 100; i++) {
                xGrafico = varGlobal.xTodos[0] + i * passo;
                yGrafico = Delta[k];
                for (j = k - 1; j >= 0; j--)
                    yGrafico = yGrafico * (xGrafico - x[j]) + Delta[j];
                polinomio.Points.Add(new DataPoint(xGrafico, yGrafico));
            }

            for (i = 0; i < n; i++) {
                ponto.Points.Add(new ScatterPoint(varGlobal.xTodos[i], varGlobal.yTodos[i], double.NaN, double.NaN, null));
            }

            for (i = 0; i <= k; i++) {
                ponto2.Points.Add(new ScatterPoint(x[i], fx[i], double.NaN, double.NaN, null));
            }

            funcao.Series.Add(polinomio);
            funcao.Series.Add(ponto);
            funcao.Series.Add(ponto2);

            ////Assign PlotModel to PlotView
            plotGrafico.Model = funcao;
            plotGrafico.Controller = plotControles;
        }

        void Gauss(int n, double[,] A, double[] b, ref double[] x) {
            int i, j, k;

            double m, soma;

            for (j = 0; j < n - 1; j++) { // anda pela coluna da matriz A
                for (i = j + 1; i < n; i++) { // anda pela linha da matriz A    

                    m = A[i, j] / A[j, j];

                    for (k = j; k < n; k++) // anda pela coluna da matriz A, alterando linha da matriz
                        A[i, k] = A[i, k] - m * A[j, k];
                    b[i] = b[i] - m * b[j];
                }
            }

            x[n - 1] = b[n - 1] / A[n - 1, n - 1];

            for (i = n - 2; i >= 0; i--) {
                soma = 0;
                for (j = i + 1; j < n; j++)
                    soma += A[i, j] * x[j];
                x[i] = (b[i] - soma) / A[i, i];
            }
        }

        double[] InterpolacaoSistemaLinear(int n, double[] x, double[] fx) {
            int i, j;
            double[,] Mx;
            double[] Vy, Va;

            Mx = new double[n, n];
            Vy = new double[n];
            Va = new double[n];

            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++)
                    Mx[i, j] = Math.Pow(x[i], j);
                Vy[i] = fx[i];
            }

            Gauss(n, Mx, Vy, ref Va);

            return Va;
        }

        double[] Newton(int n, double[] x, double[] fx) {
            int i, j, k;
            double[,] Delta;
            double[] Vy, Va;

            Delta = new double[n, n];
            Vy = new double[n];
            Va = new double[n];

            for (i = 0; i < n; i++)
                Vy[i] = fx[i];

            for (i = 0; i < n; i++)
                Delta[0, i] = Vy[i];

            k = 0;
            for (i = 1; i < n; i++) {
                for (j = 0; j < n - i; j++)
                    Delta[i, j] = (Delta[i-1, j + 1] - Delta[i-1, j]) / (x[j+k+1] - x[j]);
                k++;
            }

            for (i = 0; i < n; i++) {
                Va[i] = Delta[i, 0];
            }

            return Va;
        }

        double[] NewtonGregory(int n, double h, double[] x, double[] fx) {
            int i, j, k;
            double[,] Delta;
            double[] Vy, Va;

            Delta = new double[n, n];
            Vy = new double[n];
            Va = new double[n];

            for (i = 0; i < n; i++)
                Vy[i] = fx[i];

            for (i = 0; i < n; i++)
                Delta[0, i] = Vy[i];

            k = 0;
            for (i = 1; i < n; i++) {
                for (j = 0; j < n - i; j++)
                    Delta[i, j] = (Delta[i - 1, j + 1] - Delta[i - 1, j]);
                k++;
            }

            for (i = 0; i < n; i++) {
                Va[i] = Delta[i, 0] / (Math.Pow(h, i) * SpecialFunctions.Factorial(i));
            }

            return Va;
        }

        int MetodoSelecionado() {
            if (radioButtonSistemaLinear.Checked)
                return 0;
            else if (radioButtonNewton.Checked)
                return 1;
            else // if(radioButtonNewtonGregory.Checked)
                return 2;
        }

        private void buttonCalcular_Click(object sender, EventArgs e) {
            int i, j, k, n, metodo;
            double z, passo;
            double[] vetorX, vetorFx, vetorA, Delta, vetorXResultado;
            z = 0;

            try {
                n = int.Parse(NumeroPontos.Value.ToString());
            } catch (Exception erro) {
                MessageBox.Show("Alguma coisa deu errada ao ler o número de pontos.\n Erro: " + erro.ToString(), "Interpolação Polinomial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumeroPontos.Focus();
                return;
            }

            try {
                k = int.Parse(GrauPolinomio.Value.ToString());
            } catch(Exception erro) {
                MessageBox.Show("Alguma coisa deu errada ao ler o grau do polinômio.\n Erro: " + erro.ToString(), "Interpolação Polinomial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GrauPolinomio.Focus();
                return;
            }

            if (k < 1 || k >= n) {
                MessageBox.Show("A ordem do polinômio deve ser entre 1 e n.", "Interpolação Polinomial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GrauPolinomio.Focus();
                return;
            }

            vetorX = new double[n];
            vetorFx = new double[n];
            vetorA = new double[n];
            Delta = new double[n];
            varGlobal.xTodos = new double[n];
            varGlobal.yTodos = new double[n];
            vetorXResultado = new double[n];

            for (i = 0; i < n; i++) {
                try {
                    vetorX[i] = double.Parse(dataGridViewPontos.Rows[i].Cells[1].Value.ToString().Replace('.',','));
                } catch (Exception) {
                    MessageBox.Show("Verifique o valor de x[" + i + "].", "Interpolação Polinomial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewPontos.Rows[i].Cells[1].Selected = true;
                    return;
                }
                try {
                    vetorFx[i] = double.Parse(dataGridViewPontos.Rows[i].Cells[2].Value.ToString().Replace('.',','));
                } catch (Exception) {
                    MessageBox.Show("Verifique o valor de f(x[" + i + "]).", "Interpolação Polinomial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewPontos.Rows[i].Cells[2].Selected = true;
                    return;
                }
            }


            if (k < n - 1) {
                try {
                    z = double.Parse(textBoxPontoReferencia.Text.Replace('.',','));
                }
                catch (Exception) {
                    MessageBox.Show("Verifique o valor de z.", "Interpolação Polinomial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPontoReferencia.Focus();
                    return;
                }
            }

            for (i = 0; i < n - 1; i++) {
                for (j = i + 1; j < n; j++)
                    if (vetorX[i] == vetorX[j]) {
                        MessageBox.Show("Os valores de x[" + i + "] e x[" + j + "] são iguais.\n" +
                                        "Remova ou altere os dados repetidos para valores de x.", "Interpolação Polinomial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
            }

            Array.Sort(vetorX, vetorFx);

            for(i = 0; i < n; i++) {
                varGlobal.xTodos[i] = vetorX[i];
                varGlobal.yTodos[i] = vetorFx[i];
            }

            if(k < n - 1) {
                if (z < vetorX[0] || z > vetorX[n - 1]) {
                    MessageBox.Show("z deve estar entre " + vetorX[0] + " e " + vetorX[n-1] + ".", "Interpolação Polinomial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPontoReferencia.Focus();
                    return;
                }

                PontosProximos(z, k, n, vetorX, vetorFx);
                Array.Sort(vetorX, vetorFx, 0, k+1);
            }

            metodo = MetodoSelecionado();

            switch (metodo) {
                case 0:
                    if (k < n - 1)
                        vetorA = InterpolacaoSistemaLinear(k+1, vetorX, vetorFx);
                    else
                        vetorA = InterpolacaoSistemaLinear(n, vetorX, vetorFx);
                    break;
                case 1:
                    if (k < n - 1)
                        vetorA = Newton(k+1, vetorX, vetorFx);
                    else
                        vetorA = Newton(n, vetorX, vetorFx);
                    break;
                case 2:

                    passo = vetorX[1] - vetorX[0];

                    for (i = 2; i < n; i++) {
                        if ((vetorX[i] - vetorX[i-1]-passo)/passo > 1E-7) {
                            MessageBox.Show("Com o vetor x já ordenado, os valores de x[" + (i-1) + "] e de x[" + i + "] não tem " +
                                        "o mesmo espaçamento existente entre x[0] e x[1].", "Interpolação Polinomial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    if (k < n - 1)
                        vetorA = NewtonGregory(k+1, passo, vetorX, vetorFx);
                    else
                        vetorA = NewtonGregory(n, passo, vetorX, vetorFx);
                    break;
            }

            Array.Copy(vetorA, Delta, vetorA.Length);

            textBoxPolinomio.Clear();

            if (metodo == 0) {
                textBoxPolinomio.Text = "p" + (n - 1) + "(x) = " + Delta[0] + "*x^0";
                for (i = 1; i < n; i++) {
                    if (Delta[i] < 0)
                        textBoxPolinomio.Text = textBoxPolinomio.Text + Delta[i] + "*x^" + i;
                    else
                        textBoxPolinomio.Text = textBoxPolinomio.Text + "+" + Delta[i] + "*x^" + i;
                }
                DesenhaGrafico(k, vetorX, vetorFx, Delta);
            }
            else {

                Array.Copy(vetorX, vetorXResultado, k+1);
                textBoxPolinomio.Text = "p" + (n - 1) + "(x) = " + Delta[0];
                for (i = 0; i < n - 1; i++) {
                    if (vetorXResultado[i] < 0)
                        textBoxPolinomio.Text += "+(x+" + (-vetorXResultado[i]) + ")*(" + Delta[i + 1];
                    else if (vetorXResultado[i] == 0)
                        textBoxPolinomio.Text += "+(x-" + (-vetorXResultado[i]) + ")*(" + Delta[i + 1];
                    else
                        textBoxPolinomio.Text += "+(x" + (-vetorXResultado[i]) + ")*(" + Delta[i + 1];
                }

                for (i = 0; i < n - 1; i++)
                    textBoxPolinomio.Text += ")";
                DesenhaGrafico2(k, vetorX, vetorFx, Delta);
            }
        }

        private void buttonAlteraGridView_Click(object sender, EventArgs e) {
            SalvaDados();
            AlteraDataGridView(int.Parse(NumeroPontos.Value.ToString()));
            RestauraDados();
        }

        private void buttonLimpar_Click(object sender, EventArgs e) {
            textBoxPolinomio.Clear();
            textBoxPontoReferencia.Clear();
            dataGridViewPontos.Rows.Clear();

            NumeroPontos.Value = 3;
            AlteraDataGridView(3);

            for (int i = 0; i < varGlobal.xTodos.Length; i++) {
                varGlobal.xTodos[i] = 0.0;
                varGlobal.yTodos[i] = 0.0;
            }

            DesenhaGrafico();
        }

        private void NumeroPontos_ValueChanged(object sender, EventArgs e) {
            GrauPolinomio.Value = NumeroPontos.Value - 1;
        }

        private void NumeroPontos_Leave(object sender, EventArgs e) {
            SalvaDados();
            AlteraDataGridView((int) NumeroPontos.Value);
            RestauraDados();
        }

    }
}
