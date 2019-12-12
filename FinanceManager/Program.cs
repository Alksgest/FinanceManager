using FinanceManager.Managers;
using FinanceManager.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManager
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalSettings.LoadSettings();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //GlobalSettings.SaveSettings();
        }

        //private static void RegisterSingltones()
        //{
        //    SingltonManager.RegisterSinglton<IncomeTransactionManager>();
        //    SingltonManager.RegisterSinglton<OutcomeTransactionManager>();
        //    SingltonManager.RegisterSinglton<StatisticResolver>();
        //}
    }
}
