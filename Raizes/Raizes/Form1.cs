using System;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Raizes {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            inicializaDataGridView();

            //Add plot control to form
            //Controls.Add(myPlot);
            //calcular.Location = new Point(Width - 100, Height - 250);
        }

        public static class Globals {
            public static bool Interromper = false;
        }

        void inicializaDataGridView() {
            dataGridViewBuscaIntervalos.Columns.Clear();
            dataGridViewBuscaIntervalos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});

            dataGridViewBuscaIntervalos.Rows.Add(2);
            dataGridViewBuscaIntervalos.Rows[0].Cells[0].Value = "a[i]";
            dataGridViewBuscaIntervalos.Rows[1].Cells[0].Value = "b[i]";

            for (int i = 1; i < dataGridViewBuscaIntervalos.ColumnCount; i++) {
                dataGridViewBuscaIntervalos.Columns[i].HeaderText = "";
            }
        }

        void AlteraGridView() {
            int i = dataGridViewBuscaIntervalos.ColumnCount;
            dataGridViewBuscaIntervalos.Columns.Add("Column" + i, i.ToString());
            dataGridViewBuscaIntervalos.Columns[i].MinimumWidth = 60;
            dataGridViewBuscaIntervalos.Columns[i].Width = 70;
            dataGridViewBuscaIntervalos.Columns[i].Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewBuscaIntervalos.Columns[i].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        }

        void BuscaUniformeIntervalos(Function f, double a, double b, double Delta) {
            double p, q, fp, fq;

            int i = 0, j = 1;

            p = a;
            fp = f.calculate(p);
            q = p + Delta;
            fq = f.calculate(q);

            while(p <= b + Delta) {
                Application.DoEvents();
                if (Globals.Interromper == true) {
                    MessageBox.Show("Usuário cancelou.", "Raízes de funções com uma variável real");
                    return;
                }

                if (fp * fq <= 0) {
                    i++;

                    if (dataGridViewBuscaIntervalos.ColumnCount < i+1) {
                        AlteraGridView();
                    }
                    else {
                        dataGridViewBuscaIntervalos.Columns[i].HeaderText = i.ToString();
                    }
                    dataGridViewBuscaIntervalos.Rows[0].Cells[i].Value = Math.Round(p, 9);
                    dataGridViewBuscaIntervalos.Rows[1].Cells[i].Value = Math.Round(q, 9);
                    dataGridViewBuscaIntervalos.Update();
                }

                if (fq == 0) {
                    j++;
                    q = a + j * Delta;
                    fq = f.calculate(q);
                }
                p = q;
                fp = fq;
                j++;
                q = a + j * Delta;
                try {
                    fq = f.calculate(q);
                } catch(Exception e) {
                    MessageBox.Show("Erro: " + e.ToString(), "Raízes de funções com uma variável real");
                }
            }

            if (i == 0) {
                MessageBox.Show("Não foram encontradas regiões com indício de conter raízes no intervalo [a,b].", "Raízes de funções com uma variável real");
            }
        }

        void MetodoBuscaUniforme(Function f, double a, double b, double Epsilon, out double raiz) {
            double p, q, fp, fq;
            int i = 0;

            p = a;
            fp = f.calculate(p);
            q = p + Epsilon;
            fq = f.calculate(q);

            while (p <= b && fp * fq > 0) {
                Application.DoEvents();
                if (Globals.Interromper == true) {
                    MessageBox.Show("Usuário cancelou.", "Raízes de funções com uma variável real");
                    raiz = 0;
                    return;
                }

                i++;
                label12.Text = i.ToString();
                label12.Update();
                System.Threading.Thread.Sleep(10);

                p = q;
                fp = fq;
                q = a + i * Epsilon;
                fq = f.calculate(q);
            }

            raiz = (p + q) / 2;
        }
        
        void MetodoBissecao(Function f, double a, double b, double Epsilon, out double raiz) {
            double p, q, fp, fa;
            int i = 0;

            fa = f.calculate(a);
            p = (a + b) / 2;
            fp = f.calculate(p);
            while (Math.Abs(b-a) > Epsilon) {
                Application.DoEvents();
                if (Globals.Interromper == true) {
                    MessageBox.Show("Usuário cancelou.", "Raízes de funções com uma variável real");
                    raiz = 0;
                    return;
                }

                if (fa * fp < 0) {
                    b = p;
                }
                else {
                    a = p;
                    fa = fp;
                }

                p = (a + b) / 2;
                fp = f.calculate(p);

                i++;
                label12.Text = i.ToString();
                label12.Update();
                System.Threading.Thread.Sleep(10);

                if (Math.Abs(fp) < Epsilon)
                    break;
            }

            raiz = p;
        }

        void MetodoCordas(Function f, double a, double b, double Epsilon, out double raiz) {
            double p, fp, fa, fb;
            int i = 0;

            fa = f.calculate(a);
            fb = f.calculate(b);

            p = (a * fb - b * fa) / (fb - fa);
            fp = f.calculate(p);

            while (Math.Abs(b - a) > Epsilon) {
                Application.DoEvents();
                if (Globals.Interromper == true) {
                    MessageBox.Show("Usuário cancelou.", "Raízes de funções com uma variável real");
                    raiz = 0;
                    return;
                }

                label12.Text = (++i).ToString();
                label12.Update();
                System.Threading.Thread.Sleep(10);

                if(Math.Abs(fp) < Epsilon)
                    break;

                if (fa * fp < 0) {
                    b = p;
                    fb = fp;
                }
                else {
                    a = p;
                    fa = fp;
                }

                p = (a * fb - b * fa) / (fb - fa);
                fp = f.calculate(p);
            }

            raiz = p;
        }

        void MetodoCordasModificado(Function f, double a, double b, double Epsilon, out double raiz) {
            double p, fp, fa, fb;
            int i = 0, conta = 0, contb = 0;

            fa = f.calculate(a);
            fb = f.calculate(b);

            p = (a * fb - b * fa) / (fb - fa);
            fp = f.calculate(p);

            while (Math.Abs(b - a) > Epsilon) {
                Application.DoEvents();
                if (Globals.Interromper == true) {
                    MessageBox.Show("Usuário cancelou.", "Raízes de funções com uma variável real");
                    raiz = 0;
                    return;
                }

                label12.Text = (++i).ToString();
                label12.Update();
                System.Threading.Thread.Sleep(10);

                if (Math.Abs(fp) < Epsilon)
                    break;

                if (fa * fp < 0) {
                    conta = 0; contb++;
                    b = p;
                    fb = fp;
                }
                else {
                    contb = 0; conta++;
                    a = p;
                    fa = fp;
                }

                if (conta > 3) {
                    conta = 0;
                    contb = 0;
                    p = (a * (fb / 2) - b * fa) / ((fb / 2) - fa);
                }
                else if (contb > 3) {
                    conta = 0;
                    contb = 0;
                    p = (a * fb - b * (fa / 2)) / (fb - (fa / 2));
                }
                else
                    p = (a * fb - b * fa) / (fb - fa);
                fp = f.calculate(p);
            }

            raiz = p;
        }

        double DerivadaPrimeira(Function f, double x, double Epsilon) {
            int i;
            double p, q, h;
            h = 1000 * Epsilon;
            p = (f.calculate(x + h) - f.calculate(x - h)) / (2 * h);
            for (i = 0; i < 10; i++) {
                q = p;
                h = h / 2;
                p = (f.calculate(x + h) - f.calculate(x - h)) / (2 * h);
                if (Math.Abs(p - q) < Epsilon)
                    break;
            }

            return p;
        }

        void MetodoNewton(Function f, double a, double Epsilon, out double raiz) {
            double p, q, fp, fpDerivadaPrimeira;
            int i = 0, maxIteracoes = 1000;

            p = a;

            do {
                Application.DoEvents();
                if (Globals.Interromper == true) {
                    MessageBox.Show("Usuário cancelou.", "Raízes de funções com uma variável real");
                    raiz = 0;
                    return;
                }

                i++;
                label12.Text = i.ToString();
                label12.Update();
                System.Threading.Thread.Sleep(10);

                q = p;
                fp = f.calculate(p);
                fpDerivadaPrimeira = DerivadaPrimeira(f, p, Epsilon);
                p = p - (fp / fpDerivadaPrimeira);
            } while (Math.Abs(p - q) > Epsilon && i < maxIteracoes);
            
            raiz = p;
        }

        void MetodoNewtonModificado(Function f, double a, double Epsilon, out double raiz) {
            double p, q, fp, fpDerivadaPrimeira;
            int i = 0, maxIteracoes = 1000;

            p = a;
            fpDerivadaPrimeira = DerivadaPrimeira(f, p, Epsilon);
            do {
                Application.DoEvents();
                if (Globals.Interromper == true) {
                    MessageBox.Show("Usuário cancelou.", "Raízes de funções com uma variável real");
                    raiz = 0;
                    return;
                }

                i++;
                label12.Text = i.ToString();
                label12.Update();
                System.Threading.Thread.Sleep(10);

                q = p;
                fp = f.calculate(p);
                if (i % 5 == 0)
                    fpDerivadaPrimeira = DerivadaPrimeira(f, p, Epsilon);
                p = p - (fp / fpDerivadaPrimeira);
            } while (Math.Abs(p - q) > Epsilon && i < maxIteracoes);

            raiz = p;
        }

        int MetodoSelecionado() {
            if (radioButtonMetodoBuscaUniforme.Checked)
                return 0;
            else if (radioButtonMetodoBissecao.Checked)
                return 1;
            else if (radioButtonMetodoCordas.Checked)
                return 2;
            else if (radioButtonMetodoCordasModificado.Checked)
                return 3;
            else if (radioButtonMetodoNewton.Checked)
                return 4;
            else
                return 5;
        }

        private void buttonBuscaCalcular_Click(object sender, EventArgs e) {
            Function f;
            string expressao;
            double a, b, Delta;

            dataGridViewBuscaIntervalos.Rows.Clear();
            inicializaDataGridView();

            expressao = textBoxBuscaFuncao.Text.Replace(',', '.');
            if (String.IsNullOrWhiteSpace(expressao)) {
                MessageBox.Show("Erro: Função não informada.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxBuscaFuncao.Focus();
                return;
            }

            f = new Function("f", expressao, "x");

            try {
                a = double.Parse(textBoxBuscaValorA.Text.Replace('.', ','));
            }
            catch (FormatException) {
                MessageBox.Show("Erro: Digite um valor válido para a.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBuscaValorA.Focus();
                return;
            } catch (Exception erro) {
                MessageBox.Show("Erro: " + erro.ToString(), "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try {
                b = double.Parse(textBoxBuscaValorB.Text.Replace('.', ','));
            }
            catch (FormatException) {
                MessageBox.Show("Erro: Digite um valor válido para b.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBuscaValorB.Focus();
                return;
            }
            catch (Exception erro) {
                MessageBox.Show("Erro: " + erro.ToString(), "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (a >= b) {
                MessageBox.Show("Aviso: Valor de b deve ser maior que a.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscaValorB.Focus();
                return;
            }

            try {
                Delta = double.Parse(textBoxBuscaValorDelta.Text.Replace('.', ','));
            }
            catch (FormatException) {
                MessageBox.Show("Erro: Digite um valor válido para Delta.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBuscaValorDelta.Focus();
                return;
            }
            catch (Exception erro) {
                MessageBox.Show("Erro: " + erro.ToString(), "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Delta < (b - a) / 1000 || Delta > (b - a) / 20) {
                MessageBox.Show("Aviso: O menor valor admissível para Delta é (b-a)/1000 (1000 avaliações da função).\n\n" +
                                "O maior valor admissível para Delta é (b-a)/20 (20 avaliações da função).",
                                "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscaValorDelta.Focus();
                return;
            }

            if (double.IsNaN(f.calculate(a))) {
                MessageBox.Show("Alguma coisa deu errada.\n\n Verifique declaração da função", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                buttonBuscaCalcular.Enabled = false;
                buttonBuscaLimpar.Enabled = false;
                Globals.Interromper = false;

                BuscaUniformeIntervalos(f, a, b, Delta);
            }
            catch (Exception erro) {
                MessageBox.Show("Alguma coisa deu errada.\n\nErro: " + erro.ToString(), "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonBuscaCalcular.Enabled = true;
                buttonBuscaLimpar.Enabled = true;
                Globals.Interromper = false;

                return;
            }

            buttonBuscaCalcular.Enabled = true;
            buttonBuscaLimpar.Enabled = true;
            Globals.Interromper = false;
        }

        private void buttonBuscaGrafico_Click(object sender, EventArgs e) {
            Function f;
            string expressao;
            double a, b;

            expressao = textBoxBuscaFuncao.Text.Replace(',', '.');
            if (String.IsNullOrWhiteSpace(expressao)) {
                MessageBox.Show("Erro: Função não informada.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxBuscaFuncao.Focus();
                return;
            }

            f = new Function("f", expressao, "x");

            try {
                a = double.Parse(textBoxBuscaValorA.Text.Replace('.', ','));
            }
            catch (FormatException) {
                MessageBox.Show("Erro: Digite um valor válido para a.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBuscaValorA.Focus();
                return;
            }
            catch (Exception erro) {
                MessageBox.Show("Erro: " + erro.ToString(), "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try {
                b = double.Parse(textBoxBuscaValorB.Text.Replace('.', ','));
            }
            catch (FormatException) {
                MessageBox.Show("Erro: Digite um valor válido para b.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBuscaValorB.Focus();
                return;
            }
            catch (Exception erro) {
                MessageBox.Show("Erro: " + erro.ToString(), "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (a >= b) {
                MessageBox.Show("Aviso: Valor de b deve ser maior que a.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscaValorB.Focus();
                return;
            }

            if (double.IsNaN(f.calculate(a))) {
                MessageBox.Show("Alguma coisa deu errada.\n\n Verifique declaração da função", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                new Form2(f, a, b).Show();
            }
        }

        private void buttonBuscaLimpar_Click(object sender, EventArgs e) {
            textBoxBuscaFuncao.Clear();
            textBoxBuscaValorA.Clear();
            textBoxBuscaValorB.Clear();
            textBoxBuscaValorDelta.Clear();

            dataGridViewBuscaIntervalos.Rows.Clear();
            inicializaDataGridView();
        }

        private void buttonBuscaInterromper_Click(object sender, EventArgs e) {
            Globals.Interromper = true;
        }

        private void dataGridViewBuscaIntervalos_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex > 0) {
                try {
                    textBoxPrecisaoValorA.Text = dataGridViewBuscaIntervalos.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                    textBoxPrecisaoValorB.Text = dataGridViewBuscaIntervalos.Rows[1].Cells[e.ColumnIndex].Value.ToString();
                } catch(NullReferenceException) {
                    textBoxPrecisaoValorA.Text = "";
                    textBoxPrecisaoValorB.Text = "";
                }
            }
        }

        private void buttonPrecisaoCopiar_Click(object sender, EventArgs e) {
            textBoxPrecisaoFuncao.Text = textBoxBuscaFuncao.Text;
        }

        private void buttonPrecisaoCalcular_Click(object sender, EventArgs e) {
            Function f;
            string expressao;
            double a, b, Epsilon, raiz;

            label12.Text = "0";
            textBoxPrecisaoValorX.Clear();
            textBoxPrecisaoValorFuncao.Clear();

            expressao = textBoxPrecisaoFuncao.Text.Replace(',', '.');

            if (String.IsNullOrWhiteSpace(expressao)) {
                MessageBox.Show("Erro: Função não informada.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPrecisaoFuncao.Focus();
                return;
            }

            f = new Function("f", expressao, "x");

            try {
                a = double.Parse(textBoxPrecisaoValorA.Text.Replace('.', ','));
            }
            catch (FormatException) {
                MessageBox.Show("Erro: Digite um valor válido para a.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPrecisaoValorA.Focus();
                return;
            }
            catch (Exception erro) {
                MessageBox.Show("Erro: " + erro.ToString(), "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try {
                b = double.Parse(textBoxPrecisaoValorB.Text.Replace('.', ','));
            }
            catch (FormatException) {
                MessageBox.Show("Erro: Digite um valor válido para b.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPrecisaoValorB.Focus();
                return;
            }
            catch (Exception erro) {
                MessageBox.Show("Erro: " + erro.ToString(), "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (a >= b) {
                MessageBox.Show("Erro: Valor de b deve ser maior que a.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPrecisaoValorB.Focus();
                return;
            }

            try {
                Epsilon = double.Parse(textBoxPrecisaoValorEpsilon.Text.Replace('.', ','));
            }
            catch (FormatException) {
                MessageBox.Show("Erro: Digite um valor válido para Epsilon.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPrecisaoValorEpsilon.Focus();
                return;
            }
            catch (Exception erro) {
                MessageBox.Show("Erro: " + erro.ToString(), "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Epsilon - (b - a) / 20 > 1E-10) {
                MessageBox.Show("Aviso: O maior valor admissível para Epsilon é (b-a)/20.",
                                "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBuscaValorDelta.Focus();
                return;
            }
            try {
                buttonPrecisaoCalcular.Enabled = false;
                buttonPrecisaoLimpar.Enabled = false;
                Globals.Interromper = false;
                switch (MetodoSelecionado()) {
                    case 0:
                        MetodoBuscaUniforme(f, a, b, Epsilon, out raiz);
                        break;
                    case 1:
                        MetodoBissecao(f, a, b, Epsilon, out raiz);
                        break;
                    case 2:
                        MetodoCordas(f, a, b, Epsilon, out raiz);
                        break;
                    case 3:
                        MetodoCordasModificado(f, a, b, Epsilon, out raiz);
                        break;
                    case 4:
                        MetodoNewton(f, a, Epsilon, out raiz);
                        break;
                    default: // case: 5
                        MetodoNewtonModificado(f, a, Epsilon, out raiz);
                        break;
                }

                if (Globals.Interromper == false) {
                    textBoxPrecisaoValorX.Text = Math.Round(raiz, 15).ToString();
                    double valorfuncao = f.calculate(raiz);
                    textBoxPrecisaoValorFuncao.Text = Math.Round(valorfuncao, 15).ToString();

                    if (double.IsNaN(valorfuncao) || double.IsNaN(raiz)) {
                        MessageBox.Show("Alguma coisa deu errada.\n\n Verifique declaração da função", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (checkBoxPrecisaoGrafico.Checked) {
                        new Form2(f, a, b, Epsilon, raiz, valorfuncao).Show();
                    }
                }
                else
                    Globals.Interromper = false;

                buttonPrecisaoCalcular.Enabled = true;
                buttonPrecisaoLimpar.Enabled = true;

            } catch(Exception erro) {
                MessageBox.Show("Alguma coisa deu errada.\n\nErro: " + erro.ToString(), "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);

                buttonPrecisaoCalcular.Enabled = true;
                buttonPrecisaoLimpar.Enabled = true;
                Globals.Interromper = false;

                return;
            }
        }

        private void buttonPrecisaoGrafico_Click(object sender, EventArgs e) {
            Function f;
            string expressao;
            double a, b;

            expressao = textBoxPrecisaoFuncao.Text.Replace(',', '.');
            if (String.IsNullOrWhiteSpace(expressao)) {
                MessageBox.Show("Aviso: Função não informada.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPrecisaoFuncao.Focus();
                return;
            }

            f = new Function("f", expressao, "x");

            try {
                a = double.Parse(textBoxPrecisaoValorA.Text.Replace('.', ','));
            }
            catch (FormatException) {
                MessageBox.Show("Erro: Digite um valor válido para a.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPrecisaoValorA.Focus();
                return;
            }
            catch (Exception erro) {
                MessageBox.Show("Erro: " + erro.ToString(), "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try {
                b = double.Parse(textBoxPrecisaoValorB.Text.Replace('.', ','));
            }
            catch (FormatException) {
                MessageBox.Show("Erro: Digite um valor válido para b.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPrecisaoValorB.Focus();
                return;
            }
            catch (Exception erro) {
                MessageBox.Show("Erro: " + erro.ToString(), "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (a >= b) {
                MessageBox.Show("Erro: Valor de b deve ser maior que a.", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPrecisaoValorB.Focus();
                return;
            }

            if (double.IsNaN(f.calculate(a))) {
                MessageBox.Show("Alguma coisa deu errada.\n\n Verifique declaração da função", "Raízes de funções com uma variável real", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                new Form2(f, a, b).Show();
            }
        }

        private void buttonPrecisaoLimpar_Click(object sender, EventArgs e) {
            textBoxPrecisaoFuncao.Clear();
            textBoxPrecisaoValorA.Clear();
            textBoxPrecisaoValorB.Clear();
            textBoxPrecisaoValorEpsilon.Clear();
            textBoxPrecisaoValorX.Clear();
            textBoxPrecisaoValorFuncao.Clear();
            label12.Text = "0";
        }

        private void buttonPrecisaoInterromper_Click(object sender, EventArgs e) {
            Globals.Interromper = true;
        }
    }
}