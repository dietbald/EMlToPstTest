namespace EMlToPstTest
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
            this.emlFolderSelection = new System.Windows.Forms.Button();
            this.pstFolderSelect = new System.Windows.Forms.Button();
            this.folderInputPath = new System.Windows.Forms.TextBox();
            this.pstOutputPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emlFolderSelection
            // 
            this.emlFolderSelection.Location = new System.Drawing.Point(684, 325);
            this.emlFolderSelection.Name = "emlFolderSelection";
            this.emlFolderSelection.Size = new System.Drawing.Size(107, 23);
            this.emlFolderSelection.TabIndex = 0;
            this.emlFolderSelection.Text = ".eml folder";
            this.emlFolderSelection.UseVisualStyleBackColor = true;
            this.emlFolderSelection.Click += new System.EventHandler(this.button1_Click);
            // 
            // pstFolderSelect
            // 
            this.pstFolderSelect.Location = new System.Drawing.Point(684, 370);
            this.pstFolderSelect.Name = "pstFolderSelect";
            this.pstFolderSelect.Size = new System.Drawing.Size(107, 23);
            this.pstFolderSelect.TabIndex = 1;
            this.pstFolderSelect.Text = ".pst folder";
            this.pstFolderSelect.UseVisualStyleBackColor = true;
            this.pstFolderSelect.Click += new System.EventHandler(this.pstFolderSelect_Click);
            // 
            // folderInputPath
            // 
            this.folderInputPath.Location = new System.Drawing.Point(12, 325);
            this.folderInputPath.Name = "folderInputPath";
            this.folderInputPath.Size = new System.Drawing.Size(666, 22);
            this.folderInputPath.TabIndex = 2;
            // 
            // pstOutputPath
            // 
            this.pstOutputPath.Location = new System.Drawing.Point(13, 370);
            this.pstOutputPath.Name = "pstOutputPath";
            this.pstOutputPath.Size = new System.Drawing.Size(665, 22);
            this.pstOutputPath.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(230, 417);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(283, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 590);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.pstOutputPath);
            this.Controls.Add(this.folderInputPath);
            this.Controls.Add(this.pstFolderSelect);
            this.Controls.Add(this.emlFolderSelection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button emlFolderSelection;
        private System.Windows.Forms.Button pstFolderSelect;
        private System.Windows.Forms.TextBox folderInputPath;
        private System.Windows.Forms.TextBox pstOutputPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Button convertButton;
    }
}

