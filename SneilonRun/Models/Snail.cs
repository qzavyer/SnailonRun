using System;

namespace SnailonRun.Models
{
    public class Snail
    {
        private int _bonus;
        private TimeSpan _setingtime;
        private bool _isSettingTime;
        public int Id { get; set; }

        public string Name { private get; set; }

        public string ShortName
        {
            get
            {
                var shrt = new ShortName(Name);
                return shrt.GetShort();
            }
        }

        public int Route { get; set; }

        public TimeSpan Time
        {
            get
            {
                return _setingtime;
            }
            set
            {
                if (_isSettingTime) return;
                _setingtime = value;
                _isSettingTime = true;
            }
        }

        public int Place { get; set; }

        public int Bonus
        {
            get { return _bonus + PlcBonus; }
            set { _bonus = value; }
        }

        private int PlcBonus
        {
            get
            {
                return PlaceBonus.GetBonus(Place);
            }
        }

        public double PlcKoef
        {
            get
            {
                return PlaceKoef.GetKoef(Place);
            }
        }
    }
}