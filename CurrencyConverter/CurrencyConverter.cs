public class CurrencyConverter
{
    private static readonly string _app_id_name = "OPENEXCHANGERATES_APP_ID";
    private static string? _app_id = null;
    private decimal _exchangeRate = 1.0942M;

    static CurrencyConverter()
    {
        _app_id = Environment.GetEnvironmentVariable(_app_id_name);
        if (_app_id == null) throw new Exception($"Could not read {_app_id_name}");
    }

    public decimal Convert(decimal amountFrom)
    {
        if (amountFrom < 0) { throw new ArgumentOutOfRangeException("Amount must be positive.") ; }
        return Math.Round((amountFrom * 1) / _exchangeRate, 2, MidpointRounding.AwayFromZero);
    }

    public void SetRate(decimal exchangeRate = 1.0942M) => _exchangeRate = exchangeRate;

    static void Main(string[] args)
    {
        string? s = Environment.GetEnvironmentVariable("OPENEXCHANGERATES_APP_ID");
        Console.WriteLine(s);
        CurrencyConverter converter = new();
        decimal amountFrom = Utilities.AskForDecimal("How many euros are you exchanging? ", 0M);
        decimal exchangeRate = Utilities.AskForDecimal("What is the exchange rate? ", 0);
        converter.SetRate(exchangeRate);
        decimal amountTo = converter.Convert(amountFrom);
        Console.WriteLine($"{amountFrom} euros at an exchange rate of {exchangeRate} is\n{amountTo} U.S. dollars.");
    }
}
