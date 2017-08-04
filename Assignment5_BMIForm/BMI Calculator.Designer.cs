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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Weightlabel = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.MetricRadioButton2 = new System.Windows.Forms.RadioButton();
            this.MyHeightLabel1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BMITitlelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadioButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Weightlabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CalculateBMIButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.MetricRadioButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MyHeightLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 43);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28438F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28437F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28437F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28437F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28437F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.289F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.28913F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 290);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ImperialRadioButton1
            // 
            this.ImperialRadioButton1.AutoSize = true;
            this.ImperialRadioButton1.Location = new System.Drawing.Point(3, 3);
            this.ImperialRadioButton1.Name = "ImperialRadioButton1";
            this.ImperialRadioButton1.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioButton1.TabIndex = 0;
            this.ImperialRadioButton1.TabStop = true;
            this.ImperialRadioButton1.Text = "Imperial";
            this.ImperialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.IndianRed;
            this.textBox1.Location = new System.Drawing.Point(3, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 38);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.IndianRed;
            this.textBox2.Location = new System.Drawing.Point(140, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 38);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.IndianRed;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox3, 2);
            this.textBox3.Location = new System.Drawing.Point(3, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(269, 38);
            this.textBox3.TabIndex = 5;
            // 
            // Weightlabel
            // 
            this.Weightlabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Weightlabel, 2);
            this.Weightlabel.Location = new System.Drawing.Point(3, 123);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(149, 31);
            this.Weightlabel.TabIndex = 6;
            this.Weightlabel.Text = "My Weight:";
            this.Weightlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel1.SetColumnSpan(this.CalculateBMIButton, 2);
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 208);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(269, 38);
            this.CalculateBMIButton.TabIndex = 7;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            // 
            // MetricRadioButton2
            // 
            this.MetricRadioButton2.AutoSize = true;
            this.MetricRadioButton2.Location = new System.Drawing.Point(140, 3);
            this.MetricRadioButton2.Name = "MetricRadioButton2";
            this.MetricRadioButton2.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton2.TabIndex = 1;
            this.MetricRadioButton2.TabStop = true;
            this.MetricRadioButton2.Text = "Metric";
            this.MetricRadioButton2.UseVisualStyleBackColor = true;
            // 
            // MyHeightLabel1
            // 
            this.MyHeightLabel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.MyHeightLabel1, 2);
            this.MyHeightLabel1.Location = new System.Drawing.Point(3, 41);
            this.MyHeightLabel1.Name = "MyHeightLabel1";
            this.MyHeightLabel1.Size = new System.Drawing.Size(144, 31);
            this.MyHeightLabel1.TabIndex = 2;
            this.MyHeightLabel1.Text = "My Height:";
            // 
            // textBox4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox4, 2);
            this.textBox4.Location = new System.Drawing.Point(3, 252);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(269, 35);
            this.textBox4.TabIndex = 8;
            // 
            // BMITitlelabel
            // 
            this.BMITitlelabel.AutoSize = true;
            this.BMITitlelabel.BackColor = System.Drawing.Color.Maroon;
            this.BMITitlelabel.Location = new System.Drawing.Point(54, 9);
            this.BMITitlelabel.Name = "BMITitlelabel";
            this.BMITitlelabel.Size = new System.Drawing.Size(192, 31);
            this.BMITitlelabel.TabIndex = 1;
            this.BMITitlelabel.Text = "BMI Calculator";
            this.BMITitlelabel.Click += new System.EventHandler(this.BMITitlelabel_Click);
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
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(304, 441);
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
        private System.Windows.Forms.Label MyHeightLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Weightlabel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label BMITitlelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

