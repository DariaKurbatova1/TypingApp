using System.Text.Json.Nodes;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace GameBackend;

public class QuoteGenerator{
    public List<Quote> quotes;
    public List<String> strings;
    //add singleton pattern implementation to quote fetcher
    public QuoteFetcher fetcher = new QuoteFetcher();
    public QuoteGenerator(){
        quotes = new List<Quote>();
        strings = new List<String>();

    }
    public void generateQuotes(){
        JsonObject json = fetcher.fetchQuotes();
        var dict = JsonConvert.DeserializeObject<List<JsonQuote>>(json.ToString());
        var asArray = dict.ToArray();
        foreach (var item in asArray){
            Console.WriteLine(item);
        }
        // foreach(var item in json){
        //     Console.WriteLine(item.quote);
        // }


        // foreach (JsonObject quoteObject in json.OfType<JsonObject>()){
        //     Console.WriteLine(quoteObject);
        //     if (quoteObject.TryGetPropertyValue("quote", out JsonNode quoteText)){
        //         quotes.Add(new Quote(quoteText.ToString()));
        //         strings.Add(quoteText.ToString());
        //         Console.WriteLine(quoteText.ToString());
        //     }
        // }
        
    }
    
}