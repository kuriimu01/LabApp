namespace LabApp
{
    partial class Login
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignInRedirect = new System.Windows.Forms.Label();
            this.StrongPassCheckbox = new System.Windows.Forms.CheckBox();
            this.BruteRedirect = new System.Windows.Forms.Button();
            this.TestBot = new System.Windows.Forms.Button();
            this.BiometricLoginButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddFace = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(84)))), ((int)(((byte)(30)))));
            this.errorLabel.Location = new System.Drawing.Point(0, 87);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(512, 45);
            this.errorLabel.TabIndex = 16;
            this.errorLabel.Text = "label2";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.Enabled = false;
            this.LogInButton.FlatAppearance.BorderSize = 0;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.Location = new System.Drawing.Point(206, 260);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(90, 32);
            this.LogInButton.TabIndex = 14;
            this.LogInButton.Text = "submit";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.Location = new System.Drawing.Point(160, 195);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(188, 30);
            this.PasswordField.TabIndex = 13;
            this.PasswordField.UseSystemPasswordChar = true;
            this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginField.Location = new System.Drawing.Point(160, 134);
            this.LoginField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginField.MaxLength = 20;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(188, 37);
            this.LoginField.TabIndex = 12;
            this.LoginField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
            // 
            // LogInLabel
            // 
            this.LogInLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogInLabel.Enabled = false;
            this.LogInLabel.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LogInLabel.Location = new System.Drawing.Point(0, 22);
            this.LogInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.LogInLabel.Size = new System.Drawing.Size(512, 427);
            this.LogInLabel.TabIndex = 11;
            this.LogInLabel.Text = "Log In";
            this.LogInLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAuthorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(512, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutAuthorToolStripMenuItem
            // 
            this.aboutAuthorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorToolStripMenuItem});
            this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
            this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.aboutAuthorToolStripMenuItem.Text = "About Author";
            // 
            // AuthorToolStripMenuItem
            // 
            this.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem";
            this.AuthorToolStripMenuItem.Size = new System.Drawing.Size(350, 26);
            this.AuthorToolStripMenuItem.Text = "Бут Даниїл Романович, БІ-125-22-2-Б";
            // 
            // SignInRedirect
            // 
            this.SignInRedirect.AutoSize = true;
            this.SignInRedirect.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInRedirect.Location = new System.Drawing.Point(229, 302);
            this.SignInRedirect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignInRedirect.Name = "SignInRedirect";
            this.SignInRedirect.Size = new System.Drawing.Size(63, 26);
            this.SignInRedirect.TabIndex = 20;
            this.SignInRedirect.Text = "Sign In";
            this.SignInRedirect.Click += new System.EventHandler(this.SignInRedirect_Click);
            // 
            // StrongPassCheckbox
            // 
            this.StrongPassCheckbox.AutoSize = true;
            this.StrongPassCheckbox.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrongPassCheckbox.Location = new System.Drawing.Point(160, 233);
            this.StrongPassCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StrongPassCheckbox.Name = "StrongPassCheckbox";
            this.StrongPassCheckbox.Size = new System.Drawing.Size(169, 27);
            this.StrongPassCheckbox.TabIndex = 15;
            this.StrongPassCheckbox.Text = "Use strong password";
            this.StrongPassCheckbox.UseVisualStyleBackColor = true;
            this.StrongPassCheckbox.Visible = false;
            this.StrongPassCheckbox.CheckedChanged += new System.EventHandler(this.StrongPassCheckbox_CheckedChanged);
            // 
            // BruteRedirect
            // 
            this.BruteRedirect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.BruteRedirect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BruteRedirect.FlatAppearance.BorderSize = 0;
            this.BruteRedirect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BruteRedirect.Font = new System.Drawing.Font("Poppins", 10F);
            this.BruteRedirect.Location = new System.Drawing.Point(57, 411);
            this.BruteRedirect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BruteRedirect.Name = "BruteRedirect";
            this.BruteRedirect.Size = new System.Drawing.Size(119, 27);
            this.BruteRedirect.TabIndex = 21;
            this.BruteRedirect.Text = "Brute Force";
            this.BruteRedirect.UseVisualStyleBackColor = false;
            // 
            // TestBot
            // 
            this.TestBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.TestBot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestBot.FlatAppearance.BorderSize = 0;
            this.TestBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestBot.Font = new System.Drawing.Font("Poppins", 10F);
            this.TestBot.Location = new System.Drawing.Point(57, 380);
            this.TestBot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TestBot.Name = "TestBot";
            this.TestBot.Size = new System.Drawing.Size(119, 27);
            this.TestBot.TabIndex = 22;
            this.TestBot.Text = "Test Bot";
            this.TestBot.UseVisualStyleBackColor = false;
            this.TestBot.Click += new System.EventHandler(this.TestBot_Click);
            // 
            // BiometricLoginButton
            // 
            this.BiometricLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.BiometricLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BiometricLoginButton.FlatAppearance.BorderSize = 0;
            this.BiometricLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BiometricLoginButton.Font = new System.Drawing.Font("Poppins", 10F);
            this.BiometricLoginButton.Location = new System.Drawing.Point(306, 380);
            this.BiometricLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.BiometricLoginButton.Name = "BiometricLoginButton";
            this.BiometricLoginButton.Size = new System.Drawing.Size(119, 30);
            this.BiometricLoginButton.TabIndex = 23;
            this.BiometricLoginButton.Text = "Face Login";
            this.BiometricLoginButton.UseVisualStyleBackColor = false;
            this.BiometricLoginButton.Click += new System.EventHandler(this.BiometricLoginButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LabApp.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(143, 203);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 13);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LabApp.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(143, 143);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 13);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // AddFace
            // 
            this.AddFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.AddFace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFace.FlatAppearance.BorderSize = 0;
            this.AddFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFace.Font = new System.Drawing.Font("Poppins", 10F);
            this.AddFace.Location = new System.Drawing.Point(306, 414);
            this.AddFace.Margin = new System.Windows.Forms.Padding(2);
            this.AddFace.Name = "AddFace";
            this.AddFace.Size = new System.Drawing.Size(119, 30);
            this.AddFace.TabIndex = 24;
            this.AddFace.Text = "Add Face";
            this.AddFace.UseVisualStyleBackColor = false;
            this.AddFace.Click += new System.EventHandler(this.AddFace_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(512, 449);
            this.Controls.Add(this.AddFace);
            this.Controls.Add(this.BiometricLoginButton);
            this.Controls.Add(this.TestBot);
            this.Controls.Add(this.BruteRedirect);
            this.Controls.Add(this.SignInRedirect);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.StrongPassCheckbox);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.LogInLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TBD_But";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AuthorToolStripMenuItem;
        private System.Windows.Forms.Label SignInRedirect;
        private System.Windows.Forms.CheckBox StrongPassCheckbox;
        private System.Windows.Forms.Button BruteRedirect;
        private System.Windows.Forms.Button TestBot;
        private System.Windows.Forms.Button BiometricLoginButton;
        private System.Windows.Forms.Button AddFace;
    }
}