using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Album> Albums { get; set; }

    public Artist(string artistName)
    {
      Name = artistName;
      _instances.Add(this);
      Id = _instances.Count;
      Albums = new List<Album>{};
    }
    // Test class Artist reference PG 34

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Artist> GetAll()
    {
     return _instances;
    }

    public static Artist Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddAlbum(Album album)
    {
      Albums.Add(album);
    }
  }
}




// Parent
// -Artist

// Methods
// -Index
// -Create -new artist
// -delete -remove artist
// -Get find artist

// Views
// -new artist - home
// -delete - home


// Controllers
// -artistController




// Child
// -Albums
// -Songs

// Methods
// -Index
// -Create - create 
// -