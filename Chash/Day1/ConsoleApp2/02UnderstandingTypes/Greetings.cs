namespace _02UnderstandingTypes;

public class Greetings
{
    public static void Run()
    {
        int currentHour = DateTime.Now.Hour;

        // Determine the appropriate greeting based on the hour
        if (currentHour >= 6 && currentHour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        if (currentHour >= 12 && currentHour < 18)
        {
            Console.WriteLine("Good Afternoon");
        }
        if (currentHour >= 18 && currentHour < 22)
        {
            Console.WriteLine("Good Evening");
        }
        if ((currentHour >= 22 && currentHour <= 23) || (currentHour >= 0 && currentHour < 6))
        {
            Console.WriteLine("Good Night");
        }
    }
}