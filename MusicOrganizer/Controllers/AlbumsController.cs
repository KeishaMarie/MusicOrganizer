using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class AlbumsController : Controller
  {

    [HttpGet("/artists/{artistId}/albums/new")]
    public ActionResult New(int artistId)
    {
      Artist artist = Artist.Find(artistId);
      return View(artist);
    }

    // This one creates new albums within a given Crtist, not new artists:
    [HttpPost("/artists/{artistId}/albums")]
    public ActionResult Create(int artistId, string albumTitle)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist foundArtist = Artist.Find(artistId);
      Album newAlbum = new Album(albumTitle);
      foundArtist.AddAlbum(newAlbum);
      List<Album> artistAlbums = foundArtist.Albums;
      model.Add("album", artistAlbums);
      model.Add("artist", foundArtist);
      return View("Show", model);
    }


    [HttpPost("/albums/delete")]
    public ActionResult DeleteAll()
    {
      Album.ClearAll();
      return View();
    }

    [HttpGet("/artists/{artistId}/album/{albumId}")]
    public ActionResult Show(int artistId, int albumId)
    {
      Album album = Album.Find(albumId);
      Artist artist = Artist.Find(artistId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("album", album);
      model.Add("artist", artist);
      return View(model);
    }

  }
}