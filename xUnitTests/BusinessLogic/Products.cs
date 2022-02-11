public class Product
{
    public string Name {get;private set;}
    public int UnitsInStock {get;private set;}
    public int MinimumStockPlanned{get;private set;}

    public Product(string Name, int UnitsInStock, int MinimumStockPlanned)
    {
        this.Name = Name;
        this.MinimumStockPlanned = MinimumStockPlanned;
        this.UnitsInStock = UnitsInStock;
    }

    public bool NeedReplenish()
    {
        return (this.UnitsInStock<this.MinimumStockPlanned);
    }
}