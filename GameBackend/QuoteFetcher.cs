namespace GameBackend;
using System.IO;
using System.Text.Json.Nodes;
using Newtonsoft.Json;


public class QuoteFetcher
{
    //add singleton pattern implementation to quote fetcher
    public JsonObject fetchQuotes()
    {
        string filePath = "H:\\projects\\TypingApp\\quotes.json";
        string jsonContent = File.ReadAllText(filePath);
        JsonQuote[] quotes = JsonConvert.DeserializeObject<JsonQuote[]>(jsonContent);
        string json_data = JsonConvert.SerializeObject(quotes);
        Console.WriteLine(json_data);
        return null;
    }
}