
internal class RectangularRoomArea
{
    private const decimal Factor = 0.09290304M;

    static void Main(string[] args)
    {
        decimal length = Utilities.AskForDecimal("What is the length of the room in feet? ", 0M);
        decimal width = Utilities.AskForDecimal("What is the width of the room in feet? ", 0M);
        decimal areaInSquareFeet = width * length;
        decimal areaInSquareMeters = SquareFeetToSquareMeters(areaInSquareFeet);

        Console.WriteLine($"You entered dimensions of {length} feet by {width} feet.");
        Console.WriteLine("The area is");
        Console.WriteLine($"{areaInSquareFeet} square feet");
        Console.WriteLine($"{Math.Round(areaInSquareMeters, 3, MidpointRounding.ToEven)} square meters");
    }

    private static decimal SquareFeetToSquareMeters(decimal areaInSquareFeet)
    {
        return areaInSquareFeet * Factor;
    }

    private static decimal SquareMetersToSquareFeet(decimal areaInSquareMeters)
    {
        return areaInSquareMeters / Factor;
    }
}
