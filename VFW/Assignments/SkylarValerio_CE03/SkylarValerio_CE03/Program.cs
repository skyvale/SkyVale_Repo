using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkylarValerio_CE03
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
            Application.Run(new Form1());
        }


        // list of all the stuff i have to do:
        /*
         * update the listbox in real time when the user clicks the add button
         * 
         * fix the checked method that determines whether or not the display form
         * is already open (currently, it will not open the form again if it was previously opened)
         * 
         * clear all button from the main form
         * 
         * clear all button from the display form
         * 
         * 
         */


    }
}
