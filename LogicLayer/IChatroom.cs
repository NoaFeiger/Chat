using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    interface IChatroom
    {
        string Registration(string groupId, string nickname);
        void Login(string groupId, string nickname);
        bool IsValidRegistration(string groupId, string nickname);
        bool IsValidLogin(string groupId, string nickname);
        void Logout();
        void GetNMessages(int n);
        void DisplayNMessages(int n);
        void Send(string messageContent);

    }
}
