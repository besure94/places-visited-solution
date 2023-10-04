using System.Collections.Generic;

namespace PlacesVisited.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string LengthOfStay { get; }
    public Place(string cityName, string lengthOfStay)
    {
      CityName = cityName;
      LengthOfStay = lengthOfStay;
    }
  }
}