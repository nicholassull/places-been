using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string DateTraveled { get; set; }  

    public Place(string cityName, string dateTraveled)
    {
      CityName = cityName;
      DateTraveled = dateTraveled;
    }
  }
}
