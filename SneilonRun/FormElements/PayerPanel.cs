using System;
using System.Drawing;
using System.Windows.Forms;
using SnailonRun.Interfaces;

namespace SnailonRun.FormElements
{
    public class PayerPanel: IPanel
    {
        public Panel CreatePanel(int id, string name, EventHandler[] actions)
        {
            var panel = new Panel { Name = "panelPlayer" + id };
            var lblName = new Label { Text = name, Width = 160 };
            var btDelete = new Button
            {
                Tag = id,
                Text = "X",
                Size = new Size(20, 20),
                Location = new Point(165, 0)
            };
            btDelete.Click += actions[0];
            panel.Dock = DockStyle.Top;
            panel.Height = 25;
            panel.Controls.Add(lblName);
            panel.Controls.Add(btDelete);
            return panel;
        }
    }
}
