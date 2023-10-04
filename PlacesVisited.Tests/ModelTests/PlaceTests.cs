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
  }
}