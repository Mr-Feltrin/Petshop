using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace PetShop
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo Culture = (CultureInfo)CultureInfo.GetCultureInfo("pt-BR").Clone();
            Culture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = Culture;
            Thread.CurrentThread.CurrentUICulture = Culture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipal());
        }
    }
}
