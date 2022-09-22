// See https://aka.ms/new-console-template for more information
public class Product
{
    //caratteristiche del Prodotto 
    private int ID;
    private string name;
    private string description;
    private double price;
    private int vat;

    public Product (string name, string description, double newPrice, int vat)
    {
        ID = new Random().Next(1, 100);
        this.name = name;
        this.description = description;
        this.SetPrice(newPrice);
    }

    public Product()
    {
    }

    public int GetID () 
        { return ID; }

    public string GetName ()
        { return name; }

    public string GetDescription ()
        { return description; }

    public double GetPrice()
        { return price; }

    public int GetVat() 
        { return vat; }

    public void SetName (string name)
        { this.name = name; }

    public void SetDescription (string description)
        { this.description = description; }

    public void SetPrice (double newPrice)
        { this.price = (float)newPrice; }

    public void SetVat (int vat) 
        { this.vat = vat; }

}
