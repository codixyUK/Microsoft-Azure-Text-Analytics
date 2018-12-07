using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Text_Analytics
{
    /// <summary>
    /// This class is a form that creates GUI for a custom text analytic
    /// </summary>
    public partial class CustomAnalytic : Form
    {
        // List of actions that have been selected e.g. sentiments, key-phrases
        List<string> SelectedActions = new List<string>();

        /// <summary>
        /// Main method
        /// </summary>
        public CustomAnalytic()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button event. Collects the inputs from the list box and sends them off to the API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runBtn_Click(object sender, EventArgs e)
        {
            if (ItemLb.Items.Count > 0)
            {
                List<Input> Inputs = new List<Input>();
                List<MultiLanguageInput> MultiInput = new List<MultiLanguageInput>();
                int count = 0;

                for (int i = 0; i < ItemLb.Items.Count; i++)
                {
                    count++;
                    Input Input = new Input
                    {
                        Id = Convert.ToString(count),
                        Text = Convert.ToString(ItemLb.Items[i].ToString())
                    };
                    Inputs.Add(Input);
                }

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

            } else { MessageBox.Show("No inputs available", "Error"); }
        }

        /// <summary>
        /// This is a checkbox on value change event, which adds an action to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
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
        /// Button event to add a item into another list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            if (inputTb.Text != string.Empty)
            {
                ItemLb.Items.Add(inputTb.Text);
                inputTb.Clear();
            }
        }

        /// <summary>
        /// Button event to clear all items in a list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearItemsBtn_Click(object sender, EventArgs e)
        {
            ItemLb.Items.Clear();
        }
    }
}
