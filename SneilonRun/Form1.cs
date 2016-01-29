using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using SnailonRun.Models;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SnailonRun.FormElements;

namespace SnailonRun
{
    public partial class Form1 : Form
    {
        int _dash;
        DateTime _start;
        DateTime _end;
        readonly List<Snail> _snails = new List<Snail>();
        readonly List<Player> _players = new List<Player>();
        private int _playerId = 1;
        private int _snailId = 1;
        private int _anteId = 1;
        private IMediaPlayer player;

        public Form1()
        {
            InitializeComponent();
            player = new MediaPlayer(
                    "C:\\Users\\Qzavyer\\Music\\Unheilig - Discography\\Albums\\2010 - Grosse Freiheit (00602527318158)");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var koefs = new Dictionary<int, double>();
            var bonuses = new Dictionary<int, int>();

            koefs.Add(1, Convert.ToDouble(ConfigurationManager.AppSettings["FirstPlace"]));
            koefs.Add(2, Convert.ToDouble(ConfigurationManager.AppSettings["SecondPlace"]));
            koefs.Add(3, Convert.ToDouble(ConfigurationManager.AppSettings["ThirdPlace"]));
            koefs.Add(4, Convert.ToDouble(ConfigurationManager.AppSettings["FourthPlace"]));


            bonuses.Add(1, Convert.ToInt32(ConfigurationManager.AppSettings["FirstBonus"]));
            bonuses.Add(2, Convert.ToInt32(ConfigurationManager.AppSettings["SecondBonus"]));
            bonuses.Add(3, Convert.ToInt32(ConfigurationManager.AppSettings["ThirdBonus"]));
            bonuses.Add(4, Convert.ToInt32(ConfigurationManager.AppSettings["FourthBonus"]));

            

            PlaceBonus.SetBonus(bonuses);
            PlaceKoef.SetKoef(koefs);
        }

        private void BtClearSnails_Click(object sender, EventArgs e)
        {
            _snails.RemoveAll(r => true);
            _snailId = 1;
            panelSnails.Controls.Clear();
        }

        private void BtClearPlayers_Click(object sender, EventArgs e)
        {
            _players.RemoveAll(r => true);
            _playerId = 1;
            panelPlayers.Controls.Clear();
        }

        #region PayerControl

        private void BtAddPlayer_Click(object sender, EventArgs e)
        {
            var name = tbPlayerName.Text;
            var id = _playerId;
            _players.Add(new Player { Name = name, Id = id });
            _playerId++; 
            tbPlayerName.Clear();
            tbPlayerName.Focus();
            var lst = new BindingList<Player>(_players);
            //cbPlayer.
            cbPlayer.DataSource = lst;
            cbPlayer.DisplayMember = "ShortName";
            cbPlayer.ValueMember = "Id";
            cbPlayer.Refresh();
            AddPlayerPanel(id, name);
        }

        private void AddPlayerPanel(int id, string name)
        {
            var payerPanel = new PayerPanel();
            panelPlayers.Controls.Add(payerPanel.AddPanel(id,name, BtRemovePlayer_CLick));
        }

        private void BtRemovePlayer_CLick(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;
            var playerId = Convert.ToInt32(button.Tag);
            _players.RemoveAll(r => r.Id == playerId);
            panelPlayers.Controls.RemoveByKey("panelPlayer" + playerId);
        }

        #endregion

        #region Snail Control

        private void BtAddSnail_Click(object sender, EventArgs e)
        {
            var name = tbSnailName.Text;
            var id = _snailId;
            _snails.Add(new Snail {Name = name, Id = id, Route = 0});
            _snailId++;
            tbSnailName.Clear();
            tbSnailName.Focus();
            var lst = new BindingList<Snail>(_snails);
            //cbPlayer.
            cbSnail.DataSource = lst;
            cbSnail.DisplayMember = "ShortName";
            cbSnail.ValueMember = "Id";
            AddSnailPanel(id, name);
        }

        private void AddSnailPanel(int id, string name)
        {            
            var snailPanel = new SnailPanel();
            var actions = new EventHandler[] { BtSlice_Click, BtRemoveSnail_Click, BtNoSlice_Click };
            panelSnails.Controls.Add(snailPanel.AddPanel(id, name, actions));
        }
        
        private void BtSlice_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;
            var time = DateTime.Now - _start;
            var snailId = Convert.ToInt32(button.Tag);
            var snail = _snails.Single(r => r.Id == snailId);
            snail.Time = time;
            var label = Controls["lbTime" + snailId] as Label;
            if (label == null) return;
            label.Text = time.ToString("mm:ss");
        }

        private void BtNoSlice_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;
            var snailId = Convert.ToInt32(button.Tag);
            var snail = _snails.Single(r => r.Id == snailId);
            snail.Time = new TimeSpan(0);
            var label = Controls["lbTime" + snailId] as Label;
            if (label == null) return;
            label.Text = "";
        }

        private void BtRemoveSnail_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if(button==null) return;
            var snailId = Convert.ToInt32(button.Tag);
            foreach (var player in _players)
            {
                player.Antes.RemoveAll(r => r.Snail.Id == snailId);
            }
            _snails.RemoveAll(r => r.Id == snailId);
            panelSnails.Controls.RemoveByKey("panelSnail" + snailId);
        }

        #endregion

        private void BtAddAnte_Click(object sender, EventArgs e)
        {
            var id = _anteId;
            var playerId = cbPlayer.SelectedValue;
            var snailId = cbSnail.SelectedValue;
            var sum = Convert.ToInt32(tbAnteSum.Text);
            var player = _players.Single(r => r.Id == (int)playerId);
            var snail = _snails.Single(r => r.Id == (int)snailId);
            player.Antes.Add(new Ante {Id = id, Snail = snail, Price = sum});
            _anteId++;
        }

        private void BtRemoveAnte_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;
            var anteId = Convert.ToInt32(button.Tag);
            var player = _players.Single(r => r.Antes.Any(l => l.Id == anteId));
            player.Antes.RemoveAll(r => r.Id == anteId);
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            _dash++;
            _start = DateTime.Now;
        }

        private void BtEnd_Click(object sender, EventArgs e)
        {
            _end = DateTime.Now;
            var time = _end - _start;
            foreach (var snail in _snails)
            {
                snail.Time = time;
            }
        }

        private void BtCalculate_Click(object sender, EventArgs e)
        {
            SetPlaces();
            SaveLogFile(ConfigurationManager.AppSettings["LogFile"]);
            ClearAntes();
        }

        private void SetPlaces()
        {
            var min = new TimeSpan(0);
            var i = 1;
            while (i < _snails.Count)
            {
                min = _snails.Where(r => r.Time > min).Min(r => r.Time);
                var snail = _snails.FirstOrDefault(r => r.Time == min);
                if (snail == null) continue;
                var tbRoute = Controls.Find("tbRoute" + snail.Id, true);
                snail.Place = i;
                i++;
                if (!tbRoute.Any()) continue;
                int routeId;
                var route = tbRoute[0] as TextBox;
                if (route != null) continue;
                if (Int32.TryParse(route.Text, out routeId))
                {
                    snail.Route = routeId;
                }
            }
        }

        private void SaveLogFile(string filename)
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

        private void ClearAntes()
        {
            foreach (var snail in _snails)
            {
                snail.Time = new TimeSpan(0);
                snail.Bonus = 0;
            }
            foreach (var player in _players)
            {
                player.Antes = new List<Ante>();
            }
            _anteId = 1;
        }

        private void Play(object sender, EventArgs e)
        {
            player.Play();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.VolumeDown();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.VolumeUp();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.Next();
        }
    }
}
