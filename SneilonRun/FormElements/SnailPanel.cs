using System;
using System.Drawing;
using System.Windows.Forms;
using SnailonRun.Interfaces;

namespace SnailonRun.FormElements
{
    class SnailPanel: IPanel
    {
        public Panel CreatePanel(int id, string name, EventHandler[] actions)
        {
            var panel = new Panel { Name = "panelSnail" + id };
            var lblName = new Label { Text = name, Width = 160 };
            var tbRoute = new TextBox
            {
                Name = "tbRoute" + id,
                Text = "0",
                Size = new Size(25, 25),
                Location = new Point(160, 0),
                Visible = true
            };
            var lblTime = new Label
            {
                Text = "",
                Name = "lbTime" + id,
                Size = new Size(50, 20),
                Location = new Point(190, 0),
                BorderStyle = BorderStyle.FixedSingle
            };
            var btTime = new Button
            {
                Tag = id,
                Text = "T",
                Size = new Size(20, 20),
                Location = new Point(240, 0),
                Enabled = false
            };
            var btNoTime = new Button
            {
                Tag = id,
                Text = "!T",
                Size = new Size(20, 20),
                Location = new Point(265, 0),
                Enabled = false
            };
            var btDelete = new Button
            {
                Tag = id,
                Text = "X",
                Size = new Size(20, 20),
                Location = new Point(290, 0)
            };
            btTime.Click += actions[0];
            btDelete.Click += actions[1];
            btNoTime.Click += actions[2];
            panel.Dock = DockStyle.Top;
            panel.Height = 25;
            panel.Controls.Add(lblName);
            panel.Controls.Add(tbRoute);
            panel.Controls.Add(lblTime);
            panel.Controls.Add(btTime);
            panel.Controls.Add(btDelete);
            return panel;
        }
    }
}
