using System.Collections.Generic;

namespace SneilonRun
{
    public class PlaceBonus
    {
        public static Dictionary<int, int> Bonus;
        public static bool IsSetting = false;

        public static void SetBonus(Dictionary<int, int> koef)
        {
            if (IsSetting) return;
            Bonus = koef;
            IsSetting = true;
        }

        public static int GetBonus(int place)
        {
            return Bonus.ContainsKey(place) ? Bonus[place] : 0;
        }
    }
}