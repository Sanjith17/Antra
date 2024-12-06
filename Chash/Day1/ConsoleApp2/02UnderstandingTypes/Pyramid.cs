namespace _02UnderstandingTypes;

public static class Pyramid
{
    public static void Run()
    {
        Console.WriteLine("Enter the number");
        int n = int.Parse(Console.ReadLine());
        int number = (n * 2) - 1;
        int half = number / 2;
        for (int i = 1; i <=  n; i++)
        {
            Console.Write(new string(' ', n - i));
                
            // Print stars
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }
}