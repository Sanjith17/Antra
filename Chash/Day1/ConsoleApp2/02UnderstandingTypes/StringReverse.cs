namespace _02UnderstandingTypes;

public class StringReverse
{
    public static void Run()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Method 1: Using char array
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed1 = new string(charArray);

        Console.WriteLine("Reversed (Method 1): " + reversed1);

        // Method 2: Using a for-loop
        string reversed2 = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed2 += input[i];
        }

        Console.WriteLine("Reversed (Method 2): " + reversed2);
    }
}