using System;
using System.Drawing;
using System.Windows.Forms;

namespace SneilonRun.FormElements
{
    public class PayerPanel
    {
        public Panel AddPanel(int id, string name, EventHandler action)
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
            btDelete.Click += action;
            panel.Dock = DockStyle.Top;
            panel.Height = 25;
            panel.Controls.Add(lblName);
            panel.Controls.Add(btDelete);
            return panel;
        }
    }
}
