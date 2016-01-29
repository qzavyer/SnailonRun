using System.Collections.Generic;

namespace SneilonRun
{
    public class PlaceKoef
    {
        public static Dictionary<int, double> Koef;
        public static bool isSetting = false;

        public static void SetKoef(Dictionary<int, double> koef)
        {
            if(isSetting)return;
            Koef = koef;
            isSetting = true;
        }

        public static double GetKoef(int place)
        {
            return Koef.ContainsKey(place) ? Koef[place] : 0;
        }
    }
}