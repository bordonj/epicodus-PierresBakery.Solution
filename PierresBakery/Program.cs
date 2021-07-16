using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();

      // sets color for welcome message
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.BackgroundColor = ConsoleColor.Black;
      Console.WriteLine("Welcome to Pierre's Bakery!");

      // resets color for normal prices
      Console.ResetColor();
      Console.WriteLine("1 Bread Loaf: $5");
      Console.WriteLine("1 Pastry: $2");

      // adds color to "DEALS" message
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("DEALS");

      // resets color for deal prices
      Console.ResetColor();
      Console.WriteLine("Buy 2 loaves of bread get 1 free!");
      Console.WriteLine("Buy 3 pastries for a dollar off!");

      // adds color for user input
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.BackgroundColor = ConsoleColor.Black;
      Console.WriteLine("Would you like to buy any bread or pastries? (yes/no)");

      // resets color for rest of console
      Console.ResetColor();
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
        
        Console.WriteLine($"{numBread} loaf(loaves) added to your cart!");
        Console.WriteLine($"Your total price for bread is ${newBread.Price}.");

        // sets color for any key
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("-- press any key to continue your order--");
        Console.ReadKey();
        Console.ResetColor();
        Console.Clear();
        
        Console.WriteLine("Please enter how many pastries you would like (enter 0 if you don't want pastries):");
        string strPastry = Console.ReadLine();
        int numPastry = int.Parse(strPastry);
        try
        {
        Pastry newPastry = new Pastry(numPastry);
        newPastry.SetPrice();
        
        Console.Clear();
        Console.WriteLine($"{numPastry} pastry(pastries) added to your cart!");
        Console.WriteLine($"Your total price for pastries is ${newPastry.Price}.");

        // sets color for any key
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("-- press any key to see your total price--");
        Console.ReadKey();
        Console.ResetColor();

        Console.Clear();
        // set color for total price
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine($"Your total price is ${newPastry.Price + newBread.Price}");
        Console.ResetColor();
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

    static void WaitForAnyKeypress()
    {
      Console.WriteLine("-- press any key to go back to main menu--");
      Console.ReadKey();
    }
  }
}