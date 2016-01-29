using System.Collections.Generic;

namespace SnailonRun.Models
{
    public class Game
    {
        public IEnumerable<Player> Players { get; set; }
        public IEnumerable<Snail> Snails { get; set; }
    }
}
