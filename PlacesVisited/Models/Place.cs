using System.Collections.Generic;

namespace PlacesVisited.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string LengthOfStay { get; set; }
    public string Companions { get; }
    public Place(string cityName, string lengthOfStay, string companions)
    {
      CityName = cityName;
      LengthOfStay = lengthOfStay;
      Companions = companions;
    }
  }
}