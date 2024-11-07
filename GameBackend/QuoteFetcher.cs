namespace GameBackend;
using System.IO;

public class QuoteFetcher{
    public QuoteFetcher(){
        
        

    }
    public void fetchQuote(){
        try{
            StreamReader sr = new StreamReader("/Users/dariakurbatova/Documents/Coding Projects/TypingApp/quotes.json");
            String? line = sr.ReadLine();
            while (line != null){
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
            Console.ReadLine();
        }
        catch (Exception e){
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}