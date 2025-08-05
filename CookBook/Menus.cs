namespace CookBook;

public class Menus
{
    public static int MainMenu()
    {
        Console.WriteLine("\n1. Add recipe");
        Console.WriteLine("2. Show recipes");
        Console.WriteLine("3. Find recipe");
        Console.WriteLine("4. Remove recipe");
        Console.WriteLine("5. Exit app");
        Console.WriteLine("\nEnter your choice: ");
        Int32.TryParse(Console.ReadLine(), out int result);
        return result;  
    }

    
}   