using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AjusteCurvas {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool oxyplotdll = File.Exists("OxyPlot.dll");
            bool oxyplotwinformdll = File.Exists("OxyPlot.WindowsForms.dll");
            bool oxyplotwpf = File.Exists("OxyPlot.Wpf.dll");

            if (oxyplotdll && oxyplotwinformdll && oxyplotwpf)
                Application.Run(new Form1());
            else {
                if (!oxyplotdll) {
                    MessageBox.Show("Erro: Dll 'OxyPlot.dll' não encontrada.", "Ajustes de Curvas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!oxyplotwinformdll) {
                    MessageBox.Show("Erro: Dll 'OxyPlot.WindowsForms.dll' não encontrada.", "Ajustes de Curvas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!oxyplotwpf) {
                    MessageBox.Show("Erro: Dll 'OxyPlot.Wpf.dll' não encontrada.", "Ajustes de Curvas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
