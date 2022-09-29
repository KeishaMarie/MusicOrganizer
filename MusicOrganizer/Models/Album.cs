using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string Title { get; set; }
    private static List<Album> _instances = new List<Album> {};

    public Album (string title)
    {
      Title = title;
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Album> GetAll()
    {
      return _instances;
    }
  }
}