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
        // Item newItem = new Item(description);

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
        // Item newItem = new Item(description);

        //Assert
        Assert.AreEqual(1, newBread.Amount);
      }


  }
}