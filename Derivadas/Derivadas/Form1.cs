using System;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Derivadas {
    public partial class Form1 : Form
{       
        public Form1(){
            InitializeComponent();
            ConfiguraDataGridView(); // configura pra sempre exibir 3 colunas
            ConfiguraJacobiano();
        }

        // FUNÇÕES E EVENTS PARA CONFIGURAÇÃO DO FORMULARIO

        public static class Globals {
            public static int ScrollBarHorizontalAltura = SystemInformation.HorizontalScrollBarHeight;
            public static int ScrollBarVerticalLargura = SystemInformation.VerticalScrollBarWidth;
        }

        private void ConfiguraDataGridView() {
            dataGridViewRnValoresXi.Rows.Add(1);
            dataGridViewGradiente.Rows.Add(1);
            dataGridViewHessiana.Rows.Add(3);            

            dataGridViewRnValoresXi.Rows[0].Cells[0].Value = "xi";
            dataGridViewGradiente.Rows[0].Cells[0].Value = "G[i]";

            for (int i = 1; i <= 3; i++)
                dataGridViewHessiana.Rows[i-1].Cells[0].Value = i.ToString();
        }

        private void ConfiguraDataGridView(int i) {
            int k;

            for (k = 0; k <= i; k++) {
                dataGridViewRnValoresXi.Columns[k].Visible = true;
                dataGridViewGradiente.Columns[k].Visible = true;
                dataGridViewHessiana.Columns[k].Visible = true;
            }
            for (k = i + 1; k <= 10; k++) {
                dataGridViewRnValoresXi.Columns[k].Visible = false;
                dataGridViewGradiente.Columns[k].Visible = false;
                dataGridViewHessiana.Columns[k].Visible = false;
            }

            dataGridViewHessiana.Rows.Clear();
            dataGridViewHessiana.Rows.Add(i);
            
            for (k = 1; k <= i; k++)
                dataGridViewHessiana.Rows[k - 1].Cells[0].Value = k.ToString();

            if (i >= 8) {
                dataGridViewRnValoresXi.Height = 47 + Globals.ScrollBarHorizontalAltura;
                dataGridViewGradiente.Height = 47 + Globals.ScrollBarHorizontalAltura;
                dataGridViewHessiana.Height = 24 + 7 * 22 + Globals.ScrollBarHorizontalAltura;
                dataGridViewRnValoresXi.Width = 38 + 7 * 60;
                dataGridViewGradiente.Width = 38 + 7 * 60;
                dataGridViewHessiana.Width = 38 + 7 * 60 + Globals.ScrollBarVerticalLargura;
            }
            else {
                dataGridViewRnValoresXi.Width = 38 + i * 60;
                dataGridViewGradiente.Width = 38 + i * 60;
                dataGridViewHessiana.Width = 38 + i * 60;
                dataGridViewRnValoresXi.Height = 47;
                dataGridViewGradiente.Height = 47;
                dataGridViewHessiana.Height = 24 + i * 22;
            }
        }

        private void dataGridViewRnValoresXi_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            if (dataGridViewRnValoresXi.IsCurrentCellDirty) {
                dataGridViewRnValoresXi.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridViewJacobianoValoresXi_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            if (dataGridViewJacobianoValoresXi.IsCurrentCellDirty) {
                dataGridViewJacobianoValoresXi.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridViewJacobianoFuncoes_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            if (dataGridViewJacobianoFuncoes.IsCurrentCellDirty) {
                dataGridViewJacobianoFuncoes.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void ConfiguraJacobiano() {
            dataGridViewJacobianoValoresXi.Rows.Clear();
            dataGridViewJacobiano.Rows.Clear();
            dataGridViewJacobianoFuncoes.Rows.Clear();
            dataGridViewJacobianoValoresXi.Rows.Add(1);
            dataGridViewJacobiano.Rows.Add(3);
            dataGridViewJacobianoFuncoes.Rows.Add(3);

            dataGridViewJacobianoValoresXi.Rows[0].Cells[0].Value = "xi";

            for (int k = 1; k <= 3; k++) {
                dataGridViewJacobianoFuncoes.Rows[k - 1].Cells[0].Value = k.ToString();
                dataGridViewJacobiano.Rows[k - 1].Cells[0].Value = k.ToString();
            }

        }

        private void ConfiguraJacobiano(int i, int j) {
            int k, m;
            for (m = 0; m <= j; m++) {
                    dataGridViewJacobianoValoresXi.Columns[m].Visible = true;
                    dataGridViewJacobiano.Columns[m].Visible = true;
            }
            for (m = j + 1; m <= 10; m++) {
                dataGridViewJacobianoValoresXi.Columns[m].Visible = false;
                dataGridViewJacobiano.Columns[m].Visible = false;
            }
            
            dataGridViewJacobiano.Rows.Clear();
            dataGridViewJacobianoFuncoes.Rows.Clear();
            dataGridViewJacobiano.Rows.Add(i);
            dataGridViewJacobianoFuncoes.Rows.Add(i);

            for (k = 1; k <= i; k++) {
                dataGridViewJacobianoFuncoes.Rows[k - 1].Cells[0].Value = k.ToString();
                dataGridViewJacobiano.Rows[k - 1].Cells[0].Value = k.ToString();
            }

            if (i == 2)
                dataGridViewJacobianoFuncoes.Height = 24 + 2 * 22;
            else
                dataGridViewJacobianoFuncoes.Height = 24 + 3 * 22;

            if (j >= 8) {
                if (i >= 8) {
                    dataGridViewJacobiano.Height = 24 + 7 * 22 + Globals.ScrollBarHorizontalAltura;
                    dataGridViewJacobiano.Width = 38 + 7 * 60 + Globals.ScrollBarVerticalLargura;
                } else {
                    dataGridViewJacobiano.Height = 24 + i * 22 + Globals.ScrollBarHorizontalAltura;
                    dataGridViewJacobiano.Width = 38 + 7 * 60;
                }
                dataGridViewJacobianoValoresXi.Height = 46 + Globals.ScrollBarHorizontalAltura;
                dataGridViewJacobianoValoresXi.Width = 38 + 7 * 60;
            }
            else {
                if (i >= 8) {
                    dataGridViewJacobiano.Height = 24 + 7 * 22;
                    dataGridViewJacobiano.Width = 38 + j * 60 + Globals.ScrollBarVerticalLargura;
                } else {
                    dataGridViewJacobiano.Height = 24 + i * 22;
                    dataGridViewJacobiano.Width = 38 + j * 60;
                }
                dataGridViewJacobianoValoresXi.Height = 45;
                dataGridViewJacobianoValoresXi.Width = 38 + j * 60;
            }
        }

        // FUNÇÕES PARA CALCULO DE DERIVADAS DE FUNÇÕES DE UMA VARIÁVEL

         double DerivadaPrimeira(Function f, double x, double epsilon){
            int i;
            double p, q, h;
            h = 1000 * epsilon;   
            p = (f.calculate(x + h) - f.calculate(x - h)) / (2 * h);
            for (i = 0; i < 10; i++){
                q = p;
                h = h/2;
                p = (f.calculate(x + h) - f.calculate(x - h)) / (2 * h);
                if (Math.Abs(p - q) < epsilon)
                    break;
            }

            return p;
        }

        double DerivadaSegunda(Function f, double x, double epsilon) {
            int i;
            double p, q, h;
            h = 1000 * epsilon;
            p = (f.calculate(x + 2*h) - 2 * f.calculate(x) + f.calculate(x - 2 * h)) / (4 * h * h);
            for (i = 0; i < 10; i++) {
                q = p;
                h = h / 2;
                p = (f.calculate(x + 2 * h) - 2 * f.calculate(x) + f.calculate(x - 2 * h)) / (4 * h * h);
                if (Math.Abs(p - q) < epsilon)
                    break;
            }

            return p;
        }

        double DerivadaTerceira(Function f, double x, double epsilon) {
            int i;
            double p, q, h;
            h = 1000 * epsilon;
            p = (f.calculate(x + 3 * h) - 3 * f.calculate(x + h) - 3 * f.calculate(x - h) - f.calculate(x - 3 * h)) / (8 * h * h * h);
            for (i = 0; i < 10; i++) {
                q = p;
                h = h / 2;
                p = (f.calculate(x + 3 * h) - 3 * f.calculate(x + h) + 3 * f.calculate(x - h) - f.calculate(x - 3 * h)) / (8 * h * h * h);
                if (Math.Abs(p - q) < epsilon)
                    break;
            }

            return p;
        }

        double DerivadaQuarta(Function f, double x, double epsilon) {
            int i;
            double p, q, h;
            h = 1000 * epsilon;
            p = (f.calculate(x + 4 * h) - 4 * f.calculate(x + 2 * h) + 6 * f.calculate(x) - 4 * f.calculate(x - 2 * h) + f.calculate(x - 4 * h)) / (16 * h * h * h * h);
            for (i = 0; i < 10; i++) {
                q = p;
                h = h / 2;
                p = (f.calculate(x + 4 * h) - 4 * f.calculate(x + 2 * h) + 6 * f.calculate(x) - 4 * f.calculate(x - 2 * h) + f.calculate(x - 4 * h)) / (16 * h * h * h * h);
                if (Math.Abs(p - q) < epsilon)
                    break;
            }

            return p;
        }

        // FUNÇÕES PARA CALCULO DE DERIVADAS DE FUNÇÕES DO Rn

        double[] CriaVetor(DataGridView data, int tam) {
            double[] vet = new double[10];
            string s = "";
            for (int i = 1; i <= tam; i++) {
                s = data.Rows[0].Cells[i].Value.ToString();
                s = s.Replace('.', ',');
                double.TryParse(s, out vet[i-1]);
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
            x[i] = xi - h;
            f2 = CalculaFuncaoRn(f, x, tam);
            p = (f1 - f2) / (2 * h);
            for (int k = 1; k <= 10; k++) {
                q = p;
                h = h / 2;
                x[i] = xi + h;
                f1 = CalculaFuncaoRn(f, x, tam);
                x[i] = xi - h;
                f2 = CalculaFuncaoRn(f, x, tam);
                p = (f1 - f2) / (2 * h);
                if (Math.Abs((p - q)) < epsilon)
                    break;
            }
            x[i] = xi;
            d = p;
        }

        void DerivadaParcialSegunda(Function f, double[] x, double epsilon, int i, int j, int tam, out double d) {
            double h, p, q, xi, xj, f1, f2, f3, f4;

            h = 1000 * epsilon;
            xi = x[i];
            xj = x[j];
            if (i != j) {
                x[i] = xi + h; x[j] = xj + h; f1 = CalculaFuncaoRn(f, x, tam);
                x[j] = xj - h;                f2 = CalculaFuncaoRn(f, x, tam);
                x[i] = xi - h;                f4 = CalculaFuncaoRn(f, x, tam);
                x[j] = xj + h;                f3 = CalculaFuncaoRn(f, x, tam);
                p = (f1 - f2 - f3 + f4) / (4 * h * h);
            }
            else {
                x[i] = xi + (2 * h); f1 = CalculaFuncaoRn(f, x, tam);
                x[i] = xi - (2 * h); f3 = CalculaFuncaoRn(f, x, tam);
                x[i] = xi;           f2 = CalculaFuncaoRn(f, x, tam);
                p = (f1 - (2 * f2) + f3) / (4 * h * h);
            }

            for (int k = 1; k <= 10; k++) {
                q = p;
                h = h / 2;
                if (i != j) {
                    x[i] = xi + h; x[j] = xj + h; f1 = CalculaFuncaoRn(f, x, tam);
                    x[j] = xj - h;                f2 = CalculaFuncaoRn(f, x, tam);
                    x[i] = xi - h;                f4 = CalculaFuncaoRn(f, x, tam);
                    x[j] = xj + h;                f3 = CalculaFuncaoRn(f, x, tam);
                    p = (f1 - f2 - f3 + f4) / (4 * h * h);
                }
                else {
                    x[i] = xi + 2 * h; f1 = CalculaFuncaoRn(f, x, tam);
                    x[i] = xi - 2 * h; f3 = CalculaFuncaoRn(f, x, tam);
                    x[i] = xi;         f2 = CalculaFuncaoRn(f, x, tam);
                    p = (f1 - (2 * f2) + f3) / (4 * h * h);
                }
                if (Math.Abs(p - q) < epsilon)
                    break;
            }
            x[i] = xi;
            x[j] = xj;
            d = p;
        }

        void Gradiente(Function f, double[] x, int tam, double epsilon) {
            double d;
            dataGridViewGradiente.Rows.Clear();
            dataGridViewGradiente.Rows.Add(1);
            dataGridViewGradiente.Rows[0].Cells[0].Value = "xi";
            for (int i = 0; i < tam; i++) {
                DerivadaParcial(f, x, epsilon, i, tam, out d);
                dataGridViewGradiente.Rows[0].Cells[i + 1].Value = Math.Round(d, 9);
            }
        }
        
        void Hessiana(Function f, double[] x, int tam, double epsilon) {
            int i, j;
            double d;
            dataGridViewHessiana.Rows.Clear();
            for (i = 0; i < tam; i++) {
                dataGridViewHessiana.Rows.Add(1);
                dataGridViewHessiana.Rows[i].Cells[0].Value = (i + 1).ToString();
                for (j = i; j < tam; j++) {
                    DerivadaParcialSegunda(f, x, epsilon, i, j, tam, out d);
                    dataGridViewHessiana.Rows[i].Cells[j + 1].Value = Math.Round(d, 9);
                }
            }

            for(i = 1; i < tam; i++)
                for(j = 0; j <= i-1; j++) {
                    dataGridViewHessiana.Rows[i].Cells[j + 1].Value = dataGridViewHessiana.Rows[j].Cells[i + 1].Value;
                }
        }

        void Jacobiano(Function f, double[] x, double epsilon, int linha, int tam) {
            double d;
            dataGridViewJacobiano.Rows.Add(1);
            dataGridViewJacobiano.Rows[linha - 1].Cells[0].Value = linha.ToString();
            for (int i = 0; i < tam; i++) {
                DerivadaParcial(f, x, epsilon, i, tam, out d);
                dataGridViewJacobiano.Rows[linha - 1].Cells[i + 1].Value = Math.Round(d, 9);
            }
        }

        //EVENTOS DO FORM1

        // EVENTOS DOS BOTOES DO GROUPBOX1

        private void ButtonR1Calcula_Click(object sender, EventArgs e) {
            string expressao;
            double epsilon;
            double x, d;
            Function f;

            try {
                epsilon = double.Parse(textBoxR1ValorE.Text.Replace('.', ','));
                if (epsilon > 0.001 || epsilon < 0.0000001) {
                    MessageBox.Show("Valor incorreto para Epsilon.\nValor deve estar entre 1E-3 e 1E-7", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxR1ValorE.Focus();
                    return;
                }
            }
            catch (Exception) {
                MessageBox.Show("Digite um valor válido para epsilon.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxR1ValorE.Focus();
                return;
            }

            try {
                x = double.Parse(textBoxR1ValorX.Text.Replace('.', ','));
            } catch(Exception) {
                MessageBox.Show("Digite um valor válido para x.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxR1ValorX.Focus();
                return;
            }

            expressao = textBoxR1Funcao.Text.Replace(',', '.');
            if (String.IsNullOrWhiteSpace(expressao)) {
                MessageBox.Show("Função não informada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxR1Funcao.Focus();
                return;
            }

            f = new Function("f", expressao, "x");

            try {
                d = DerivadaPrimeira(f, x, epsilon);
                textBoxR1DerivadaPrimeira.Text = d.ToString();

                d = DerivadaSegunda(f, x, epsilon);
                textBoxR1DerivadaSegunda.Text = d.ToString();

                d = DerivadaTerceira(f, x, epsilon);
                textBoxR1DerivadaTerceira.Text = d.ToString();

                d = DerivadaQuarta(f, x, epsilon);
                textBoxR1DerivadaQuarta.Text = d.ToString();
            }
            catch (Exception) {
                MessageBox.Show("Alguma coisa deu errado.\nVerifique se os dados foram inseridos corretamente.\n ", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonR1Limpa_Click(object sender, EventArgs e) {
            textBoxR1Funcao.Clear();
            textBoxR1ValorX.Clear();
            textBoxR1ValorE.Clear();
            textBoxR1DerivadaPrimeira.Clear();
            textBoxR1DerivadaSegunda.Clear();
            textBoxR1DerivadaTerceira.Clear();
            textBoxR1DerivadaQuarta.Clear();
            textBoxR1Funcao.Focus();
        }

        // EVENTOS DOS BOTOES DO GROUPBOX2

        private void ButtonAlteraMatriz_Click(object sender, EventArgs e) {
            try {
                int n = int.Parse(textBoxRnNumeroVariaveis.Text);
                if (n < 1) {
                    MessageBox.Show("Digite um valor válido para n.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxRnNumeroVariaveis.Focus();
                    return;
                }
                else if (n < 2) {
                    MessageBox.Show("Para funções de uma váriável, use a parte de cima.", "Aviso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxRnNumeroVariaveis.Focus();
                }
                else if (n > 10) {
                    MessageBox.Show("Número máximo de váriaveis é 10.", "Aviso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxRnNumeroVariaveis.Focus();
                }
                else {
                    ConfiguraDataGridView(int.Parse(textBoxRnNumeroVariaveis.Text));
                    textBoxRnFuncao.Focus();
                }
            }
            catch (Exception) {
                MessageBox.Show("Digite um valor válido (número inteiro) para n.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonRnCalcula_Click(object sender, EventArgs e) {
            int n;
            double epsilon;
            double[] x = new double[10];
            string expressao;
            Function f;

            try {
                n = int.Parse(textBoxRnNumeroVariaveis.Text);
                if (n < 1) {
                    MessageBox.Show("Digite um valor válido para n.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxRnNumeroVariaveis.Focus();
                    return;
                }
                else if (n < 2) {
                    MessageBox.Show("Para funções de uma váriável, use a parte de cima.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxRnNumeroVariaveis.Focus();
                    return;
                }
                else if (n > 10) {
                    MessageBox.Show("Número máximo de váriaveis é 10.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxRnNumeroVariaveis.Focus();
                    return;
                }
            }
            catch (Exception) {
                MessageBox.Show("Digite um valor válido (número inteiro) para n.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRnNumeroVariaveis.Focus();
                return;
            }

            try {
                epsilon = double.Parse(textBoxRnValorE.Text.Replace('.', ','));
                if (epsilon > 0.001 || epsilon < 0.0000001) {
                    MessageBox.Show("Valor incorreto para Epsilon.\nValor deve estar entre 1E-3 e 1E-7", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxRnValorE.Focus();
                    return;
                }
            }
            catch (Exception) {
                MessageBox.Show("Digite um valor válido para epsilon.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRnValorE.Focus();
                return;
            }

            expressao = textBoxRnFuncao.Text.Replace(',','.');
            if (String.IsNullOrWhiteSpace(expressao)) {
                MessageBox.Show("Função não informada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxRnFuncao.Focus();
                return;
            }

            for (int i = 1; i <= n; i++) {
                if (dataGridViewRnValoresXi.Rows[0].Cells[i].Value == null || String.IsNullOrEmpty(dataGridViewRnValoresXi.Rows[0].Cells[i].Value.ToString())) {
                    MessageBox.Show("Valor incorreto para x" + i.ToString(), "Erro", MessageBoxButtons.OK);
                    dataGridViewRnValoresXi.Rows[0].Cells[i].Selected = true;
                    return;
                }
            }

            try {
                x = CriaVetor(dataGridViewRnValoresXi, n);
                CriaFuncaoRn(out f, expressao, n);
                Gradiente(f, x, n, epsilon);
                Hessiana(f, x, n, epsilon);
            } catch (Exception) {
                MessageBox.Show("Alguma coisa deu errado.\nVerifique se os dados foram inseridos corretamente.\n ", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRnLimpa_Click(object sender, EventArgs e) {
            textBoxRnFuncao.Clear();
            textBoxRnNumeroVariaveis.Text = "3";
            textBoxRnValorE.Clear();
            ConfiguraDataGridView(3);
            textBoxRnFuncao.Focus();
        }

        private void ButtonJacobianoAlteraMatriz_Click(object sender, EventArgs e) {
            int m, n;
            try {
                m = int.Parse(textBoxJacobianoValorM.Text);
                if (m < 2 || m > 10) {
                    MessageBox.Show("Valor de m incorreto: número deve estar entre 2 e 10.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }   
            }
            catch (Exception) {
                MessageBox.Show("Digite um valor válido (número inteiro) para m.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try {
                n = int.Parse(textBoxJacobianoValorN.Text);
                if (n < 2 || n > 10) {
                    MessageBox.Show("Valor de n incorreto: número deve estar entre 2 e 10.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            } catch(Exception) {
                MessageBox.Show("Digite um valor válido (número inteiro) para n.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ConfiguraJacobiano(m, n);
        }

        private void ButtonJacobianoCalcula_Click(object sender, EventArgs e) {
            int m, n;
            double epsilon;
            double[] x = new double[20];
            Function f;

            try {
                m = int.Parse(textBoxJacobianoValorM.Text);
                if (m < 2 || m > 10) {
                    MessageBox.Show("Valor de m incorreto: número deve estar entre 2 e 10.", "Aviso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxJacobianoValorM.Focus();
                    return;
                }
            }
            catch (Exception) {
                MessageBox.Show("Digite um valor válido (número inteiro) para m.", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxJacobianoValorM.Focus();
                return;
            }
            try {
                n = int.Parse(textBoxJacobianoValorN.Text);
                if (n < 2 || n > 10) {
                    MessageBox.Show("Valor de n incorreto: número deve estar entre 2 e 10.", "Aviso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxJacobianoValorN.Focus();
                    return;
                }
            }
            catch (Exception) {
                MessageBox.Show("Digite um valor válido (número inteiro) para n.", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxJacobianoValorN.Focus();
                return;
            }

            try {
                epsilon = double.Parse(textBoxJacobianoValorE.Text.Replace('.', ','));
                if (epsilon > 0.001 || epsilon < 0.0000001) {
                    MessageBox.Show("Valor incorreto para Epsilon.\nValor deve estar entre 1E-3 e 1E-7", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxJacobianoValorE.Focus();
                    return;
                }
            } catch(Exception) {
                MessageBox.Show("Digite um valor válido epsilon.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxJacobianoValorE.Focus();
                return;
            }

            try {
                x = CriaVetor(dataGridViewJacobianoValoresXi, n);
            } catch (Exception) {
                MessageBox.Show("Alguma coisa deu errado.\n Verifique se os dados 'xi' foram inseridos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridViewJacobianoValoresXi.Focus();
                return;
            }
            dataGridViewJacobiano.Rows.Clear();
            for (int i = 1; i <= n; i++) {
                try {
                    CriaFuncaoRn(out f, dataGridViewJacobianoFuncoes.Rows[i - 1].Cells[1].Value.ToString().Replace(',', '.'), n);
                } catch(Exception) {
                    MessageBox.Show("Alguma coisa deu errado.\n Verifique se as foram inseridas corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridViewJacobianoFuncoes.Rows[i - 1].Cells[1].Selected = true;
                    return;
                }
                Jacobiano(f, x, epsilon, i, n);
            }
        }

        private void ButtonJacobianoLimpa_Click(object sender, EventArgs e) {
            ConfiguraJacobiano();
        }
    }
}
