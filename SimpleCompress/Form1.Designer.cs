namespace SimpleCompress
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnFolderNav = new System.Windows.Forms.Button();
            this.btnZipFolder = new System.Windows.Forms.Button();
            this.btnZipFile = new System.Windows.Forms.Button();
            this.btnFileNav = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder:";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(90, 17);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(344, 20);
            this.txtFolder.TabIndex = 1;
            // 
            // btnFolderNav
            // 
            this.btnFolderNav.Location = new System.Drawing.Point(451, 15);
            this.btnFolderNav.Name = "btnFolderNav";
            this.btnFolderNav.Size = new System.Drawing.Size(55, 23);
            this.btnFolderNav.TabIndex = 2;
            this.btnFolderNav.Text = "...";
            this.btnFolderNav.UseVisualStyleBackColor = true;
            this.btnFolderNav.Click += new System.EventHandler(this.btnFolderNav_Click);
            // 
            // btnZipFolder
            // 
            this.btnZipFolder.Location = new System.Drawing.Point(538, 15);
            this.btnZipFolder.Name = "btnZipFolder";
            this.btnZipFolder.Size = new System.Drawing.Size(75, 23);
            this.btnZipFolder.TabIndex = 3;
            this.btnZipFolder.Text = "ZipFolder";
            this.btnZipFolder.UseVisualStyleBackColor = true;
            this.btnZipFolder.Click += new System.EventHandler(this.btnZipFolder_Click);
            // 
            // btnZipFile
            // 
            this.btnZipFile.Location = new System.Drawing.Point(538, 41);
            this.btnZipFile.Name = "btnZipFile";
            this.btnZipFile.Size = new System.Drawing.Size(75, 23);
            this.btnZipFile.TabIndex = 7;
            this.btnZipFile.Text = "ZipFile";
            this.btnZipFile.UseVisualStyleBackColor = true;
            this.btnZipFile.Click += new System.EventHandler(this.btnZipFile_Click);
            // 
            // btnFileNav
            // 
            this.btnFileNav.Location = new System.Drawing.Point(451, 41);
            this.btnFileNav.Name = "btnFileNav";
            this.btnFileNav.Size = new System.Drawing.Size(55, 23);
            this.btnFileNav.TabIndex = 6;
            this.btnFileNav.Text = "...";
            this.btnFileNav.UseVisualStyleBackColor = true;
            this.btnFileNav.Click += new System.EventHandler(this.btnFileNav_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(344, 20);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(90, 69);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(344, 23);
            this.progressBar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "0%";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(538, 68);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 144);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnZipFile);
            this.Controls.Add(this.btnFileNav);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZipFolder);
            this.Controls.Add(this.btnFolderNav);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnFolderNav;
        private System.Windows.Forms.Button btnZipFolder;
        private System.Windows.Forms.Button btnZipFile;
        private System.Windows.Forms.Button btnFileNav;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
    }
}

