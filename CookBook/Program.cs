namespace CookBook;


class Program
{
    static void Main(string[] args)
    {
        IRecipeService service = new RecipeService();
        
        
        Console.WriteLine("Welcome to the Cook Book app!");
        Console.WriteLine("What would you like to do?");

        
        
        bool app = true;
        while (app)
        {
            int mainMenuAnswer = Menus.MainMenu();
            switch (mainMenuAnswer)
            {
                case 1:
                    service.AddRecipe();
                    break;
                case 2:
                    service.ShowRecipes();
                    break;
                case 3:
                    Console.WriteLine("\nEnter recipe ID to find it.");
                    service.FindRecipe();
                    break;
                case 4:
                    service.RemoveRecipe();
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