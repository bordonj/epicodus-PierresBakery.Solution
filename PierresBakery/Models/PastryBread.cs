namespace PierresBakery.Models
{
  
  public class Pastry
  {
    // Public properties
    public int Amount { get; set; }

    // Constructor
    public Pastry(int amount)
    {
      Amount = amount;
      int price = 0;
    }
    public int SetPrice()
    {
      return Amount * 2;
    }
  }

    // properties, methods, etc. will go here.
  
  public class Bread
  {
    // Public properties
    public int Amount { get; set; }

    // Constructor
    public Bread(int amount)
    {
      Amount = amount;
      int price = 0;
    }
  }
}

