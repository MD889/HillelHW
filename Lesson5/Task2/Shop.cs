using System;

public enum ShopType
{
    Grocery,
    Hardware,
    Clothing,
    Footwear
}

public class Shop : IDisposable
{
    private string name;
    private string address;
    private ShopType type;
    private bool disposed = false;
    public Shop(string name, string address, ShopType type)
    {
        this.name = name;
        this.address = address;
        this.type = type;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public ShopType Type
    {
        get { return type; }
        set { type = value; }
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Shop name: " + name);
        Console.WriteLine("Shop address: " + address);
        Console.WriteLine("Shop type: " + type);
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            disposed = true;
            Console.WriteLine($"Shop {name} disposed.");
        }
    }
    ~Shop()
    {
        Dispose(false);
    }
}
