using System.Text.Json.Nodes;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace GameBackend;

public class QuoteGenerator{
    public List<Quote> quotes;
    public List<String> strings;
    public QuoteFetcher fetcher;
    //add singleton pattern implementation to quote fetcher
    public QuoteGenerator(QuoteFetcher fetcher)
    {
        this.fetcher = fetcher;
        quotes = new List<Quote>();
        strings = new List<String>();

    }
    public void generateQuotes(){
        JObject jsonData = fetcher.fetchQuotes();
        JArray quotesArray = (JArray)jsonData["quotes"];

        foreach(var item in quotesArray)
        {
            string text = item["Quote"].ToString();
            Quote newQuote = new Quote(text);
            quotes.Add(newQuote);
        }
        foreach (var quote in quotes)
        {
            Console.WriteLine(new string(quote.QuoteCharacters.ToArray()));
        }

    }
    
}