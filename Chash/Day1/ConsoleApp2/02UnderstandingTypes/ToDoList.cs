namespace _02UnderstandingTypes;

public class ToDoList
{
    public static void Run()
    {
        List<String> toDo = new List<string>();

        for (; true;)
        {   Console.WriteLine("The Current List is:");
            foreach (var item in toDo)
            {
                Console.WriteLine(item);                
            }
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            String str = Console.ReadLine();
            // Console.WriteLine(str.Trim().Substring(2));
            if (str.StartsWith("+ ") || str.StartsWith("- ") || str.StartsWith("--"))
            {
                if (str.Equals("--"))
                {
                    toDo.Clear();
                    break;
                }
                else if (str.StartsWith("+"))
                {
                    toDo.Add(str.Trim().Substring(1));
                }
                else if (str.StartsWith("-"))
                {
                    toDo.Remove(str.Trim().Substring(1));
                }
            }
            
        }
    }
}