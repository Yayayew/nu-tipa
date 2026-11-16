namespace ConsoleApp2;

public class Store : Observer
{
    private readonly List<Product> products = new ()
    {
        new Product("Молоко", 100, 2),
        new Product("Яйца 20 штук", 160, 4),
        new Product("Хлеб украинский", 780, 7),
        new Product("Три корочки", 50, 9)
    };

    public void Update(Product product, int amount)
    {
        products[products.IndexOf(product)].changeInStockAmount(amount);
    }

    public void printProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("В корзине нет товаров");
            return;
        }
        for (int i = 0; i < products.Count; i++) 
            Console.WriteLine(i + 1 + " " + products[i].getTitle() 
                              + " " + products[i].getPrice() + 
                              " " + products[i].getInStockAmount());
    }
    
    public Product getProduct(int productId)
    {
        return products[productId];
    }
}