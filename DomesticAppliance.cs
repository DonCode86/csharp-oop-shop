// See https://aka.ms/new-console-template for more information
public class DomesticAppliance : Product
{
    public string brand { get; private set; }
    public int wattage { get; private set; }

    public DomesticAppliance(string newName, string newDescription, float newPrice, int newVat, string brand, int wattage) :base(newName, newDescription, newPrice, newVat)
    {
        this.brand = brand;
        this.wattage = wattage;
    }
}