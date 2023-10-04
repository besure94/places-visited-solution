using System.Collections.Generic;

namespace PlacesVisited.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string CountryName { get; }
    public string LengthOfStay { get; set; }
    public string Companions { get; set; }
    public string JournalEntry { get; set; }
    public Place(string cityName, string countryName, string lengthOfStay, string companions, string journalEntry)
    {
      CityName = cityName;
      CountryName = countryName;
      LengthOfStay = lengthOfStay;
      Companions = companions;
      JournalEntry = journalEntry;
    }
  }
}