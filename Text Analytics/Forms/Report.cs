using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Text_Analytics
{
    /// <summary>
    /// This class is a form that generates a report based on the data in the lists
    /// </summary>
    public partial class Report : Form
    {
        // List of data strings
        private List<string> KeyPhraseOccurrences, LanguageOccurrences, SentimentOccurrences, EntityOccurrences;

        /// <summary>
        /// Main method. Puts all the data from the lists into a list box.
        /// Also sets the global lists
        /// </summary>
        /// <param name="Languages"></param>
        /// <param name="KeyPhrases"></param>
        /// <param name="Sentiments"></param>
        /// <param name="Entities"></param>
        /// <param name="Data"></param>
        /// <param name="KeyPhraseOccurrences"></param>
        /// <param name="LanguageOccurrences"></param>
        /// <param name="SentimentOccurrences"></param>
        /// <param name="EntityOccurrences"></param>
        public Report(List<string> Languages, List<string> KeyPhrases, List<string> Sentiments, 
            List<string> Entities, List<string> Data, List<string> KeyPhraseOccurrences, List<string> LanguageOccurrences,
            List<string> SentimentOccurrences, List<string> EntityOccurrences)
        {
            this.InitializeComponent();

            this.KeyPhraseOccurrences = KeyPhraseOccurrences;
            this.LanguageOccurrences = LanguageOccurrences;
            this.SentimentOccurrences = SentimentOccurrences;
            this.EntityOccurrences = EntityOccurrences;

            if (Languages.Count > 0)
            {
                for (int i = 0; i < Languages.Count; i++)
                {
                    LanguagesLb.Items.Add(Languages[i]);
                }
            }

            if (KeyPhrases.Count > 0)
            {
                for (int i = 0; i < KeyPhrases.Count; i++)
                {
                    KeyPhrasesLb.Items.Add(KeyPhrases[i]);
                }
            }

            if (Sentiments.Count > 0)
            {
                List<double> result = SentimentOccurrences.Select(x => double.Parse(x)).ToList();
                double average = SentimentOccurrences.Count > 0 ? result.Average() : 0.0;
                SentimentPb.Value = (int)(average * 100.0f);
                SentimentsLb.Items.Add("----- Average Sentiment: " + average);
                SentimentsLb.Items.Add("");

                for (int i = 0; i < Sentiments.Count; i++)
                {
                    SentimentsLb.Items.Add(Sentiments[i]);
                }
            }

            if (Entities.Count > 0)
            {
                for (int i = 0; i < Entities.Count; i++)
                {
                    EntitiesLb.Items.Add(Entities[i]);
                }
            }

            if (Data.Count > 0)
            {
                for (int i = 0; i < Data.Count; i++)
                {
                    DataLb.Items.Add(Data[i]);
                }
            }
        }

        /// <summary>
        /// Opens a form to show the occurrences of the 'type' of data
        /// See param
        /// </summary>
        /// <param name="Occurrences"></param>
        /// <param name="type"></param>
        private void LoadOccurrences(List<string> Occurrences, string type)
        {
            Occurrences OccurrencesFrm = new Occurrences(Occurrences, type);
            OccurrencesFrm.ShowDialog();
        }

        /// <summary>
        /// Opens a form to show the occurrences in a chart
        /// </summary>
        /// <param name="Occurences"></param>
        private void AddOccurencesToChart(List<string> Occurences)
        {
            List<int> OccurrencesList_Chart = new List<int>();
            List<string> DocumentsList_Chart = new List<string>();

            var g = Occurences.GroupBy(i => i);

            foreach (var grp in g)
            {
                DocumentsList_Chart.Add(grp.Key);
                OccurrencesList_Chart.Add(grp.Count());
            }

            ChartResult ChartFrm = new ChartResult(DocumentsList_Chart, OccurrencesList_Chart);
            ChartFrm.ShowDialog();
        }

        /// <summary>
        /// Button event. Prints all the data in the list boxes
        /// to a directory selected by the Save File Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintReportBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != string.Empty)
                    {
                        StreamWriter sw = new StreamWriter(sfd.FileName);

                        sw.WriteLine("Report time and date: " + System.DateTime.Now.ToString(), true);
                        sw.WriteLine("", true);

                        sw.WriteLine("-------------- Languages --------------", true);
                        sw.WriteLine("", true);
                        for (int i = 0; i < LanguagesLb.Items.Count; i++)
                        {
                            sw.WriteLine(LanguagesLb.Items[i].ToString(), true);
                        }
                        sw.WriteLine("", true);
                        sw.WriteLine("-------------- Key Phrases --------------", true);
                        sw.WriteLine("", true);
                        for (int i = 0; i < KeyPhrasesLb.Items.Count; i++)
                        {
                            sw.WriteLine(KeyPhrasesLb.Items[i].ToString(), true);
                        }
                        sw.WriteLine("", true);
                        sw.WriteLine("-------------- Sentiments --------------", true);
                        sw.WriteLine("", true);
                        for (int i = 0; i < SentimentsLb.Items.Count; i++)
                        {
                            sw.WriteLine(SentimentsLb.Items[i].ToString(), true);
                        }
                        sw.WriteLine("", true);
                        sw.WriteLine("-------------- Entities --------------", true);
                        sw.WriteLine("", true);
                        for (int i = 0; i < EntitiesLb.Items.Count; i++)
                        {
                            sw.WriteLine(EntitiesLb.Items[i].ToString(), true);
                        }
                        sw.WriteLine("", true);
                        sw.WriteLine("-------------- Orignal Data --------------", true);
                        sw.WriteLine("", true);
                        for (int i = 0; i < DataLb.Items.Count; i++)
                        {
                            sw.WriteLine(DataLb.Items[i].ToString(), true);
                        }
                        sw.Close();

                        MessageBox.Show(this, "Report successfully saved", "Success");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(this, "Error: " + ex.Message); return; }
        }

        /// <summary>
        /// Calls the 'LoadOccurrences' method, passing the occurrence list and type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeeOccurrLangBtn_Click(object sender, EventArgs e)
        {
            LoadOccurrences(LanguageOccurrences, "Languages");
        }

        /// <summary>
        /// Calls the 'LoadOccurrences' method, passing the occurrence list and type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeeOccurrKeyPhraseBtn_Click(object sender, EventArgs e)
        {
            LoadOccurrences(KeyPhraseOccurrences, "Key-Phrases");
        }

        /// <summary>
        /// Calls the 'LoadOccurrences' method, passing the occurrence list and type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeeOccurrSentBtn_Click(object sender, EventArgs e)
        {
            LoadOccurrences(SentimentOccurrences, "Sentiments");
        }

        /// <summary>
        /// Calls the 'LoadOccurrences' method, passing the occurrence list and type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeeOccurrEntityBtn_Click(object sender, EventArgs e)
        {
            LoadOccurrences(EntityOccurrences, "Entities");
        }

        /// <summary>
        /// Button event. Calls 'AddOccurencesToChart' passing the occurrence list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LanguagesChartBtn_Click(object sender, System.EventArgs e)
        {
            AddOccurencesToChart(LanguageOccurrences);
        }

        /// <summary>
        /// Button event. Calls 'AddOccurencesToChart' passing the occurrence list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyPhraseChartBtn_Click(object sender, System.EventArgs e)
        {
            AddOccurencesToChart(KeyPhraseOccurrences);
        }

        /// <summary>
        /// Button event. Calls 'AddOccurencesToChart' passing the occurrence list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EntitiesChartBtn_Click(object sender, System.EventArgs e)
        {
            AddOccurencesToChart(EntityOccurrences);
        }
    }
}
