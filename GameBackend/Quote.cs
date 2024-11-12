namespace GameBackend;
public class Quote{
    public List<char> QuoteCharacters;
    public string Author;
    public Quote(String quote, string author){
        QuoteCharacters = new List<char>();
        QuoteCharacters = quote.ToList();
        Author = author;

    }
    public string QuoteCharactersToString()
    {
        return new string(QuoteCharacters.ToArray());
    }
}
