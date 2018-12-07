namespace Text_Analytics
{
    partial class CustomAnalytic
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
            this.inputTb = new System.Windows.Forms.TextBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ItemLb = new System.Windows.Forms.ListBox();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.ClearItemsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTb
            // 
            this.inputTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTb.Location = new System.Drawing.Point(13, 13);
            this.inputTb.Multiline = true;
            this.inputTb.Name = "inputTb";
            this.inputTb.Size = new System.Drawing.Size(612, 40);
            this.inputTb.TabIndex = 0;
            // 
            // runBtn
            // 
            this.runBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runBtn.Location = new System.Drawing.Point(484, 329);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(141, 53);
            this.runBtn.TabIndex = 1;
            this.runBtn.Text = "Run Analystic";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(142, 358);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(76, 21);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "Entities";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(142, 340);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(149, 21);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Sentiment Analysis";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 358);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 21);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Key-Phrase";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 340);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Language";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // ItemLb
            // 
            this.ItemLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemLb.FormattingEnabled = true;
            this.ItemLb.ItemHeight = 16;
            this.ItemLb.Location = new System.Drawing.Point(13, 108);
            this.ItemLb.Name = "ItemLb";
            this.ItemLb.Size = new System.Drawing.Size(612, 212);
            this.ItemLb.TabIndex = 18;
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItemBtn.Location = new System.Drawing.Point(532, 64);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(93, 32);
            this.AddItemBtn.TabIndex = 19;
            this.AddItemBtn.Text = "Add Item";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // ClearItemsBtn
            // 
            this.ClearItemsBtn.Location = new System.Drawing.Point(12, 64);
            this.ClearItemsBtn.Name = "ClearItemsBtn";
            this.ClearItemsBtn.Size = new System.Drawing.Size(93, 32);
            this.ClearItemsBtn.TabIndex = 20;
            this.ClearItemsBtn.Text = "Clear Items";
            this.ClearItemsBtn.UseVisualStyleBackColor = true;
            this.ClearItemsBtn.Click += new System.EventHandler(this.ClearItemsBtn_Click);
            // 
            // CustomAnalystic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 391);
            this.Controls.Add(this.ClearItemsBtn);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.ItemLb);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.inputTb);
            this.Name = "CustomAnalystic";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Run Custom Analystic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTb;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox ItemLb;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.Button ClearItemsBtn;
    }
}