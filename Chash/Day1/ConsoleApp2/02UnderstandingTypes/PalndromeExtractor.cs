using System.Text.RegularExpressions;

namespace _02UnderstandingTypes;

public class PalndromeExtractor
{
    public static void Run()
    {
        String input = Console.ReadLine();
        char[] specialCharacters = { '.', ',', ':', ';', '?', '!', '\'', '\"', '(', ')', '[', ']', '\\', '/', '&', '=' };
        String separators = @"[.,:;=()&[\]""'/\\!? ]";

        // Split the input into words and separators
        string[] words = Regex.Split(input.Trim(), separators);
        List<String> palndromes = new List<String>();

        for (int i = 0; i < words.Length; i++)
        {
            if (CheckPalindrome(words[i].Trim(specialCharacters)))
            {
                palndromes.Add(words[i].Trim(specialCharacters));
            }
        }
        palndromes.Sort();
        String[] array = palndromes.ToArray();
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i].Length > 0)
            {
                Console.Write($"{array[i]}, ");
            }
        }
        Console.WriteLine($"{array[array.Length - 1]}");
        // Console.WriteLine(string.Join(", ", palndromes));
    }

    public static bool CheckPalindrome(String word)
    {
        
        int j = word.Length - 1;
        
        string reversed = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversed += word[i];
        }
        // Console.WriteLine(reversed);
        if (word == reversed)
        {
            return true;
        }
        return false;

    }
}