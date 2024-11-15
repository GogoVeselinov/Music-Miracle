using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace MusicTask
{
    public abstract class Song
    {
        private string _title;
        private string _artist;
        private string _album;
        private double _duration;
        private string _realiseDate;

        public Song(string title, string artist, string album ,double duration, string RealiseDate)
        {
            this._title = title;
            this._artist = artist;
            this._album = album;
            this._duration = duration;
            this._realiseDate = RealiseDate;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }

        public double Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public string RealiseDate
        {
            get { return _realiseDate; }
            set { _realiseDate = value; }
        }

        public abstract void PrintInfo();
    }
}
