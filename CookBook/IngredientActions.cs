namespace CookBook;



public class IngredientActions
{
    public static Ingredient AddIngredient()
    {
        Console.WriteLine("\nIngredient name: ");
        string name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Ingredient name cannot be empty.");
            return null; 
        }
        Console.WriteLine("\nIngredient amount: ");
        if (!Int32.TryParse(Console.ReadLine(), out int amount))
        {
            Console.WriteLine("Please enter a valid number for amount.");
            return null; // Lub ponów próbę
        }
        Console.WriteLine("\nIngredient measure unit: 1 - gram, 2 - ml, 3 - piece, 4 - pinch");
        bool validUnit = false;
        int unitChoice = 0;
        while (!validUnit)
        {
            string userInput = Console.ReadLine();
            if (Int32.TryParse(userInput, out unitChoice) && unitChoice >= 1 && unitChoice <= 4)
            {
                validUnit = true;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 4: ");
            }
        }
        
        try
        {
            Ingredient ingredient = new Ingredient(name, amount, (Ingredient.Unit)unitChoice);
            return ingredient;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
        
    }
}