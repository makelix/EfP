using System.Text;

internal class SimpleMath
{
    static void Main(string[] args)
    {
        int first = Utilities.AskForInt("What is the first number? ");
        int second = Utilities.AskForInt("What is the second number? ");
        StringBuilder sb = new();
        sb.Append($"{first} + {second} = {first + second}\n");
        sb.Append($"{first} - {second} = {first - second}\n");
        sb.Append($"{first} * {second} = {first * second}\n");
        sb.Append($"{first} / {second} = {first / second}");
        Console.WriteLine(sb.ToString());
    }
}
