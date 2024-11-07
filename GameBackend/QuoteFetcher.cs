namespace GameBackend;
using System.IO;
using System.Text.Json.Nodes;

public class QuoteFetcher{
    public QuoteFetcher(){
        
        

    }
    public JsonObject fetchQuote(){
        try{
            StreamReader sr = new StreamReader("/Users/dariakurbatova/Documents/Coding Projects/TypingApp/quotes.json");
            String jsonString = "";
            String? line = sr.ReadLine();
            jsonString += line;
            while (line != null){
                line = sr.ReadLine();
                jsonString += line;
            }
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