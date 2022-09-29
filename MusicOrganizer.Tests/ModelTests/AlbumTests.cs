using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class Albumtests : IDisposable
  {
    public void Dispose()
    {
      Album.ClearAll();
    }

    [TestMethod]
    public void AlbumConstructor_CreatesInstancesOfAlbum_Album()
    {
      Album newAlbum = new Album("test");
      Assert.AreEqual(typeof(Album), newAlbum.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Working Man's Dead";

      //Act
      Album newAlbum = new Album(title);
      string result = newAlbum.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Working Man's Dead";
      Album newAlbum = new Album(title);

      //Act
      string updatedTitle = "Europe 72";
      newAlbum.Title = updatedTitle;
      string result = newAlbum.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_AlbumList()
    {
      // Arrange
      List<Album> newList = new List<Album> { };

      // Act
      List<Album> result = Album.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAlbum_AlbumList()
    {
      //Arrange
      string title01 = "Working Man's Dead";
      string title02 = "Europe 72";
      Album newAlbum1 = new Album(title01);
      Album newAlbum2 = new Album(title02);
      List<Album> newList = new List<Album> { newAlbum1, newAlbum2 };

      //Act
      List<Album> result = Album.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_AlbumsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "Working Man's Dead";
      Album newAlbum = new Album(title);

      //Act
      int result = newAlbum.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectAlbum_Album()
    {
      //Arrange
      string title01 = "Working Man's Dead";
      string title02 = "Europe 72";
      Album newAlbum1 = new Album(title01);
      Album newAlbum2 = new Album(title02);

      //Act
      Album result = Album.Find(2);

      //Assert
      Assert.AreEqual(newAlbum2, result);
    }
  }
}