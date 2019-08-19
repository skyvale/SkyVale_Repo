using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Skylar Valerio
 * 08.11.19
 * CE02: Passing Data and Multiple Forms
 * MDV1830-O 01
 */

namespace SkylarValerio_CE02
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
            Application.Run(new ArtFight_2019());
        }
    }
}
