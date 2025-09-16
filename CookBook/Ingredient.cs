namespace CookBook;

public class Ingredient
{
    public string Name { get; set; }
    public int Amount { get; set; }
    public Unit MeasureUnit { get; set; }
    public enum Unit
    {
        gram = 1,
        ml = 2,
        piece = 3,
        pinch = 4
    }


    
}

