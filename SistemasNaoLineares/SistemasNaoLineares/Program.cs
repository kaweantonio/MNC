using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemasNaoLineares {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string mxparser = "MathParser.org-mXparser.Net40.dll";

            if (File.Exists(mxparser)) {
                Application.Run(new Form1());
            }
            else {
                MessageBox.Show("Erro: Dll " + mxparser + " não encontrada.", "Sistemas de Equações Não-Lineareas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
