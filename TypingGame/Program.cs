using GameBackend;

namespace TypingGame
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("hello");
            QuoteFetcher fetcher = new QuoteFetcher();
            fetcher.fetchQuotes();
            QuoteGenerator generator = new QuoteGenerator(fetcher);
            generator.generateQuotes();
        }
    }
}
