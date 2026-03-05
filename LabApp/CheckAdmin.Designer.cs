namespace LabApp
{
    partial class CheckAdmin
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
            this.PassAdminField = new System.Windows.Forms.TextBox();
            this.ChangePassButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PassAdminField
            // 
            this.PassAdminField.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassAdminField.Location = new System.Drawing.Point(255, 193);
            this.PassAdminField.MaxLength = 20;
            this.PassAdminField.Name = "PassAdminField";
            this.PassAdminField.Size = new System.Drawing.Size(249, 37);
            this.PassAdminField.TabIndex = 14;
            this.PassAdminField.UseSystemPasswordChar = true;
            // 
            // ChangePassButton
            // 
            this.ChangePassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.ChangePassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePassButton.FlatAppearance.BorderSize = 0;
            this.ChangePassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassButton.Location = new System.Drawing.Point(320, 285);
            this.ChangePassButton.Name = "ChangePassButton";
            this.ChangePassButton.Size = new System.Drawing.Size(120, 39);
            this.ChangePassButton.TabIndex = 21;
            this.ChangePassButton.Text = "submit";
            this.ChangePassButton.UseVisualStyleBackColor = false;
            this.ChangePassButton.Click += new System.EventHandler(this.ChangePassButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 50);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enter Admin Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CheckAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangePassButton);
            this.Controls.Add(this.PassAdminField);
            this.Name = "CheckAdmin";
            this.Text = "CheckAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassAdminField;
        private System.Windows.Forms.Button ChangePassButton;
        private System.Windows.Forms.Label label1;
    }
}