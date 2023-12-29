using System.Text;

internal class SimpleMath
{
    static void Main(string[] args)
    {
        int first = Utilities.AskForInt("What is the first number? ", 0);
        int second = Utilities.AskForInt("What is the second number? ", 0);
        StringBuilder sb = new();
        sb.Append($"{first} + {second} = {first + second}\n");
        sb.Append($"{first} - {second} = {first - second}\n");
        sb.Append($"{first} * {second} = {first * second}\n");
        sb.Append($"{first} / {second} = {first / second}");
        Console.WriteLine(sb.ToString());
    }
}
