namespace _02UnderstandingTypes;

public class MostFrequent
{
    public static void Run()
    {
        Console.WriteLine("Give the input. Once you finsh entering all the numbers, press enter in the blank new line");
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
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            // Calculate frequency of each number
            foreach (int number in arrayofarraies[j])
            {
                if (frequency.ContainsKey(number))
                {
                    frequency[number]++;
                }
                else
                {
                    frequency[number] = 1;
                }
            }

            // Find the maximum frequency
            int maxFrequency = frequency.Values.Max();

            // Find all numbers with the maximum frequency
            var mostFrequentNumbers = frequency.Where(x => x.Value == maxFrequency)
                .Select(x => x.Key)
                .ToList();

            // Find the leftmost number with the maximum frequency
            int leftmost = arrayofarraies[j].First(n => mostFrequentNumbers.Contains(n));

            // Print the result
            if (mostFrequentNumbers.Count == 1)
            {
                Console.WriteLine($"The number {mostFrequentNumbers[0]} is the most frequent (occurs {maxFrequency} times).");
            }
            else
            {
                string numbersList = string.Join(", ", mostFrequentNumbers);
                Console.WriteLine($"The numbers {numbersList} have the same maximal frequency (each occurs {maxFrequency} times). The leftmost of them is {leftmost}.");
            }
            
        }
        
    }
}