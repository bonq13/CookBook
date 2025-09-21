namespace CookBook;


public class Recipe
{
    private int _id;
    private Type _mealType;
    private string _name;
    private string _description;

     
    public Recipe(int id, string name, Type mealType)
    {
        _id = id;
        _name = name;
        _mealType = mealType;

    }

    public Recipe()
    {
        Id = 1; 
        Name = "Default Recipe";
        MealType = Type.breakfast;
        Description = string.Empty;
        
    }
    
    public int Id
    {
        get => _id;
        set
        {
            if(value > 0) _id = value;
            else throw new ArgumentException("Invalid ID - must be positive.");
        }
    }
    
    public Type MealType
    {
        get => _mealType;
        set
        {
            if (Enum.IsDefined(typeof(Type), value))
                _mealType = value;
            else
                throw new ArgumentException("Invalid meal type.");
        }
    }
    
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