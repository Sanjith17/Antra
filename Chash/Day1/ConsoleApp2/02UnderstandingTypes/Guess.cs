namespace _02UnderstandingTypes;

public static class Guess
{
    public static void Run()
    {
        Console.Write("Guess the number from 1-3: ");

        // Read and convert input to an integer
        if  (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
        int correctNumber = new Random().Next(3) + 1;
        if (correctNumber == number)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Wrong!");
        }
    }
}