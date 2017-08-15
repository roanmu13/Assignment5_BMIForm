using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name:Rosa Munguia
 * Student No. 300735300
 * Date: August 15 2017
 * Description: BMI Calculator Assignment
 * Version 0.2- Started splashform first
 */
namespace Assignment5_BMIForm
{
   public static class Program
    {
        //Creates Reference to forms
        public static BMICalculator BMI_Form = new BMICalculator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BMI_Form = new BMICalculator();//instantiates new object of BMI calculator

            Application.Run(new SplashForm());
        }
    }
}
