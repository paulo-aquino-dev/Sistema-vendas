using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russo2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new telaLogin());
        }
    }
    public class Func
    {
        private static string funcionario;
        public static string Funcionario
        {
            get { return funcionario; }
            set { funcionario = value; }
        }
    }
    public class DiaS
    {
        private static string diaSemana;
        public static string DiaSemana
        {
            get { return diaSemana; }
            set { diaSemana = value; }
        }
    }
}
