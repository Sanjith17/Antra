using System.Text.RegularExpressions;

namespace _02UnderstandingTypes;

public class ServerParser
{
    public static void Run()
    {
        String input = Console.ReadLine();
        char[] specialCharacters = { '.', ',', ':', ';', '?', '!', '\'', '\"', '(', ')', '[', ']', '\\', '/', '&', '=' };
        String separators = @"//:";
        string[] words = Regex.Split(input.Trim(), separators);
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }

    }
}