namespace Text_Analytics
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExcelDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textAnalyticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAnalysticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runCustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1177, 436);
            this.dataGridView1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.textAnalyticToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1177, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importExcelDocumentToolStripMenuItem,
            this.importTextFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importExcelDocumentToolStripMenuItem
            // 
            this.importExcelDocumentToolStripMenuItem.Name = "importExcelDocumentToolStripMenuItem";
            this.importExcelDocumentToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.importExcelDocumentToolStripMenuItem.Text = "Import Excel Document";
            this.importExcelDocumentToolStripMenuItem.Click += new System.EventHandler(this.importExcelDocumentToolStripMenuItem_Click);
            // 
            // importTextFileToolStripMenuItem
            // 
            this.importTextFileToolStripMenuItem.Name = "importTextFileToolStripMenuItem";
            this.importTextFileToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.importTextFileToolStripMenuItem.Text = "Import Text File";
            this.importTextFileToolStripMenuItem.Click += new System.EventHandler(this.importTextFileToolStripMenuItem_Click);
            // 
            // textAnalyticToolStripMenuItem
            // 
            this.textAnalyticToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.runAnalysticToolStripMenuItem,
            this.runCustomToolStripMenuItem});
            this.textAnalyticToolStripMenuItem.Name = "textAnalyticToolStripMenuItem";
            this.textAnalyticToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.textAnalyticToolStripMenuItem.Text = "Text Analytic";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.testToolStripMenuItem.Text = "Run Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // runAnalysticToolStripMenuItem
            // 
            this.runAnalysticToolStripMenuItem.Name = "runAnalysticToolStripMenuItem";
            this.runAnalysticToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.runAnalysticToolStripMenuItem.Text = "Run Analytic";
            this.runAnalysticToolStripMenuItem.Click += new System.EventHandler(this.runAnalysticToolStripMenuItem_Click);
            // 
            // runCustomToolStripMenuItem
            // 
            this.runCustomToolStripMenuItem.Name = "runCustomToolStripMenuItem";
            this.runCustomToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.runCustomToolStripMenuItem.Text = "Run Custom";
            this.runCustomToolStripMenuItem.Click += new System.EventHandler(this.runCustomToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 464);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Analytics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importExcelDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textAnalyticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAnalysticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runCustomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

