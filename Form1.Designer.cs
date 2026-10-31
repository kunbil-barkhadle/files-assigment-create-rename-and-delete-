namespace craete_new_file
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOldName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtNewFileName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(0, -4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(804, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "File Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOldName
            // 
            this.lblOldName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblOldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOldName.Location = new System.Drawing.Point(265, 77);
            this.lblOldName.Name = "lblOldName";
            this.lblOldName.Size = new System.Drawing.Size(194, 30);
            this.lblOldName.TabIndex = 1;
            this.lblOldName.Text = "Current File Name";
            this.lblOldName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(268, 110);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(191, 20);
            this.txtFileName.TabIndex = 2;
            // 
            // lblNewName
            // 
            this.lblNewName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewName.Location = new System.Drawing.Point(265, 133);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(194, 30);
            this.lblNewName.TabIndex = 3;
            this.lblNewName.Text = "New File Name";
            this.lblNewName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewFileName
            // 
            this.txtNewFileName.Location = new System.Drawing.Point(268, 166);
            this.txtNewFileName.Name = "txtNewFileName";
            this.txtNewFileName.Size = new System.Drawing.Size(191, 20);
            this.txtNewFileName.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Location = new System.Drawing.Point(268, 192);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(191, 28);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create File";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRename
            // 
            this.btnRename.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRename.Location = new System.Drawing.Point(268, 226);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(191, 28);
            this.btnRename.TabIndex = 6;
            this.btnRename.Text = "Rename File";
            this.btnRename.UseVisualStyleBackColor = false;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(268, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete File";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtNewFileName);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblOldName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOldName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtNewFileName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnDelete;
    }
}

