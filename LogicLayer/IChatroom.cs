using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    interface IChatroom
    {
        Boolean Registration(string groupId, string nickname);
        void Login(string groupId, string nickname);
        void Start();
        bool IsValidRegistration(string groupId, string nickname);
        bool IsValidLogin(string groupId, string nickname);
        void Logout();
        List<string> RetrieveNMessages(int n);

        List<Message> DisplayNMessages(int n);
        void Send(string messageContent);

    }
}
