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

            Console.Clear();

            //start game
            StartTypingChallenge(selectedQuote);
        }
        public static void StartTypingChallenge(Quote quote)
        {
            string correctQuote = quote.QuoteCharactersToString();
            int totalCharacters = correctQuote.Length;
            int correctCount = 0;

            //create line of _ of the lenght of the quote
            char[] userInput = new char[totalCharacters];
            for (int i = 0; i < totalCharacters; i++)
                userInput[i] = '_';

            for( int i = 0; i< totalCharacters; i++)
            {
                Console.Clear();
                Console.WriteLine("Start typing:");
                Console.WriteLine("Your quote: " + correctQuote);
                Console.WriteLine("Author: " + quote.Author);
                Console.WriteLine("Your input:");
                Console.WriteLine(new string(userInput));

                //check which key is pressed by user
                var key = Console.ReadKey(intercept: true);

                //check if entered character is correct
                if (key.KeyChar == correctQuote[i])
                {
                    userInput[i] = key.KeyChar;  
                    correctCount++;           
                }
                //if char is incorrect:
                else
                {
                    userInput[i] = key.KeyChar;
                }
                

            }
            //show user's result
            double accuracy = ((double)correctCount / totalCharacters) * 100;
            Console.Clear();
            Console.WriteLine("Typing challenge is done!");
            Console.WriteLine("Your accuracy: "+Math.Round(accuracy, 2)+"%");

        }
    }
}
