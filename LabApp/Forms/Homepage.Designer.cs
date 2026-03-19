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
            this.resourceData = new System.Windows.Forms.DataGridView();
            this.openButton = new System.Windows.Forms.Button();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resourceData)).BeginInit();
            this.SuspendLayout();
            // 
            // HelloUsername
            // 
            this.HelloUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HelloUsername.Dock = System.Windows.Forms.DockStyle.Left;
            this.HelloUsername.Font = new System.Drawing.Font("Poppins Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloUsername.Location = new System.Drawing.Point(0, 0);
            this.HelloUsername.Name = "HelloUsername";
            this.HelloUsername.Size = new System.Drawing.Size(798, 574);
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
            this.LogOutLabel.Location = new System.Drawing.Point(0, 519);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(798, 55);
            this.LogOutLabel.TabIndex = 16;
            this.LogOutLabel.Text = "Log Out";
            this.LogOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
            // 
            // resourceData
            // 
            this.resourceData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resourceData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resourceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourceData.Location = new System.Drawing.Point(65, 117);
            this.resourceData.Name = "resourceData";
            this.resourceData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.resourceData.RowHeadersVisible = false;
            this.resourceData.RowHeadersWidth = 51;
            this.resourceData.RowTemplate.Height = 24;
            this.resourceData.Size = new System.Drawing.Size(680, 346);
            this.resourceData.TabIndex = 19;
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.openButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(332, 469);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(129, 33);
            this.openButton.TabIndex = 20;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RoleLabel.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(12, 6);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(67, 31);
            this.RoleLabel.TabIndex = 21;
            this.RoleLabel.Text = "Role: ";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(65, 469);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(129, 33);
            this.refreshButton.TabIndex = 22;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 574);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.resourceData);
            this.Controls.Add(this.LogOutLabel);
            this.Controls.Add(this.ChangePassButton);
            this.Controls.Add(this.HelloUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage TBD_But";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resourceData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloUsername;
        private System.Windows.Forms.Button ChangePassButton;
        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.DataGridView resourceData;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Button refreshButton;
    }
}