using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;
namespace PresentationLayer
{
    interface IGui
    {
        void BuildGui(Chatroom chat); // instructor
        void Start();
        void Registration(string nickname, string groupId);
        void Login(User user);

    }
}
