using GameBackend;

namespace TypingGame
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the typing test game!");

            QuoteFetcher fetcher = new QuoteFetcher();
            QuoteGenerator generator = new QuoteGenerator(fetcher);

            generator.generateQuotes();

            //get random quote
            Random rand = new Random();
            Quote selectedQuote = generator.quotes[rand.Next(generator.quotes.Count)];

            //display quote to user
            Console.Clear();
            Console.WriteLine("Type the following quote as accurately as you can...\n");
            Console.WriteLine($"Quote: \"{selectedQuote.QuoteCharactersToString()}\"\n");

        }
    }
}
