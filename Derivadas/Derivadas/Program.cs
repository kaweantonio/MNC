using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Derivadas
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists("MathParser.org-mXparser.Net40.dll")) {
                Application.Run(new Form1());
            }
            else {
                MessageBox.Show("Erro: Dll 'MathParser.org-mXparser.Net40.dll' não encontrada.", "Derivadas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
