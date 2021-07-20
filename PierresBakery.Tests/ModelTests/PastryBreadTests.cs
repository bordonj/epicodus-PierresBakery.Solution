using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryBreadTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
      [TestMethod]
      public void SetAmountOfPastriesToBuy_SetAmount_Int()
      {
        //Arrange
        int pastryAmt = 1;

        //Act
        Pastry newPastry = new Pastry(pastryAmt);

        //Assert
        Assert.AreEqual(1, newPastry.Amount);
      }
      [TestMethod]
      public void SetAmountOfBreadToBuy_SetAmount_Int()
      {
        //Arrange
        int breadAmt = 1;

        //Act
        Bread newBread = new Bread(breadAmt);

        //Assert
        Assert.AreEqual(1, newBread.Amount);
      }
      [TestMethod]
      public void SetPriceBasedOnAmtForPastry_SetPrice_Int()
      {
        //Arrange
        int pastryAmt = 1;

        //Act
        Pastry newPastry = new Pastry(pastryAmt);
        newPastry.SetPrice();

        //Assert
        Assert.AreEqual(2, newPastry.SetPrice());
      }
      [TestMethod]
      public void SetPriceBasedOnDealForPastry_SetPrice_Int()
      {
        //Arrange
        int pastryAmt = 3;

        //Act
        Pastry newPastry = new Pastry(pastryAmt);
        newPastry.SetPrice();

        //Assert
        Assert.AreEqual(5, newPastry.SetPrice());
      }
      [TestMethod]
      public void SetPriceBasedOnDealForBread_SetPrice_Int()
      {
        //Arrange
        int breadAmt = 2;

        //Act
        Bread newBread = new Bread(breadAmt);
        newBread.SetPrice();

        //Assert
        Assert.AreEqual(10, newBread.SetPrice());
      }
      [TestMethod]
      public void SetPriceBasedOnDealPlusMoreForPastry_SetPrice_Int()
      {
        //Arrange
        int pastryAmt = 5;

        //Act
        Pastry newPastry = new Pastry(pastryAmt);
        newPastry.SetPrice();

        //Assert
        Assert.AreEqual(9, newPastry.SetPrice());
      }
      [TestMethod]
      public void SetPriceBasedOnDealPlusMoreForBread_SetPrice_Int()
      {
        //Arrange
        int breadAmt = 3;

        //Act
        Bread newBread = new Bread(breadAmt);
        newBread.SetPrice();

        //Assert
        Assert.AreEqual(10, newBread.SetPrice());
      }
      [TestMethod]
      public void SetPriceBasedOn4ForBread_SetPrice_Int()
      {
        //Arrange
        int breadAmt = 4;

        //Act
        Bread newBread = new Bread(breadAmt);
        newBread.SetPrice();

        //Assert
        Assert.AreEqual(15, newBread.SetPrice());
      }
      [TestMethod]
      public void SetPriceBasedOn5ForBread_SetPrice_Int()
      {
        //Arrange
        int breadAmt = 5;

        //Act
        Bread newBread = new Bread(breadAmt);
        newBread.SetPrice();

        //Assert
        Assert.AreEqual(20, newBread.SetPrice());
      }
      [TestMethod]
      public void SetPriceBasedOn6ForBread_SetPrice_Int()
      {
        //Arrange
        int breadAmt = 6;

        //Act
        Bread newBread = new Bread(breadAmt);
        newBread.SetPrice();

        //Assert
        Assert.AreEqual(20, newBread.SetPrice());
      }

  }
}