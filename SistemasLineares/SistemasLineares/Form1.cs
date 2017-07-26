using System;
using System.Windows.Forms;

namespace SistemasLineares {
    public partial class Form1 : Form {
        public String[,] MatrizA { get; private set; }
        public String[] VetorB { get; private set; }

        public Form1() {
            InitializeComponent();

            AlteraDatagGridView();
        }

        #region Funções que alteram a Grid do Formulário

        void SalvaElementos() {
            int n = int.Parse(numericUpDownVariaveis.Value.ToString());

            VetorB = new string[n];
            MatrizA = new string[n, n];
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Application.DoEvents();
                    try {
                        MatrizA[i, j] = (string) dataGridViewDados.Rows[i].Cells[j+1].Value;
                    }
                    catch (Exception) {
                        MatrizA[i, j] = "";
                    }
                }
                try {
                    VetorB[i] = (string) dataGridViewDados.Rows[i].Cells[21].Value;
                }
                catch (Exception) {
                    VetorB[i] = "";
                }
            }
        }

        void ReposicionaElementos() {
            int n = int.Parse(numericUpDownVariaveis.Value.ToString());

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++)
                    dataGridViewDados.Rows[i].Cells[j + 1].Value = MatrizA[i, j];
                dataGridViewDados.Rows[i].Cells[21].Value = VetorB[i];
            }
        }

        void AlteraDatagGridView() {
            int n = int.Parse(numericUpDownVariaveis.Value.ToString());
            dataGridViewDados.Rows.Clear();
            dataGridViewDados.Rows.Add(n);

            for (int i = 1; i <= n; i++) {
                dataGridViewDados.Columns[i].Visible = true;
                dataGridViewDados.Columns[i].HeaderText = i.ToString();
                dataGridViewDados.Rows[i - 1].Cells[0].Value = i.ToString();
            }

            for (int i = n+1; i <= 20; i++) {
                dataGridViewDados.Columns[i].Visible = false;
            }

            if (Globals.tipoMetodo) {// caso seja [true], cria mais uma row para o insercao do vetor x inicial
                dataGridViewDados.Rows.Add(1);
                dataGridViewDados.Rows[n].Cells[0].Value = "x Inicial";
                if (n <= 8) {
                    dataGridViewDados.Height = (n + 2) * 22 + 2;
                    dataGridViewDados.Width = (n + 2) * 60 + 3;
                }
                else {
                    dataGridViewDados.Height = (10) * 22 + 2 + Globals.ScrollBarHorizontalAltura;
                    dataGridViewDados.Width = (10) * 60 + 3 + Globals.ScrollBarVerticalLargura;
                }
            }
            else {
                if (n <= 8) {
                    dataGridViewDados.Height = (n + 1) * 22 + 2;
                    dataGridViewDados.Width = (n + 2) * 60 + 3;
                }
                else {
                    dataGridViewDados.Height = (10) * 22 + 2 + Globals.ScrollBarHorizontalAltura;
                    dataGridViewDados.Width = (10) * 60 + 3 + Globals.ScrollBarVerticalLargura;
                }
            }
        }

        void PreencheZerosDataGridView() {
            for (int i = 1; i < dataGridViewDados.ColumnCount; i++) {
                for (int j = 0; j < dataGridViewDados.RowCount; j++) {
                    if (dataGridViewDados.Rows[j].Cells[i].Value == null || dataGridViewDados.Rows[j].Cells[i].Value.ToString() == "")
                        dataGridViewDados.Rows[j].Cells[i].Value = "0";
                }
            }

            for (int i = 0; i < dataGridViewDados.RowCount; i++)
                if (dataGridViewDados.Rows[i].Cells[21].Value.ToString() == "" || dataGridViewDados.Rows[i].Cells[21].Value == null)
                    dataGridViewDados.Rows[i].Cells[21].Value = "0";
        }

    #endregion

    #region Seção com as funções para cada método disponível para o Cálculo de Sistema Lineares

        void GaussSimples(ref double[,] A, ref double[] b, out double[] x, int n) {
            int i, j, k;

            double m, soma;
            x = new double[n];

            for (j = 0; j < n - 1; j++) { // anda pela coluna da matriz A
                for (i = j + 1; i < n; i++) { // anda pela linha da matriz A    
                    try {
                        m = A[i, j] / A[j, j];
                    } catch (DivideByZeroException) {
                        throw new DivideByZeroException("A[" + (j+1) + "][" + (j+1) + "] é igual a zero ou foi zerado durante a execução do método." +
                                                                "\n\nTente por Gauss - Pivotamento Parcial ou Total");
                    }

                    if (double.IsNaN(m))
                        throw new DivideByZeroException("A[" + (j+1) + "][" + (j+1) + "] é igual a zero ou foi zerado durante a execução do método." +
                                                                "\n\nTente por Gauss - Pivotamento Parcial ou Total");

                    for (k = j; k < n; k++) // anda pela coluna da matriz A, alterando linha da matriz
                        A[i, k] = A[i, k] - m * A[j, k];
                    b[i] = b[i] - m * b[j];
                }
            }

            try {
                x[n - 1] = b[n - 1] / A[n - 1, n - 1];
            } catch (DivideByZeroException) {
                throw new DivideByZeroException("A[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução do método." +
                                        "\n\nTente por Gauss - Pivotamento Parcial ou Total");
            }

            if (double.IsNaN(x[n-1]))
                throw new DivideByZeroException("A[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução do método." +
                                        "\n\nTente por Gauss - Pivotamento Parcial ou Total");

            for (i = n - 2; i >= 0; i--) {
                soma = 0;
                for (j = i + 1; j < n; j++)
                    soma += A[i, j] * x[j];
                try {
                    x[i] = (b[i] - soma) / A[i, i];
                } catch (DivideByZeroException) {
                    throw new DivideByZeroException("A[" + (i+1) + "][" + (i+1) + "] é igual a zero ou foi zerado durante a execução do método." +
                                    "\n\nTente por Gauss - Pivotamento Parcial ou Total");
                }

                if (double.IsNaN(x[i]))
                    throw new DivideByZeroException("A[" + (i+1) + "][" + (i+1) + "] é igual a zero ou foi zerado durante a execução do método." +
                                    "\n\nTente por Gauss - Pivotamento Parcial ou Total");
            }
        }

        void GaussPivotamentoParcial(ref double[,] A, ref double[] b, out double[] x, int n) {
            int i, j, k, p;

            double m, soma, maiorElem, aux;
            x = new double[n];

            for (j = 0; j < n - 1; j++) { // anda pela coluna da matriz A
                maiorElem = Math.Abs(A[j, j]);
                p = j;
                // determina maior elemento da coluna
                for (k = j + 1; k < n; k++) {
                    if (Math.Abs(A[k, j]) > maiorElem) {
                        maiorElem = Math.Abs(A[k, j]);
                        p = k; // salva indice da linha do maior elemento
                    }
                }

                // se indice da linha do maior elemento (p) for diferente de j, troca linha p com linha j
                if (p != j) {
                    for (k = j; k < n; k++) {
                        aux = A[j, k];
                        A[j, k] = A[p, k];
                        A[p, k] = aux;
                    }
                    // troca b da linha p com b da linha j
                    aux = b[j];
                    b[j] = b[p];
                    b[p] = aux;
                }

                for (i = j + 1; i < n; i++) { // anda pela linha da matriz A                        
                    try {
                        m = A[i, j] / A[j, j];
                    } catch (DivideByZeroException) {
                            throw new DivideByZeroException("A[" + (j+1) + "][" + (j+1) + "] é igual a zero ou foi zerado durante a execução do método.\n\n" +
                                                        "Não é possível resolver por esse método.");
                    }

                    if (double.IsNaN(m))
                        throw new DivideByZeroException("A[" + (j+1) + "][" + (j+1) + "] é igual a zero ou foi zerado durante a execução do método.\n\n" +
                                                        "Não é possível resolver por esse método.");

                    for (k = j; k < n; k++) // anda pela coluna da matriz A, alterando linha da matriz
                        A[i, k] = A[i, k] - m * A[j, k];
                    b[i] = b[i] - m * b[j];
                }
            }

            try {
                x[n - 1] = b[n - 1] / A[n - 1, n - 1];
            } catch (DivideByZeroException) {
                throw new DivideByZeroException("A[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução do método.\n\n" +
                            "Não é possível resolver por esse método.");
            }

            if (double.IsNaN(x[n-1]))
                throw new DivideByZeroException("A[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução do método.\n\n" +
                            "Não é possível resolver por esse método.");

            for (i = n - 2; i >= 0; i--) {
                soma = 0;
                for (j = i + 1; j < n; j++)
                    soma += A[i, j] * x[j];
                try {
                    x[i] = (b[i] - soma) / A[i, i];
                }
                catch (DivideByZeroException) {
                    throw new DivideByZeroException("A[" + (i+1) + "][" + (i+1) + "] é igual a zero ou foi zerado durante a execução do método.\n\n" +
                            "Não é possível resolver por esse método.");
                }

                if (double.IsNaN(x[i]))
                    throw new DivideByZeroException("A[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a execução do método.\n\n" +
                            "Não é possível resolver por esse método.");
            }
        }

        void GaussPivotamentoTotal(ref double[,] A, ref double[] b, out double[] x, out int[] posXs, int n) {
            int i, j, k, p, q;
            posXs = new int[n]; // vetor que armazena a posicao dos Xs

            double m, soma, maiorElem, aux;
            x = new double[n];

            // inicia vetor posXs com as posicao padrao dos Xs no sistema, 
            // partindo da suposicao de nao haver troca de colunas  
            for (i = 0; i < n; i++) {
                posXs[i] = i;
            }

            for (j = 0; j < n - 1; j++) { // anda pela coluna da matriz A
                maiorElem = Math.Abs(A[j, j]);
                p = j;
                q = j;
                // determina maior elemento da sub-matriz
                for (i = j; i < n; i++) { // anda pela coluna da sub-matriz
                    for (k = j; k < n; k++) { // anda pela linha da sub-matriz
                        if (Math.Abs(A[k, i]) > maiorElem) {
                            maiorElem = Math.Abs(A[k, i]);
                            p = k; // salva indice da linha do maior elemento
                            q = i; // salva indice da coluna do maior elemento
                        }
                    }
                }

                // se indice da linha do maior elemento (p) for diferente de j
                // e indice da coluna do maior elemento (q) for igual a j, troca linha p com linha j
                if (p != j && q == j) {
                    for (k = j; k < n; k++) {
                        aux = A[j, k];
                        A[j, k] = A[p, k];
                        A[p, k] = aux;
                    }
                    // troca b da linha p com b da linha j
                    aux = b[j];
                    b[j] = b[p];
                    b[p] = aux;
                }
                // se indice da linha do maior elemento (p) for igual a j
                // e indice da coluna do maior elemento (q) for diferente de j, troca coluna q com coluna j
                else if (p == j && q != j) {
                    for (k = 0; k < n; k++) {
                        aux = A[k, j];
                        A[k, j] = A[k, q];
                        A[k, q] = aux;
                    }
                    // troca posicao de Xj e Xq no vetor posXs
                    aux = posXs[j];
                    posXs[j] = posXs[q];
                    posXs[q] = ((int) aux);
                }
                // se indice da linha do maior elemento (p) for diferente de j
                // e indice da coluna do maior elemento (q) for diferente de j, 
                // troca linha p com linha j e coluna q com coluna j
                else if (p != j && q != j) {
                    for (k = j; k < n; k++) {
                        aux = A[j, k];
                        A[j, k] = A[p, k];
                        A[p, k] = aux;
                    }

                    for (k = 0; k < n; k++) {
                        aux = A[k, j];
                        A[k, j] = A[k, q];
                        A[k, q] = aux;
                    }
                    // troca b da linha p com b da linha j
                    aux = b[j];
                    b[j] = b[p];
                    b[p] = aux;

                    // troca posicao de Xj e Xq no vetor posXs
                    aux = posXs[j];
                    posXs[j] = posXs[q];
                    posXs[q] = ((int) aux);
                }

                for (i = j + 1; i < n; i++) { // anda pela linha da matriz A
                    try {
                        m = A[i, j] / A[j, j];
                    }
                    catch (DivideByZeroException) {
                        throw new DivideByZeroException("A[" + (j+1) + "][" + (j+1) + "] é igual a zero ou foi zerado durante a execução do método.\n\n" +
                                                    "Não é possível resolver por esse método.");
                    }

                    if(double.IsNaN(m))
                        throw new DivideByZeroException("A[" + (j+1) + "][" + (j+1) + "] é igual a zero ou foi zerado durante a execução do método.\n\n" +
                                                    "Não é possível resolver por esse método.");

                    for (k = j; k < n; k++) // anda pela coluna da matriz A, alterando linha da matriz
                        A[i, k] = A[i, k] - m * A[j, k];
                    b[i] = b[i] - m * b[j];
                }
            }

            try {
                x[posXs[n - 1]] = b[n - 1] / A[n - 1, n - 1];
            } catch (DivideByZeroException) {
                throw new DivideByZeroException("A[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução do método.\n\n" +
                            "Não é possível resolver por esse método.");
            }

            if(double.IsNaN(x[posXs[n-1]]))
                throw new DivideByZeroException("A[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução do método.\n\n" +
                            "Não é possível resolver por esse método.");

            for (i = n - 2; i >= 0; i--) {
                soma = 0;
                for (j = i + 1; j < n; j++)
                    soma += A[i, j] * x[posXs[j]];
                try {
                    x[posXs[i]] = (b[i] - soma) / A[i, i];
                } catch (DivideByZeroException) {
                    throw new DivideByZeroException("A[" + (i+1) + "][" + (i+1) + "] é igual a zero ou foi zerado durante a execução do método.\n\n" +
                        "Não é possível resolver por esse método.");
                }

                if(double.IsNaN(x[posXs[i]]))
                    throw new DivideByZeroException("A[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a execução do método.\n\n" +
                        "Não é possível resolver por esse método.");
            }
        }

        void DecomposicaoLU(double[,] A, ref double[] b, out double[] x, int n) {
            int i, j, k;

            double soma;
            double[] y;
            //double[,] L, U;

            x = new double[n];
            y = new double[n];

            for (i = 0; i < n; i++) {
                for (j = i; j < n; j++) {
                    soma = 0;
                    for (k = 0; k <= i - 1; k++) {
                        soma += A[i, k] * A[k, j];
                    }
                    A[i, j] = A[i, j] - soma;
                }
                for (j = i + 1; j < n; j++) {
                    soma = 0;
                    for (k = 0; k <= i - 1; k++)
                        soma += A[j, k] * A[k, i];
                    try {
                        A[j, i] = (A[j, i] - soma) / A[i, i];
                    } catch (DivideByZeroException) {
                        throw new DivideByZeroException("U[" + (i+1) + "][" + (i+1) + "] é igual a zero ou foi zerado durante a execução da solução do sistem U.x=y." +
                                    "\n\nNão é possível resolver por esse método.");
                    }

                    if(double.IsNaN(A[i, i]))
                        throw new DivideByZeroException("U[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a execução da solução do sistem U.x=y." +
                                    "\n\nNão é possível resolver por esse método.");
                }
            }

            y[0] = b[0]; // y[0] = b[0] / 1
            for (i = 1; i < n; i++) {
                soma = 0;
                for (j = 0; j <= i - 1; j++)
                    soma += A[i, j] * y[j];
                y[i] = (b[i] - soma); // (b[i] - soma) / 1;
            }

            try {
                x[n - 1] = y[n - 1] / A[n - 1, n - 1];
            } catch (DivideByZeroException) {
                throw new DivideByZeroException("U[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução da solução do sistem U.x=y." +
                                    "\n\nNão é possível resolver por esse método.");
            }

            if (double.IsNaN(x[n-1]))
                throw new DivideByZeroException("U[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução da solução do sistem U.x=y." +
                                    "\n\nNão é possível resolver por esse método.");

            for (i = n - 2; i >= 0; i--) {
                soma = 0;
                for (j = i + 1; j < n; j++)
                    soma += A[i, j] * x[j];
                try {
                    x[i] = (y[i] - soma) / A[i, i];
                } catch (DivideByZeroException) {
                    throw new DivideByZeroException("U[" + (i+1) + "][" + (i+1) + "] é igual a zero ou foi zerado durante a execução da solução do sistem U.x=y." +
                                    "\n\nNão é possível resolver por esse método.");
                }

                if (double.IsNaN(x[i]))
                    throw new DivideByZeroException("U[" + (i+1) + "][" + (i+1) + "] é igual a zero ou foi zerado durante a execução da solução do sistem U.x=y." +
                                    "\n\nNão é possível resolver por esse método.");
            }

            //for (k = 0; k < n; k++) 
            //    L[k, k] = 1;

            //for (i = 0; i < n; i++) {
            //    for (j = i; j < n; j++) {
            //        soma = 0;
            //        for (k = 0; k <= i-1; k++) {
            //            soma += L[i, k] * U[k, j];
            //        }
            //        U[i, j] = A[i,j] - soma;
            //    }
            //    for (j = i+1; j < n; j++) {
            //        soma = 0;
            //        for (k = 0; k <= i - 1; k++)
            //            soma += L[j, k] * U[k, i];
            //        L[j, i] = (A[j, i] - soma) / U[i, i];
            //    }
            //}

            //y[0] = b[0] / L[0, 0]; // y[0] = b[0]
            //for (i = 1; i < n; i++) {
            //    soma = 0;
            //    for (j = 0; j <= i - 1; j++)
            //        soma += L[i, j] * y[j];
            //    y[i] = (b[i] - soma) / L[i, i];
            //}

            //x[n-1] = y[n-1] / U[n-1, n-1];
            //for (i = n-2; i >= 0; i--) {
            //    soma = 0;
            //    for (j = i + 1; j < n; j++)
            //        soma += U[i, j] * x[j];
            //    x[i] = (y[i] - soma) / U[i, i];
            //}
        }

        void GaussCompacto(double[,] A, ref double[] b, out double[] x, int n) {
            int i, j, k;

            double soma, soma2;

            x = new double[n];

            for (i = 0; i < n; i++) {
                soma2 = 0;
                for (j = i; j < n; j++) {
                    soma = 0;
                    for (k = 0; k <= i - 1; k++) {
                        soma += A[i, k] * A[k, j];
                        soma2 += A[i, k] * b[k];
                    }
                    A[i, j] = A[i, j] - soma;
                }
                b[i] = b[i] - soma2;
                
                for (j = i + 1; j < n; j++) {
                    soma = 0;
                    for (k = 0; k <= i - 1; k++)
                        soma += A[j, k] * A[k, i];
                    try {
                        A[j, i] = (A[j, i] - soma) / A[i, i];
                    } catch (DivideByZeroException) {
                        throw new DivideByZeroException("U[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a execução da decomposição da matriz A." +
                                        "\n\nNão é possível resolver por esse método");
                    }

                    if (double.IsNaN(A[j, i]))
                        throw new DivideByZeroException("U[" + (i+1) + "][" + (i+1) + "] é igual a zero ou foi zerado durante a execução da decomposição da matriz A." +
                                        "\n\nNão é possível resolver por esse método");
                }
            }

            try {
                x[n - 1] = b[n - 1] / A[n - 1, n - 1];
            }
            catch (DivideByZeroException) {
                throw new DivideByZeroException("U[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução da decomposição da matriz A." +
                                        "\n\nNão é possível resolver por esse método");
            }

            if (double.IsNaN(x[n-1]))
                throw new DivideByZeroException("U[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução da decomposição da matriz A." +
                                        "\n\nNão é possível resolver por esse método");

            for (i = n - 2; i >= 0; i--) {
                soma = 0;
                for (j = i + 1; j < n; j++)
                    soma += A[i, j] * x[j];
                try {
                    x[i] = (b[i] - soma) / A[i, i];
                } catch (DivideByZeroException) {
                    throw new DivideByZeroException("U[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a resolução do sistema U.x=b(transformado)." +
                                    "\n\nNão é possível resolver por esse método");
                }

                if (double.IsNaN(x[i]))
                    throw new DivideByZeroException("U[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a resolução do sistema U.x=b(transformado)." +
                                    "\n\nNão é possível resolver por esse método");
            }
        }

        void Cholesky(double[,] A, ref double[] b, out double[] x, int n) {
            int i, j, k;

            double soma, aux;
            double[] y;
            //double[,] G;

            x = new double[n];
            y = new double[n];
            //G = new double[n, n];

            for (i = 0; i < n; i++) {
                for (j = i + 1; j < n; j++) {
                    if (A[i, j] != A[j, i])
                        throw new NaoAtendeCriterios("Matriz não é simétrica.");
                }
            }

            aux = 1;
            for (i = 0; i < n; i++)
                aux *= A[i, i];

            if (aux <= 0)
                throw new NaoAtendeCriterios("Matriz não é definida positiva.");

            for (k = 0; k < n; k++) {
                soma = 0;
                for (j = 0; j <= k - 1; j++) {
                    soma += Math.Pow(A[k, j], 2);
                }
                try {
                    A[k, k] = Math.Sqrt(A[k, k] - soma);
                } catch (ArithmeticException) {
                    throw new ErroAoCalcularRaiz("Não foi possível calcular o valor de G[" + (k+1) + "][" + (k+1) + "].");
                }

                if (double.IsNaN(A[k, k]) || double.IsInfinity(A[k, k]))
                    throw new ErroAoCalcularRaiz("Não foi possível calcular o valor de G[" + (k+1) + "][" + (k+1) + "].");

                for (i = k + 1; i < n; i++) {
                    soma = 0;
                    for (j = 0; j <= k - 1; j++) {
                        soma += A[i, j] * A[k, j];
                    }
                    try {
                        A[i, k] = (A[i, k] - soma) / A[k, k];
                    }
                    catch (DivideByZeroException) {
                        throw new DivideByZeroException("G[" + (i+1) + "][" + (i+1) + "] é igual a zero ou foi zerado durante a execução do método." +
                                        "\n\nNão é possível resolver por esse método.");
                    }

                    if (double.IsNaN(A[i, k]) || double.IsInfinity(A[i,k]))
                        throw new DivideByZeroException("G[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a execução do método." +
                                        "\n\nNão é possível resolver por esse método.");
                }
            }

            for (i = 1; i <= n - 1; i++) {
                for (j = i + 1; j < n; j++)
                    A[i, j] = A[j, i];
            }

            try {
                y[0] = b[0] / A[0, 0];
            } catch (DivideByZeroException) {
                throw new DivideByZeroException("G[1][1] é igual a zero ou foi zerado durante a execução do método.");
            }

            if(double.IsNaN(y[0]) || double.IsInfinity(y[0]))
                throw new DivideByZeroException("G[1][1] é igual a zero ou foi zerado durante a execução do método.");

            for (i = 1; i < n; i++) {
                soma = 0;
                for (j = 0; j <= i - 1; j++)
                    soma += A[i, j] * y[j];
                try {
                    y[i] = (b[i] - soma) / A[i, i];
                } catch (DivideByZeroException) {
                    throw new DivideByZeroException("G[" + (i+1) + "][" + (i+1) + "] é igual a zero ou foi zerado durante a execução do método.");
                }

                if (double.IsNaN(y[i]) || double.IsInfinity(y[i]))
                    throw new DivideByZeroException("G[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a execução do método.");
            }

            try {
                x[n - 1] = y[n - 1] / A[n - 1, n - 1];
            }
            catch (DivideByZeroException) {
                throw new DivideByZeroException("G[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução do método.");
            }

            if (double.IsNaN(x[n-1]) || double.IsInfinity(x[n-1]))
                throw new DivideByZeroException("G[" + n + "][" + n + "] é igual a zero ou foi zerado durante a execução do método.");

            for (i = n - 2; i >= 0; i--) {
                soma = 0;
                for (j = i + 1; j < n; j++)
                    soma += A[j, i] * x[j];
                try {
                    x[i] = (y[i] - soma) / A[i, i];
                } catch (DivideByZeroException) {
                    throw new DivideByZeroException("G[" + (i+1) + "][" + (i+1) + "] é igual a zero ou foi zerado durante a execução do método.");
                }

                if (double.IsNaN(x[i]) || double.IsInfinity(x[i]) )
                    throw new DivideByZeroException("G[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a execução do método.");
            }

            //for (i = 0; i < n; i++) {
            //    for (j = i + 1; j < n; j++) {
            //        if (A[i, j] != A[j, i])
            //            return;
            //    }
            //}

            //for (k = 0; k < n; k++) {
            //    soma = 0;
            //    for (j = 0; j <= k - 1; j++) {
            //        soma += Math.Pow(G[k, j], 2);
            //    }
            //    G[k, k] = Math.Sqrt(A[k, k] - soma);
            //    for (i = k+1; i < n; i++) {
            //        soma = 0;
            //        for (j = 0; j <= k-1; j++) {
            //            soma += G[i, j] * G[k, j];
            //        }

            //        G[i, k] = (A[i, k] - soma) / G[k, k];
            //    }
            //}

            //for (i = 1; i <= n - 1; i++) {
            //    for (j = i + 1; j < n; j++)
            //        G[i, j] = G[j, i];
            //}

            //y[0] = b[0] / G[0, 0];
            //for (i = 1; i < n; i++) {
            //    soma = 0;
            //    for (j = 0; j <= i - 1; j++)
            //        soma += G[i, j] * y[j];
            //    y[i] = (b[i] - soma) / G[i, i];
            //}

            //x[n-1] = y[n-1] / G[n-1, n-1];
            //for (i = n - 2; i >= 0; i--) {
            //    soma = 0;
            //    for (j = i + 1; j < n; j++)
            //        soma += G[j, i] * x[j];
            //    x[i] = (y[i] - soma) / G[i, i];
            //}
        }

        double Distancia(double[] x, double[] xIni, int n) {
            int i;
            double numerador, denominador;

            numerador = 0;
            denominador = 0;
            for (i = 0; i < n; i++) {
                numerador += Math.Pow((x[i]-xIni[i]), 2);
                denominador += Math.Pow(x[i], 2);
            }

            return Math.Sqrt(numerador/denominador);
        }

        void Jacobi(double[,] A, ref double[] b, out double[] x, ref double[] xIni, int n, int maxIteracao, double Epsilon) {
            int i, j, k;

            double maximo, soma, distancia = 0;

            bool CondLinhas, CondColunas; // variavel boolean para condicao das linhas e colunas

            x = new double[n];

            // verifica condicao das linhas
            maximo = 0;
            for (i = 0; i < n; i++) {
                soma = 0;
                for (j = 0; j < n; j++)
                    if (i != j)
                        soma += Math.Abs(A[i, j]);
                soma /= A[i, i];
                if (soma > maximo)
                    maximo = soma;
            }
            CondLinhas = (maximo < 1);

            // verifica condicao das colunas
            for (j = 0; j < n; j++) {
                soma = 0;
                for (i = 0; i < n; i++)
                    if (i != j)
                        soma += Math.Abs(A[i, j]);
                soma /= A[j, j];
                if (soma > maximo)
                    maximo = soma;
            }
            CondColunas = (maximo < 1);

            // se CondLinhas e CondColunas falsos, interrompe
            if (!CondLinhas && !CondColunas)
                throw new NaoAtendeCriterios("A matriz A não atende ao Critério das Linhas,\n" +
                                    "nem ao Critério das Colunas.");

            k = 0;
            while (k <= maxIteracao) {
                k++;

                for (i = 0; i < n; i++) {
                    soma = 0;
                    for (j = 0; j < n; j++)
                        if (i != j)
                            soma += A[i, j] * xIni[j];
                    try {
                        x[i] = (b[i] - soma) / A[i, i];
                    } catch (DivideByZeroException) {
                        throw new DivideByZeroException("A[" + (i+1) + "][" + (i+1) + "] é igual a zero ou foi zerado durante a execução do método.");
                    }

                    if (double.IsNaN(x[i]) || double.IsInfinity(x[i]) )
                        throw new DivideByZeroException("A[" + (i + 1) + "][" + (i + 1) + "] é igual a zero ou foi zerado durante a execução do método.");
                }

                try {
                    distancia = Distancia(x, xIni, n);
                } catch (ArithmeticException) {
                    throw new ErroAoCalcularRaiz("Não foi possível calcular o critério de parada ||xk+1 - xk|| / ||xk+1|| na iteração " + k + ".");
                }

                if (double.IsNaN(distancia) || double.IsInfinity(distancia))
                    throw new ErroAoCalcularRaiz("Não foi possível calcular o critério de parada ||xk+1 - xk|| / ||xk+1|| na iteração " + k + ".");

                if (distancia < Epsilon)
                    return;

                for (i = 0; i < n; i++)
                    xIni[i] = x[i];
            }

            throw new ExcedeuLimiteIteracoes("Excedeu o número de iterações sem convergir.\n||xk+1 - xk|| / ||xk+1|| = " + distancia); 
        }

        void GaussSeidel(double[,] A, ref double[] b, out double[] x, ref double[] xIni, int n, int maxIteracao, double Epsilon) {
            int i, j, k;

            double maximo, soma, distancia = 0;
            double[] Beta;

            bool CondLinhas, CondSassenfeld; // variavel boolean para condicao das linhas e Sassenfeld

            x = new double[n];
            Beta = new double[n];

            // verifica condicao das linhas
            maximo = 0;
            for (i = 0; i < n; i++) {
                soma = 0;
                for (j = 0; j < n; j++)
                    if (i != j)
                        soma += Math.Abs(A[i, j]);
                soma /= A[i, i];
                if (soma > maximo)
                    maximo = soma;
            }
            CondLinhas = (maximo < 1);

            // verifica condicao de Sassenfeld
            maximo = 0;
            for (i = 0; i < n; i++) {
                Beta[i] = 0;
                for (j = 0; j <= i - 1; j++) {
                    Beta[i] += A[i, j] / A[i, i] * Beta[j]; // soma da linha de j = 0 ate i-1
                }

                for (j = i+1; j < n; j++) {
                    Beta[i] += A[i, j] / A[i, i]; // soma da linha de j = i+1 ate n-1
                }

                if (Beta[i] > maximo)
                    maximo = Beta[i];
            }

            CondSassenfeld = (maximo < 1);

            // se CondLinha e CondSassenfeld falsos, interrompe
            if (!CondLinhas && !CondSassenfeld)
                throw new NaoAtendeCriterios("A matriz A não atende ao Critério das Linhas,\nnem ao Critério de Sassenfeld.");

            x = (double[]) xIni.Clone(); // clona vetor xIni e atribui vetor x;

            k = 0;
            while (k <= maxIteracao) {
                k++;

                for (i = 0; i < n; i++) {
                    soma = 0;
                    for (j = 0; j < n; j++)
                        if (i != j)
                            soma += A[i, j] * x[j];
                    try {
                        x[i] = (b[i] - soma) / A[i, i];
                    } catch (DivideByZeroException) {
                        throw new DivideByZeroException("A[" + i + 1 + "][" + i + 1 + "] é igual a zero ou foi zerado durante a execução do método.");
                    }

                    if(double.IsNaN(x[i]))
                        throw new DivideByZeroException("A[" + i + 1 + "][" + i + 1 + "] é igual a zero ou foi zerado durante a execução do método.");

                }

                try {
                    distancia = Distancia(x, xIni, n);
                } catch (ArithmeticException) {
                    throw new ErroAoCalcularRaiz("Não foi possível calcular o critério de parada ||xk+1 - xk|| / ||xk+1|| na iteração " + k + ".");
                }

                if (double.IsNaN(distancia) || double.IsInfinity(distancia))
                    throw new ErroAoCalcularRaiz("Não foi possível calcular o critério de parada ||xk+1 - xk|| / ||xk+1|| na iteração " + k + ".");

                if (distancia < Epsilon)
                    return;

                for (i = 0; i < n; i++)
                    xIni[i] = x[i];
            }

            throw new ExcedeuLimiteIteracoes("Excedeu o número de iterações sem convergir.\n" +
                                        "||xk+1 - xk|| = " + distancia);
        }

    #endregion

    #region Seção com as funções para Cálculo de Determinante e Matriz Inversa

        double Determinante(double[,] A, int n, int metodo) {
            int i;
            double det = 1;

            // se metodo igual a 6, então calcula determinante para Cholesky
            if (metodo == 6) {
                for (i = 0; i < n; i++)
                    det *= A[i, i];

                return Math.Pow(det, 2);
            }
            // para qualquer outro método
            else {
                for (i = 0; i < n; i++)
                    det *= A[i, i];

                return det;
            }
        }

        void MatrizInversa(double[,] matrizA, out double[,] Inversa, int n, int metodo) {
            int i, j;

            int[] posXs = new int[n];
            double[] vetorB = new double[n];
            double[] vetorX;
            double[,] copiaMatrizA;
            Inversa = new double[n, n];

            copiaMatrizA = (double[,]) matrizA.Clone();
            for (j = 0; j < n; j++) {
                for (i = 0; i < n; i++) {
                    vetorB[i] = 0;
                }
                vetorB[j] = 1;

                if (metodo == 0) {
                    GaussSimples(ref matrizA, ref vetorB, out vetorX, n);
                }
                else if (metodo == 1) {
                    GaussPivotamentoParcial(ref matrizA, ref vetorB, out vetorX, n);
                }
                else if (metodo == 2)
                    GaussPivotamentoTotal(ref matrizA, ref vetorB, out vetorX, out posXs, n);
                else if (metodo == 3)
                    GaussCompacto(matrizA, ref vetorB, out vetorX, n);
                else if (metodo == 4)
                    DecomposicaoLU(matrizA, ref vetorB, out vetorX, n);
                else
                    Cholesky(matrizA, ref vetorB, out vetorX, n);

                matrizA = (double[,]) copiaMatrizA.Clone();

                for (i = 0; i < n; i++)
                    Inversa[i, j] = vetorX[i];
            }
        }

    #endregion

    #region Eventos dos botões

        int MetodoSelecionado() {
            switch (Globals.radioButtonChecked) {
                case "GaussSimples": return 0;
                case "GaussPivotParcial": return 1;
                case "GaussPivotTotal": return 2;
                case "GaussCompacto": return 3;
                case "DecompLU": return 4;
                case "Cholesky": return 5;
                case "Jacobi": return 6;
                default: return 7; // case "GaussSeidel"
            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e) {
            int i, j, metodo, numIteracao, numVariaveis;
            int[] posXs;
            double tolerancia, determinante = 0;
            double[] vetorB, vetorX, vetorXIni;
            double[,] matrizA, matrizACopia, inversa;

            if (checkBoxPreencherZeros.Checked)
                PreencheZerosDataGridView();

            if (Globals.tipoMetodo == false) {
                try {
                    numVariaveis = int.Parse(numericUpDownVariaveis.Value.ToString());
                } catch (Exception erro) {
                    MessageBox.Show("Alguma coisa deu errada.\n\nErro: " + erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                matrizA = new double[numVariaveis, numVariaveis];
                matrizACopia = new double[numVariaveis, numVariaveis];
                vetorB = new double[numVariaveis];
                posXs = new int[numVariaveis];
                inversa = new double[numVariaveis, numVariaveis];

                for (i = 0; i < numVariaveis; i++) {
                    for (j = 0; j < numVariaveis; j++) {
                        try {
                            matrizA[i, j] = double.Parse(dataGridViewDados.Rows[i].Cells[j + 1].Value.ToString());
                        } catch (Exception) {
                            MessageBox.Show("Valor incorreto para A[" + (i + 1) + "][" + (j + 1) + "].", "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataGridViewDados.Rows[i].Cells[j + 1].Selected = true;
                            return;
                        }
                    }
                    try {
                        vetorB[i] = double.Parse(dataGridViewDados.Rows[i].Cells[21].Value.ToString());
                    } catch (Exception) {
                        MessageBox.Show("Valor incorreto para b[" + (i + 1) + "].", "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridViewDados.Rows[i].Cells[21].Selected = true;
                        return;
                    }
                }

                matrizACopia = (double[,]) matrizA.Clone();

                try {
                    metodo = MetodoSelecionado();
                    switch (metodo) {
                        case 0: GaussSimples(ref matrizA, ref vetorB, out vetorX, numVariaveis);
                            break;
                        case 1: GaussPivotamentoParcial(ref matrizA, ref vetorB, out vetorX, numVariaveis);
                            break;
                        case 2: GaussPivotamentoTotal(ref matrizA, ref vetorB, out vetorX, out posXs, numVariaveis);
                            break;
                        case 3: GaussCompacto(matrizA, ref vetorB, out vetorX, numVariaveis);
                            break;
                        case 4: DecomposicaoLU(matrizA, ref vetorB, out vetorX, numVariaveis);
                            break;
                        // case 5
                        default: Cholesky(matrizA, ref vetorB, out vetorX, numVariaveis);
                            break;
                    }
                } catch (DivideByZeroException erro) {
                    MessageBox.Show(erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                } catch(ErroAoCalcularRaiz erro) {
                    MessageBox.Show(erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                } catch(NaoAtendeCriterios erro) {
                    MessageBox.Show(erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                } catch (Exception erro) {
                    MessageBox.Show("Alguma coisa deu errada.\n\nErro: " + erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try {
                    if (checkBoxOpcaoDeterminante.Checked && checkBoxOpcaoDeterminante.Enabled) {
                        determinante = Determinante(matrizA, numVariaveis, metodo);
                    }
                }
                catch (Exception erro) {
                    MessageBox.Show("Alguma coisa deu errada ao calcular o determinante.\n\nErro: " + erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try {
                    if (checkBoxOpcaoInversa.Checked && checkBoxOpcaoInversa.Enabled) {
                        MatrizInversa(matrizACopia, out inversa, numVariaveis, metodo);
                    }
                } catch(Exception erro) {
                    MessageBox.Show("Alguma coisa deu errada ao calcular a matriz Inversa.\n\nErro: " + erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (metodo == 2)
                    new Form2(matrizA, vetorB, vetorX, numVariaveis, posXs, checkBoxOpcaoDeterminante.Checked && checkBoxOpcaoDeterminante.Enabled, determinante, checkBoxOpcaoInversa.Checked && checkBoxOpcaoInversa.Enabled, inversa).Show();
                else
                    new Form2(matrizA, vetorB, vetorX, numVariaveis, checkBoxOpcaoDeterminante.Checked, determinante, checkBoxOpcaoInversa.Checked, inversa).Show();
            }
            else {
                try {
                    numVariaveis = int.Parse(numericUpDownVariaveis.Value.ToString());
                } catch (Exception erro) {
                    MessageBox.Show("Alguma coisa deu errada.\n\nErro: " + erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try {
                    numIteracao = int.Parse(numericUpDownIteracao.Value.ToString());
                } catch(Exception erro) {
                    MessageBox.Show("Alguma coisa deu errada.\n\nErro: " + erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try {
                    tolerancia = double.Parse(numericUpDownTolerancia.Value.ToString());
                } catch (Exception erro) {
                    MessageBox.Show("Alguma coisa deu errada.\n\nErro: " + erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                matrizA = new double[numVariaveis, numVariaveis];
                vetorB = new double[numVariaveis];
                vetorXIni = new double[numVariaveis];

                for (i = 0; i < numVariaveis; i++) {
                    for (j = 0; j < numVariaveis; j++) {
                        try {
                            matrizA[i, j] = double.Parse(dataGridViewDados.Rows[i].Cells[j + 1].Value.ToString());
                        } catch (Exception) {
                            MessageBox.Show("Valor incorreto para A[" + (i + 1) + "][" + (j + 1) + "].", "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataGridViewDados.Rows[i].Cells[j + 1].Selected = true;
                            return;
                        }
                    }
                    try {
                        vetorB[i] = double.Parse(dataGridViewDados.Rows[i].Cells[21].Value.ToString());
                    } catch (Exception) {
                        MessageBox.Show("Valor incorreto para b[" + (i + 1) + "].", "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridViewDados.Rows[i].Cells[21].Selected = true;
                        return;
                    }

                    try {
                        vetorXIni[i] = double.Parse(dataGridViewDados.Rows[numVariaveis].Cells[i + 1].Value.ToString());
                    } catch (Exception) {
                        MessageBox.Show("Valor incorreto para x[" + (i + 1) + "].", "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridViewDados.Rows[numVariaveis].Cells[i + 1].Selected = true;
                        return;
                    }
                }

                try {
                    switch (MetodoSelecionado()) {
                        case 6:
                            Jacobi(matrizA, ref vetorB, out vetorX, ref vetorXIni, numVariaveis, numIteracao, tolerancia);
                            break;
                        default: // case 7:
                            GaussSeidel(matrizA, ref vetorB, out vetorX, ref vetorXIni, numVariaveis, numIteracao, tolerancia);
                            break;
                    }
                }
                catch (DivideByZeroException erro) {
                    MessageBox.Show(erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (ExcedeuLimiteIteracoes erro) {
                    MessageBox.Show(erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch(NaoAtendeCriterios erro) {
                    MessageBox.Show(erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch(ErroAoCalcularRaiz erro) {
                    MessageBox.Show(erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception erro) {
                    MessageBox.Show("Alguma coisa deu errada.\n\nErro: " + erro.Message, "Sistemas Lineares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                new Form2(matrizA, vetorB, vetorX, numVariaveis, false, 0, false, null).Show();
            }
        }

        private void buttonAlteraGrid_Click(object sender, EventArgs e) {
            SalvaElementos();
            AlteraDatagGridView();
            ReposicionaElementos();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e) {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked) {
                if (rb.Tag.ToString() == "Jacobi" || rb.Tag.ToString().Equals("GaussSeidel")) {
                    checkBoxOpcaoDeterminante.Enabled = false;
                    checkBoxOpcaoInversa.Enabled = false;
                    Globals.tipoMetodo = true;
                }
                else {
                    checkBoxOpcaoDeterminante.Enabled = true;
                    checkBoxOpcaoInversa.Enabled = true;
                    Globals.tipoMetodo = false;
                }
                SalvaElementos();
                AlteraDatagGridView();
                ReposicionaElementos();
                Globals.radioButtonChecked = rb.Tag.ToString();
            }
        }

        private void numericUpDownVariaveis_Leave(object sender, EventArgs e) {
            SalvaElementos();
            AlteraDatagGridView();
            ReposicionaElementos();
        }

        private void buttonLimpar_Click(object sender, EventArgs e) {
            dataGridViewDados.Rows.Clear();
            numericUpDownVariaveis.Value = 3;
            AlteraDatagGridView();
        }
    }

    #endregion

    #region Classes descendentes da Classe Exception para identificação de exceções específicas dos métodos
    
    public class ExcedeuLimiteIteracoes : Exception {
        public ExcedeuLimiteIteracoes() : base() { }
        public ExcedeuLimiteIteracoes(String message) : base(message) { }
    }

    public class NaoAtendeCriterios : Exception {
        public NaoAtendeCriterios() : base() { }
        public NaoAtendeCriterios(String message) : base(message) { }
    }

    public class ErroAoCalcularRaiz : Exception {
        public ErroAoCalcularRaiz() : base() { }
        public ErroAoCalcularRaiz(String message) : base(message) { }
    }

    public static class Globals {
        public static string radioButtonChecked = "GaussSimples";
        public static bool   tipoMetodo = false; // [false] para metodos diretos e [true] para metodos iterativos
                                                // Começa com false, pois o radioButton para o metodo de Gauss Simples
                                                // ja esta checado no inicio da aplicacao
        public static int    ScrollBarHorizontalAltura = SystemInformation.HorizontalScrollBarHeight;
        public static int    ScrollBarVerticalLargura = SystemInformation.VerticalScrollBarWidth;
    }
    #endregion
}
