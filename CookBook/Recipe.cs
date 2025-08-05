namespace CookBook;

public class Recipe
{
    public int Id { get; set; }
    public Type MealType { get; set; }
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public string Description { get; set; }

    public enum Type
    {
        breakfast = 1,
        soup = 2,
        dinner = 3,
        dessert = 4,
        snack = 5,
        
        
    }
    
    
    
}