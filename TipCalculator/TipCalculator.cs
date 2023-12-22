using System.Security.Cryptography.X509Certificates;

namespace TipCalculator
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
    internal class TipCalculator
    {
        public double BillAmount { get; set; }
        public double TipPercentage { get; set; }
        public double Tip => BillAmount * TipPercentage / 100;
        public double Total => BillAmount + Tip;

        public TipCalculator() : this(0, 0) { }

        public TipCalculator(double billAmount, double tipPercentage)
        {
            BillAmount = billAmount;
            TipPercentage = tipPercentage;
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
            Console.WriteLine($"Tip: ${tipCalculator.Tip}");
            Console.WriteLine($"Total: ${tipCalculator.Total}");
        }
    }
}
