using System;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;
using System.Collections.Generic;

namespace Text_Analytics
{
    /// <summary>
    /// This class handles the Text Analytic client and extracts the results from the inputs
    /// 4 main functions of Text Analsytic: Language, Key-Phrases, Sentiment and Entities.
    /// Make sure the API is up to date and uses the: 1,000 transaction subcription
    /// </summary>
    class TextAnalyticClient
    {
        // Create the Text Analystic Client
        private ITextAnalyticsClient client;

        // This variable delays each task 
        // Can be set to 0, however we should leave a delay before processing the next document list
        private int delay = 500;

        // List of strings to hold data
        private List<string> LanguagesList = new List<string>();
        private List<string> LanguageOccurrences = new List<string>();
        private List<string> KeyPhrasesList = new List<string>();
        private List<string> KeyPhraseOccurrences = new List<string>();
        private List<string> SentimentsList = new List<string>();
        private List<string> SentimentOccurrences = new List<string>();
        private List<string> EntitiesList = new List<string>();
        private List<string> EntityOccurrences = new List<string>();
        private List<string> DataList = new List<string>();

        /* 
         * If the methods (Languages, KeyPhrases, Sentiments and Entities)
         * returns an error, check that the API hasn't ran out of requests
         * the current API keys supports 1k transaction at one time */

        /// <summary>
        /// Create the Text Analystic Client
        /// </summary>
        public TextAnalyticClient()
        {
            // Create a client.
            client = new TextAnalyticsClient(new ApiKeyServiceClientCredentials())
            {
                // End point may change if you upgrade the API
                Endpoint = "https://uksouth.api.cognitive.microsoft.com"
            };
        }

        /// <summary>
        /// This amazing method puts a list inside a list..  you heard that right.
        /// It seperates all the documents into a list of 1000 documents, this is so it can
        /// be processed through the API. The API only supports 1000 documents per request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="chunkSize"></param>
        /// <returns></returns>
        public static List<List<T>> SplitIntoChunks<T>(List<T> list, int chunkSize)
        {
            if (chunkSize <= 0)
            {
                throw new ArgumentException("chunkSize must be greater than 0.");
            }

            List<List<T>> retVal = new List<List<T>>();
            int index = 0;
            while (index < list.Count)
            {
                int count = list.Count - index > chunkSize ? chunkSize : list.Count - index;
                retVal.Add(list.GetRange(index, count));

                index += chunkSize;
            }

            return retVal;
        }

