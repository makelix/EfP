using System.Globalization;

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
        public double BillAmount { get; set; }

        /// <summary>
        /// Tip rate in percents.
        /// </summary>
        public double TipRate { get; set; }

        /// <summary>
        /// The tip in dollars.
        /// </summary>
        public double Tip => BillAmount * TipRate / 100;

        /// <summary>
        /// The total sum (bill amount + tip) in dollars.
        /// </summary>
        public double Total => BillAmount + Tip;

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

        public TipCalculator(double billAmount, double tipPercentage)
        {
            if (Double.IsNegative(billAmount))
            {
                throw new ArgumentOutOfRangeException("Amount must be positive.");
            }

            if (Double.IsNegative(tipPercentage))
            {
                throw new ArgumentOutOfRangeException("Tip must be positive.");
            }

            BillAmount = billAmount;
            TipRate = tipPercentage;
        }

        static void Main(string[] args)
        {
            // Read sum of bill.
            double billAmount = 100.0;

            // Read tip percentage.
            double tipPercentage = 5.0;

            // Calculate tip.
            // Calculate total.
            TipCalculator tipCalculator = new(billAmount, tipPercentage);

            // Print tip and total.
            Console.WriteLine($"The tip is {tipCalculator.TipAsString}");
            Console.WriteLine($"The total is {tipCalculator.TotalAsString}");
        }
    }
}
