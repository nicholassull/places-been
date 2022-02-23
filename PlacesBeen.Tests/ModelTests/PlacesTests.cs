using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesBeen.Models;



namespace PlacesBeen.TestTools
{
  [TestClass]

  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

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
    [TestMethod]
    public void GetALl_ReturnsEmptyList_PlaceList()
    {
      //Arrange
      List<Place> newPlace = new List<Place> { };

      //Act
      List<Place> result = Place.GetAll();

      //Assert
      CollectionAssert.AreEqual(newPlace, result);
    }
  }
}



