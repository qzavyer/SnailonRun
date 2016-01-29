namespace SnailonRun.Models
{
    public class Ante
    {
        public int Id { get; set; }
        public Snail Snail { get; set; }
        public double Price { get; set; }

        public double Win
        {
            get { return Price*Snail.PlcKoef + Snail.Bonus; }
        }
    }
}