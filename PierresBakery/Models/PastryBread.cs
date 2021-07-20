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
      if (Amount >= 3)
      {
        Price = ((Amount / 3) * 5) + ((Amount % 3) * 2);
        return Price;
      }
      Price = Amount * 2;
      return Price;
    }
  }
  
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
        Price = ((Amount / 3) * 10) + ((Amount % 3) * 5);
        return Price;
      }
      Price = Amount * 5;
      return Price;
    }
  }
}

