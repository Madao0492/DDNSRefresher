using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDNSRefresher
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DDNSRefresher dRefresher = new DDNSRefresher();
            if(Properties.Settings.Default.SSID == "")
            {
                Application.Run(dRefresher);
            }
            else
            {
                dRefresher.updDDNS(Properties.Settings.Default.SSID, Properties.Settings.Default.Host, Properties.Settings.Default.Domain, Properties.Settings.Default.Password);
                Application.Run();
            }
        }
    }
}
