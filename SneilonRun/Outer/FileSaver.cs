using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SnailonRun.Models;

namespace SnailonRun.Outer
{
    public class FileSaver
    {
        int _dash;
        DateTime _start;
        DateTime _end;
        IEnumerable<Snail> _snails;
        IEnumerable<Player> _players;
        
        public FileSaver(int dash, TimePeriod period, Game game)
        {
            _dash = dash;
            _start = period.Start;
            _end = period.End;
            _snails = game.Snails;
            _players = game.Players;
        }

        public void SaveLogFile(string filename)
        {
            using (var file = new StreamWriter(filename, true, Encoding.UTF8))
            {
                if (_dash == 1)
                {
                    file.WriteLine("{0:dd.MM.yyyy}", _end);
                }
                file.WriteLine("-- Забег № {0} --", _dash);
                file.WriteLine("Время начала: {0:HH:mm:ss}", _start);
                file.WriteLine("Время окончания: {0:HH:mm:ss}", _end);
                file.WriteLine();
                file.WriteLine("Дорожка\tИмя улиты\tВремя\tМесто\tБонус");
                foreach (var snail in _snails.OrderBy(r => r.Route))
                {
                    file.WriteLine("{0}\t{1}\t{2:mm:ss}\t{3}\t{4}", snail.Route, snail.ShortName, snail.Time,
                        snail.Place,
                        snail.Bonus);
                }
                file.WriteLine();
                file.WriteLine("Имя игрока\tИмя улиты\tСтавка\tВыигрыш");
                foreach (var player in _players)
                {
                    foreach (var ante in player.Antes)
                    {
                        file.WriteLine("{0}\t{1}\t{2}\t{3}", player.ShortName, ante.Snail.ShortName, ante.Price,
                            ante.Win);
                    }
                }
                file.WriteLine();
                file.WriteLine("Имя игрока\tСумма выигрышей");
                foreach (var player in _players)
                {
                    file.WriteLine("{0}\t{1}", player.ShortName, player.Win);
                }
                file.WriteLine();
            }
        }
    }
}
