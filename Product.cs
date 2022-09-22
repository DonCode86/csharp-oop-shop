// See https://aka.ms/new-console-template for more information
public class Product
{
    //caratteristiche del Prodotto 
    private int ID;
    private string name;
    private string description;
    private float price;
    private int vat;

    public Product (string name, string description, float price, int vat)
    {
        ID = new Random().Next(1, 100);
        this.name = name;
        this.description = description;
        this.price = price;
    }
   
    public int GetID () 
        { return ID; }

    public string GetName ()
        { return name; }

    public string GetDescription ()
        { return description; }

    public float GetPrice()
        { return price; }

    public int GetVat() 
        { return vat; }

    public void SetName (string name)
        { this.name = name; }

    public void SetDescription (string description)
        { this.description = description; }

    public void SetPrice (int price)
        { this.price = price; }

    public void SetVat (int vat) 
        { this.vat = vat; }



}
