using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Text_Analytics
{
    /// <summary>
    /// This class is a form to display the data occurrences
    /// </summary>
    public partial class Occurrences : Form
    {
        // type of occurrence
        private string type;

        /// <summary>
        /// Main method that displays the occurrences in a list box
        /// </summary>
        /// <param name="Occurrences"></param>
        /// <param name="type"></param>
        public Occurrences(List<string> Occurrences, string type)
        {
            this.InitializeComponent();
            this.type = type;

            var g = Occurrences.GroupBy(i => i);

            foreach (var grp in g)
            {
                OccurrencesLb.Items.Add(grp.Key + ": " + grp.Count() + " occurrences");
            }

            label1.Text = label1.Text + " " + type;
        }

        /// <summary>
        /// Button on click. Prints the results in the list box
        /// using a stream writer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintReportBtn_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName != string.Empty)
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter(sfd.FileName);

                        sw.WriteLine("Report time and date: " + System.DateTime.Now.ToString(), true);
                        sw.WriteLine("", true);

                        sw.WriteLine("-------------- " + type + " Occurrences --------------", true);
                        sw.WriteLine("", true);
                        for (int i = 0; i < OccurrencesLb.Items.Count; i++)
                        {
                            sw.WriteLine(OccurrencesLb.Items[i].ToString(), true);
                        }

                        sw.Close();

                        MessageBox.Show(this, "Report successfully saved", "Success");
                    }
                    catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
                }
            }
        }
    }
}
