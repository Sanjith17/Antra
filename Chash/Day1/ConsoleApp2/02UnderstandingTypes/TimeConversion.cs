namespace _02UnderstandingTypes;

public class TimeConversion
{
    public static void Run()
    {
        Console.Write("Enter the number of centuries: ");
            
        // Input number of centuries as an integer
        if (!int.TryParse(Console.ReadLine(), out int centuries) || centuries < 0)
        {
            Console.WriteLine("Please enter a valid non-negative integer.");
            return;
        }
        
        long years = centuries * 100L;
        long days = years * 365L + (years / 4L - years / 100L + years / 400L);
        long hours = days * 24L;
        long minutes = hours * 60L;
        long seconds = minutes * 60L;
        long milliseconds = seconds * 1000L;
        decimal microseconds = milliseconds * 1000m; 
        decimal nanoseconds = microseconds * 1000m;
        Console.WriteLine($"Centuries: {centuries}");
        Console.WriteLine($"Years: {years}");
        Console.WriteLine($"Days (including leap years): {days}");
        Console.WriteLine($"Hours: {hours}");
        Console.WriteLine($"Minutes: {minutes}");
        Console.WriteLine($"Seconds: {seconds}");
        Console.WriteLine($"Milliseconds: {milliseconds}");
        Console.WriteLine($"Microseconds: {microseconds}");
        Console.WriteLine($"Nanoseconds: {nanoseconds}");
    }
}