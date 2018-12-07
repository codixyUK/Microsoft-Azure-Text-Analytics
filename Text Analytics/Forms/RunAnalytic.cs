using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Text_Analytics
{
    /// <summary>
    /// This class is a form that lets the user decide which data they want to generate
    /// </summary>
    public partial class RunAnalytic : Form
    {
        // Objects
        private DataGridView dataGridView;

        // Lists
        private List<string> SelectedActions = new List<string>();
        private List<int> ColumnIndexes = new List<int>();

        /// <summary>
        /// Main method. Adds all the columns from the excel document into a list box
        /// </summary>
        /// <param name="dataGridView"></param>
        public RunAnalytic(DataGridView dataGridView)
        {
            InitializeComponent();

            this.dataGridView = dataGridView;


            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                notRelevantLb.Items.Add(dataGridView.Columns[i].HeaderText);
            }
        }

        /// <summary>
        /// Returns the number of a specific column in the excel document
        /// See param
        /// </summary>
        /// <param name="colName"></param>
        /// <returns></returns>
        private int GetColumnIndex(string colName)
        {
            return dataGridView.Columns[colName].Index;
        }

        /// <summary>
        /// Button event. Creates all the inputs from the excel data
        /// from each selected column and extract data based on the selected actions
        /// then displays the 'Generate form'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            ColumnIndexes.Clear();

            if (relevantLb.Items.Count == 0)
            {
                MessageBox.Show("You haven't selected any columns that are relevant", "Error");
                return;
            }

            // Adds all the columns selected into a list
            for (int i = 0; i < relevantLb.Items.Count; i++)
            {
                ColumnIndexes.Add(GetColumnIndex(relevantLb.Items[i].ToString()));
            }

            // Objects
            TextAnalyticClient textAnalysisClient = new TextAnalyticClient();

            // Lists
            List<MultiLanguageInput> MultiInput = new List<MultiLanguageInput>();
            List<Input> Inputs = new List<Input>();

            // Variables
            int count = 0;

            // Loop through all rows in the selected columns and extract data into a 'Input'
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                for (int i = 0; i < ColumnIndexes.Count; i++)
                {
                    if (row.Cells[ColumnIndexes[i]].Value != null)
                    {
                        count++;
                        Input Input = new Input
                        {
                            Id = Convert.ToString(count),
                            Text = Convert.ToString(row.Cells[ColumnIndexes[i]].Value)
                        };
                        Inputs.Add(Input);
                    }
                }
            }

            // Converts from Input to MultiInput
            for (int i = 0; i < Inputs.Count; i++)
            {
                MultiLanguageInput Input = new MultiLanguageInput
                {
                    Language = "En",
                    Id = Inputs[i].Id,
                    Text = Inputs[i].Text
                };
                MultiInput.Add(Input);
            }

            Generate GenerateFrm = new Generate(SelectedActions, Inputs, MultiInput);
            GenerateFrm.ShowDialog();
        }

        /// <summary>
        /// Button event. Adds column from one list box to another
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (relevantLb.Items.Contains(notRelevantLb.SelectedItem.ToString())) { return; }

            if (notRelevantLb.SelectedItem != null)
            {
                relevantLb.Items.Add(notRelevantLb.SelectedItem.ToString());

                try
                {
                    notRelevantLb.SelectedIndex = notRelevantLb.SelectedIndex + 1;
                }
                catch { return; } // Index out of bound
            }
        }

        /// <summary>
        /// Removes a column from a list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (relevantLb.SelectedItem != null)
            {
                relevantLb.Items.Remove(relevantLb.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// On check changed event. Add/remove appropriate action to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Checked)
            {
                SelectedActions.Add(cb.Text);
            }
            else
            {
                SelectedActions.Remove(cb.Text);
            }
        }

        /// <summary>
        /// Button event. Moves all items from one list box to another
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllBtn_Click(object sender, EventArgs e)
        {
            relevantLb.Items.Clear();

            for (int i = 0; i < notRelevantLb.Items.Count; i++)
            {
                relevantLb.Items.Add(notRelevantLb.Items[i]);
            }
        }

        /// <summary>
        /// Button event. Clears all the items in a list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            relevantLb.Items.Clear();
        }
    }
}
