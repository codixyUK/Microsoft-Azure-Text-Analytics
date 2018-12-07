****************************************************************************************
The application is designed to import excel documents and text files to run a powerful 
Text Analytic API against the results.

Project Created by Richard Jacobs for Selenity under work experience.
Any issues, feel free to contact Richard: richardjacobs97@hotmail.co.uk.
05/12/2018

****************************************************************************************

[1] "One or more errors occurred" - This is an error indicating that the API cannot 
process the data due to a number of reasons e.g:

	1) The API subscription restricts the amount of documents per request.
	   Each request needs to have a 1000 or less documents
	   See: Classes/TextAnalyticClient/List<T>SplitIntoChunks()
       This method splits all the data into a list of 1000 documents

	2) The Text Analytic Client cannot connect due to incorrect API keys. 
       See Classes/ApiKeyServiceClientCredentials/subscriptionKeys[]

	3) The Text Analstic Client cannot connect due to incorrect end point address
       See Classes/TextAnalyticClient/TextAnalyticClient()

	4) You have simply reached the maximum number of requests per subscription
       Update the subscription

NOTE: To change the Text Analytic subscription, you must update the API keys and the end point address!

[2] "Error extracting data from excel document:" - This is an error indicating that the data
from the excel document cannot be extracted. This can be caused by a number of reasons:

	1) Excel file directory doesn't exist
	   Make sure you actually select the correct directory of the excel document

	2) Excel file is in the wrong format. Use .xls, .xlsx, .xlsm only
       Run .xlsx for best results

	3) Excel file is in the wrong style
       Make sure row 1 of the excel document holds the columns, so that we can extract and pick which columns we want to use

	4) File too big to extract 
       Consider splitting the excel file into smaller parts for the program to process.

