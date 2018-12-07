namespace Text_Analytics
{
    partial class Import
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
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePathTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Example1LL = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ContinueBtn.Location = new System.Drawing.Point(27, 240);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(396, 43);
            this.ContinueBtn.TabIndex = 9;
            this.ContinueBtn.Text = "Continue";
            this.ContinueBtn.UseVisualStyleBackColor = true;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(320, 190);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(103, 30);
            this.BrowseBtn.TabIndex = 8;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a document:";
            // 
            // FilePathTb
            // 
            this.FilePathTb.Enabled = false;
            this.FilePathTb.Location = new System.Drawing.Point(27, 194);
            this.FilePathTb.Name = "FilePathTb";
            this.FilePathTb.Size = new System.Drawing.Size(287, 22);
            this.FilePathTb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 68);
            this.label2.TabIndex = 10;
            this.label2.Text = "If you\'re selecting a text file, make sure each data is seperated by\r\na line. Use" +
    " commas to seperate data under headers and use \r\ncommas at the start to declare " +
    "headers. \r\nOr leave blank for default.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Example1LL
            // 
            this.Example1LL.AutoSize = true;
            this.Example1LL.Location = new System.Drawing.Point(65, 105);
            this.Example1LL.Name = "Example1LL";
            this.Example1LL.Size = new System.Drawing.Size(148, 17);
            this.Example1LL.TabIndex = 11;
            this.Example1LL.TabStop = true;
            this.Example1LL.Text = "See example (Default)";
            this.Example1LL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Example1LL_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(229, 105);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "See example 2 (Headers)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 298);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Example1LL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContinueBtn);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilePathTb);
            this.Name = "Import";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ContinueBtn;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePathTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Example1LL;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}