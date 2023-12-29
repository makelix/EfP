using System.Collections;
using System.Collections.Generic;

internal class PrintQuote
{
    static void Main(string[] args)
    {
        List<KeyValuePair<string, string>> quotes = [];
        while (true)
        {
            string quote= Utilities.AskForString("What is the quote? ", false);
            if (String.IsNullOrEmpty(quote))
                break;
            string author = Utilities.AskForString("Who said it? ");
            KeyValuePair<string, string> kvp = new(author, quote);
            quotes.Add(kvp);
        }

        foreach (var quote in quotes)
        {
            Console.WriteLine(quote.Key + " says, \"" + quote.Value + "\"");
        }
    }
}