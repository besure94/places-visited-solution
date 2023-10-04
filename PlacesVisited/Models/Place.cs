using System.Collections.Generic;

namespace PlacesVisited.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string LengthOfStay { get; set; }
    public string Companions { get; set; }
    public string JournalEntry { get; }
    public Place(string cityName, string lengthOfStay, string companions, string journalEntry)
    {
      CityName = cityName;
      LengthOfStay = lengthOfStay;
      Companions = companions;
      JournalEntry = journalEntry;
    }
  }
}