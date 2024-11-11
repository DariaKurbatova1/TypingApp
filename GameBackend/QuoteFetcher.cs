namespace GameBackend;
using System.IO;
using System.Text.Json.Nodes;

public class QuoteFetcher{
    //add singleton pattern implementation to quote fetcher
    public JsonObject fetchQuotes(){
        StreamReader reader = new StreamReader("H:\\projects\\TypingApp\\quotes.json");
        string line = reader.ReadToEnd();
        Console.WriteLine(line);
        return null;
    }
}