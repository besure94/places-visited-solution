using System.Collections.Generic;

namespace PlacesVisited.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string CountryName { get; set; }
    public string LengthOfStay { get; set; }
    public string Companions { get; set; }
    public string JournalEntry { get; set; }
    private static List<Place> _instances = new List<Place> { };

    public Place(string cityName, string countryName, string lengthOfStay, string companions, string journalEntry)
    {
      CityName = cityName;
      CountryName = countryName;
      LengthOfStay = lengthOfStay;
      Companions = companions;
      JournalEntry = journalEntry;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }
  }
}