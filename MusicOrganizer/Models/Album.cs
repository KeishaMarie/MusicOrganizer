using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string Description { get; set; }
    private static List<Album> _instances = new List<Album> {};

    public Album (string description)
    {
      Description = description;
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}