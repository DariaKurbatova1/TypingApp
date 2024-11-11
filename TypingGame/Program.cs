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
        }
    }
}
