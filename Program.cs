// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Product
{
    //caratteristiche del Prodotto 
    private int ID;
    private string name;
    private string description;
    private float price;
    private int vat;

    public Product (string name, string description, float price)
    {
        this.ID = new Random().Next(1, 100);
        this.name = name;
        this.description = description;
        this.price = price;
    }
   
}