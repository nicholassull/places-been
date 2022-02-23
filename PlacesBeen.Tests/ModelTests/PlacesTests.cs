using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesBeen.Models;



namespace PlacesBeen.TestTools
{
  [TestClass]

  public class PlaceTests 
  {
    [TestMethod]
    public void ItemConstructor_CreateInstancesOfPlace_Place()
    {
      Place newPlace = new Place("test", "January 4th");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
   [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "City";
      string dateTraveled = "January 4th";
      Place newPlace = new Place(description, dateTraveled);
      
      //Act
      string result = newPlace.CityName;

      //Assert
      Assert.AreEqual(description, result);
    }

  }
}


