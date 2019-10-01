using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Skylar Valerio
 * 07.13.19
 * VFW C201907
 * CE: Introduction to Windows Forms
 *
 */

namespace SkylarValerio_CE01
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
            Application.Run(new usersForm());
        }
    }
}