        /// <summary>
        /// This method gets the list of inputs and sends them off to the API
        /// to get a list of language detection results returned.
        /// </summary>
        /// <param name="Inputs"></param>
        public void DetectLanguages(List<Input> Inputs)
        {
            if (Inputs == null) { return; }

            List<List<Input>> Lists = SplitIntoChunks(Inputs, 1000);

            try
            {
                for (int i = 0; i < Lists.Count; i++)
                {
                    LanguageBatchResult result = null;
                    result = client.DetectLanguageAsync(new BatchInput(Lists[i])).Result;

                    foreach (var document in result.Documents)
                    {
                        if (document.DetectedLanguages[0].Name != null)
                        {
                            LanguagesList.Add("Document ID: " + document.Id + ", Language: " + document.DetectedLanguages[0].Name);
                            LanguageOccurrences.Add(document.DetectedLanguages[0].Name);
                        }
                    }
                    System.Threading.Thread.Sleep(delay);
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Error: " + ex.Message); }
        }

        /// <summary>
        /// This method gets the list of inputs and sends them off to the API
        /// to get a list of key phrase results returned.
        /// </summary>
        /// <param name="Inputs"></param>
        public void KeyPhrase(List<MultiLanguageInput> Inputs)
        {
            if (Inputs == null) { return; }

            List<List<MultiLanguageInput>> Lists = SplitIntoChunks(Inputs, 1000);

            try
            {
                for (int i = 0; i < Lists.Count; i++)
                {
                    var result = client.KeyPhrasesAsync(new MultiLanguageBatchInput(Lists[i])).Result;

                    foreach (var document in result.Documents)
                    {
                        string keyPhrases = string.Empty;

                        foreach (string keyphrase in document.KeyPhrases)
                        {
                            keyPhrases += keyphrase + " | ";

                            if (keyphrase != string.Empty)
                                KeyPhraseOccurrences.Add(keyphrase);
                        }

                        if (keyPhrases != string.Empty)
                            KeyPhrasesList.Add("Document ID: " + document.Id + ", Key Phrases: " + keyPhrases);
                    }
                    System.Threading.Thread.Sleep(delay);
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Error: " + ex.Message); }
        }

        /// <summary>
        /// This method gets the list of inputs and sends them off to the API
        /// to get a list of sentiment results returned.
        /// </summary>
        /// <param name="Inputs"></param>
        public void Sentiment(List<MultiLanguageInput> Inputs)
        {
            if (Inputs == null) { return; }

            List<List<MultiLanguageInput>> Lists = SplitIntoChunks(Inputs, 1000);

            try
            {
                for (int i = 0; i < Lists.Count; i++)
                {
                    SentimentBatchResult result = client.SentimentAsync(new MultiLanguageBatchInput(Lists[i])).Result;

                    // Printing sentiment results
                    foreach (var document in result.Documents)
                    {
                        //{1:0.00} gets 0.00 instead of 0.000000000000 ->

                        if (document.Score != null)
                        {
                            SentimentsList.Add("Document ID: " + document.Id + ", Sentiment Score: " + document.Score);
                            SentimentOccurrences.Add(document.Score.ToString());
                        }
                    }
                    System.Threading.Thread.Sleep(delay);
                }
            } catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Error: " + ex.Message); }
        }

        /// <summary>
        /// This method gets the list of inputs and sends them off to the API
        /// to get a list of entity results returned.
        /// </summary>
        /// <param name="Inputs"></param>
        public void Entities(List<MultiLanguageInput> Inputs)
        {
            if (Inputs == null) { return; }

            List<List<MultiLanguageInput>> Lists = SplitIntoChunks(Inputs, 1000);

            try
            {
                for (int i = 0; i < Lists.Count; i++)
                {
                    EntitiesBatchResultV2dot1 result = client.EntitiesAsync(new MultiLanguageBatchInput(Lists[i])).Result;

                    // Printing entities results
                    foreach (var document in result.Documents)
                    {
                        string entities = string.Empty;

                        foreach (EntityRecordV2dot1 entity in document.Entities)
                        {
                            if (entity.Name != string.Empty)
                            {
                                entities += entity.Name + " | ";
                                EntityOccurrences.Add(entity.Name);
                            }
                        }

                        if (entities != string.Empty)
                            EntitiesList.Add("Document ID: " + document.Id + ", Entities: " + entities);
                    }
                    System.Threading.Thread.Sleep(delay);
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Error: " + ex.Message); }
        }

        /// <summary>
        /// This method is called last and the original data is displayed from the input
        /// Also it creates the report form
        /// </summary>
        /// <param name="Inputs"></param>
        /// <returns></returns>
        public bool FinishTask(List<MultiLanguageInput> Inputs)
        {
            try
            {
                foreach (var input in Inputs)
                {
                    if (input.Text != string.Empty)
                        DataList.Add("Document ID: " + input.Id + ", Data: " + input.Text);
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Error: " + ex.Message); return false; }

            Report reportFrm = new Report(LanguagesList, KeyPhrasesList, SentimentsList, EntitiesList,
                DataList, KeyPhraseOccurrences, LanguageOccurrences, SentimentOccurrences, EntityOccurrences);

            reportFrm.Show();

            return true;
        }

        /// <summary>
        /// This method is used to test whether to API is working by sending sample data
        /// </summary>
        public void Test()
        {
            try
            {
                // Extracting language
                Console.WriteLine("===== LANGUAGE EXTRACTION ======");

                var result = client.DetectLanguageAsync(new BatchInput(
                        new List<Input>()
                            {
                          new Input("1", "This is a document written in English."),
                          new Input("2", "Este es un document escrito en Español."),
                          new Input("3", "这是一个用中文写的文件")
                        })).Result;

                // Printing language results.
                foreach (var document in result.Documents)
                {
                    Console.WriteLine("Document ID: {0} , Language: {1}", document.Id, document.DetectedLanguages[0].Name);
                }

                // Getting key-phrases
                Console.WriteLine("\n\n===== KEY-PHRASE EXTRACTION ======");

                KeyPhraseBatchResult result2 = client.KeyPhrasesAsync(new MultiLanguageBatchInput(
                            new List<MultiLanguageInput>()
                            {
                          new MultiLanguageInput("ja", "1", "猫は幸せ"),
                          new MultiLanguageInput("de", "2", "Fahrt nach Stuttgart und dann zum Hotel zu Fu."),
                          new MultiLanguageInput("en", "3", "My cat is stiff as a rock."),
                          new MultiLanguageInput("es", "4", "A mi me encanta el fútbol!")
                            })).Result;

                // Printing keyphrases
                foreach (var document in result2.Documents)
                {
                    Console.WriteLine("Document ID: {0} ", document.Id);

                    Console.WriteLine("\t Key phrases:");

                    foreach (string keyphrase in document.KeyPhrases)
                    {
                        Console.WriteLine("\t\t" + keyphrase);
                    }
                }

                // Extracting sentiment
                Console.WriteLine("\n\n===== SENTIMENT ANALYSIS ======");

                SentimentBatchResult result3 = client.SentimentAsync(
                        new MultiLanguageBatchInput(
                            new List<MultiLanguageInput>()
                            {
                          new MultiLanguageInput("en", "0", "I had the best day of my life."),
                          new MultiLanguageInput("en", "1", "This was a waste of my time. The speaker put me to sleep."),
                          new MultiLanguageInput("es", "2", "No tengo dinero ni nada que dar..."),
                          new MultiLanguageInput("it", "3", "L'hotel veneziano era meraviglioso. È un bellissimo pezzo di architettura."),
                            })).Result;


                // Printing sentiment results
                foreach (var document in result3.Documents)
                {
                    Console.WriteLine("Document ID: {0} , Sentiment Score: {1:0.00}", document.Id, document.Score);
                }


                // Identify entities
                Console.WriteLine("\n\n===== ENTITIES ======");

                EntitiesBatchResultV2dot1 result4 = client.EntitiesAsync(
                        new MultiLanguageBatchInput(
                            new List<MultiLanguageInput>()
                            {
                          new MultiLanguageInput("en", "0", "The Great Depression began in 1929. By 1933, the GDP in America fell by 25%.")
                            })).Result;

                // Printing entities results
                foreach (var document in result4.Documents)
                {
                    Console.WriteLine("Document ID: {0} ", document.Id);

                    Console.WriteLine("\t Entities:");

                    foreach (EntityRecordV2dot1 entity in document.Entities)
                    {
                        Console.WriteLine("\t\t" + entity.Name);
                    }
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Test Failed. Error: " + ex.Message); return; }
            System.Windows.Forms.MessageBox.Show("Test successful! Test results are in the console", "Success");
        }
    }
}

