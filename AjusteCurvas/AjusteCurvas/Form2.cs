using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace AjusteCurvas {
    public partial class Form2 : Form {
        public Form2(int n, double[] xGrade, double[] yGrade, bool[] TemAjuste, int numCoeficientes, double[,] coeficientes) {
            InitializeComponent();

            int i;
            double passo, DeltaX, a, b;
            double[] xGrafico, yGrafico, coef;

            xGrafico = new double[101];
            yGrafico = new double[101];

            PlotController plotControles = new PlotController();
            PlotModel funcao = new PlotModel();

            ScatterSeries pontos = new ScatterSeries{
                Title = "Pontos da Amostra",
                MarkerFill = OxyColors.Black,
                MarkerType = MarkerType.Circle,
                MarkerSize = 5
            };
            LineSeries polinomio1 = new LineSeries{
                Color = OxyColors.MediumAquamarine,
                StrokeThickness = 1.5,
                LineStyle = LineStyle.Dash  
            };
            LineSeries polinomio2 = new LineSeries{
                Color = OxyColors.IndianRed,
                StrokeThickness = 1.5,
                LineStyle = LineStyle.Dash,
            };
            LineSeries polinomio3 = new LineSeries{
                Color = OxyColors.Cyan,
                StrokeThickness = 2,
                LineStyle = LineStyle.Solid
            };
            LineSeries polinomio4 = new LineSeries{
                Color = OxyColors.Magenta,
                StrokeThickness = 1.5,
                LineStyle = LineStyle.Dash
            };
            LineSeries polinomio5 = new LineSeries{
                Color = OxyColors.RoyalBlue,
                StrokeThickness = 1.5,
                LineStyle = LineStyle.Dash
            };

            plotControles.UnbindAll();

            DeltaX = (xGrade[xGrade.Length - 1] - xGrade[0]) / 100;
            passo = 101;

            for (i = 0; i < xGrade.Length; i++) {
                pontos.Points.Add(new ScatterPoint(xGrade[i], yGrade[i], double.NaN, double.NaN, null));
            }
            
            for (i = 0; i <= 100; i++) {
                xGrafico[i] = xGrade[0] + i * DeltaX;
            }

            if (numCoeficientes == 2) {
                // y = a + b.x
                if (TemAjuste[1]) {
                    a = coeficientes[0, 0];
                    b = coeficientes[0, 1];
                    polinomio1.Points.Add(new DataPoint(xGrafico[0], a + b * xGrafico[0]));
                    polinomio1.Points.Add(new DataPoint(xGrafico[99], a + b * xGrafico[99]));
                    polinomio1.Title = "y = a + b.x";
                }
                // y = a.e^(b.x)
                if (TemAjuste[2]) {
                    a = coeficientes[1, 0];
                    b = coeficientes[1, 1];
                    polinomio2.Title = "y = a.e^(b.x)";
                    try {
                        for (i = 0; i < passo; i++) {
                            polinomio2.Points.Add(new DataPoint(xGrafico[i], a * Math.Exp(b * xGrafico[i])));
                        }
                    }
                    catch (Exception) {
                        polinomio2.Title = "y = a.e^(b.x) (Erro)";
                    }
                }
                // y = a.b^x
                if (TemAjuste[3]) {
                    a = coeficientes[2, 0];
                    b = coeficientes[2, 1];
                    polinomio3.Title = "y = a.b^x";
                    try {
                        for (i = 0; i < passo; i++) {
                            polinomio3.Points.Add(new DataPoint(xGrafico[i], a * Math.Pow(b, xGrafico[i])));
                        }
                    }
                    catch (Exception) {
                        polinomio3.Title = "y = a.b^x (Erro)";
                    }
                }
                // y = 1/(a + b.x)
                if (TemAjuste[4]) {
                    a = coeficientes[3, 0];
                    b = coeficientes[3, 1];
                    polinomio4.Title = "y = 1/(a + b.x)";
                    try {
                        for (i = 0; i < passo; i++) {
                            polinomio4.Points.Add(new DataPoint(xGrafico[i], 1 / (a + b * xGrafico[i])));
                        }
                    }
                    catch (Exception) {
                        polinomio4.Title = "y = 1/(a + b.x) (Erro)";
                    }
                }
                // y = a.x^b
                if (TemAjuste[5]) {
                    a = coeficientes[4, 0];
                    b = coeficientes[4, 1];
                    polinomio5.Title = "y = a.x^b";
                    try {
                        for (i = 0; i < passo; i++) {
                            polinomio5.Points.Add(new DataPoint(xGrafico[i], a * Math.Pow(xGrafico[i], b)));
                        }
                    }
                    catch (Exception) {
                        polinomio5.Title = "y = a.x^b (Erro)";
                    }
                }
            }
            else {
                coef = new double[numCoeficientes];
                // p2(x) = a0 + a1.x + a2.x^2
                if (TemAjuste[1]) {
                    coef[0] = coeficientes[0, 0];
                    coef[1] = coeficientes[0, 1];
                    coef[2] = coeficientes[0, 2];
                    polinomio1.Title = "p2(x)";
                    try {
                        for (i = 0; i < passo; i++) {
                            polinomio1.Points.Add(new DataPoint(xGrafico[i], coef[0] + coef[1]*xGrafico[i] + coef[2] * Math.Pow(xGrafico[i], 2)));
                        }
                    }
                    catch (Exception) {
                        polinomio1.Title = "p2(x) (Erro)";
                    }
                }
                // p3(x) = a0 + a1.x + a2.x^2 + a3.x^3
                if (TemAjuste[2]) {
                    coef[0] = coeficientes[1, 0];
                    coef[1] = coeficientes[1, 1];
                    coef[2] = coeficientes[1, 2];
                    coef[3] = coeficientes[1, 3];
                    polinomio2.Title = "p3(x)";
                    try {
                        for (i = 0; i < passo; i++) {
                            polinomio2.Points.Add(new DataPoint(xGrafico[i], coef[0] + coef[1] * xGrafico[i] + coef[2] * Math.Pow(xGrafico[i], 2) + 
                                                                             coef[3] * Math.Pow(xGrafico[i], 3)));
                        }
                    }
                    catch (Exception) {
                        polinomio2.Title = "p3(x) (Erro)";
                    }
                }
                // p4(x) = a0 + a1.x + a2.x^2 + a3.x^3 + a4.x^4
                if (TemAjuste[3]) {
                    coef[0] = coeficientes[2, 0];
                    coef[1] = coeficientes[2, 1];
                    coef[2] = coeficientes[2, 2];
                    coef[3] = coeficientes[2, 3];
                    coef[4] = coeficientes[2, 4];
                    polinomio3.Title = "p4(x)";
                    try {
                        for (i = 0; i < passo; i++) {
                            polinomio3.Points.Add(new DataPoint(xGrafico[i], coef[0] + coef[1] * xGrafico[i] + coef[2] * Math.Pow(xGrafico[i], 2) + 
                                                                             coef[3] * Math.Pow(xGrafico[i], 3) + coef[4] * Math.Pow(xGrafico[i], 4)));
                        }
                    }
                    catch (Exception) {
                        polinomio3.Title = "p4(x) (Erro)";
                    }
                }
                // p5(x) = a0 + a1.x + a2.x^2 + a3.x^3 + a4.x^4 + a5.x^5
                if (TemAjuste[4]) {
                    coef[0] = coeficientes[3, 0];
                    coef[1] = coeficientes[3, 1];
                    coef[2] = coeficientes[3, 2];
                    coef[3] = coeficientes[3, 3];
                    coef[4] = coeficientes[3, 4];
                    coef[5] = coeficientes[3, 5];
                    polinomio4.Title = "p5(x)";
                    try {
                        for (i = 0; i < passo; i++) {
                            polinomio4.Points.Add(new DataPoint(xGrafico[i], coef[0] + coef[1] * xGrafico[i] + coef[2] * Math.Pow(xGrafico[i], 2) +
                                                                             coef[3] * Math.Pow(xGrafico[i], 3) + coef[4] * Math.Pow(xGrafico[i], 4) +
                                                                             coef[5] * Math.Pow(xGrafico[i], 5)));
                        }
                    }
                    catch (Exception) {
                        polinomio4.Title = "p5(x) (Erro)";
                    }
                }
                // p6(x) = a0 + a1.x + a2.x^2 + a3.x^3 + a4.x^4 + a5.x^5 + a6.x^6
                if (TemAjuste[5]) {
                    coef[0] = coeficientes[4, 0];
                    coef[1] = coeficientes[4, 1];
                    coef[2] = coeficientes[4, 2];
                    coef[3] = coeficientes[4, 3];
                    coef[4] = coeficientes[4, 4];
                    coef[5] = coeficientes[4, 5];
                    coef[6] = coeficientes[4, 6];
                    polinomio5.Title = "p6(x)";
                    try {
                        for (i = 0; i < passo; i++) {
                            polinomio5.Points.Add(new DataPoint(xGrafico[i], coef[0] + coef[1] * xGrafico[i] + coef[2] * Math.Pow(xGrafico[i], 2) +
                                                                             coef[3] * Math.Pow(xGrafico[i], 3) + coef[4] * Math.Pow(xGrafico[i], 4) +
                                                                             coef[5] * Math.Pow(xGrafico[i], 5) + coef[6] * Math.Pow(xGrafico[i], 6)));
                        }
                    }
                    catch (Exception) {
                        polinomio5.Title = "p6(x) (Erro)";
                    }
                }
            }


            funcao.Series.Add(pontos);
            funcao.Series.Add(polinomio1);
            funcao.Series.Add(polinomio3);
            funcao.Series.Add(polinomio2);
            funcao.Series.Add(polinomio4);
            funcao.Series.Add(polinomio5);

            ////Assign PlotModel to PlotView
            plotGrafico.Model = funcao;
            plotGrafico.Controller = plotControles;
        }
    }
}
