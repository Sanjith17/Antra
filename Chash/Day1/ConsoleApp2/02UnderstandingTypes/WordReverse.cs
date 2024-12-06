using System.Text.RegularExpressions;

namespace _02UnderstandingTypes;

public class WordReverse
{
    public static void Run()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        // Define separators
        string separators = @"[.,:;=()&[\]""'/\\!? ]";

        // Split the input into words and separators
        string[] words = Regex.Split(input.Trim(), separators);
        MatchCollection separatorsMatches = Regex.Matches(input, separators);

        List<string> reversedWords = new List<string>();
        foreach (var word in words)
        {
            if (!string.IsNullOrWhiteSpace(word)) // Ignore empty parts from split
            {
                reversedWords.Add(word);
            }
        }
        reversedWords.Reverse();

        
        int wordIndex = 0;
        string result = "";
        foreach (Match match in separatorsMatches)
        {
            if (wordIndex < reversedWords.Count)
            {
                result += reversedWords[wordIndex++];
            }
            result += match.Value; // Append separator
        }

        if (wordIndex < reversedWords.Count)
        {
            result += reversedWords[wordIndex];
        }

        // Output the result
        Console.WriteLine("Reversed sentence:");
        Console.WriteLine(result);
    }
}