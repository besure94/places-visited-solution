using PlacesVisited.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Reflection;

namespace PlacesVisited.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {

    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Vancouver", "Canada", "3 days", "Brandon", "Biked to Stanley Park.", "img/vancouver/vancouverbike.jpg");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      string cityName = "Vancouver";
      Place newPlace = new Place(cityName, "Canada", "3 days", "Brandon", "Biked to Stanley Park.", "img/vancouver/vancouverbike.jpg");
      string result = newPlace.CityName;
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetCityName_SetCityName_String()
    {
      string cityName = "Vancouver";
      Place newPlace = new Place(cityName, "Canada", "5 days", "Brandon", "Biked to Stanley Park.", "img/vancouver/vancouverbike.jpg");
      string updatedCityName = "Philadelphia";
      newPlace.CityName = updatedCityName;
      string result = newPlace.CityName;
      Assert.AreEqual(updatedCityName, result);
    }

    [TestMethod]
    public void GetCountryName_ReturnsCountryName_String()
    {
      string countryName = "Canada";
      Place newPlace = new Place("Vancouver", countryName, "3 days", "Brandon", "Biked to Stanley Park.", "img/vancouver/vancouverbike.jpg");
      string result = newPlace.CountryName;
      Assert.AreEqual(countryName, result);
    }

    [TestMethod]
    public void SetCountryName_SetCountryName_String()
    {
      string countryName = "Canada";
      Place newPlace = new Place("Vancouver", countryName, "3 days", "Brandon", "Biked to Stanley Park.", "img/vancouver/vancouverbike.jpg");
      string updatedCountryName = "Mexico";
      newPlace.CountryName = updatedCountryName;
      string result = newPlace.CountryName;
      Assert.AreEqual(updatedCountryName, result);
    }

    [TestMethod]
    public void GetLengthOfStay_ReturnsLengthOfStay_String()
    {
      string lengthOfStay = "3 days";
      Place newPlace = new Place("Vancouver", "Canada",lengthOfStay, "Brandon", "Biked to Stanley Park.", "img/vancouver/vancouverbike.jpg");
      string result = newPlace.LengthOfStay;
      Assert.AreEqual(lengthOfStay, result);
    }

    [TestMethod]
    public void SetLengthOfStay_SetLengthOfStay_String()
    {
      string lengthOfStay = "3 days";
      Place newPlace = new Place("Vancouver", "Canada",lengthOfStay, "Brandon", "Biked to Stanley Park.", "img/vancouver/vancouverbike.jpg");
      string updatedLengthOfStay = "5 days";
      newPlace.LengthOfStay = updatedLengthOfStay;
      string result = newPlace.LengthOfStay;
      Assert.AreEqual(updatedLengthOfStay, result);
    }

    [TestMethod]
    public void GetCompanions_ReturnsCompanions_String()
    {
      string companions = "Brandon";
      Place newPlace = new Place("Vancouver", "Canada", "3 days", companions, "Biked to Stanley Park.", "img/vancouver/vancouverbike.jpg");
      string result = newPlace.Companions;
      Assert.AreEqual(companions, result);
    }

    [TestMethod]
    public void SetCompanions_SetCompanions_String()
    {
      string companions = "Brandon";
      Place newPlace = new Place("Vancouver", "Canada", "3 days", companions, "Biked to Stanley Park.", "img/vancouver/vancouverbike.jpg");
      string updatedCompanions = "Kai";
      newPlace.Companions = updatedCompanions;
      string result = newPlace.Companions;
      Assert.AreEqual(updatedCompanions, result);
    }

    [TestMethod]
    public void GetJournalEntry_ReturnsJournalEntry_String()
    {
      string journalEntry = "Biked to Stanley Park.";
      Place newPlace = new Place("Vancouver", "Canada", "3 days", "Brandon", journalEntry, "img/vancouver/vancouverbike.jpg");
      string result = newPlace.JournalEntry;
      Assert.AreEqual(journalEntry, result);
    }

