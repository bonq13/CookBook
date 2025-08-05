namespace CookBook;

public class RecipeActions
{
    public static List<Recipe> recipes = new List<Recipe>();

    public static void AddRecipe()
    {
        Recipe recipe = new Recipe();
        recipe.Ingredients = new List<Ingredient>(); 
        Console.WriteLine("Enter Recipe ID:");
        Int32.TryParse(Console.ReadLine(), out int recipeId);
        recipe.Id = recipeId;
        Console.WriteLine("Choose meal type: \n breakfast = 1,\n soup = 2,\n dinner = 3,\n dessert = 4,\n snack = 5,");
        bool validType = false;
        while (!validType)
        {
            string userInput = Console.ReadLine();
            if (Int32.TryParse(userInput, out int typeChoice) && typeChoice >= 1 && typeChoice <= 5)
            {
                recipe.MealType = (Recipe.Type)typeChoice;
                validType = true;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 5: ");
            }
        }
        
        Console.WriteLine("Enter Recipe Name:");
        recipe.Name = Console.ReadLine();
        Console.WriteLine("Enter Recipe Ingredients:");
        bool ingredientsAmount = false;
        while (!ingredientsAmount)
        {
            recipe.Ingredients.Add(IngredientActions.AddIngredient()); 
            Console.WriteLine("Do you want to add another ingredient? (1 - yes / 2 - no):");
            string userAnswer = Console.ReadLine();
            if (Int32.TryParse(userAnswer, out int answer) && answer == 1)
           {
                ingredientsAmount = false;
            }
            else if (Int32.TryParse(userAnswer, out answer) && answer == 2)
            {
                ingredientsAmount = true;
            }
            else
            {
                Console.WriteLine("Please enter 1 or 2: ");
                ingredientsAmount = false;
            }
        }

        Console.WriteLine("\nEnter Recipe Description:");
        recipe.Description = Console.ReadLine();

        recipes.Add(recipe);
    }

    public static void ShowRecipes()
    {
        if (recipes.Count == 0)
        {
            Console.WriteLine("No recipes available.");
            return;
        }

        Console.WriteLine("Available recipes:");
        foreach (Recipe recipe in recipes)
        {
            Console.WriteLine(recipe.Id + ". " + recipe.Name);
            
        }
        
        Console.WriteLine("Enter recipe ID to see details or 0 to exit");
        FindRecipe();
    }

    public static void FindRecipe()
    {
        if (Int32.TryParse(Console.ReadLine(), out int answer) && answer != 0)
        {
            foreach (Recipe recipe in recipes)
            {
            
                Console.WriteLine("Recipe Name: " + recipe.Name);
                Console.WriteLine("Meal type: " + recipe.MealType);
                if (recipe.Ingredients != null && recipe.Ingredients.Count > 0)
                {
                    Console.WriteLine("Ingredients:");
                    foreach (Ingredient ingredient in recipe.Ingredients)
                    {
                        Console.WriteLine($"  {ingredient.Name}: {ingredient.Amount} {ingredient.MeasureUnit}");
                    }
                }
                else
                {
                    Console.WriteLine(" No ingredients.");
                }
                Console.WriteLine("Recipe Description: " + recipe.Description);
                Console.WriteLine();
            }
            
        }
        else
        {
            Console.WriteLine("Incorrect recipe ID.");
        }
    }

    public static void RemoveRecipe()
    {
        
        Console.WriteLine("Enter Recipe ID to remove (positive number):");
        int recipeId;
        while (!Int32.TryParse(Console.ReadLine(), out recipeId) || recipeId <= 0)
        {
            Console.WriteLine("Please enter a valid positive number for Recipe ID:");
        }

       
        Recipe recipeToRemove = null;
        foreach (Recipe recipe in recipes)
        {
            if (recipe.Id == recipeId)
            {
                recipeToRemove = recipe;
                break; 
            }
        }
        
        if (recipeToRemove != null)
        {
            recipes.Remove(recipeToRemove);
            Console.WriteLine("Recipe removed successfully.");
        }
        else
        {
            Console.WriteLine("Recipe not found.");
        }
    }
}