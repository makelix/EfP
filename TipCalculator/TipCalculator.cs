using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TipCalculatorNS
{
    /// <summary>
    /// Create a simple tip calculator. The program should prompt
    /// for a bill amount and a tip rate.The program must compute
    /// the tip and then display both the tip and the total amount of
    /// the bill.
    /// Example output:
    /// What is the bill? $200
    /// What is the tip percentage? 15
    /// The tip is $30.00
    /// The total is $230.00
    /// </summary>
    public class TipCalculator
    {
        /// <summary>
        /// Bill amount in dollars.
        /// </summary>
        public decimal BillAmount { get; set; }

        /// <summary>
        /// Tip rate in percents.
        /// </summary>
        public decimal TipRate { get; set; }

        /// <summary>
        /// The tip in dollars.
        /// </summary>
        public decimal Tip => Math.Round((BillAmount * TipRate / 100), 2, MidpointRounding.AwayFromZero);

        /// <summary>
        /// The total sum (bill amount + tip) in dollars.
        /// </summary>
        public decimal Total => Math.Round((BillAmount + Tip), 2, MidpointRounding.AwayFromZero);

        /// <summary>
        /// The tip as a string: $#.##
        /// </summary>
        // TODO: round up
        public string TipAsString => Tip.ToString("$0.00", CultureInfo.InvariantCulture);

        /// <summary>
        /// The total sum as string $#.##
        /// </summary>
        // TODO: round up
        public string TotalAsString => Total.ToString("$0.00", CultureInfo.InvariantCulture);

        public TipCalculator() : this(0, 0) { }

        public TipCalculator(decimal billAmount, decimal tipPercentage)
        {
            if (Decimal.IsNegative(billAmount))
            {
                throw new ArgumentOutOfRangeException("Amount must be positive.");
            }

            if (Decimal.IsNegative(tipPercentage))
            {
                throw new ArgumentOutOfRangeException("Tip must be positive.");
            }

            BillAmount = billAmount;
            TipRate = tipPercentage;
        }

        static void Main(string[] args)
        {
            // Read sum of bill and tip percentage.
            Console.WriteLine("Input:");
            decimal billAmount = DoRead("bill amount");
            decimal tipPercentage = DoRead("tip rate");

            // Calculate tip and total.
            TipCalculator tipCalculator = new(billAmount, tipPercentage);

            // Print tip and total.
            Console.WriteLine($"The tip is {tipCalculator.TipAsString}");
            Console.WriteLine($"The total is {tipCalculator.TotalAsString}");
        }

        /// <summary>
        /// Prompt user for a positive decimal number.
        /// Loop until they give one.
        /// </summary>
        /// <param name="prompt">The prompt to show the user.</param>
        /// <returns>A positive decimal number.</returns>
        private static decimal DoRead(string prompt)
        {
            while (true)
            {
                Console.Write($"  {prompt}: ");
                string? line = Console.ReadLine();

                if (Decimal.TryParse(line, out decimal value)
                    && Decimal.IsPositive(value))
                {
                    return value;
                }

                Console.WriteLine("Expected result: Please enter a valid number for");
                Console.WriteLine($"                 the {prompt}.");
            }
        }
    }
}
