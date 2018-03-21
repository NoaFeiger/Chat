using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class User:IUser
    {
        private string groupID;
        private string nickname;
        public User(string groupID, string nickname)
        {
            this.groupID = groupID;
            this.nickname = nickname;

        }
        public string GroupID ()
        {
            return this.groupID;
        }

        public string Nickname()
        {
            return this.nickname;
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public void Send(string messageContent)
        {
            throw new NotImplementedException();
        }
    }
}
