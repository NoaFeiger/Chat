using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicLayer
{
    public class Chatroom:IChatroom
    {
        private List<User> users;
        private List<Message> messages;
        private IUser currentUser;
        public const string URL= null;

        public Chatroom()
        {
            this.users = new List<User>();
            this.messages = new List<Message>();
            this.currentUser = null;
        }

        public string Registration(string groupId, string nickname)
        {
            throw new NotImplementedException();
        }

        public void Login(string groupId, string nickname)
        {
            throw new NotImplementedException();
        }

        bool IChatroom.IsValidRegistration(string groupId, string nickname)
        {
            throw new NotImplementedException();
        }

        public bool IsValidLogin(string groupId, string nickname)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public void GetNMessages(int n)
        {
            throw new NotImplementedException();
        }

        public void DisplayNMessages(int n)
        {
            throw new NotImplementedException();
        }

        public void Send(string messageContent)
        {
            throw new NotImplementedException();
        }
    }
}

