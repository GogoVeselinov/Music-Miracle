using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicTask
{
    public class Rap : Song
    {
        private string _genre;

        public Rap(string title, string artist, string album, double duration, string genre,string RealiseDate) : base(title, artist, album, duration, RealiseDate)
        {
            this._genre = genre;
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}, Artist: {Artist}, Album: {Album} Duration: {Duration}, Genre: {Genre}");
        }
    }
}