using System.Collections.Generic;
using System.Linq;

namespace SnailonRun.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Name{ private get; set;}

        public string ShortName
        {
            get
            {
                var shrt = new ShortName(Name);
                return shrt.GetShort();
            }
        }

        public List<Ante> Antes { get; set; }

        public double Win
        {
            get { return Antes.Sum(r => r.Win); }
        }
    }
}