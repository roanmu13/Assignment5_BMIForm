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
 * Date: August 13 2017
 * Description: BMI Calculator Assignment
 * Version 0.3- added metric conversion and refactored imperial conversion
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

        private double _heightFtCm;

        private double _weight;

        private double _inchesHeight;

        private double _displayBMI;

        //Public properties

        public double HeightFtCm {
            get
            {
                return this._heightFtCm;
            }

            set
            {
                this._heightFtCm = value;
            }
        }

        public double Weight {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
            }
        }
        public double InchesHeight
        {
            get
            {
                return this._inchesHeight;
            }
            set
            {
                this._inchesHeight = value;
            }
        }  
        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        /// <summary>
        /// This is the imperial method for bmi calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            //Getting user's inputted information
            //   _heightFtCm = double.Parse(HeightTextBox.Text);
            //  _inchesHeight = double.Parse(HeightTextBoxInches.Text);
            //  _weight = double.Parse(WeightTextBox.Text);

            bool _correctHeightFtCm = double.TryParse(HeightTextBox.Text, out _heightFtCm);
            bool _correctInchesHeight= double.TryParse(HeightTextBoxInches.Text, out _inchesHeight);
            bool _correctWeight= double.TryParse(WeightTextBox.Text, out _weight);

            if (ImperialRadioButton1.Checked==true)
            {
                if ((_correctHeightFtCm ==true && _heightFtCm >0) && 
                    (_correctInchesHeight==true && _inchesHeight >= 0) && 
                    (_correctWeight==true && _weight > 0))
                {
                    this._inchesHeight += this._heightFtCm * 12;
                    this._displayBMI = (this._weight * 703) / (this._inchesHeight * this._inchesHeight);
                     DisplayTextBox.Text = this._displayBMI.ToString();
                }

                else
                {
                    DisplayTextBox.Text = "Only enter numeric values";
                }
            }
            else if (MetricRadioButton2.Checked == true)
            {
               if((_correctHeightFtCm && _heightFtCm > 0) && 
                    (_correctInchesHeight ==true && _inchesHeight >0) &&
                    (_correctWeight && Weight >0))
                    {
                    this._displayBMI = _weight / (this._heightFtCm * this._heightFtCm );
                    DisplayTextBox.Text = this._displayBMI.ToString();
                }
                else
                {
                    DisplayTextBox.Text = "Only enter numeric values";
                }

            }
        }
        private void ImperialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.HeightTextBoxInches.Show();
        }

        private void MetricRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.WeightTextBox.Clear();
            this.HeightTextBox.Clear();
            this.DisplayTextBox.Clear();
            this.HeightTextBoxInches.Clear();
            this.HeightTextBoxInches.Hide();

        }
    }
}
