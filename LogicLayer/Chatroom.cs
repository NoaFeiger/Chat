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
        const string INVALID_GROUPID_ERROR = "The group doesn't exist!";
        const string INVALID_NICKNAME_ERROR = "Already used nickname";
        public Chatroom()
        {
            this.users = new List<User>();
            this.messages = new List<Message>();
            this.currentUser = null;
        }

        public void Start()
        {
            //start and init all the fields of chatroom
            //open a new gui object and send him to start
           // Gui g = new Gui(this);
            // g.Start();
           
        }
        public bool Registration(string groupId, string nickname)
        {
            return false;
            
          // check validation of input, if not ok throw exception
        }
        public bool IsValidnickname(string groupId, string nickname)
        {
            // need to check if this nickname is already used
            return false;
        }
        public bool IsValidgroupId(string groupId, string nickname)
        {
          
            return false;
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

        public List<string> RetrieveNMessages(int n)
        {
            throw new NotImplementedException();
        }

       
        public List<Message> DisplayNMessages(int n)
        {
            return null;
        }

        public void Send(string messageContent)
        {
            throw new NotImplementedException();
        }
    }
}

