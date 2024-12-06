namespace _02UnderstandingTypes;

public static class AgeCalculator
{
    public static void Run()
    {
        Console.Write("Enter your Birthday in this form (e.g., MM/dd/yyyy): ");

        // Read user input as a string
        string userInput = Console.ReadLine();

        if (DateTime.TryParse(userInput, out DateTime enteredDate))
        {
            Console.WriteLine($"You entered a valid date: {enteredDate.ToShortDateString()}");
            DateTime today = DateTime.Today;
            TimeSpan age = today - enteredDate;
            Console.WriteLine($"Your age is {age.Days} days.");
            int daysToNextAnniversary = 10000 - (age.Days % 10000);
            Console.WriteLine($"You have {daysToNextAnniversary} days for your next 100000 day anniversary.");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter a valid date.");
        }
        
        
    }
}