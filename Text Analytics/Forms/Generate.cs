using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Text_Analytics
{
    /// <summary>
    /// This class is a form that runs a background thread that 
    /// calls the functions of the Text Analytic
    /// </summary>
    public partial class Generate : Form
    {
        // Lists
        private List<string> SelectedActions;
        private List<Input> Inputs;
        private List<MultiLanguageInput> MultiInput;

        // Objects
        private TextAnalyticClient textAnalyticClient;
        private BackgroundWorker worker;

        // Variables
        private bool isCancelled = false;

        /// <summary>
        /// Main method. Creates objects, assigns to global objects and lists
        /// Creates a background thread
        /// </summary>
        /// <param name="SelectedActions"></param>
        /// <param name="Inputs"></param>
        /// <param name="MultiInput"></param>
        public Generate(List<string> SelectedActions, List<Input> Inputs, List<MultiLanguageInput> MultiInput)
        {
            this.InitializeComponent();
            this.textAnalyticClient = new TextAnalyticClient();
            this.SelectedActions = SelectedActions;
            this.Inputs = Inputs;
            this.MultiInput = MultiInput;

            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        /// <summary>
        /// Background thread event. Checks what actions have been selected
        /// and then calls the appropiate functions of the Text Analytic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SelectedActions.Contains("Language") && !isCancelled)
            {
                textAnalyticClient.DetectLanguages(Inputs);
            }

            if (SelectedActions.Contains("Key-Phrase") && !isCancelled)
            {
                textAnalyticClient.KeyPhrase(MultiInput);
            }

            if (SelectedActions.Contains("Sentiment Analysis") && !isCancelled)
            {
                textAnalyticClient.Sentiment(MultiInput);
            }

            if (SelectedActions.Contains("Entities") && !isCancelled)
            {
                textAnalyticClient.Entities(MultiInput);
            }
        }

        /// <summary>
        /// Event for when the background thread has finish
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (SelectedActions.Count > 0)
            {
                if (!isCancelled)
                    textAnalyticClient.FinishTask(MultiInput);
            }
            this.Close();
        }

        /// <summary>
        /// On form closing, cancel the background thread etc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Generate_FormClosing(object sender, FormClosingEventArgs e)
        {
            isCancelled = true;
            worker.WorkerSupportsCancellation = true;
            worker.CancelAsync();
            worker.Dispose();
            worker = null;
            GC.Collect();
        }
    }
}
