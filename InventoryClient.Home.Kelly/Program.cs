using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using EntityFrameworkCore.Data.Home.Kelly;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryClient.Home.Kelly
{
    internal static class Program
    {
        ///Variable Declarations
        public static string apiRoot = ConfigurationManager.AppSettings["APIRoot"];

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormMain main = new FormMain(apiRoot);

            Application.Run(main);
        }

        
    }
}
