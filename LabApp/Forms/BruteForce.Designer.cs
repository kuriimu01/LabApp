namespace LabApp.Forms
{
    partial class BruteForce
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
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.MinLengthNum = new System.Windows.Forms.NumericUpDown();
            this.MaxLengthNum = new System.Windows.Forms.NumericUpDown();
            this.ChbLatinLower = new System.Windows.Forms.CheckBox();
            this.ChbLatinUpper = new System.Windows.Forms.CheckBox();
            this.ChbDigits = new System.Windows.Forms.CheckBox();
            this.ChbSpecial = new System.Windows.Forms.CheckBox();
            this.ChbCyrillic = new System.Windows.Forms.CheckBox();
            this.BtnCalculateTime = new System.Windows.Forms.Button();
            this.BtnStartBruteForce = new System.Windows.Forms.Button();
            this.LblAttempts = new System.Windows.Forms.Label();
            this.LblEstimatedTime = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.LblTimeElapsed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinLengthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLengthNum)).BeginInit();
            this.SuspendLayout();
            // 
            // UserComboBox
            // 
            this.UserComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(350, 35);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(155, 24);
            this.UserComboBox.TabIndex = 0;
            // 
            // MinLengthNum
            // 
            this.MinLengthNum.Location = new System.Drawing.Point(262, 90);
            this.MinLengthNum.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MinLengthNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinLengthNum.Name = "MinLengthNum";
            this.MinLengthNum.Size = new System.Drawing.Size(120, 22);
            this.MinLengthNum.TabIndex = 1;
            this.MinLengthNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaxLengthNum
            // 
            this.MaxLengthNum.Location = new System.Drawing.Point(466, 90);
            this.MaxLengthNum.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MaxLengthNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxLengthNum.Name = "MaxLengthNum";
            this.MaxLengthNum.Size = new System.Drawing.Size(120, 22);
            this.MaxLengthNum.TabIndex = 2;
            this.MaxLengthNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ChbLatinLower
            // 
            this.ChbLatinLower.AutoSize = true;
            this.ChbLatinLower.Location = new System.Drawing.Point(262, 132);
            this.ChbLatinLower.Name = "ChbLatinLower";
            this.ChbLatinLower.Size = new System.Drawing.Size(47, 20);
            this.ChbLatinLower.TabIndex = 3;
            this.ChbLatinLower.Text = "a-z";
            this.ChbLatinLower.UseVisualStyleBackColor = true;
            // 
            // ChbLatinUpper
            // 
            this.ChbLatinUpper.AutoSize = true;
            this.ChbLatinUpper.Location = new System.Drawing.Point(262, 158);
            this.ChbLatinUpper.Name = "ChbLatinUpper";
            this.ChbLatinUpper.Size = new System.Drawing.Size(50, 20);
            this.ChbLatinUpper.TabIndex = 4;
            this.ChbLatinUpper.Text = "A-Z";
            this.ChbLatinUpper.UseVisualStyleBackColor = true;
            // 
            // ChbDigits
            // 
            this.ChbDigits.AutoSize = true;
            this.ChbDigits.Location = new System.Drawing.Point(466, 158);
            this.ChbDigits.Name = "ChbDigits";
            this.ChbDigits.Size = new System.Drawing.Size(47, 20);
            this.ChbDigits.TabIndex = 5;
            this.ChbDigits.Text = "0-9";
            this.ChbDigits.UseVisualStyleBackColor = true;
            // 
            // ChbSpecial
            // 
            this.ChbSpecial.AutoSize = true;
            this.ChbSpecial.Location = new System.Drawing.Point(466, 132);
            this.ChbSpecial.Name = "ChbSpecial";
            this.ChbSpecial.Size = new System.Drawing.Size(53, 20);
            this.ChbSpecial.TabIndex = 6;
            this.ChbSpecial.Text = "!@#";
            this.ChbSpecial.UseVisualStyleBackColor = true;
            // 
            // ChbCyrillic
            // 
            this.ChbCyrillic.AutoSize = true;
            this.ChbCyrillic.Location = new System.Drawing.Point(262, 184);
            this.ChbCyrillic.Name = "ChbCyrillic";
            this.ChbCyrillic.Size = new System.Drawing.Size(48, 20);
            this.ChbCyrillic.TabIndex = 7;
            this.ChbCyrillic.Text = "а-я";
            this.ChbCyrillic.UseVisualStyleBackColor = true;
            // 
            // BtnCalculateTime
            // 
            this.BtnCalculateTime.Location = new System.Drawing.Point(291, 249);
            this.BtnCalculateTime.Name = "BtnCalculateTime";
            this.BtnCalculateTime.Size = new System.Drawing.Size(130, 23);
            this.BtnCalculateTime.TabIndex = 8;
            this.BtnCalculateTime.Text = "Calculate Time";
            this.BtnCalculateTime.UseVisualStyleBackColor = true;
            this.BtnCalculateTime.Click += new System.EventHandler(this.BtnCalculateTime_Click);
            // 
            // BtnStartBruteForce
            // 
            this.BtnStartBruteForce.Location = new System.Drawing.Point(427, 249);
            this.BtnStartBruteForce.Name = "BtnStartBruteForce";
            this.BtnStartBruteForce.Size = new System.Drawing.Size(130, 23);
            this.BtnStartBruteForce.TabIndex = 9;
            this.BtnStartBruteForce.Text = "Start Brute Force";
            this.BtnStartBruteForce.UseVisualStyleBackColor = true;
            this.BtnStartBruteForce.Click += new System.EventHandler(this.BtnStartBruteForce_Click);
            // 
            // LblAttempts
            // 
            this.LblAttempts.AutoSize = true;
            this.LblAttempts.Location = new System.Drawing.Point(12, 9);
            this.LblAttempts.Name = "LblAttempts";
            this.LblAttempts.Size = new System.Drawing.Size(77, 16);
            this.LblAttempts.TabIndex = 10;
            this.LblAttempts.Text = "LblAttempts";
            // 
            // LblEstimatedTime
            // 
            this.LblEstimatedTime.AutoSize = true;
            this.LblEstimatedTime.Location = new System.Drawing.Point(21, 316);
            this.LblEstimatedTime.Name = "LblEstimatedTime";
            this.LblEstimatedTime.Size = new System.Drawing.Size(116, 16);
            this.LblEstimatedTime.TabIndex = 11;
            this.LblEstimatedTime.Text = "LblEstimatedTime";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(368, 220);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(63, 16);
            this.LblResult.TabIndex = 12;
            this.LblResult.Text = "LblResult";
            // 
            // LblTimeElapsed
            // 
            this.LblTimeElapsed.AutoSize = true;
            this.LblTimeElapsed.Location = new System.Drawing.Point(12, 35);
            this.LblTimeElapsed.Name = "LblTimeElapsed";
            this.LblTimeElapsed.Size = new System.Drawing.Size(107, 16);
            this.LblTimeElapsed.TabIndex = 13;
            this.LblTimeElapsed.Text = "LblTimeElapsed";
            // 
            // BruteForce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 362);
            this.Controls.Add(this.LblTimeElapsed);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LblEstimatedTime);
            this.Controls.Add(this.LblAttempts);
            this.Controls.Add(this.BtnStartBruteForce);
            this.Controls.Add(this.BtnCalculateTime);
            this.Controls.Add(this.ChbCyrillic);
            this.Controls.Add(this.ChbSpecial);
            this.Controls.Add(this.ChbDigits);
            this.Controls.Add(this.ChbLatinUpper);
            this.Controls.Add(this.ChbLatinLower);
            this.Controls.Add(this.MaxLengthNum);
            this.Controls.Add(this.MinLengthNum);
            this.Controls.Add(this.UserComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BruteForce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BruteForce";
            this.Load += new System.EventHandler(this.BruteForce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinLengthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLengthNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UserComboBox;
        private System.Windows.Forms.NumericUpDown MinLengthNum;
        private System.Windows.Forms.NumericUpDown MaxLengthNum;
        private System.Windows.Forms.CheckBox ChbLatinLower;
        private System.Windows.Forms.CheckBox ChbLatinUpper;
        private System.Windows.Forms.CheckBox ChbDigits;
        private System.Windows.Forms.CheckBox ChbSpecial;
        private System.Windows.Forms.CheckBox ChbCyrillic;
        private System.Windows.Forms.Button BtnCalculateTime;
        private System.Windows.Forms.Button BtnStartBruteForce;
        private System.Windows.Forms.Label LblAttempts;
        private System.Windows.Forms.Label LblEstimatedTime;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label LblTimeElapsed;
    }
}