namespace CookBook;

public class Recipe
{
    private int _id;

    public int Id
    {
        get => _id;
        set
        {
            if(value > 0) _id = value;
            else throw new ArgumentException("Invalid ID - must be positive.");
        }
    }
    private Type _mealType;

    public Type MealType
    {
        get => _mealType;
        set => _mealType = value;
    }
    
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ? throw new ArgumentException("Name cannot be empty.") : value;
    }
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public IReadOnlyList<Ingredient> Ingredients
    {
        get => _ingredients.AsReadOnly();
    }
   
    public void AddIngredient(Ingredient ingredient)
    {
        if (!string.IsNullOrEmpty(ingredient.Name))
            _ingredients.Add(ingredient);
    }
    
    private string _description;
    public string Description { get => _description; set => _description = value; }

    public enum Type
    {
        breakfast = 1,
        soup = 2,
        dinner = 3,
        dessert = 4,
        snack = 5,
        
        
    }
    
    
    
}