namespace RateInterest
{
    partial class Form1
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
            this.creditAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.annualRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.amountOfDays = new System.Windows.Forms.TextBox();
            this.periodTermPanel = new System.Windows.Forms.Panel();
            this.toTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.amountRB = new System.Windows.Forms.RadioButton();
            this.periodRB = new System.Windows.Forms.RadioButton();
            this.amountDaysLabel = new System.Windows.Forms.Label();
            this.periodTermPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // creditAmount
            // 
            this.creditAmount.Location = new System.Drawing.Point(158, 38);
            this.creditAmount.Name = "creditAmount";
            this.creditAmount.Size = new System.Drawing.Size(200, 20);
            this.creditAmount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Credit amount, euro";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(221, 246);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(90, 22);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Annual percentage rate, %";
            // 
            // annualRate
            // 
            this.annualRate.Location = new System.Drawing.Point(158, 204);
            this.annualRate.Name = "annualRate";
            this.annualRate.Size = new System.Drawing.Size(200, 20);
            this.annualRate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Term of credit:";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(83, 245);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(90, 22);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // amountOfDays
            // 
            this.amountOfDays.Location = new System.Drawing.Point(158, 135);
            this.amountOfDays.Name = "amountOfDays";
            this.amountOfDays.Size = new System.Drawing.Size(200, 20);
            this.amountOfDays.TabIndex = 13;
            this.amountOfDays.Visible = false;
            // 
            // periodTermPanel
            // 
            this.periodTermPanel.Controls.Add(this.toTime);
            this.periodTermPanel.Controls.Add(this.label4);
            this.periodTermPanel.Controls.Add(this.fromDate);
            this.periodTermPanel.Controls.Add(this.label2);
            this.periodTermPanel.Location = new System.Drawing.Point(29, 107);
            this.periodTermPanel.Name = "periodTermPanel";
            this.periodTermPanel.Size = new System.Drawing.Size(329, 79);
            this.periodTermPanel.TabIndex = 14;
            // 
            // toTime
            // 
            this.toTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toTime.Location = new System.Drawing.Point(129, 40);
            this.toTime.Name = "toTime";
            this.toTime.Size = new System.Drawing.Size(200, 20);
            this.toTime.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "To";
            // 
            // fromDate
            // 
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate.Location = new System.Drawing.Point(129, 12);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(200, 20);
            this.fromDate.TabIndex = 11;
            this.fromDate.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "From";
            // 
            // amountRB
            // 
            this.amountRB.AutoSize = true;
            this.amountRB.Location = new System.Drawing.Point(273, 75);
            this.amountRB.Name = "amountRB";
            this.amountRB.Size = new System.Drawing.Size(85, 17);
            this.amountRB.TabIndex = 15;
            this.amountRB.Text = "days amount";
            this.amountRB.UseVisualStyleBackColor = true;
            this.amountRB.CheckedChanged += new System.EventHandler(this.amountRB_CheckedChanged);
            // 
            // periodRB
            // 
            this.periodRB.AutoSize = true;
            this.periodRB.Checked = true;
            this.periodRB.Location = new System.Drawing.Point(158, 75);
            this.periodRB.Name = "periodRB";
            this.periodRB.Size = new System.Drawing.Size(78, 17);
            this.periodRB.TabIndex = 16;
            this.periodRB.TabStop = true;
            this.periodRB.Text = "date period";
            this.periodRB.UseVisualStyleBackColor = true;
            // 
            // amountDaysLabel
            // 
            this.amountDaysLabel.AutoSize = true;
            this.amountDaysLabel.Location = new System.Drawing.Point(43, 142);
            this.amountDaysLabel.Name = "amountDaysLabel";
            this.amountDaysLabel.Size = new System.Drawing.Size(84, 13);
            this.amountDaysLabel.TabIndex = 17;
            this.amountDaysLabel.Text = "Number of days:";
            this.amountDaysLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 294);
            this.Controls.Add(this.amountDaysLabel);
            this.Controls.Add(this.periodRB);
            this.Controls.Add(this.amountRB);
            this.Controls.Add(this.periodTermPanel);
            this.Controls.Add(this.amountOfDays);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.annualRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creditAmount);
            this.Name = "Form1";
            this.Text = "Rate Interest Calculation";
            this.periodTermPanel.ResumeLayout(false);
            this.periodTermPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox creditAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox annualRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox amountOfDays;
        private System.Windows.Forms.Panel periodTermPanel;
        private System.Windows.Forms.DateTimePicker toTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton amountRB;
        private System.Windows.Forms.RadioButton periodRB;
        private System.Windows.Forms.Label amountDaysLabel;
    }
}

