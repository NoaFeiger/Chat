using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;

namespace PresentationLayer
{
    class Program
    {
        //public static string groupId;
        //public static string nickname;
        const string INVALID_GROUPID_ERROR = "The group doesn't exist";
        const string INVALID_NICKNAME_ERROR = "Already used nickname";
        static void Main(string[] args)
        {
            int request = -1;
            Chatroom chatR = new Chatroom();
            Console.WriteLine("Welcome to our chat room");
            Console.WriteLine("Press 1 - to registrate +/n" +
                  "Press 2- to login +/n" +
                  "Press 0 -to exit");
            request = int.Parse(Console.ReadLine());
            while (request!=0)
            {
                if (request == 1)
                    RegistrarionHandler(chatR);
                

                request = int.Parse(Console.ReadLine());
                Console.ReadLine();
                //  request = int
            }
            
        }
        public static string RegistrarionHandler(Chatroom chatR)
        {
            string groupId;
            string nickname;
            Console.WriteLine("Insert GroupId:");
            groupId = Console.ReadLine();
            Console.WriteLine("Insert nickname: ");
            nickname = Console.ReadLine();
            if (chatR.Registration(groupId, nickname) == INVALID_GROUPID_ERROR)
                Console.WriteLine(INVALID_GROUPID_ERROR);
            return "";
        }

    }
}
