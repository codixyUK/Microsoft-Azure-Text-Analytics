using System;
using System.Windows.Forms;

namespace Text_Analytics
{
    /// <summary>
    /// Gets the directory of a document
    /// </summary>
    public partial class Import : Form
    {
        // Variables
        private int flag = 0;

        /// <summary>
        /// Main method
        /// </summary>
        public Import(int flag)
        {
            this.InitializeComponent();
            this.flag = flag;
        }

        /// <summary>
        /// Button Event. Open a Open File Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (flag == 0)
                ofd.Filter = "Excel Files| *.xls; *.xlsx; *.xlsm";
            else if (flag == 1)
                ofd.Filter = "Text Files| *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName != null)
                    FilePathTb.Text = ofd.FileName;
            }
        }

        /// <summary>
        /// Button event. Updates the connecting string 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            if (FilePathTb.Text != null)
            {
                if (flag == 0)
                    Main.connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FilePathTb.Text + ";Extended Properties=Excel 8.0;";
                else if (flag == 1)
                    Main.connectionString = FilePathTb.Text;
            }
        }

        private void Example1LL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\Data\\Input.txt");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\Data\\Input2.txt");
        }
    }
}
