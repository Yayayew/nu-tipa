namespace ConsoleApp2;

public class Life
{
    private Customer customer = new Customer(2000);
    private Store store = new Store();

    public Life()
    {
        customer.Subscribe(store);
        while (true)
        {  
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("""
                              1 - добавить товар
                              2 - удалить товар
                              3 - посмотреть карзину
                              4 - посмотреть каталог
                              5 - Сколько у меня грош?
                              """);
            int storeEvent = Convert.ToInt32(Console.ReadLine());
            switch (storeEvent)
            {
                case 1:
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    store.printProducts();
                    Console.WriteLine("Введите номер товара ");
                    customer.buy(
                        store.getProduct(Convert.ToInt32(Console.ReadLine()) - 1));
                    Console.WriteLine();
                    Console.WriteLine("Ваши корзина:");
                    customer.printProducts();
                    Console.WriteLine("Нажмите enter, чтобы продолжить");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    customer.printProducts();
                    Console.WriteLine("Введите номер товара ");
                    customer.removeProduct(store.getProduct(
                        Convert.ToInt32(Console.ReadLine()) - 1));
                    Console.WriteLine();
                    showProducts();
                    break;
                case 3:
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    showProducts();
                    break;
                case 4:
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("Каталог магазина:");
                    store.printProducts();
                    Console.WriteLine("Нажмите enter, чтобы продолжить");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("Ваши гроши: " + customer.getBudget());
                    Console.WriteLine("Нажмите enter, чтобы продолжить");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Нет такого варианта");
                    break;
            }
        }
    }

    private void showProducts()
    {
        Console.WriteLine("Ваши корзина:");
        customer.printProducts();
        Console.WriteLine("Нажмите enter, чтобы продолжить");
        Console.ReadLine();
    }
}