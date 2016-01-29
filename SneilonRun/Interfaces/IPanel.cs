using System;
using System.Windows.Forms;

namespace SnailonRun.Interfaces
{
    interface IPanel
    {
        Panel CreatePanel(int id, string name, EventHandler[] actions);
    }
}
