using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    interface IUser
    {
        string GroupID { get; }
        string Nickname{ get; }
        void Send(string messageContent);
        void Logout();
    }
}
