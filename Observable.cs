namespace ConsoleApp2;

public interface Observable
{
    void Subscribe(Observer observer);
    void Unsubscribe(Observer observer);
    void Notify(Product product, int amount);
}