

public class CurrencyConverter
{
    private decimal _exchangeRate = 1.0942M;

    public decimal Convert(decimal amountFrom)
    {
        if (amountFrom < 0) { throw new ArgumentOutOfRangeException("Amount must be positive.") ; }
        return Math.Round((amountFrom * 1) / _exchangeRate, 2, MidpointRounding.AwayFromZero);
    }

    public void SetRate(decimal exchangeRate = 1.0942M) => _exchangeRate = exchangeRate;

    static void Main(string[] args)
    {
        CurrencyConverter converter = new();
        decimal amountFrom = Utilities.AskForDecimal("How many euros are you exchanging? ", 0M);
        decimal exchangeRate = Utilities.AskForDecimal("What is the exchange rate? ", 0);
        converter.SetRate(exchangeRate);
        decimal amountTo = converter.Convert(amountFrom);
        Console.WriteLine($"{amountFrom} euros at an exchange rate of {exchangeRate} is\n{amountTo} U.S. dollars.");
    }
}
