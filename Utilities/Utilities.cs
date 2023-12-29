public class Utilities
{
    /// <summary>
    /// Request a string from the user on commandline.
    /// </summary>
    /// <param name="prompt">The prompt presented to the user.</param>
    /// <param name="isMandatory">If true, the user must provide a valid strin.</param>
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

    public static void Main()
    {
        string input = AskForString("Type a string: ");
        Console.WriteLine($"You typed: {input}");
    }
}
