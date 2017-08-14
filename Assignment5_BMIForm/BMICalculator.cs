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
 * Date: August 14 2017
 * Description: BMI Calculator Assignment
 * Version 0.6- Added form closing event handler
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

        private double _heightFtOrCm;

        private double _weightLbsOrKg;

        private double _inchesHeight;

        private double _displayBMI;

        //Public properties

        public double HeightFtOrCm {
            get
            {
                return this._heightFtOrCm;
            }

            set
            {
                this._heightFtOrCm = value;
            }
        }

        public double WeightLbsOrKg {
            get
            {
                return this._weightLbsOrKg;
            }
            set
            {
                this._weightLbsOrKg = value;
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

            bool _correctHeightFtOrCm = double.TryParse(HeightTextBox.Text, out _heightFtOrCm);
            bool _correctInchesHeight= double.TryParse(HeightTextBoxInches.Text, out _inchesHeight);
            bool _correctWeightLbsOrKg= double.TryParse(WeightTextBox.Text, out _weightLbsOrKg);

            if (ImperialRadioButton1.Checked)
            {
                if ((_correctHeightFtOrCm ==true && _heightFtOrCm >0) && 
                    (_correctInchesHeight==true && _inchesHeight >= 0) && 
                    (_correctWeightLbsOrKg==true && _weightLbsOrKg > 0))
                {
                    this._inchesHeight += this._heightFtOrCm * 12;
                    this._displayBMI = (this._weightLbsOrKg * 703) / (this._inchesHeight * this._inchesHeight);
                     DisplayTextBox.Text = String.Format("Your BMI IS " + this._displayBMI.ToString("F2")); 
                }

                else
                {
                    DisplayTextBox.Text = "Only enter numeric values";
                }
            }
            else// if (MetricRadioButton2.Checked == true)
            {
               if((_correctHeightFtOrCm && _heightFtOrCm > 0) && 
                    //(_correctInchesHeight ==true && _inchesHeight >0) &&
                    (_correctWeightLbsOrKg && WeightLbsOrKg >0))
                    {
                    double _heightFtM = this._heightFtOrCm / 100;
                    this._displayBMI = (_weightLbsOrKg / (_heightFtM * _heightFtM)) ;
                    DisplayTextBox.Text = String.Format("Your BMI is {0}",this._displayBMI.ToString("F2"));
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
            this.InchLabel.Show();
            this.FeetLabel.Text = "ft";
            this.LbsLabel.Text = "lbs";
        }

        private void MetricRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

           this.WeightTextBox.Clear();
           this.HeightTextBox.Clear();
           this.DisplayTextBox.Clear();
           this.HeightTextBoxInches.Hide();
           this.HeightTextBoxInches.Hide();
            this.InchLabel.Hide();
            this.FeetLabel.Text = "cm";
            this.LbsLabel.Text="kg";

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.WeightTextBox.Text = "";
            this.HeightTextBox.Text = "";
            this.DisplayTextBox.Text = "";
            this.HeightTextBoxInches.Text = "";
        }

        /// <summary>
        /// this is the formClosing event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
