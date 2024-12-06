namespace _02UnderstandingTypes;

public class PrimeNumbers
{
    public static int[] FindPrimeNumbers(int startNum, int endNum)
    {
        List<int> primeNumbers = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    primeNumbers.Add(i);
                }
            }
        }
        int[] primeNumbersArray = primeNumbers.ToArray();
        return primeNumbersArray;
    }
}