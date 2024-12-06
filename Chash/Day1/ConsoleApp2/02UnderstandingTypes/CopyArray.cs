namespace _02UnderstandingTypes;

public class CopyArray
{
    public static void Run()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
         int[] newArray = new int[array.Length];

         for (int i = 0; i < array.Length; i++)
         {
             newArray[i] = array[i];
         }
         Console.WriteLine("The old array is:");
         for (int i = 0; i < array.Length; i++)
         {
             Console.Write(array[i]);
             
         }
         Console.WriteLine();
         Console.WriteLine("The new array is:");
         for (int i = 0; i < newArray.Length; i++)
         {
             Console.Write(newArray[i]);
         }
    }
}