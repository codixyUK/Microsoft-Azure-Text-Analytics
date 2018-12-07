using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Text_Analytics
{
    public partial class Main : Form
    {
        // Connection string of the excel document
        public static string connectionString = "";

        /// <summary>
        /// Main method
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method extracts the data from the excel or text document using
        /// a connection string and displaying the results in a Data Grid View
        /// </summary>
        private void UpdateConnection(int flag)
        {
            try
            {
                if (flag == 0)
                {
                    OleDbConnection connection = new OleDbConnection(connectionString);
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [Responses$]", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];
                }
                else if (flag == 1)
                {
                    // Set column names by using a comma or blank if its just one column
                    string[] textData = System.IO.File.ReadAllLines(connectionString);
                    string[] headers = textData[0].Split(',');

                    //Create and populate DataTable
                    DataTable dataTable1 = new DataTable();
                    foreach (string header in headers)
                        dataTable1.Columns.Add(header, typeof(string), null);
                    for (int i = 1; i < textData.Length; i++)
                        dataTable1.Rows.Add(textData[i].Split(','));

                    //Set the DataSource of DataGridView to the DataTable
                    dataGridView1.DataSource = dataTable1;
                }
                this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error extracting data from excel document:\n\n" + e.Message);
            }
        }

        /// <summary>
        /// On menu item click. Open import form
        /// On close -> Update connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importExcelDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Import ImportFrm = new Import(0))
            {
                if (ImportFrm.ShowDialog() == DialogResult.OK)
                {
                    if (connectionString != string.Empty)
                    {
                        this.UpdateConnection(0);
                    }
                }
            }
        }

        /// <summary>
        /// On menu item click. Open import form
        /// On close -> Update connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Import ImportFrm = new Import(1))
            {
                if (ImportFrm.ShowDialog() == DialogResult.OK)
                {
                    if (connectionString != string.Empty)
                    {
                        this.UpdateConnection(1);
                    }
                }
            }
        }

        /// <summary>
        /// Menu item on click. Test the Text Analstic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextAnalyticClient textAnalysisClient = new TextAnalyticClient();
            textAnalysisClient.Test();
        }

        /// <summary>
        /// Menu item on click. Open the RunAnalytic form
        /// Pass the Data Grid View Control as parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runAnalysticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunAnalytic runAnalytic = new RunAnalytic(dataGridView1);
            runAnalytic.Show();
        }

        /// <summary>
        /// Menu item on click. Opens the CustomAnalytic form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runCustomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomAnalytic customAnalytic = new CustomAnalytic();
            customAnalytic.Show();
        }

        /// <summary>
        /// Menu item on click. Opens a internal .txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\Data\\ReadMe.txt");
        }
    }
}
