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
      if (Amount % 3 == 0)
      {
        Price = (Amount / 3) * 5;
        return Price;
      }
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
    public int SetPrice()
    {
      if (Amount > 2)
      {
        Price = ((Amount / 2) * 5) + ((Amount % 2) * 5);
        return Price;
      }
      if (Amount % 2 == 0)
      {
        Price = (Amount / 2) * 5;
        return Price;
      }
      Price = Amount * 5;
      return Price;
    }
  }
}

