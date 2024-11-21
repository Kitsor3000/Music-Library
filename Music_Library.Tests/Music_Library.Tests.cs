using System.Linq;
using Xunit;
using Music_Library;

namespace Music_Library.Tests
{
    public class MusicDataTests
    {
        [Fact]
        public void AddTrack_ValidData_TrackIsAdded()
        {
            // Arrange
            var musicData = new MusicData();
            string title = "Test Song";
            string author = "Test Artist";
            string genre = "Rock";
            int year = 2000;

            // Act
            musicData.AddTrack(title, author, genre, year);

            // Assert
            Assert.Single(musicData.MusicArray); // Перевіряємо, що додано один трек
            var track = musicData.MusicArray.First();
            Assert.Equal(title, track.Title);
            Assert.Equal(author, track.Author);
            Assert.Equal(genre, track.Genre);
            Assert.Equal(year, track.Year);
        }

        [Fact]
        public void ClearTracks_AllTracksRemoved()
        {
            // Arrange
            var musicData = new MusicData();
            musicData.AddTrack("Track 1", "Artist 1", "Pop", 2001);
            musicData.AddTrack("Track 2", "Artist 2", "Jazz", 1999);

            // Act
            musicData.ClearTracks();

            // Assert
            Assert.Empty(musicData.MusicArray); // Перевіряємо, що список треків порожній
        }

        [Fact]
        public void AddDefaultTracks_DefaultTracksAdded()
        {
            // Arrange
            var musicData = new MusicData();

            // Act
            musicData.AddDefaultTracks();

            // Assert
            Assert.Equal(5, musicData.MusicArray.Count); // Перевіряємо, що додано 5 треків
        }

        [Theory]
        [InlineData("Song A", "Artist A", "Genre A", 2000)]
        [InlineData("Song B", "Artist B", "Genre B", 1995)]
        public void AddTrack_MultipleTracks_TracksAreAdded(string title, string author, string genre, int year)
        {
            // Arrange
            var musicData = new MusicData();

            // Act
            musicData.AddTrack(title, author, genre, year);

            // Assert
            Assert.Contains(musicData.MusicArray, t => t.Title == title && t.Author == author && t.Genre == genre && t.Year == year);
        }
    }
}
