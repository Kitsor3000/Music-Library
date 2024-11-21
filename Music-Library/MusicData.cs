using System.Collections.Generic;

namespace Music_Library
{
    public class MusicData
    {
        // Список для зберігання музичних треків
        public List<(string Title, string Author, string Genre, int Year)> MusicArray { get; set; }

        // Конструктор
        public MusicData()
        {
            MusicArray = new List<(string Title, string Author, string Genre, int Year)>();
        }

        // Метод для додавання треку
        public void AddTrack(string title, string author, string genre, int year)
        {
            MusicArray.Add((title, author, genre, year));
        }

        // Метод для очищення всіх треків
        public void ClearTracks()
        {
            MusicArray.Clear();
        }

        // Метод для додавання треків за замовчуванням
        public void AddDefaultTracks()
        {
            var defaultTracks = new[]
            {
                ("Track 1", "Artist A", "Rock", 2001),
                ("Track 2", "Artist B", "Pop", 2003),
                ("Track 3", "Artist C", "Jazz", 1999),
                ("Track 4", "Artist D", "Classical", 2010),
                ("Track 5", "Artist E", "Hip-hop", 2015)
            };

            foreach (var track in defaultTracks)
            {
                MusicArray.Add(track);
            }
        }
    }
}
