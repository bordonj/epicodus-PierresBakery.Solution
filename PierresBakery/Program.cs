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
      Console.WriteLine("Deals: Buy 2 loaves of bread get 1 free! Buy 3 pastries for $5!");
      Console.WriteLine("Would you like to buy any bread or pastries? (yes/no)");
      string userBreadReply = Console.ReadLine();
      if (userBreadReply.ToLower() == "yes")
      {
        AddFood();
      }
      else 
      {
        Console.WriteLine("Looks like you didn't buy anything. Please come back again if you change your mind!");

        WaitForAnyKeypress();
        Main();
      }

    }

    static void AddFood()
    {
      Console.Clear();
      Console.WriteLine("Please enter how many loaves you would like (enter 0 if you don't want bread):");
      string strBread = Console.ReadLine();
      try
      {
        int numBread = int.Parse(strBread);
        Bread newBread = new Bread(numBread);
        newBread.SetPrice();
        
        Console.WriteLine($"{numBread} loaf(loaves) added to your cart!!");
        Console.WriteLine($"Your total price for bread is ${newBread.Price}.");
        
        Console.WriteLine("Please enter how many pastries you would like (enter 0 if you don't want pastries):");
        string strPastry = Console.ReadLine();
        int numPastry = int.Parse(strPastry);
        try
        {
        Pastry newPastry = new Pastry(numPastry);
        newPastry.SetPrice();
        
        Console.WriteLine($"{numPastry} pastry(pastries) added to your cart!!");
        Console.WriteLine($"Your total price for pastries is ${newPastry.Price}.");
        Console.WriteLine("-- press any key to see your total price");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine($"Your total price is ${newPastry.Price + newBread.Price}");
        }
        catch (Exception ex)
        {
          Console.WriteLine("Message = {0}", ex.Message);
          Console.WriteLine("Source = {0}", ex.Source);
          Console.WriteLine("StackTrace = {0}", ex.StackTrace);
          Console.WriteLine("TargetSite = {0}", ex.TargetSite);

          WaitForAnyKeypress();
          Main();
        }
        
      }
      catch (Exception ex)
      {
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Source = {0}", ex.Source);
        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
        
        WaitForAnyKeypress();
        Main();
      }

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