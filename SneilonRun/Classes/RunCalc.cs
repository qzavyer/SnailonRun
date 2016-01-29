using System;
using System.Collections.Generic;
using System.Linq;
using SnailonRun.Models;

namespace SnailonRun.Classes
{
    public class RunCalc
    {
        public void SetPlaces(IEnumerable<Snail> snails)
        {
            var min = new TimeSpan(0);
            var i = 1;
            while (i < snails.Count())
            {
                min = snails.Where(r => r.Time > min).Min(r => r.Time);
                var snail = snails.FirstOrDefault(r => r.Time == min);
                if (snail == null) continue;
                snail.Place = i;
                i++;                
            }
        }
    }
}
