using System;

namespace Model
{
    public class Model
    {

        private string _artist;
        private string _title;
        private int _duration;
        private int _publicYear;

        public Model()
        {}

        public Model(string artist, string title, int duration, int publicYear)
        {
            _artist = artist;
            _title = title;
            _duration = duration;
            _publicYear = publicYear;
        }

        public override string ToString()
        {
            return $"{nameof(_artist)}: {_artist}, {nameof(_title)}: {_title}, {nameof(_duration)}: {_duration}, {nameof(_publicYear)}: {_publicYear}";
        }

        public string Artist
        {
            get => _artist;
            set => _artist = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public int Duration
        {
            get => _duration;
            set => _duration = value;
        }

        public int PublicYear
        {
            get => _publicYear;
            set => _publicYear = value;
        }
    }
}
