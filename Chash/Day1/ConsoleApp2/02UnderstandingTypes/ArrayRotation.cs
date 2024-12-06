namespace _02UnderstandingTypes;

public class ArrayRotation
{
    public static void Run()
    {
        Console.WriteLine("Enter the Input");
        String str = Console.ReadLine();
        int r = int.Parse(Console.ReadLine());
        String[] strArray = str.Trim().Split(' ');
        int[] intArray = Array.ConvertAll(strArray, int.Parse);
        int n = intArray.Length;
        int[] rotArray = new int[intArray.Length];
        int[] sumArray = new int[intArray.Length];

        for (int j = 1; j <= r; j++)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                rotArray[(i + j) % n] = intArray[i];
            }
            for (int i = 0; i < intArray.Length; i++)
            {
                sumArray[i] = rotArray[i] + sumArray[i];
            }
            
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{sumArray[i]} ");
        }
    }
}