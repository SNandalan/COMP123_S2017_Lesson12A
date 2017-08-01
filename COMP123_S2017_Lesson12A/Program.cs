using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Sushmita Nandalan
 * Dtae: August 1st, 2017
 * Description: This is a Demo application to showcase User Interface
 * Version: 0.1 - Created the Project
 */

namespace COMP123_S2017_Lesson12A
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
            Application.Run(new Demo());
        }
    }
}
