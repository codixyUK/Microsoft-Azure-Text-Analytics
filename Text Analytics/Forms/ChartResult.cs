using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Text_Analytics
{
    /// <summary>
    /// This class is a form class to display a chart of data
    /// </summary>
    public partial class ChartResult : Form
    {
        // Lists of strings and integers
        private List<string> Documents;
        private List<int> Occurrences;

        /// <summary>
        /// Main method, gets parameters and sets the chart properties
        /// </summary>
        /// <param name="Documents"></param>
        /// <param name="Occurrences"></param>
        public ChartResult(List<string> Documents, List<int> Occurrences)
        {
            this.InitializeComponent();
            this.Documents = Documents;
            this.Occurrences = Occurrences;

            // Set palette
            this.chart1.Palette = ChartColorPalette.Excel;

            // Set title
            this.chart1.Titles.Add("Occurrences");

            SelectSeriesCb.Items.Add("All");

            for (int i = 0; i < Documents.Count; i++)
            {
                SelectSeriesCb.Items.Add(Documents[i]);
            }

            this.UpdateChart(Documents, Occurrences);
        }

        /// <summary>
        /// Updates the chart
        /// </summary>
        /// <param name="Documents"></param>
        /// <param name="Occurrences"></param>
        private void UpdateChart(List<string> Documents, List<int> Occurrences)
        {
            this.chart1.Series.Clear();

            // Add series.
            for (int i = 0; i < Documents.Count; i++)
            {
                Series series = this.chart1.Series.Add(Documents[i]);
                series.Points.Add(Occurrences[i]);
            }
            this.chart1.Refresh();
        }

        /// <summary>
        /// Event that is triggered when a combo box value has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSeriesCb_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (SelectSeriesCb.SelectedItem.ToString() != string.Empty)
            {
                List<string> DocumentsTemp = new List<string>();
                List<int> OccurrencesTemp = new List<int>();

                if (SelectSeriesCb.SelectedItem.ToString() == "All")
                {
                    DocumentsTemp = Documents;
                    OccurrencesTemp = Occurrences;
                }

                for (int i = 0; i < Documents.Count; i++)
                {
                    if (Documents[i] == SelectSeriesCb.SelectedItem.ToString())
                    {
                        DocumentsTemp.Add(Documents[i]);
                        OccurrencesTemp.Add(Occurrences[i]);
                    }
                }
                this.UpdateChart(DocumentsTemp, OccurrencesTemp);
                this.chart1.Refresh();
            }
        }
    }
}
