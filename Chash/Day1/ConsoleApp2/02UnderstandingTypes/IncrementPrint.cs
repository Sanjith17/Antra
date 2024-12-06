namespace _02UnderstandingTypes;

public  class IncrementPrint
{
    public static void Run()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j < 24; j = j + i)
            {
                Console.Write($"{j},");
            }
            Console.WriteLine("24");
        }

    }
}