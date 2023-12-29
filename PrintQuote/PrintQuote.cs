internal class PrintQuote
{
    static void Main(string[] args)
    {
        string quote= Utilities.AskForString("What is the quote? ");
        string author = Utilities.AskForString("Who said it? ");
        Console.WriteLine(author + " says, \"" + quote + "\"");
    }
}