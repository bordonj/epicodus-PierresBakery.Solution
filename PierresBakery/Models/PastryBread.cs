namespace PierresBakery.Models
{
  
  public class Pastry
  {
    // Public properties
    public int Amount { get; set; }
    public int Price { get; set; }

    // Constructor
    public Pastry(int amount, int price = 0)
    {
      Amount = amount;
      Price = price;
    }
    public int SetPrice()
    {
      Price = Amount * 2;
      return Price;
    }
  }

    // properties, methods, etc. will go here.
  
  public class Bread
  {
    // Public properties
    public int Amount { get; set; }
    public int Price { get; set; }

    // Constructor
    public Bread(int amount, int price = 0)
    {
      Amount = amount;
      Price = price;
    }
  }
}

