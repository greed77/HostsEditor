using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;

namespace HostsEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool ok;
            Mutex m = new System.Threading.Mutex(true, Assembly.GetExecutingAssembly().GetType().GUID.ToString(), out ok);

            if (!ok)
            {
                MessageBox.Show("Another instance is already running.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

            GC.KeepAlive(m);                // important!      
        }
    }
}
