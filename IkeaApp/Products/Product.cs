namespace IkeaApp.Products;

public abstract class Product
{
    protected string protected_name;
    protected float protected_price; // = 0.01f;
    protected string protected_shelf; // = "unknown";
    protected string protected_description; // = "A wonderful product";

    protected Product(string name, float price, string shelf, string description)
    {
        this.protected_name = name;
        this.protected_price = price;
        this.protected_shelf = "222." + shelf;
        this.protected_description = description;
    }

    public abstract float Price();

    public abstract String GetShelf();

    public abstract String Description();
    
}