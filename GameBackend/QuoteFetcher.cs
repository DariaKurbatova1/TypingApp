namespace GameBackend;
using System.IO;
using System.Text.Json.Nodes;

public class QuoteFetcher{
    //add singleton pattern implementation to quote fetcher
    public JsonObject fetchQuotes(){
        try{
            StreamReader sr = new StreamReader("/Users/dariakurbatova/Documents/Coding Projects/TypingApp/quotes.json");
            String jsonString = sr.ReadToEnd();
            sr.Close();
            JsonObject jsonObject = JsonNode.Parse(jsonString).AsObject();
            Console.WriteLine(jsonObject);
            return jsonObject;
        }
        catch (Exception e){
            Console.WriteLine("Exception: " + e.Message);
        }
        return null;
    }
}