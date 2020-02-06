# Text-Analytics
Using Microsoft Azure's powerful Text Analystic tool to run through excel and text documents, while extracting results for languages, key-phrases, sentiments and entities. The results are displayed in a list, occurrences, charts and reports. You can select which columns you would like to analyse from the excel or text file. 

# How to set it up

Go to Microsoft Azure Portal and grab a API key for the Text Analytic resource. I recommend the 1,000 calls per minute subscription tier.
Head to: Text-Analytics/Text Analytics/Classes/ApiKeyServiceClientCredentials.cs and replace the API strings with your API keys.

```
// Add subscription key here
string[] subscriptionKeys = { "" };
```

Head over to: Text-Analytics/Text Analytics/Classes/TextAnalyticClient.cs and replace the endpoint with your API endpoint.

```
// Create a client.
client = new TextAnalyticsClient(new ApiKeyServiceClientCredentials())
{
    // End point may change if you upgrade the API
    Endpoint = "https://uksouth.api.cognitive.microsoft.com"
};
```

and you're good to go :)
