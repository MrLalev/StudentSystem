using StudentDataBaseWinApp.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentDataBaseWinApp.Repo
{
    class UserRepo : BaseRepo<User>
    {
        public UserRepo()
        {
            SourceFile = "users.txt";
        }

        public override void ReadFromSource(StreamReader sr, User item)
        {
            item.Id = Convert.ToInt32(sr.ReadLine());
            item.Username = sr.ReadLine();
            item.Password = sr.ReadLine();
            item.FullName = sr.ReadLine();
            item.UserRole = Convert.ToInt32(sr.ReadLine());
        }

        public override void WriteToSource(StreamWriter sw, User item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.Username);
            sw.WriteLine(item.Password);
            sw.WriteLine(item.FullName);
            sw.WriteLine(item.UserRole);
        }

        internal static User GetByUsernameAndPassword(string username, string password)
        {
            User logged = null;
            User admin = null;

            FileStream stream = new FileStream("users.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);

            while (sr.EndOfStream == false)
            {
                User user = new User();

                user.Id = Convert.ToInt32(sr.ReadLine());
                user.Username = sr.ReadLine();
                user.Password = sr.ReadLine();
                user.FullName = sr.ReadLine();
                user.UserRole = Convert.ToInt32(sr.ReadLine());

                if (user.Username == username && user.Password == password)
                {
                    if (user.UserRole == 1)
                    {
                        admin = user;
                        break;
                    }
                    else
                    {
                        logged = user;
                        break;
                    }
                }
            }

            sr.Close();
            stream.Close();

            if (admin != null)
            {
                return admin;
            }
            else
            {
                return logged;
            }
        }
    }
}
