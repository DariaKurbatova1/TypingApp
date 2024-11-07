namespace GameBackend;
public class Quote{
    public List<char> QuoteCharacters;
    public Quote(String quote){
        QuoteCharacters = new List<char>();
        QuoteCharacters = quote.ToList();
    }
}
