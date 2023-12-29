internal class RetirementCalculator
{
    static void Main(string[] args)
    {
        int age = Utilities.AskForInt("What is your current age? ");
        int retirementAge = Utilities.AskForInt("At what age would you like to retire? ");

        int yearsLeft = retirementAge - age;
        int currentYear = DateTime.Now.Year;
        int retirementYear = currentYear + yearsLeft;

        if (yearsLeft < 0)
        {
            Console.WriteLine("You can already retire.");
        }
        else
        {            
            Console.WriteLine($"You have {yearsLeft} years left until you can retire.");
            Console.WriteLine($"It's {currentYear}, so you can retire in {retirementYear}.");
        }
    }
}
