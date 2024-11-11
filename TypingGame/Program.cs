using GameBackend;

namespace TypingGame
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("hello");
            Quote quote = new Quote("hello");
            foreach (char c in quote.QuoteCharacters)
            {
                Console.WriteLine(c);
            }
            QuoteGenerator qg = new QuoteGenerator();
            qg.generateQuotes();
            foreach (String s in qg.strings){
                Console.Write(s);
            }
        }
    }
}
