using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Travel
  {
    public string Ticket { get; set; }
    public string DateTraveled { get; set; }
    public int Id { get; }
    private static List<Travel> _instances = new List<Travel> {};    
    

    public Travel(string ticket, string dateTraveled)
    {
      Ticket = ticket;
      DateTraveled = dateTraveled;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Travel> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
