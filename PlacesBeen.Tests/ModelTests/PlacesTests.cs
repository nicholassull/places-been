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

  }
}