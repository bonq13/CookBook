namespace CookBook;

public class Ingredient
{
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ? throw new ArgumentException("Name cannot be empty.") : value;
    }
    
    private int _amount;
    public int Amount
    {
        get => _amount;
        set
        {
            if (value > 0) _amount = value;
            else throw new ArgumentException("Amount must be positive.");
        }
    }

    private Unit _measureUnit;

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

