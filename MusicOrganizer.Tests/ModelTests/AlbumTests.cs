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
  }
}