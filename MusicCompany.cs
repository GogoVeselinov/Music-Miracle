using System;
using System.Collections.Generic;

namespace MusicTask
{
    public class MusicCompany
    {
        private List<Song> _songs;

        public MusicCompany()
        {
            _songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            _songs.Add(song);
        }

        public void PrintAllSongs()
        {
            foreach (var song in _songs)
            {
                song.PrintInfo();
            }
        }
    }
}