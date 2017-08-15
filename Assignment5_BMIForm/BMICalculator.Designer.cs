namespace Assignment5_BMIForm
{
    partial class BMICalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculator));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioButton1 = new System.Windows.Forms.RadioButton();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.Weightlabel = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.MetricRadioButton2 = new System.Windows.Forms.RadioButton();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBoxInches = new System.Windows.Forms.TextBox();
            this.FeetLabel = new System.Windows.Forms.Label();
            this.InchLabel = new System.Windows.Forms.Label();
            this.LbsLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.YourBMIisLabel = new System.Windows.Forms.Label();
            this.BMITitlelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadioButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.WeightTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Weightlabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CalculateBMIButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.MetricRadioButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MyHeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.HeightTextBoxInches, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.FeetLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.InchLabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.LbsLabel, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.ResetButton, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.DisplayTextBox, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.YourBMIisLabel, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 43);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 290);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ImperialRadioButton1
            // 
            this.ImperialRadioButton1.AutoSize = true;
            this.ImperialRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.ImperialRadioButton1, 2);
            this.ImperialRadioButton1.Location = new System.Drawing.Point(3, 3);
            this.ImperialRadioButton1.Name = "ImperialRadioButton1";
            this.ImperialRadioButton1.Size = new System.Drawing.Size(130, 33);
            this.ImperialRadioButton1.TabIndex = 0;
            this.ImperialRadioButton1.TabStop = true;
            this.ImperialRadioButton1.Text = "Imperial";
            this.ImperialRadioButton1.UseVisualStyleBackColor = false;
            this.ImperialRadioButton1.CheckedChanged += new System.EventHandler(this.ImperialRadioButton1_CheckedChanged);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeightTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.HeightTextBox.Location = new System.Drawing.Point(3, 75);
            this.HeightTextBox.MaxLength = 1;
            this.HeightTextBox.Multiline = true;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(62, 30);
            this.HeightTextBox.TabIndex = 3;
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.WeightTextBox, 3);
            this.WeightTextBox.Location = new System.Drawing.Point(3, 147);
            this.WeightTextBox.MaxLength = 3;
            this.WeightTextBox.Multiline = true;
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(198, 30);
            this.WeightTextBox.TabIndex = 7;
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Weightlabel
            // 
            this.Weightlabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Weightlabel, 4);
            this.Weightlabel.Location = new System.Drawing.Point(3, 108);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(186, 36);
            this.Weightlabel.TabIndex = 6;
            this.Weightlabel.Text = "My Weight:";
            this.Weightlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.OrangeRed;
            this.tableLayoutPanel1.SetColumnSpan(this.CalculateBMIButton, 2);
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 183);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(130, 39);
            this.CalculateBMIButton.TabIndex = 9;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // MetricRadioButton2
            // 
            this.MetricRadioButton2.AutoSize = true;
            this.MetricRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.MetricRadioButton2, 2);
            this.MetricRadioButton2.Location = new System.Drawing.Point(139, 3);
            this.MetricRadioButton2.Name = "MetricRadioButton2";
            this.MetricRadioButton2.Size = new System.Drawing.Size(130, 33);
            this.MetricRadioButton2.TabIndex = 1;
            this.MetricRadioButton2.TabStop = true;
            this.MetricRadioButton2.Text = "Metric";
            this.MetricRadioButton2.UseVisualStyleBackColor = false;
            this.MetricRadioButton2.CheckedChanged += new System.EventHandler(this.MetricRadioButton2_CheckedChanged);
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.MyHeightLabel, 4);
            this.MyHeightLabel.Location = new System.Drawing.Point(3, 39);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(179, 33);
            this.MyHeightLabel.TabIndex = 2;
            this.MyHeightLabel.Text = "My Height:";
            // 
            // HeightTextBoxInches
            // 
            this.HeightTextBoxInches.BackColor = System.Drawing.SystemColors.Control;
            this.HeightTextBoxInches.Location = new System.Drawing.Point(139, 75);
            this.HeightTextBoxInches.MaxLength = 1;
            this.HeightTextBoxInches.Multiline = true;
            this.HeightTextBoxInches.Name = "HeightTextBoxInches";
            this.HeightTextBoxInches.Size = new System.Drawing.Size(62, 30);
            this.HeightTextBoxInches.TabIndex = 5;
            this.HeightTextBoxInches.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FeetLabel
            // 
            this.FeetLabel.AutoSize = true;
            this.FeetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeetLabel.Location = new System.Drawing.Point(71, 72);
            this.FeetLabel.Name = "FeetLabel";
            this.FeetLabel.Size = new System.Drawing.Size(31, 32);
            this.FeetLabel.TabIndex = 10;
            this.FeetLabel.Text = "ft";
            // 
            // InchLabel
            // 
            this.InchLabel.AutoSize = true;
            this.InchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InchLabel.Location = new System.Drawing.Point(207, 72);
            this.InchLabel.Name = "InchLabel";
            this.InchLabel.Size = new System.Drawing.Size(38, 32);
            this.InchLabel.TabIndex = 11;
            this.InchLabel.Text = "in";
            // 
            // LbsLabel
            // 
            this.LbsLabel.AutoSize = true;
            this.LbsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbsLabel.Location = new System.Drawing.Point(207, 144);
            this.LbsLabel.Name = "LbsLabel";
            this.LbsLabel.Size = new System.Drawing.Size(52, 32);
            this.LbsLabel.TabIndex = 12;
            this.LbsLabel.Text = "lbs";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanel1.SetColumnSpan(this.ResetButton, 2);
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(139, 183);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(133, 39);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DisplayTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.DisplayTextBox, 4);
            this.DisplayTextBox.Location = new System.Drawing.Point(3, 251);
            this.DisplayTextBox.Multiline = true;
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.ReadOnly = true;
            this.DisplayTextBox.Size = new System.Drawing.Size(269, 32);
            this.DisplayTextBox.TabIndex = 8;
            this.DisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YourBMIisLabel
            // 
            this.YourBMIisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YourBMIisLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.YourBMIisLabel, 4);
            this.YourBMIisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourBMIisLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.YourBMIisLabel.Location = new System.Drawing.Point(3, 225);
            this.YourBMIisLabel.Name = "YourBMIisLabel";
            this.YourBMIisLabel.Size = new System.Drawing.Size(269, 23);
            this.YourBMIisLabel.TabIndex = 14;
            this.YourBMIisLabel.Text = "Your BMI is";
            this.YourBMIisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMITitlelabel
            // 
            this.BMITitlelabel.AutoSize = true;
            this.BMITitlelabel.BackColor = System.Drawing.Color.Transparent;
            this.BMITitlelabel.Location = new System.Drawing.Point(54, 9);
            this.BMITitlelabel.Name = "BMITitlelabel";
            this.BMITitlelabel.Size = new System.Drawing.Size(241, 39);
            this.BMITitlelabel.TabIndex = 1;
            this.BMITitlelabel.Text = "BMI Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = global::Assignment5_BMIForm.Properties.Resources.lightRedBackground;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BMITitlelabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculator_FormClosing);
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton ImperialRadioButton1;
        private System.Windows.Forms.RadioButton MetricRadioButton2;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label Weightlabel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Label BMITitlelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox HeightTextBoxInches;
        private System.Windows.Forms.Label FeetLabel;
        private System.Windows.Forms.Label InchLabel;
        private System.Windows.Forms.Label LbsLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label YourBMIisLabel;
    }
}

