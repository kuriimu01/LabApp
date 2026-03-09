namespace LabApp
{
    partial class AdminPannel
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
            this.usersData = new System.Windows.Forms.DataGridView();
            this.saveChanges = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.resourceData = new System.Windows.Forms.DataGridView();
            this.deleteResource = new System.Windows.Forms.Button();
            this.saveResource = new System.Windows.Forms.Button();
            this.addResource = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceData)).BeginInit();
            this.SuspendLayout();
            // 
            // usersData
            // 
            this.usersData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.usersData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.usersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersData.Location = new System.Drawing.Point(12, 35);
            this.usersData.Name = "usersData";
            this.usersData.RowHeadersVisible = false;
            this.usersData.RowHeadersWidth = 51;
            this.usersData.RowTemplate.Height = 24;
            this.usersData.Size = new System.Drawing.Size(577, 372);
            this.usersData.TabIndex = 0;
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.saveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChanges.FlatAppearance.BorderSize = 0;
            this.saveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChanges.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges.Location = new System.Drawing.Point(299, 413);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(99, 27);
            this.saveChanges.TabIndex = 15;
            this.saveChanges.Text = "Save";
            this.saveChanges.UseVisualStyleBackColor = false;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.deleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUser.FlatAppearance.BorderSize = 0;
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUser.Location = new System.Drawing.Point(179, 413);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(99, 27);
            this.deleteUser.TabIndex = 17;
            this.deleteUser.Text = "Delete";
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // resourceData
            // 
            this.resourceData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resourceData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resourceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourceData.Location = new System.Drawing.Point(651, 35);
            this.resourceData.Name = "resourceData";
            this.resourceData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.resourceData.RowHeadersVisible = false;
            this.resourceData.RowHeadersWidth = 51;
            this.resourceData.RowTemplate.Height = 24;
            this.resourceData.Size = new System.Drawing.Size(405, 372);
            this.resourceData.TabIndex = 18;
            // 
            // deleteResource
            // 
            this.deleteResource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.deleteResource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteResource.FlatAppearance.BorderSize = 0;
            this.deleteResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteResource.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteResource.Location = new System.Drawing.Point(651, 413);
            this.deleteResource.Name = "deleteResource";
            this.deleteResource.Size = new System.Drawing.Size(99, 27);
            this.deleteResource.TabIndex = 21;
            this.deleteResource.Text = "Delete";
            this.deleteResource.UseVisualStyleBackColor = false;
            this.deleteResource.Click += new System.EventHandler(this.deleteResource_Click);
            // 
            // saveResource
            // 
            this.saveResource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.saveResource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveResource.FlatAppearance.BorderSize = 0;
            this.saveResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveResource.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveResource.Location = new System.Drawing.Point(957, 413);
            this.saveResource.Name = "saveResource";
            this.saveResource.Size = new System.Drawing.Size(99, 27);
            this.saveResource.TabIndex = 19;
            this.saveResource.Text = "Save";
            this.saveResource.UseVisualStyleBackColor = false;
            this.saveResource.Click += new System.EventHandler(this.saveResource_Click);
            // 
            // addResource
            // 
            this.addResource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.addResource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addResource.FlatAppearance.BorderSize = 0;
            this.addResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addResource.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResource.Location = new System.Drawing.Point(809, 413);
            this.addResource.Name = "addResource";
            this.addResource.Size = new System.Drawing.Size(99, 27);
            this.addResource.TabIndex = 22;
            this.addResource.Text = "Add";
            this.addResource.UseVisualStyleBackColor = false;
            this.addResource.Click += new System.EventHandler(this.addResource_Click);
            // 
            // AdminPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 512);
            this.Controls.Add(this.addResource);
            this.Controls.Add(this.deleteResource);
            this.Controls.Add(this.saveResource);
            this.Controls.Add(this.resourceData);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.usersData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminPannel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPannel";
            this.Load += new System.EventHandler(this.AdminPannel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersData;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.DataGridView resourceData;
        private System.Windows.Forms.Button deleteResource;
        private System.Windows.Forms.Button saveResource;
        private System.Windows.Forms.Button addResource;
    }
}