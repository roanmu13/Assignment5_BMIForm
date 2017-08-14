using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name:Rosa Munguia
 * Student No. 300735300
 * Date: August 3 2017
 * Description: BMI Calculator Assignment
 * Version 0.2- Started splashform first
 */
namespace Assignment5_BMIForm
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
            Application.Run(new SplashForm());
        }
    }
}
