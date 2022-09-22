// See https://aka.ms/new-console-template for more information
public class Water : Product
{
    public float capacity { get; set; }
    private float maxCapacity = 1.5F;

    public Water(string newName, string NewDestription,float newPrice, int newVat, float newCapacity) : base(newName, NewDestription, newPrice)
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
}