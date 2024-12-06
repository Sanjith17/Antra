namespace _02UnderstandingTypes;

public class LongestSequence
{
    public static void Run()
    {
        Console.WriteLine("Give the imput. Once you finsh entering all the numbers, press enter in the blank new line");
        List<int[]> numbers = new List<int[]>();
        for (; true;)
        {
            String line = Console.ReadLine();
            if (line == "")
                break;
            int[] array = line.Trim().Split(' ').Select(int.Parse).ToArray();
            numbers.Add(array);
        }
        
        int[][] arrayofarraies = numbers.ToArray();
        for (int j = 0; j < arrayofarraies.Length; j++)
        {
            int longestStart = 0;
            int longestLength = 0;
            int currentStart = 0;
            int currentLength = 1;
            for (int i = 1; i < arrayofarraies[j].Length; i++)
            {
                if (arrayofarraies[j][i] == arrayofarraies[j][i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > longestLength)
                    {
                        longestLength = currentLength;
                        longestStart = currentStart;
                    }

                    // Reset the current sequence
                    currentStart = i;
                    currentLength = 1;
                }
            }

            // Final check after the loop
            if (currentLength > longestLength)
            {
                longestLength = currentLength;
                longestStart = currentStart;
            }
            
            for (int i = longestStart; i < longestStart + longestLength; i++)
            {
                Console.Write(arrayofarraies[j][i] + " ");
            }
            Console.WriteLine();
            
        }
        
    }
}