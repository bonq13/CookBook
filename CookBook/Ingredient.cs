namespace CookBook;

public class Ingredient
{
    private string _name;
    private int _amount;
    private Unit _measureUnit;

    public Ingredient(string name, int amount, Unit measureUnit)
    {
        Name = name;
        Amount = amount;
        MeasureUnit = measureUnit;
    }

    public Ingredient()
    {
        _name = "Unknown";
        _amount = 1;
    }
    
    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ? throw new ArgumentException("Name cannot be empty.") : value;
    }
  
    public int Amount
    {
        get => _amount;
        set
        {
            if (value > 0) _amount = value;
            else throw new ArgumentException("Amount must be positive.");
        }
    }
    
    public Unit MeasureUnit
    {
        get => _measureUnit;
        set => _measureUnit = value;
    }
    public enum Unit
    {
        gram = 1,
        ml = 2,
        piece = 3,
        pinch = 4
    }


    
}

