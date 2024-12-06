namespace _02UnderstandingTypes;

public class Guess2
{
    public static void Run()
    {
        Console.Write("Guess the number");

        // Read and convert input to an integer
        if  (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
        int correctNumber = new Random().Next(3) + 1;
        if (number <1 || number >3)
        {
            Console.WriteLine("The Number entered  is not in the range of 1 to 3.!");
        }
        else if (number == correctNumber)
        {
            Console.WriteLine("You guessed the number!");
        }
        else if (number < correctNumber)
        {
            Console.WriteLine("Your value is less than the number!");
        }
        else
        {
            Console.WriteLine("Your number is greater than the number!");
        }
    }
}