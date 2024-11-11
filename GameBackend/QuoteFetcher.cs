namespace GameBackend;
using System.IO;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


public class QuoteFetcher
{
    //add singleton pattern implementation to quote fetcher
    public JObject fetchQuotes()
    {
        string filePath = "H:\\projects\\TypingApp\\quotes.json";
        string jsonContent = File.ReadAllText(filePath);
        JsonQuote[] quotes = JsonConvert.DeserializeObject<JsonQuote[]>(jsonContent);
        JObject jsonData = JObject.FromObject(new { quotes });
        Console.WriteLine(jsonData);
        return jsonData;
    }
}