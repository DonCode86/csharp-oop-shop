// See https://aka.ms/new-console-template for more information
public class FruitBag : Product
{
    public float capacity { get; set; }
    private float maxCapacity { get; } = 5;

    public FruitBag(string newName, string NewDestription, float newPrice, int newVat, float newCapacity) : base(newName, NewDestription, newPrice, newVat)
    {
        if (newCapacity <= this.maxCapacity)
        {
            this.capacity = newCapacity;
        }
        else
        {
            Console.WriteLine("Hai superato la capacita' massima possibile (5)");
        }
    }
}