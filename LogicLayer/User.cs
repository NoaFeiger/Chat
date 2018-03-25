using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using CommunicationLayer;
using PersistentLayer;
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
            Save();
        }
        public string GroupID ()
        {
            return this.groupID;
        }
        public string Nickname()
        {
            return this.nickname;
        }
        public void Save()
        {
            UserHandler.SaveToFile(Nickname(), GroupID());
        }
        //returns message that recieved from server. The function build a Message instance that save itself in the constructor
        public Message Send(string messageContent)
        {
            IMessage message = Communication.Instance.Send(Chatroom.URL, GroupID(), Nickname(), messageContent);
            return new Message(message);
        }
        public void Logout()
        {
            //its functionality will be only in the logger
        }
        public override string ToString()
        {
            return GroupID() + Nickname();
        }
    }
}
