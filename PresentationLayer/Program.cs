using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;

namespace PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Chatroom cr = new Chatroom();
            cr.Start();
            Gui gui = new Gui(cr);
            gui.Start();
        }
    }
}
