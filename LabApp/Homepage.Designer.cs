namespace LabApp
{
    partial class Homepage
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
            this.HelloUsername = new System.Windows.Forms.Label();
            this.ChangePassButton = new System.Windows.Forms.Button();
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelloUsername
            // 
            this.HelloUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HelloUsername.Dock = System.Windows.Forms.DockStyle.Left;
            this.HelloUsername.Font = new System.Drawing.Font("Poppins Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloUsername.Location = new System.Drawing.Point(0, 0);
            this.HelloUsername.Name = "HelloUsername";
            this.HelloUsername.Size = new System.Drawing.Size(798, 450);
            this.HelloUsername.TabIndex = 0;
            this.HelloUsername.Text = "Username: ";
            this.HelloUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChangePassButton
            // 
            this.ChangePassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.ChangePassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePassButton.FlatAppearance.BorderSize = 0;
            this.ChangePassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassButton.Location = new System.Drawing.Point(267, 58);
            this.ChangePassButton.Name = "ChangePassButton";
            this.ChangePassButton.Size = new System.Drawing.Size(257, 39);
            this.ChangePassButton.TabIndex = 15;
            this.ChangePassButton.Text = "Change Password";
            this.ChangePassButton.UseVisualStyleBackColor = false;
            this.ChangePassButton.Click += new System.EventHandler(this.ChangePassButton_Click);
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LogOutLabel.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LogOutLabel.Location = new System.Drawing.Point(1, 395);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(798, 55);
            this.LogOutLabel.TabIndex = 16;
            this.LogOutLabel.Text = "Log Out";
            this.LogOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOutLabel);
            this.Controls.Add(this.ChangePassButton);
            this.Controls.Add(this.HelloUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Homepage";
            this.Text = "Homepage TBD_But";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HelloUsername;
        private System.Windows.Forms.Button ChangePassButton;
        private System.Windows.Forms.Label LogOutLabel;
    }
}