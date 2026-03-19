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
            this.rolesData = new System.Windows.Forms.DataGridView();
            this.AddRoleAccessRule = new System.Windows.Forms.Button();
            this.SaveRoleAccessRule = new System.Windows.Forms.Button();
            this.DelRoleAccessRule = new System.Windows.Forms.Button();
            this.disData = new System.Windows.Forms.DataGridView();
            this.disDel = new System.Windows.Forms.Button();
            this.disSave = new System.Windows.Forms.Button();
            this.disAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disData)).BeginInit();
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
            this.usersData.Size = new System.Drawing.Size(556, 372);
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
            this.resourceData.Location = new System.Drawing.Point(589, 35);
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
            this.deleteResource.Location = new System.Drawing.Point(604, 413);
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
            this.saveResource.Location = new System.Drawing.Point(880, 413);
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
            this.addResource.Location = new System.Drawing.Point(751, 413);
            this.addResource.Name = "addResource";
            this.addResource.Size = new System.Drawing.Size(99, 27);
            this.addResource.TabIndex = 22;
            this.addResource.Text = "Add";
            this.addResource.UseVisualStyleBackColor = false;
            this.addResource.Click += new System.EventHandler(this.addResource_Click);
            // 
            // rolesData
            // 
            this.rolesData.AllowUserToAddRows = false;
            this.rolesData.AllowUserToDeleteRows = false;
            this.rolesData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rolesData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rolesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesData.Location = new System.Drawing.Point(1022, 35);
            this.rolesData.Margin = new System.Windows.Forms.Padding(1);
            this.rolesData.Name = "rolesData";
            this.rolesData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.rolesData.RowHeadersVisible = false;
            this.rolesData.RowHeadersWidth = 51;
            this.rolesData.RowTemplate.Height = 24;
            this.rolesData.Size = new System.Drawing.Size(474, 372);
            this.rolesData.TabIndex = 23;
            // 
            // AddRoleAccessRule
            // 
            this.AddRoleAccessRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.AddRoleAccessRule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRoleAccessRule.FlatAppearance.BorderSize = 0;
            this.AddRoleAccessRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRoleAccessRule.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoleAccessRule.Location = new System.Drawing.Point(1241, 411);
            this.AddRoleAccessRule.Name = "AddRoleAccessRule";
            this.AddRoleAccessRule.Size = new System.Drawing.Size(99, 27);
            this.AddRoleAccessRule.TabIndex = 24;
            this.AddRoleAccessRule.Text = "Add";
            this.AddRoleAccessRule.UseVisualStyleBackColor = false;
            this.AddRoleAccessRule.Click += new System.EventHandler(this.AddRoleAccessRule_Click);
            // 
            // SaveRoleAccessRule
            // 
            this.SaveRoleAccessRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.SaveRoleAccessRule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveRoleAccessRule.FlatAppearance.BorderSize = 0;
            this.SaveRoleAccessRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveRoleAccessRule.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveRoleAccessRule.Location = new System.Drawing.Point(1397, 414);
            this.SaveRoleAccessRule.Name = "SaveRoleAccessRule";
            this.SaveRoleAccessRule.Size = new System.Drawing.Size(99, 27);
            this.SaveRoleAccessRule.TabIndex = 25;
            this.SaveRoleAccessRule.Text = "Save";
            this.SaveRoleAccessRule.UseVisualStyleBackColor = false;
            this.SaveRoleAccessRule.Click += new System.EventHandler(this.SaveRoleAccessRule_Click);
            // 
            // DelRoleAccessRule
            // 
            this.DelRoleAccessRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.DelRoleAccessRule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelRoleAccessRule.FlatAppearance.BorderSize = 0;
            this.DelRoleAccessRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelRoleAccessRule.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelRoleAccessRule.Location = new System.Drawing.Point(1044, 411);
            this.DelRoleAccessRule.Name = "DelRoleAccessRule";
            this.DelRoleAccessRule.Size = new System.Drawing.Size(99, 27);
            this.DelRoleAccessRule.TabIndex = 26;
            this.DelRoleAccessRule.Text = "Delete";
            this.DelRoleAccessRule.UseVisualStyleBackColor = false;
            this.DelRoleAccessRule.Click += new System.EventHandler(this.DelRoleAccessRule_Click);
            // 
            // disData
            // 
            this.disData.AllowUserToAddRows = false;
            this.disData.AllowUserToDeleteRows = false;
            this.disData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.disData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.disData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disData.Location = new System.Drawing.Point(12, 455);
            this.disData.Margin = new System.Windows.Forms.Padding(1);
            this.disData.Name = "disData";
            this.disData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.disData.RowHeadersVisible = false;
            this.disData.RowHeadersWidth = 51;
            this.disData.RowTemplate.Height = 24;
            this.disData.Size = new System.Drawing.Size(982, 372);
            this.disData.TabIndex = 27;
            // 
            // disDel
            // 
            this.disDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.disDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disDel.FlatAppearance.BorderSize = 0;
            this.disDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disDel.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disDel.Location = new System.Drawing.Point(61, 841);
            this.disDel.Name = "disDel";
            this.disDel.Size = new System.Drawing.Size(99, 27);
            this.disDel.TabIndex = 28;
            this.disDel.Text = "Delete";
            this.disDel.UseVisualStyleBackColor = false;
            this.disDel.Click += new System.EventHandler(this.disDel_Click_1);
            // 
            // disSave
            // 
            this.disSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.disSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disSave.FlatAppearance.BorderSize = 0;
            this.disSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disSave.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disSave.Location = new System.Drawing.Point(880, 841);
            this.disSave.Name = "disSave";
            this.disSave.Size = new System.Drawing.Size(99, 27);
            this.disSave.TabIndex = 30;
            this.disSave.Text = "Save";
            this.disSave.UseVisualStyleBackColor = false;
            this.disSave.Click += new System.EventHandler(this.disSave_Click_1);
            // 
            // disAdd
            // 
            this.disAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.disAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disAdd.FlatAppearance.BorderSize = 0;
            this.disAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disAdd.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disAdd.Location = new System.Drawing.Point(436, 841);
            this.disAdd.Name = "disAdd";
            this.disAdd.Size = new System.Drawing.Size(99, 27);
            this.disAdd.TabIndex = 29;
            this.disAdd.Text = "Add";
            this.disAdd.UseVisualStyleBackColor = false;
            this.disAdd.Click += new System.EventHandler(this.disAdd_Click_1);
            // 
            // AdminPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 916);
            this.Controls.Add(this.disSave);
            this.Controls.Add(this.disAdd);
            this.Controls.Add(this.disDel);
            this.Controls.Add(this.disData);
            this.Controls.Add(this.DelRoleAccessRule);
            this.Controls.Add(this.SaveRoleAccessRule);
            this.Controls.Add(this.AddRoleAccessRule);
            this.Controls.Add(this.rolesData);
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
            ((System.ComponentModel.ISupportInitialize)(this.rolesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disData)).EndInit();
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
        private System.Windows.Forms.DataGridView rolesData;
        private System.Windows.Forms.Button AddRoleAccessRule;
        private System.Windows.Forms.Button SaveRoleAccessRule;
        private System.Windows.Forms.Button DelRoleAccessRule;
        private System.Windows.Forms.DataGridView disData;
        private System.Windows.Forms.Button disDel;
        private System.Windows.Forms.Button disSave;
        private System.Windows.Forms.Button disAdd;
    }
}