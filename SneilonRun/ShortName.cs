using System.Linq;

namespace SnailonRun
{
    public class ShortName
    {
        private string _name;

        public ShortName(string name)
        {
            _name = name;
        }

        public string GetShort()
        {
            var tName = _name;
            if (tName.Length > 15)
            {
                var names = tName.Split(' ', ',', '-', '.');
                var shorts = 0;
                var shortlen = 0;
                var namecnt = names.Count();
                var sublen = 15 / namecnt;
                while (names.Any(r => r.Length < sublen && r.Length > shortlen))
                {
                    shortlen = names.Where(r => r.Length > shortlen).Min(r => r.Length);
                    var cnt = names.Count(r => r.Length == shortlen);
                    shorts += (shortlen * cnt);
                    sublen = (15 - shorts) / names.Count(r => r.Length > shortlen);
                }
                var newNames = names.Select(name => name.Substring(0, 1).ToUpper() + name.Remove(0, 1)).ToList();
                var result = "";
                foreach (var name in newNames)
                {
                    var len = name.Length > sublen ? sublen : name.Length;
                    result = result + name.Substring(0, len);
                }
                return result;
            }
            while (tName.Length < 8)
            {
                tName = tName + " ";
            }
            return tName;
        }

        public string GetFullName()
        {
            return _name;
        }
    }
}
