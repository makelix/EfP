public class SelfCheckout
{
    // Record for storing the price and quantity of an item.
    public record Item(decimal Price, int Quantity);

    public int Count { get { return _items.Count; } }
    public decimal Subtotal { get; private set; } = decimal.Zero;
    public decimal Tax { get; private set; } = decimal.Zero;
    public decimal Total { get; private set; } = decimal.Zero;

    /// <summary>
    /// Add item to SelfCheckout and recalculate properties.
    /// </summary>
    /// <param name="item">Item to add.</param>
    public void Add(Item item)
    {
        _items.Add(item);
        Subtotal += item.Price * item.Quantity;
        Tax = TaxRate * Subtotal / 100;
        Total = Subtotal + Tax;
    }

    // List of items.
    private readonly List<Item> _items = [];

    // Tax rate in percent.
    private const decimal TaxRate = 5.5M;

    static void Main(string[] args)
    {
        SelfCheckout selfCheckout = new();

        // Read list of items from user.
        ReadItems(selfCheckout);
        if (selfCheckout.Count == 0)
            return;

        Console.WriteLine($"Subtotal: {Utilities.ToDollarString(selfCheckout.Subtotal)}");
        Console.WriteLine($"Tax: {Utilities.ToDollarString(selfCheckout.Tax)}");
        Console.WriteLine($"Total: {Utilities.ToDollarString(selfCheckout.Total)}");
    }

    /// <summary>
    /// Read prices and quantities from the user.
    /// Add them as Items to SelfCheckout.
    /// </summary>
    private static void ReadItems(SelfCheckout selfCheckout)
    {
        // Loop until no price given.
        while (true)
        {
            // Compute number of next item.
            int nextItemNum = selfCheckout.Count + 1;

            // Read price of item.
            decimal price = Utilities.AskForDecimal($"Enter the price of item {nextItemNum}: ",
                                                    0M, Decimal.MaxValue, false, -1);

            // Exit when no price is given.
            if (price < 0)
                break;

            // Read number of items.
            int quantity = Utilities.AskForInt($"Enter the quantity of item {nextItemNum}: ", 1);

            // Store price and quantity as Item to SelfCheckou.
            selfCheckout.Add(new Item(price, quantity));
        }
    }

    /// <summary>
    /// Calculate the sum of items in a list.
    /// </summary>
    /// <param name="items">A list of Items.</param>
    /// <returns>Sum of items. Return 0 on null or empty list.</returns>
    private static decimal SumOfItems(List<Item> items)
    {
        if (items == null || items.Count == 0)
            return 0;

        decimal sum = 0M;
        foreach (var item in items)
        {
            sum += item.Price * item.Quantity;
        }
        return sum;
    }
}