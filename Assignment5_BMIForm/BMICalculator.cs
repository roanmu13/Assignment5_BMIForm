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
 * Name:Rosa Munguia
 * Student No. 300735300
 * Date: August 3 2017
 * Description: BMI Calculator Assignment
 * Version 0.2- added imperial bmi calculator method
 */
namespace Assignment5_BMIForm
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        //Private instance variables

        private double _inchesHeight;

        private double _poundsWeight;

        //Public properties

        public double InchesHeight { get
            {
                return this._inchesHeight;
            }

            set
            {
                this._inchesHeight = value;
            }
        }

        public double PoundsWeight { get
            {
                return this._poundsWeight;
            }
            set
            {
                this._poundsWeight = value;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ImperialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the imperial method for bmi calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            _inchesHeight = double.Parse(heightTextBoxInches.Text);
            _poundsWeight = double.Parse(WeightTextBoxPounds.Text);

            if(ImperialRadioButton1.Checked==true)
            {
                if((_inchesHeight >0) && (_poundsWeight > 0))
                {
                     double _impBMI = (_poundsWeight * 703) / (_inchesHeight * _inchesHeight);
                     ImperialDisplayTextBox.Text = _impBMI.ToString();
                }
               
            }

           

            
        }
    }
}
