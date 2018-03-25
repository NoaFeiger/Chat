using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistentLayer;
using CommunicationLayer;

 

namespace LogicLayer
{ 
    public class Message
    {
        private Guid Id;
        private string nickname;
        private string groupId;
        private DateTime date;
        private string messageContent;
        const int MAX_LENGTH = 150; 

        public Message(IMessage message)
        {
            this.Id = message.Id;
            this.nickname = message.UserName;
            this.groupId = message.GroupID;
            this.date = message.Date;
            this.messageContent = message.MessageContent;

        }
        public Message(string id, string nickname, string groupId, string date, string messageContent)
        {
            this.Id = new Guid(id);
            this.nickname = nickname;
            this.groupId = groupId;
            this.date = DateTime.Parse(date);
            this.messageContent = messageContent;
        }
        //Save message into file in persistent layer
        public void Save()
        {
           MessageHandler.SaveToFile(this.Id, this.nickname, this.groupId, this.date, this.messageContent);
        }
        //Static function which checks if the message content is valid 
        public static bool CheckValidity(string messageContent)
        {
            if (messageContent.Length > MAX_LENGTH)
                return false;
            return true;
        }
        public override string ToString()
        {
            return this.messageContent + " send by " + this.groupId + ":" + this.nickname + " " + this.date;
        }
    }
}
