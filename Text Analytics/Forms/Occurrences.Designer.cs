namespace Text_Analytics
{
    partial class Occurrences
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
            this.OccurrencesLb = new System.Windows.Forms.ListBox();
            this.PrintReportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OccurrencesLb
            // 
            this.OccurrencesLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OccurrencesLb.FormattingEnabled = true;
            this.OccurrencesLb.ItemHeight = 16;
            this.OccurrencesLb.Location = new System.Drawing.Point(0, 46);
            this.OccurrencesLb.Name = "OccurrencesLb";
            this.OccurrencesLb.Size = new System.Drawing.Size(645, 436);
            this.OccurrencesLb.TabIndex = 0;
            // 
            // PrintReportBtn
            // 
            this.PrintReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintReportBtn.Location = new System.Drawing.Point(541, 8);
            this.PrintReportBtn.Name = "PrintReportBtn";
            this.PrintReportBtn.Size = new System.Drawing.Size(96, 30);
            this.PrintReportBtn.TabIndex = 19;
            this.PrintReportBtn.Text = "Print Report";
            this.PrintReportBtn.UseVisualStyleBackColor = true;
            this.PrintReportBtn.Click += new System.EventHandler(this.PrintReportBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Listing the occurrences of:";
            // 
            // Occurrences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrintReportBtn);
            this.Controls.Add(this.OccurrencesLb);
            this.Name = "Occurrences";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Occurrences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OccurrencesLb;
        private System.Windows.Forms.Button PrintReportBtn;
        private System.Windows.Forms.Label label1;
    }
}