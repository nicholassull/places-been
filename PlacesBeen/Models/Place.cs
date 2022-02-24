using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string DateTraveled { get; set; }
    public int Id { get; }
    private static List<Place> _instances = new List<Place> {};    
    

    public Place(string cityName, string dateTraveled)
    {
      CityName = cityName;
      DateTraveled = dateTraveled;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
