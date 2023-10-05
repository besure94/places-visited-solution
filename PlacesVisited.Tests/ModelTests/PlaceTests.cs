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
      Place newPlace = new Place("Vancouver", "Canada", "3 days", "Brandon", "Biked to Stanley Park.");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      string cityName = "Vancouver";
      Place newPlace = new Place(cityName, "Canada", "3 days", "Brandon", "Biked to Stanley Park.");
      string result = newPlace.CityName;
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetCityName_SetCityName_String()
    {
      string cityName = "Vancouver";
      Place newPlace = new Place(cityName, "Canada", "5 days", "Brandon", "Biked to Stanley Park.");
      string updatedCityName = "Philadelphia";
      newPlace.CityName = updatedCityName;
      string result = newPlace.CityName;
      Assert.AreEqual(updatedCityName, result);
    }

    [TestMethod]
    public void GetCountryName_ReturnsCountryName_String()
    {
      string countryName = "Canada";
      Place newPlace = new Place("Vancouver", countryName, "3 days", "Brandon", "Biked to Stanley Park.");
      string result = newPlace.CountryName;
      Assert.AreEqual(countryName, result);
    }

    [TestMethod]
    public void SetCountryName_SetCountryName_String()
    {
      string countryName = "Canada";
      Place newPlace = new Place("Vancouver", countryName, "3 days", "Brandon", "Biked to Stanley Park.");
      string updatedCountryName = "Mexico";
      newPlace.CountryName = updatedCountryName;
      string result = newPlace.CountryName;
      Assert.AreEqual(updatedCountryName, result);
    }

    [TestMethod]
    public void GetLengthOfStay_ReturnsLengthOfStay_String()
    {
      string lengthOfStay = "3 days";
      Place newPlace = new Place("Vancouver", "Canada",lengthOfStay, "Brandon", "Biked to Stanley Park.");
      string result = newPlace.LengthOfStay;
      Assert.AreEqual(lengthOfStay, result);
    }

    [TestMethod]
    public void SetLengthOfStay_SetLengthOfStay_String()
    {
      string lengthOfStay = "3 days";
      Place newPlace = new Place("Vancouver", "Canada",lengthOfStay, "Brandon", "Biked to Stanley Park.");
      string updatedLengthOfStay = "5 days";
      newPlace.LengthOfStay = updatedLengthOfStay;
      string result = newPlace.LengthOfStay;
      Assert.AreEqual(updatedLengthOfStay, result);
    }

    [TestMethod]
    public void GetCompanions_ReturnsCompanions_String()
    {
      string companions = "Brandon";
      Place newPlace = new Place("Vancouver", "Canada", "3 days", companions, "Biked to Stanley Park.");
      string result = newPlace.Companions;
      Assert.AreEqual(companions, result);
    }

    [TestMethod]
    public void SetCompanions_SetCompanions_String()
    {
      string companions = "Brandon";
      Place newPlace = new Place("Vancouver", "Canada", "3 days", companions, "Biked to Stanley Park.");
      string updatedCompanions = "Kai";
      newPlace.Companions = updatedCompanions;
      string result = newPlace.Companions;
      Assert.AreEqual(updatedCompanions, result);
    }

    [TestMethod]
    public void GetJournalEntry_ReturnsJournalEntry_String()
    {
      string journalEntry = "Biked to Stanley Park.";
      Place newPlace = new Place("Vancouver", "Canada", "3 days", "Brandon", journalEntry);
      string result = newPlace.JournalEntry;
      Assert.AreEqual(journalEntry, result);
    }

    [TestMethod]
    public void SetJournalEntry_SetJournalEntry_String()
    {
      string journalEntry = "Biked to Stanley Park.";
      Place newPlace = new Place("Vancouver", "Canada", "3 days", "Brandon", journalEntry);
      string updatedJournalEntry = "Took ferry to North Vancouver.";
      newPlace.JournalEntry = updatedJournalEntry;
      string result = newPlace.JournalEntry;
      Assert.AreEqual(updatedJournalEntry, result);
    }

    [TestMethod]
    public void GetImage_ReturnsImage_String()
    {
      string imageUrl = ""
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
      Place newPlace01 = new Place(cityName01, countryName01, lengthOfStay01, companions01, journalEntry01);
      Place newPlace02 = new Place(cityName02, countryName02, lengthOfStay02, companions02, journalEntry02);
      List<Place> newList = new List<Place> { newPlace01, newPlace02 };
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_DeletesAllPlacesInList_Void()
    {
      Place place01 = new Place("Vancouver", "Canada", "3 days", "Brandon", "Biked to Stanley Park.");
      Place place02 = new Place("Philadelphia", "United States", "5 days", "Kai", "Visited art museum.");
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
      Place newPlace = new Place(cityName, countryName, lengthOfStay, companions, journalEntry);
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
      Place newPlace01 = new Place(cityName01, countryName01, lengthOfStay01, companions01, journalEntry01);
      Place newPlace02 = new Place(cityName02, countryName02, lengthOfStay02, companions02, journalEntry02);
      Place result = Place.Find(2);
      Assert.AreEqual(newPlace02, result);
    }
  }
}