using System.Text.Json.Nodes;

namespace GameBackend;

public class QuoteGenerator{
    public List<Quote> quotes;
    //add singleton pattern implementation to quote fetcher
    public QuoteFetcher fetcher = new QuoteFetcher();
    public QuoteGenerator(){

    }
    public void generateQuotes(){
        JsonObject json = fetcher.fetchQuotes();
        
    }
    
}