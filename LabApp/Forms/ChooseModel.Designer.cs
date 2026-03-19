namespace LabApp.Forms
{
    partial class ChooseModel
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
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.ModelCombo = new System.Windows.Forms.ComboBox();
            this.saveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ChooseLabel.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseLabel.Location = new System.Drawing.Point(184, 23);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(412, 58);
            this.ChooseLabel.TabIndex = 22;
            this.ChooseLabel.Text = "Choose security model";
            // 
            // ModelCombo
            // 
            this.ModelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelCombo.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelCombo.Location = new System.Drawing.Point(181, 170);
            this.ModelCombo.Name = "ModelCombo";
            this.ModelCombo.Size = new System.Drawing.Size(404, 44);
            this.ModelCombo.TabIndex = 23;
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(177)))));
            this.saveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChanges.FlatAppearance.BorderSize = 0;
            this.saveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChanges.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges.Location = new System.Drawing.Point(334, 352);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(99, 27);
            this.saveChanges.TabIndex = 24;
            this.saveChanges.Text = "Save";
            this.saveChanges.UseVisualStyleBackColor = false;
            this.saveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // ChooseModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.ModelCombo);
            this.Controls.Add(this.ChooseLabel);
            this.Name = "ChooseModel";
            this.Text = "TBD_But Select model";
            this.Load += new System.EventHandler(this.ChooseModel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.ComboBox ModelCombo;
        private System.Windows.Forms.Button saveChanges;
    }
}