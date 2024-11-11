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
        
    }
    
}