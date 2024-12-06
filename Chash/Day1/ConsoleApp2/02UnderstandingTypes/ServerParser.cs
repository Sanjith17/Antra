using System.Text.RegularExpressions;

namespace _02UnderstandingTypes;

public class ServerParser
{
    public static void Run()
    {
        String input = Console.ReadLine();
        char[] specialCharacters = { '.', ',', ':', ';'};
        String separators = @"/";
        string[] words = Regex.Split(input.Trim(), separators);
        
        List<String> list = new List<String>();
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].Trim(specialCharacters);
            if (words[i].Length > 0)
            {
                list.Add(words[i]);
            }
        }

        String[] arrWords = list.ToArray();

        if (arrWords.Length == 1)
        {
            Console.WriteLine("[protocol] = \"\"");
            Console.WriteLine($"[server] = \"{arrWords[0]}\"");
            Console.WriteLine("[resource] = \"\"");
            
        }
        else if (arrWords.Length == 3)
        {
            Console.WriteLine($"[protocol] = \"{arrWords[0]}\"");
            Console.WriteLine($"[server] = \"{arrWords[1]}\"");
            Console.WriteLine($"[resource] = \"{arrWords[2]}\"");

            
        }
        else if (arrWords[0].IndexOf(".") >= 0)
        {
            Console.WriteLine($"[protocol] = \"\"");
            Console.WriteLine($"[server] = \"{arrWords[0]}\"");
            Console.WriteLine($"[resource] = \"{arrWords[1]}\"");
        }
        else
        {
            Console.WriteLine($"[protocol] = \"{arrWords[0]}\"");
            Console.WriteLine($"[server] = \"{arrWords[1]}\"");
            Console.WriteLine($"[resource] = \"\"");
        }

    }
}