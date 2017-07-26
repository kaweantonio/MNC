using System;
using System.IO;
using System.Windows.Forms;

namespace Interpolacao {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool mathParserdll = File.Exists("MathNet.Numerics.dll");
            bool oxyplotdll = File.Exists("OxyPlot.dll");
            bool oxyplotwinformdll = File.Exists("OxyPlot.WindowsForms.dll");
            bool oxyplotwpf = File.Exists("OxyPlot.Wpf.dll");

            if (mathParserdll && oxyplotdll && oxyplotwinformdll && oxyplotwpf)
                Application.Run(new Form1());
            else {
                if (!mathParserdll) {
                    MessageBox.Show("Erro: Dll 'MathNet.Numerics.dll' não encontrada.", "Interpolação Polinomial",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!oxyplotdll) {
                    MessageBox.Show("Erro: Dll 'OxyPlot.dll' não encontrada.", "Interpolação Polinomial",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!oxyplotwinformdll) {
                    MessageBox.Show("Erro: Dll 'OxyPlot.WindowsForms.dll' não encontrada.", "Interpolação Polinomial",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!oxyplotwpf) {
                    MessageBox.Show("Erro: Dll 'OxyPlot.Wpf.dll' não encontrada.", "Interpolação Polinomial",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
