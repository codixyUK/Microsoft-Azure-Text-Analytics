namespace Text_Analytics
{
    partial class Report
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
            this.LanguagesLb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyPhrasesLb = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SentimentsLb = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EntitiesLb = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DataLb = new System.Windows.Forms.ListBox();
            this.SentimentPb = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.KeyPhraseChartBtn = new System.Windows.Forms.Button();
            this.LanguagesChartBtn = new System.Windows.Forms.Button();
            this.EntitiesChartBtn = new System.Windows.Forms.Button();
            this.PrintReportBtn = new System.Windows.Forms.Button();
            this.SeeOccurrLangBtn = new System.Windows.Forms.Button();
            this.SeeOccurrKeyPhraseBtn = new System.Windows.Forms.Button();
            this.SeeOccurrEntityBtn = new System.Windows.Forms.Button();
            this.SeeOccurrSentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LanguagesLb
            // 
            this.LanguagesLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguagesLb.FormattingEnabled = true;
            this.LanguagesLb.ItemHeight = 16;
            this.LanguagesLb.Location = new System.Drawing.Point(12, 44);
            this.LanguagesLb.Name = "LanguagesLb";
            this.LanguagesLb.Size = new System.Drawing.Size(1102, 132);
            this.LanguagesLb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Languages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key-Phrases";
            // 
            // KeyPhrasesLb
            // 
            this.KeyPhrasesLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyPhrasesLb.FormattingEnabled = true;
            this.KeyPhrasesLb.ItemHeight = 16;
            this.KeyPhrasesLb.Location = new System.Drawing.Point(12, 216);
            this.KeyPhrasesLb.Name = "KeyPhrasesLb";
            this.KeyPhrasesLb.Size = new System.Drawing.Size(1102, 132);
            this.KeyPhrasesLb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sentiments";
            // 
            // SentimentsLb
            // 
            this.SentimentsLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SentimentsLb.FormattingEnabled = true;
            this.SentimentsLb.ItemHeight = 16;
            this.SentimentsLb.Location = new System.Drawing.Point(12, 396);
            this.SentimentsLb.Name = "SentimentsLb";
            this.SentimentsLb.Size = new System.Drawing.Size(1102, 132);
            this.SentimentsLb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entities";
            // 
            // EntitiesLb
            // 
            this.EntitiesLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntitiesLb.FormattingEnabled = true;
            this.EntitiesLb.ItemHeight = 16;
            this.EntitiesLb.Location = new System.Drawing.Point(12, 575);
            this.EntitiesLb.Name = "EntitiesLb";
            this.EntitiesLb.Size = new System.Drawing.Size(1102, 132);
            this.EntitiesLb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 720);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Original Data";
            // 
            // DataLb
            // 
            this.DataLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataLb.FormattingEnabled = true;
            this.DataLb.ItemHeight = 16;
            this.DataLb.Location = new System.Drawing.Point(12, 753);
            this.DataLb.Name = "DataLb";
            this.DataLb.Size = new System.Drawing.Size(1102, 132);
            this.DataLb.TabIndex = 8;
            // 
            // SentimentPb
            // 
            this.SentimentPb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SentimentPb.Location = new System.Drawing.Point(675, 372);
            this.SentimentPb.Name = "SentimentPb";
            this.SentimentPb.Size = new System.Drawing.Size(210, 10);
            this.SentimentPb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bad";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(900, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Good";
            // 
            // KeyPhraseChartBtn
            // 
            this.KeyPhraseChartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyPhraseChartBtn.Location = new System.Drawing.Point(1018, 182);
            this.KeyPhraseChartBtn.Name = "KeyPhraseChartBtn";
            this.KeyPhraseChartBtn.Size = new System.Drawing.Size(96, 30);
            this.KeyPhraseChartBtn.TabIndex = 14;
            this.KeyPhraseChartBtn.Text = "See Chart";
            this.KeyPhraseChartBtn.UseVisualStyleBackColor = true;
            this.KeyPhraseChartBtn.Click += new System.EventHandler(this.KeyPhraseChartBtn_Click);
            // 
            // LanguagesChartBtn
            // 
            this.LanguagesChartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguagesChartBtn.Location = new System.Drawing.Point(1018, 10);
            this.LanguagesChartBtn.Name = "LanguagesChartBtn";
            this.LanguagesChartBtn.Size = new System.Drawing.Size(96, 30);
            this.LanguagesChartBtn.TabIndex = 15;
            this.LanguagesChartBtn.Text = "See Chart";
            this.LanguagesChartBtn.UseVisualStyleBackColor = true;
            this.LanguagesChartBtn.Click += new System.EventHandler(this.LanguagesChartBtn_Click);
            // 
            // EntitiesChartBtn
            // 
            this.EntitiesChartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EntitiesChartBtn.Location = new System.Drawing.Point(1018, 539);
            this.EntitiesChartBtn.Name = "EntitiesChartBtn";
            this.EntitiesChartBtn.Size = new System.Drawing.Size(96, 30);
            this.EntitiesChartBtn.TabIndex = 16;
            this.EntitiesChartBtn.Text = "See Chart";
            this.EntitiesChartBtn.UseVisualStyleBackColor = true;
            this.EntitiesChartBtn.Click += new System.EventHandler(this.EntitiesChartBtn_Click);
            // 
            // PrintReportBtn
            // 
            this.PrintReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintReportBtn.Location = new System.Drawing.Point(1018, 893);
            this.PrintReportBtn.Name = "PrintReportBtn";
            this.PrintReportBtn.Size = new System.Drawing.Size(96, 30);
            this.PrintReportBtn.TabIndex = 18;
            this.PrintReportBtn.Text = "Print Report";
            this.PrintReportBtn.UseVisualStyleBackColor = true;
            this.PrintReportBtn.Click += new System.EventHandler(this.PrintReportBtn_Click);
            // 
            // SeeOccurrLangBtn
            // 
            this.SeeOccurrLangBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeeOccurrLangBtn.Location = new System.Drawing.Point(862, 10);
            this.SeeOccurrLangBtn.Name = "SeeOccurrLangBtn";
            this.SeeOccurrLangBtn.Size = new System.Drawing.Size(150, 30);
            this.SeeOccurrLangBtn.TabIndex = 19;
            this.SeeOccurrLangBtn.Text = "See Occurrences";
            this.SeeOccurrLangBtn.UseVisualStyleBackColor = true;
            this.SeeOccurrLangBtn.Click += new System.EventHandler(this.SeeOccurrLangBtn_Click);
            // 
            // SeeOccurrKeyPhraseBtn
            // 
            this.SeeOccurrKeyPhraseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeeOccurrKeyPhraseBtn.Location = new System.Drawing.Point(862, 182);
            this.SeeOccurrKeyPhraseBtn.Name = "SeeOccurrKeyPhraseBtn";
            this.SeeOccurrKeyPhraseBtn.Size = new System.Drawing.Size(150, 30);
            this.SeeOccurrKeyPhraseBtn.TabIndex = 20;
            this.SeeOccurrKeyPhraseBtn.Text = "See Occurrences";
            this.SeeOccurrKeyPhraseBtn.UseVisualStyleBackColor = true;
            this.SeeOccurrKeyPhraseBtn.Click += new System.EventHandler(this.SeeOccurrKeyPhraseBtn_Click);
            // 
            // SeeOccurrEntityBtn
            // 
            this.SeeOccurrEntityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeeOccurrEntityBtn.Location = new System.Drawing.Point(862, 539);
            this.SeeOccurrEntityBtn.Name = "SeeOccurrEntityBtn";
            this.SeeOccurrEntityBtn.Size = new System.Drawing.Size(150, 30);
            this.SeeOccurrEntityBtn.TabIndex = 21;
            this.SeeOccurrEntityBtn.Text = "See Occurrences";
            this.SeeOccurrEntityBtn.UseVisualStyleBackColor = true;
            this.SeeOccurrEntityBtn.Click += new System.EventHandler(this.SeeOccurrEntityBtn_Click);
            // 
            // SeeOccurrSentBtn
            // 
            this.SeeOccurrSentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeeOccurrSentBtn.Location = new System.Drawing.Point(964, 360);
            this.SeeOccurrSentBtn.Name = "SeeOccurrSentBtn";
            this.SeeOccurrSentBtn.Size = new System.Drawing.Size(150, 30);
            this.SeeOccurrSentBtn.TabIndex = 22;
            this.SeeOccurrSentBtn.Text = "See Occurrences";
            this.SeeOccurrSentBtn.UseVisualStyleBackColor = true;
            this.SeeOccurrSentBtn.Click += new System.EventHandler(this.SeeOccurrSentBtn_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 933);
            this.Controls.Add(this.SeeOccurrSentBtn);
            this.Controls.Add(this.SeeOccurrEntityBtn);
            this.Controls.Add(this.SeeOccurrKeyPhraseBtn);
            this.Controls.Add(this.SeeOccurrLangBtn);
            this.Controls.Add(this.PrintReportBtn);
            this.Controls.Add(this.EntitiesChartBtn);
            this.Controls.Add(this.LanguagesChartBtn);
            this.Controls.Add(this.KeyPhraseChartBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SentimentPb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EntitiesLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SentimentsLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyPhrasesLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LanguagesLb);
            this.Name = "Report";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LanguagesLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox KeyPhrasesLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox SentimentsLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox EntitiesLb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox DataLb;
        private System.Windows.Forms.ProgressBar SentimentPb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button KeyPhraseChartBtn;
        private System.Windows.Forms.Button LanguagesChartBtn;
        private System.Windows.Forms.Button EntitiesChartBtn;
        private System.Windows.Forms.Button PrintReportBtn;
        private System.Windows.Forms.Button SeeOccurrLangBtn;
        private System.Windows.Forms.Button SeeOccurrKeyPhraseBtn;
        private System.Windows.Forms.Button SeeOccurrEntityBtn;
        private System.Windows.Forms.Button SeeOccurrSentBtn;
    }
}