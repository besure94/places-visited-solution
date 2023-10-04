using PlacesVisited.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace PlacesVisited.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place();
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
  }
}