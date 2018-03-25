using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    interface IUser
    {
        string GroupID();
        string Nickname();
        Message Send(string messageContent);
        void Logout();
        
    }
}
