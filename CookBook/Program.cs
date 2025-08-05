namespace CookBook;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the Cook Book app!");
        Console.WriteLine("What would you like to do?");

        
        
        bool app = true;
        while (app)
        {
            int mainMenuAnswer = Menus.MainMenu();
            switch (mainMenuAnswer)
            {
                case 1:
                    RecipeActions.AddRecipe();
                    break;
                case 2:
                    RecipeActions.ShowRecipes();
                    break;
                case 3:
                    Console.WriteLine("\nEnter recipe ID to find it.");
                    RecipeActions.FindRecipe();
                    break;
                case 4:
                    RecipeActions.RemoveRecipe();
                    break;
                case 5:
                    app = false;
                    break;
                default:
                    Console.WriteLine("\nInvalid menu option.");
                    break;
            }
        }
    }
}