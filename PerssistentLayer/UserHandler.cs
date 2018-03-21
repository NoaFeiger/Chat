using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;
using System.IO;
namespace PerssistentLayer
{
    class UserHandler
    {
        public static void Main(String[] args)
        {
            saveToFile(new User("NoaFeiger","23"));
            saveToFile(new User("NitzanFarhi","1"));
            List<User> temp = RestoreUsers();
            Print(temp);
            Console.ReadLine();
        }
        public static void Print(List<User> temp) // just for checking
        {
            foreach(User item in temp)
            {
                Console.WriteLine(item.GroupID() +" " + item.Nickname());
            }
        }
        public static void saveToFile(User user)
        {
            string startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            startupPath += "\\DataUsers.txt";
            using (StreamWriter sw = File.AppendText(startupPath))
            {
                sw.WriteLine(user.GroupID() + "," + user.Nickname());

            }

        }
        public static List<User> RestoreUsers()
        {
            List<User> userList = new List<User>();
            string startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            startupPath += "\\DataUsers.txt";
            var lines = System.IO.File.ReadAllLines(startupPath);

            foreach (string item in lines)
            {
                var values = item.Split(',');
                userList.Add(new User((values[0]), (values[1])));
            }
            return userList;
        }

    }
}






