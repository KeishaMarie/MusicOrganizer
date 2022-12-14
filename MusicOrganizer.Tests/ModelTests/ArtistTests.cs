using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTests : IDisposable
  {
    
    public void Dispose()
    {
      Artist.ClearAll();
    }

    [TestMethod]
    public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
    {
      Artist newArtist = new Artist("test artist");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Category";
      Artist newArtist = new Artist(name);

      //Act
      string result = newArtist.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsArtistId_Int()
    {
      //Arrange
      string name = "Test Artist";
      Artist newArtist = new Artist(name);

      //Act
      int result = newArtist.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllArtistObjects_ArtistList()
    {
      //Arrange
      string name01 = "Frank Zappa";
      string name02 = "The Gratefule Dead";
      Artist newArtist1 = new Artist(name01);
      Artist newArtist2 = new Artist(name02);
      List<Artist> newList = new List<Artist> { newArtist1, newArtist2 };

      //Act
      List<Artist> result = Artist.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectArtist_Artist()
    {
      //Arrange
      string name01 = "Frank Zappa";
      string name02 = "The Grateful Dead";
      Artist newArtist1 = new Artist(name01);
      Artist newArtist2 = new Artist(name02);

      //Act
      Artist result = Artist.Find(2);

      //Assert
      Assert.AreEqual(newArtist2, result);
    }

    [TestMethod]
    public void AddAlbum_AssociatesAlbumWithCategory_AlbumList()
    {
      //Arrange
      string title = "Working Man's Dead";
      Album newAlbum = new Album(title);
      List<Album> newList = new List<Album> { newAlbum };
      string name = "The Grateful Dead";
      Artist newArtist = new Artist(name);
      newArtist.AddAlbum(newAlbum);

      //Act
      List<Album> result = newArtist.Albums;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}