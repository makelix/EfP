public class SelfCheckout
{
    // Record for storing the price and quantity of an item.
    private record Item(decimal Price, int Quantity);

    // Tax rate in percent.
    private static decimal TaxRate = 5.5M;

    static void Main(string[] args)
    {
        // Read list of items from user.
        List<Item> items = ReadItems();
        if (items == null || items.Count == 0)
            return;

        // Calculate subtotal, taxes and total.
        decimal subtotal = SumOfItems(items);
        decimal tax = TaxRate * subtotal / 100;
        decimal total = subtotal + tax;

        Console.WriteLine($"Subtotal: {Utilities.ToDollarString(subtotal)}");
        Console.WriteLine($"Tax: {Utilities.ToDollarString(tax)}");
        Console.WriteLine($"Total: {Utilities.ToDollarString(total)}");
    }

    /// <summary>
    /// Read Prices and Quantities of Items from user.
    /// </summary>
    /// <returns>List of Items.</returns>
    private static List<Item> ReadItems()
    {
        List<Item> items = new();

        // Loop until no price given.
        while (true)
        {
            // Proceed to next "row" of bill.
            int row = items.Count + 1;

            // Read price of item.
            decimal price = Utilities.AskForDecimal($"Enter the price of item {row}: ",
                                                    0M, Decimal.MaxValue, false, -1);

            // Exit loop when no price given.
            if (price < 0)
                break;

            // Read number of items.
            int quantity = Utilities.AskForInt($"Enter the quantity of item {row}: ", 1);

            // Store price and quantity as Item.
            items.Add(new Item(price, quantity));
        }

        return items;
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