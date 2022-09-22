// See https://aka.ms/new-console-template for more information
public class FruitBag : Product
{
    public int capacity { get; set; }
    public int MaxCapacity = 5;

    public FruitBag (string newName, string NewDestription, float newPrice, int newVat, float newCapacity) :base(newName, NewDestription, newPrice, newVat)
    {
        this.capacity = capacity;
    }
}