using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Integrais {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool mathParserdll = File.Exists("MathParser.org-mXparser.Net40.dll");
            bool oxyplotdll = File.Exists("OxyPlot.dll");
            bool oxyplotwinformdll = File.Exists("OxyPlot.WindowsForms.dll");
            bool oxyplotwpf = File.Exists("OxyPlot.Wpf.dll");

            if (mathParserdll && oxyplotdll && oxyplotwinformdll && oxyplotwpf)
                Application.Run(new Form1());
            else {
                if (!mathParserdll) {
                    MessageBox.Show("Erro: Dll 'MathParser.org-mXparser.Net40.dll' não encontrada.", "Integrais Numéricas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!oxyplotdll) {
                    MessageBox.Show("Erro: Dll 'OxyPlot.dll' não encontrada.", "Integrais Numéricas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!oxyplotwinformdll) {
                    MessageBox.Show("Erro: Dll 'OxyPlot.WindowsForms.dll' não encontrada.", "Integrais Numéricas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!oxyplotwpf) {
                    MessageBox.Show("Erro: Dll 'OxyPlot.Wpf.dll' não encontrada.", "Integrais Numéricas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
