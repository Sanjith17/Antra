using System.Security.AccessControl;

namespace _02UnderstandingTypes;

public static class FizzWord
{
    public static void Run()
    {
        for (var i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz"); 
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}