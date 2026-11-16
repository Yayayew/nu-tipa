namespace ConsoleApp2;

public class Customer : Observable
{
    private readonly List<Observer> observers = new();
    private readonly List<Product> products;
    private int budget;

    public Customer(int budget)
    {
        this.budget = budget;
        products = new List<Product>();
    }
    
    public void buy(Product product)
    {
        if (budget < product.getPrice())
        {
            Console.WriteLine("Разбогатей!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        } 
        else if (product.getInStockAmount() == 0)
        {
            Console.WriteLine("Нет в наличии!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
        else
        {
            products.Add(product);
            budget -= product.getPrice();
            Notify(product, -1);
        }
    }

    public void removeProduct(Product product)
    {
        product.getTitle();
        if (products.Contains(product))
        {
            products.Remove(product);
            budget += product.getPrice();
            Notify(product, 1);
        }
        else
        {
            Console.WriteLine("Нет такого товара в корзине");
        }
    }
    
    public void Subscribe(Observer observer)
    {
        observers.Add(observer);
    }

    public void Unsubscribe(Observer observer)
    {
        observers.Remove(observer);
    }

    public void Notify(Product product, int amount)
    {
        foreach (var observer in observers)
        {
            observer.Update(product, amount);
        }
    }

    public void printProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("В корзине нет товаров");
            return;
        }
        for (int i = 0; i < products.Count; i++) 
            Console.WriteLine(i + 1 + " " + products[i].getTitle());
    }

    public int getBudget()
    {
        return budget;
    }
}