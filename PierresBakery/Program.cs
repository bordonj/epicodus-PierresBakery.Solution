using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Single loaf: $5");
      Console.WriteLine("One Pastry: $2");
      Console.WriteLine("Deals: Buy 2 loaves of bread get 1 free!");
      Console.WriteLine("Deals: Buy 3 pastries for $5!");
      Console.WriteLine("Would you like to buy any loaves of bread? (yes/no)");
      string userBreadReply = Console.ReadLine();
      if (userBreadReply.ToLower() == "yes")
      {
        AddBread();
      }
      else 
      {
        Console.WriteLine("Would you like to buy any pastries?");
        string userPastryReply = Console.ReadLine();

        if (userPastryReply.ToLower() == "yes")
        {
          AddPastry();
        }
        else 
        {
          Console.WriteLine("Looks like you didn't buy anything. Please come back again if you change your mind!");
          Main();
        }
      }

    }

    static void AddBread()
    {
      Console.WriteLine("Please enter how many loaves you would like");
      string strBread = Console.ReadLine();
      int numBread = int.Parse(strBread);
      Bread newBread = new Bread(numBread);
      newBread.SetPrice();
      
      Console.WriteLine($"{numBread} loaf(loaves)have been added to your cart!!");
      
      WaitForAnyKeypress();
      Main();
    }
    static void AddPastry()
    {
      Console.WriteLine("adding pastries tbd");

      WaitForAnyKeypress();
      Main();
    }

    static void WaitForAnyKeypress()
    {
      Console.WriteLine("-- press any key to go back to main menu");
      Console.ReadKey();
    }
  }
}