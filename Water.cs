// See https://aka.ms/new-console-template for more information
public class Water : Product
{
    public double capacity { get; set; }
    private float maxCapacity = 1.5F;
    public float ph { get; set; }
    public string source { get; }

    public Water(string newName, string NewDestription,float newPrice, int newVat, double newCapacity) : base(newName, NewDestription, newPrice, newVat)
    {
        if (newCapacity <= this.maxCapacity)
        {
            this.capacity = newCapacity;
        }
        else
        {
            Console.WriteLine("Hai superato la capacita' massima possibile (1,5l)");
        } 
    }

    public void DrinkIt (double ltToDrink)
    {
        capacity -= ltToDrink;
    }

    public void Fill (float ltToDrink)
    {
        capacity += ltToDrink;
    }

    public void empty ()
    {
        capacity = 0;
    }
}
