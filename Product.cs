namespace ConsoleApp2;

public class Product
{
    private readonly int price;
    private readonly string title;
    private int inStockAmount;

    public Product(string title, int price, int inStockAmount)
    {
        this.title = title;
        this.price = price;
        this.inStockAmount = inStockAmount;
    }

    public string getTitle()
    {
        return title;
    }

    public int getPrice()
    {
        return price;
    }

    public int getInStockAmount()
    {
        return inStockAmount;
    }

    public void changeInStockAmount(int amount)
    {
        inStockAmount += amount;
    }
}