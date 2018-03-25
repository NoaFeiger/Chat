using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistentLayer;
using CommunicationLayer; 

namespace LogicLayer
{
    public class Chatroom
    {
        private List<IUser> users;
        private List<Message> messages;
        private IUser currentUser;
        public const string URL= "www";
        public const int VALID_GROUPID = 23;
        const string INVALID_GROUPID_ERROR = "The group doesn't exist!";
        const string INVALID_NICKNAME_ERROR = "Already used nickname";
        const string ILLEGAL_LOGIN = "You aren't registered, please register first";
        const string ILLEGAL_LENGTH_MESSAGE = "The message souldn't be more than 150 characters";
        public Chatroom() { 
            this.users = new List<IUser>();
            this.messages = new List<Message>();
            this.currentUser = null;
        }
        public void Start()
        {
            //restoring the users list
            List<String> usersData = UserHandler.RestoreUsers();
            foreach (string data in usersData)
            {
                string[] details = data.Split(',');
                this.users.Add(new User(details[0], details[1]));
            }

            //restoring the messages list
            List<String> messagesData = MessageHandler.RestoreMessages();
            if (messagesData != null)
            {
                foreach (string data in messagesData)
                {
                    string[] details = data.Split(',');
                    this.messages.Add(new Message(details[0], details[1], details[2], details[3], details[4]));
                }
            }
        }
        /*Check if groupID and nickname inputs are legal. If groupID doesn't exist or nickname is already been used
        by the same group, the function throws an exception*/
        public bool Registration(string groupId, string nickname)
        {
            if (!IsValidnickname(groupId, nickname))
                throw new Exception(INVALID_NICKNAME_ERROR);
            if (!IsValidgroupId(groupId))
                throw new Exception(INVALID_GROUPID_ERROR);
            else
            {
                this.currentUser = new User(groupId, nickname); //constructor adds user to file 
                this.users.Add(currentUser);
                return true;
            }
                
        }
        //Check if nickname is already been used in the same group. 
        private bool IsValidnickname(string groupId, string nickname)
        {
            foreach(IUser user in this.users)
            {
                if (user.GroupID().Equals(groupId) && user.Nickname().Equals(nickname))
                    return false;
            }
            return true; 
        }
        //Check if groupID is exist in the file which inclueds all the groupIDs participate in the project 
        private bool IsValidgroupId(string groupId)
        {  
            if (Int32.Parse(groupId) <= VALID_GROUPID)
                return true;
            return false;
        }
        //Check if the user is registered. If isn't throw an exception
        public bool Login(string groupId, string nickname)
        {
            foreach (IUser user in this.users)
            {
                if (user.GroupID().Equals(groupId) && user.Nickname().Equals(nickname))
                {
                    this.currentUser = user;
                    return true;
                }
            }
            throw new Exception(ILLEGAL_LOGIN);
        }
        //Logout the current user
        public void Logout()
        {
            this.currentUser.Logout();
            this.currentUser = null; 
        }
        public void RetrieveNMessages(int number)
        { 
            List<IMessage> retrievedMessages = Communication.Instance.GetTenMessages(URL);
            foreach (IMessage msg in retrievedMessages)
            {
                Message newMessage = new Message(msg);
                if (!this.messages.Contains(newMessage))
                { 
                    this.messages.Add(newMessage);
                    newMessage.Save();
                }
            }

        }
        public List<Message> DisplayNMessages(int number)
        {
            List<Message> display = new List<Message>();
            for(int i =this.messages.Count-1; i >= 0 & number > 0; i = i-1)
            {
                display.Add(this.messages[i]);
                number = number - 1; 
            }
            display.Reverse();
            return display;
           
        }
        /*Check if the message content is legal.(maybe should do it in message class)And delegate the send operation to the user */
        public void Send(string messageContent)
        {
            if (!Message.CheckValidity(messageContent))
                throw new Exception(ILLEGAL_LENGTH_MESSAGE);
            if (this.currentUser != null)
            {
                Message msg = this.currentUser.Send(messageContent);
                this.messages.Add(msg);
                msg.Save();
            }
            else
                throw new NullReferenceException();

        }
    }
}

