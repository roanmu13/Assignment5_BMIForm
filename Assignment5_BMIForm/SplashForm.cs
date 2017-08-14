using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Rosa Munguia
 * Student Number: 300735300
 * Date: August 14 2017
 * Description: This is the splash form class for the BMI calculator
 * Version 0.2- Created splashForm Timer_tick event
 */
namespace Assignment5_BMIForm
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for tick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            BMICalculator BMI_calc = new BMICalculator();
            BMI_calc.Show();
            this.Hide();
            SplashFormTimer.Enabled = false; //turn off timer

        }
    }
}
