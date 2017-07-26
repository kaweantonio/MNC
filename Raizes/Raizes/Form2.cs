using System;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Raizes {
    public partial class Form2 : Form {
        public Form2(Function f, double a, double b) {
            InitializeComponent();

            //Create Plotmodel object
            
            Func<double, double> funcao = (x) => f.calculate(x);
            var plotFuncao = new PlotModel();

            PlotController plotControles = new PlotController();

            plotControles.UnbindAll();

            plotFuncao.Series.Add(new FunctionSeries(funcao, a, b, (b-a)/1000, "Função"));
            plotFuncao.TextColor = OxyColors.Black;
            //plotFuncao.Axes.Add(linearAxis);

            ////Assign PlotModel to PlotView
            plotViewGrafico.Model = plotFuncao;
            plotViewGrafico.Controller = plotControles;

            label1.Text = label1.Text + f.getFunctionExpressionString();
        }
        
        public Form2(Function f, double a, double b, double epsilon, double raiz, double valorFuncao) {
            InitializeComponent();


            //Create Plotmodel object
            ScatterSeries ponto = new ScatterSeries{Title = "Raiz"};
            Func<double, double> funcao = (x) => f.calculate(x);
            var plotFuncao = new PlotModel();

            PlotController plotControles = new PlotController();
            LinearAxis linearAxis = new LinearAxis() {
                AbsoluteMinimum = a,
                AbsoluteMaximum = b,
                IsPanEnabled = false,
            };

            plotControles.UnbindAll();
        
            plotFuncao.Series.Add(new FunctionSeries(funcao, a, b, epsilon, "Função")); // adiciona função no plotView
            ponto.Points.Add((new ScatterPoint(raiz, valorFuncao, double.NaN, double.NaN, "Raiz"))); // adiciona raiz no plotView
            plotFuncao.Series.Add(ponto);
            plotFuncao.LegendPosition = LegendPosition.RightTop; // posição da legenda
            plotFuncao.TextColor = OxyColors.Black;
            //plotFuncao.Axes.Add(linearAxis);

            ////Assign PlotModel to PlotView
            plotViewGrafico.Model = plotFuncao;
            plotViewGrafico.Controller = plotControles;
            
            label1.Text = label1.Text + f.getFunctionExpressionString();
        }
    }
}
