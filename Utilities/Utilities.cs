using System.Globalization;
using System.Text;

public class Utilities
{
    /// <summary>
    /// Request a string from the user on commandline.
    /// </summary>
    /// <param name="prompt">The prompt presented to the user.</param>
    /// <param name="isMandatory">If true, the user must provide a valid string.</param>
    /// <param name="defaultValue">The defaultValue is returned when isMandatory == false
    ///                            and the user doesn't provide an answer.</param>
    /// <returns>The string provided by the user or the defaultValue.</returns>
    public static string AskForString(string prompt,
                                      bool   isMandatory = true,
                                      string defaultValue = "")
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            // If we received a string, return it.
            if (!String.IsNullOrEmpty(input))
                return input;

            // We didn't receive a string: if input isn't mandatory,
            // return the default value.
            if (!isMandatory)
                return defaultValue;

            // Input is mandatory but we didn't receive it:
            // loop until we get one.
        }
    }

    /// <summary>
    /// Request an integer from the user on commandline.
    /// </summary>
    /// <param name="prompt">The prompt presented to the user.</param>
    /// <param name="minValue">The minimum accepted value.</param>
    /// <param name="maxValue">The maximum accepted value.</param>
    /// <param name="isMandatory">If true, the user must provide a valid integer.</param>
    /// <param name="defaultValue">The defaultValue is returned when isMandatory == false
    ///                            and the user doesn't provide an answer. The defaultValue
    ///                            can be outside the minimum and maximum values.
    /// <returns>The integer provided by the user or the defaultValue.</returns>
    public static int AskForInt(string prompt,
                                int minValue = int.MinValue,
                                int maxValue = int.MaxValue,
                                bool isMandatory = true,
                                int defaultValue = 0)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            // If we didn't receive input...
            if (String.IsNullOrEmpty(input))
            {
                // ...but input is mandatory, ask again.
                if (isMandatory)
                    continue;

                // If input isn't mandatory, return the default value.
                return defaultValue;
            }

            // We received a string - if it's a valid number between
            // minValue and maxValue, return it.
            if (int.TryParse(input, out int result))
            {
                if (minValue <= result && result <= maxValue)
                    return result;
            }
        }
    }

    /// <summary>
    /// Request a decimal from the user on commandline.
    /// </summary>
    /// <param name="prompt">The prompt presented to the user.</param>
    /// <param name="minValue">The minimum accepted value.</param>
    /// <param name="maxValue">The maximum accepted value.</param>
    /// <param name="isMandatory">If true, the user must provide a valid decimal.</param>
    /// <param name="defaultValue">The defaultValue is returned when isMandatory == false
    ///                            and the user doesn't provide an answer. The defaultValue
    ///                            can be outside the minimum and maximum values.
    /// <returns>The decimal provided by the user or the defaultValue.</returns>
    public static decimal AskForDecimal(string prompt,
                                        decimal minValue = decimal.MinValue,
                                        decimal maxValue = decimal.MaxValue,
                                        bool isMandatory = true,
                                        decimal defaultValue = 0M)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            // If we didn't receive input...
            if (String.IsNullOrEmpty(input))
            {
                // ...but input is mandatory, ask again.
                if (isMandatory)
                    continue;

                // If input isn't mandatory, return the default value.
                return defaultValue;
            }

            // We received a string - if it's a valid number between
            // minValue and maxValue, return it.
            if (decimal.TryParse(input, out decimal result))
            {
                if (minValue <= result && result <= maxValue)
                    return result;
            }
        }
    }

    /// <summary>
    /// Convert a decimal number to a string like "$13.00".
    /// </summary>
    /// <param name="value">Value to convert.</param>
    /// <returns>String representation of the value.</returns>
    public static string ToDollarString(decimal value)
    {
        // Construct the string to return.
        StringBuilder sb = new();

        // Round the number to two decimal places.
        decimal roundedValue = Math.Round(value, 2, MidpointRounding.AwayFromZero);
        
        // Append sign if necessary.
        if (roundedValue < 0) sb.Append('-');

        // Append dollar sign and absolute value.
        sb.Append(Math.Abs(roundedValue).ToString("$0.00", CultureInfo.InvariantCulture));

        return sb.ToString();
    }

    public static void Main()
    {
        int input = AskForInt("Type a number: ");
        Console.WriteLine($"You typed: {input}");
    }
}