    [TestMethod]
    public void SetJournalEntry_SetJournalEntry_String()
    {
      string journalEntry = "Biked to Stanley Park.";
      Place newPlace = new Place("Vancouver", "Canada", "3 days", "Brandon", journalEntry, "img/vancouver/vancouverbike.jpg");
      string updatedJournalEntry = "Took ferry to North Vancouver.";
      newPlace.JournalEntry = updatedJournalEntry;
      string result = newPlace.JournalEntry;
      Assert.AreEqual(updatedJournalEntry, result);
    }

    [TestMethod]
    public void GetImageUrl_ReturnsImageUrl_String()
    {
      string imageUrl = "img/vancouver/vancouverbike.jpg";
      Place newPlace = new Place("Vancouver", "Canada", "3 days", "Brandon", "Biked to Stanley Park", imageUrl);
      string result = newPlace.ImageUrl;
      Assert.AreEqual(imageUrl, result);
    }

    [TestMethod]
    public void SetImageUrl_SetImageUrl_String()
    {
      string imageUrl = "img/vancouver/vancouverbike.jpg";
      Place newPlace = new Place("Vancouver", "Canada", "3 days", "Brandon", "Biked to Stanley Park", imageUrl);
      string updatedImageUrl = "img/vancouver/vancouverskyline.jpg";
      newPlace.ImageUrl = updatedImageUrl;
      string result = newPlace.ImageUrl;
      Assert.AreEqual(updatedImageUrl, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Place> newPlace = new List<Place> { };
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newPlace, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string cityName01 = "Vancouver";
      string cityName02 = "Philadelphia";
      string countryName01 = "Canada";
      string countryName02 = "United States";
      string lengthOfStay01 = "3 days";
      string lengthOfStay02 = "5 days";
      string companions01 = "Brandon";
      string companions02 = "Kai";
      string journalEntry01 = "Biked to Stanley Park.";
      string journalEntry02 = "Visited art museum.";
      string imageUrl01 = "img/vancouver/vancouverbike.jpg";
      string imageUrl02 = "img/vancouver/vancouverskyline.jpg";
      Place newPlace01 = new Place(cityName01, countryName01, lengthOfStay01, companions01, journalEntry01, imageUrl01);
      Place newPlace02 = new Place(cityName02, countryName02, lengthOfStay02, companions02, journalEntry02, imageUrl02);
      List<Place> newList = new List<Place> { newPlace01, newPlace02 };
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_DeletesAllPlacesInList_Void()
    {
      Place place01 = new Place("Vancouver", "Canada", "3 days", "Brandon", "Biked to Stanley Park.", "img/vancouver/vancouverbike.jpg");
      Place place02 = new Place("Philadelphia", "United States", "5 days", "Kai", "Visited art museum.", "img/vancouver/vancouverskyline.jpg");
      List<Place> expected = new List<Place> { };
      Place.ClearAll();
      CollectionAssert.AreEqual(expected, Place.GetAll());
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string cityName = "Vancouver";
      string countryName = "Canada";
      string lengthOfStay = "3 days";
      string companions = "Brandon";
      string journalEntry = "Biked to Stanley Park.";
      string imageUrl = "img/vancouver/vancouverskyline.jpg";
      Place newPlace = new Place(cityName, countryName, lengthOfStay, companions, journalEntry, imageUrl);
      int result = newPlace.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
      string cityName01 = "Vancouver";
      string cityName02 = "Philadelphia";
      string countryName01 = "Canada";
      string countryName02 = "United States";
      string lengthOfStay01 = "3 days";
      string lengthOfStay02 = "5 days";
      string companions01 = "Brandon";
      string companions02 = "Kai";
      string journalEntry01 = "Biked to Stanley Park.";
      string journalEntry02 = "Visited art museum.";
      string imageUrl01 = "img/vancouver/vancouverskyline.jpg";
      string imageUrl02 = "img/vancouver/vancouverbike.jpg";
      Place newPlace01 = new Place(cityName01, countryName01, lengthOfStay01, companions01, journalEntry01, imageUrl01);
      Place newPlace02 = new Place(cityName02, countryName02, lengthOfStay02, companions02, journalEntry02, imageUrl02);
      Place result = Place.Find(2);
      Assert.AreEqual(newPlace02, result);
    }
  }
}