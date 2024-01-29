using System.Net.Http;

public class CurrencyConverter
{
    /// <summary>
    /// Application ID used to connect to OpenExchangeRates.
    /// </summary>
    private readonly string _app_id = string.Empty;

    /// <summary>
    /// Base address of OpenExchangeRates API.
    /// </summary>
    private const string _baseAddress = "https://openexchangerates.org/api/";

    private readonly HttpClient _httpClient = new()
    {
        BaseAddress = new Uri(_baseAddress)
    };

    private decimal _exchangeRate = 1.0942M;

    public CurrencyConverter(string appId)
    {
        if (String.IsNullOrWhiteSpace(appId))
            throw new ArgumentException("OpenExchangeRates application ID cannot be empty.");
        _app_id = appId;
    }

    /// <summary>
    /// Get exchange rates from OpenExchangeRates.
    /// </summary>
    /// <returns>The received content as string.</returns>
    public async Task<string> GetRatesAsync()
    {
        try
        {
            using HttpResponseMessage response = await _httpClient.GetAsync($"latest.json?app_id={_app_id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException e)
        {
            throw new Exception(e.Message);
        }
    }

    public decimal Convert(decimal amountFrom)
    {
        if (amountFrom < 0) { throw new ArgumentOutOfRangeException("Amount must be positive.") ; }
        return Math.Round((amountFrom * 1) / _exchangeRate, 2, MidpointRounding.AwayFromZero);
    }

    public void SetRate(decimal exchangeRate = 1.0942M) => _exchangeRate = exchangeRate;

    static async Task Main(string[] args)
    {
        // Get OpenExchangeRates application ID from environment variable.
        string? appId = Environment.GetEnvironmentVariable("OPENEXCHANGERATES_APP_ID");
        if (String.IsNullOrWhiteSpace(appId))
            throw new Exception("AppID is empty.");
        Console.WriteLine($"Application ID: {appId}");

        // Create a converter using the application ID.
        CurrencyConverter converter = new(appId);

        // Get JSON from OpenExchangeRates.
        string json = await converter.GetRatesAsync();
        Console.WriteLine(json);

/*        decimal amountFrom = Utilities.AskForDecimal("How many euros are you exchanging? ", 0M);
        decimal exchangeRate = Utilities.AskForDecimal("What is the exchange rate? ", 0);
        converter.SetRate(exchangeRate);
        decimal amountTo = converter.Convert(amountFrom);
        Console.WriteLine($"{amountFrom} euros at an exchange rate of {exchangeRate} is\n{amountTo} U.S. dollars.");
*/    }
}
