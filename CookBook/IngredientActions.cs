namespace CookBook;

public class IngredientActions
{
    public static Ingredient AddIngredient()
    {
        Ingredient ingredient = new Ingredient();
        Console.WriteLine("\nIngredient name: ");
        ingredient.Name = Console.ReadLine();
        Console.WriteLine("\nIngredient amount: ");
        int amount;
        while (!Int32.TryParse(Console.ReadLine(), out amount) || amount <= 0)
        {
            Console.WriteLine("Please enter a valid positive number for amount: ");
        }
        ingredient.Amount = amount;
        Console.WriteLine("\nIngredient measure unit: 1 - gram, 2 - ml, 3 - piece, 4 - pinch");
        bool validUnit = false;
        while (!validUnit)
        {
            string userInput = Console.ReadLine();
            if (Int32.TryParse(userInput, out int unitChoice) && unitChoice >= 1 && unitChoice <= 4)
            {
                ingredient.MeasureUnit = (Ingredient.Unit)unitChoice;
                validUnit = true;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 4: ");
            }
        }
        
        return ingredient;
        
    }
}