namespace LabApp
{
    partial class ChangePassword
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
            this.NewPasswordField = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordField = new System.Windows.Forms.TextBox();
            this.PasswordChangeLabel = new System.Windows.Forms.Label();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.EnterLabel = new System.Windows.Forms.Label();
            this.BackToHomepage = new System.Windows.Forms.Label();
            this.ChangePassButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.IsStrongPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewPasswordField
            // 
            this.NewPasswordField.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordField.Location = new System.Drawing.Point(276, 227);
            this.NewPasswordField.MaxLength = 20;
            this.NewPasswordField.Name = "NewPasswordField";
            this.NewPasswordField.Size = new System.Drawing.Size(249, 37);
            this.NewPasswordField.TabIndex = 13;
            this.NewPasswordField.UseSystemPasswordChar = true;
            this.NewPasswordField.TextChanged += new System.EventHandler(this.NewPasswordField_TextChanged);
            // 
            // ConfirmPasswordField
            // 
            this.ConfirmPasswordField.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordField.Location = new System.Drawing.Point(276, 300);
            this.ConfirmPasswordField.MaxLength = 20;
            this.ConfirmPasswordField.Name = "ConfirmPasswordField";
            this.ConfirmPasswordField.Size = new System.Drawing.Size(249, 37);
            this.ConfirmPasswordField.TabIndex = 14;
            this.ConfirmPasswordField.UseSystemPasswordChar = true;
            // 
            // PasswordChangeLabel
            // 
            this.PasswordChangeLabel.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordChangeLabel.Location = new System.Drawing.Point(-9, 30);
            this.PasswordChangeLabel.Name = "PasswordChangeLabel";
            this.PasswordChangeLabel.Size = new System.Drawing.Size(816, 64);
            this.PasswordChangeLabel.TabIndex = 15;
            this.PasswordChangeLabel.Text = "Changing Password";
            this.PasswordChangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassLabel.Location = new System.Drawing.Point(271, 271);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(152, 26);
            this.ConfirmPassLabel.TabIndex = 17;
            this.ConfirmPassLabel.Text = "Confirm password";
            // 
            // EnterLabel
            // 
            this.EnterLabel.AutoSize = true;
            this.EnterLabel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterLabel.Location = new System.Drawing.Point(271, 198);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(163, 26);
            this.EnterLabel.TabIndex = 18;
            this.EnterLabel.Text = "Enter new password";
            // 
            // BackToHomepage
            // 
            this.BackToHomepage.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToHomepage.Location = new System.Drawing.Point(345, 456);
            this.BackToHomepage.Name = "BackToHomepage";
            this.BackToHomepage.Size = new System.Drawing.Size(89, 26);
            this.BackToHomepage.TabIndex = 19;
            this.BackToHomepage.Text = "Back";
            this.BackToHomepage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackToHomepage.Click += new System.EventHandler(this.BackToHomepage_Click);
            // 
            // ChangePassButton
            // 
            this.ChangePassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.ChangePassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePassButton.Enabled = false;
            this.ChangePassButton.FlatAppearance.BorderSize = 0;
            this.ChangePassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassButton.Location = new System.Drawing.Point(333, 385);
            this.ChangePassButton.Name = "ChangePassButton";
            this.ChangePassButton.Size = new System.Drawing.Size(120, 39);
            this.ChangePassButton.TabIndex = 20;
            this.ChangePassButton.Text = "submit";
            this.ChangePassButton.UseVisualStyleBackColor = false;
            this.ChangePassButton.Click += new System.EventHandler(this.ChangePassButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(84)))), ((int)(((byte)(30)))));
            this.errorLabel.Location = new System.Drawing.Point(-14, 81);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(801, 46);
            this.errorLabel.TabIndex = 22;
            this.errorLabel.Text = "error";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IsStrongPassword
            // 
            this.IsStrongPassword.AutoSize = true;
            this.IsStrongPassword.Location = new System.Drawing.Point(273, 350);
            this.IsStrongPassword.Name = "IsStrongPassword";
            this.IsStrongPassword.Size = new System.Drawing.Size(167, 16);
            this.IsStrongPassword.TabIndex = 23;
            this.IsStrongPassword.Text = "Strong password required: ";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.IsStrongPassword);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.ChangePassButton);
            this.Controls.Add(this.BackToHomepage);
            this.Controls.Add(this.EnterLabel);
            this.Controls.Add(this.ConfirmPassLabel);
            this.Controls.Add(this.PasswordChangeLabel);
            this.Controls.Add(this.ConfirmPasswordField);
            this.Controls.Add(this.NewPasswordField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewPasswordField;
        private System.Windows.Forms.TextBox ConfirmPasswordField;
        private System.Windows.Forms.Label PasswordChangeLabel;
        private System.Windows.Forms.Label ConfirmPassLabel;
        private System.Windows.Forms.Label EnterLabel;
        private System.Windows.Forms.Label BackToHomepage;
        private System.Windows.Forms.Button ChangePassButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label IsStrongPassword;
    }
}