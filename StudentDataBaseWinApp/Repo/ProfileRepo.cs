using StudentDataBaseWinApp.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentDataBaseWinApp.Repo
{
    class ProfileRepo : BaseRepo<Profil>
    {
        public ProfileRepo()
        {
            SourceFile = "profils.txt";
        }

        public override void ReadFromSource(StreamReader sr, Profil item)
        {
            item.Id = Convert.ToInt32(sr.ReadLine());
            item.Username = sr.ReadLine();
            item.FullName = sr.ReadLine();
            item.Age = Convert.ToInt32(sr.ReadLine());
            item.Gender = sr.ReadLine();
            item.Facultet = sr.ReadLine();
            item.Discipline = sr.ReadLine();
            item.Email = sr.ReadLine();
            item.Picture = sr.ReadLine();
        }

        public override void WriteToSource(StreamWriter sw, Profil item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.Username);
            sw.WriteLine(item.FullName);
            sw.WriteLine(item.Age);
            sw.WriteLine(item.Gender);
            sw.WriteLine(item.Facultet);
            sw.WriteLine(item.Discipline);
            sw.WriteLine(item.Email);
            sw.WriteLine(item.Picture);
        }

        public void EditProfil(Profil edit, User loggedUser)
        {
            List<Profil> profils = this.GetAll();
            UserRepo userRepo = new UserRepo();
            List<User> users = userRepo.GetAll();

            foreach (Profil profil in profils)
            {
                if (profil.Username == edit.Username)
                {
                    profil.Id = edit.Id;
                    profil.Username = edit.Username;
                    profil.FullName = edit.FullName;
                    profil.Age = edit.Age;
                    profil.Gender = edit.Gender;
                    profil.Facultet = edit.Facultet;
                    profil.Discipline = edit.Discipline;
                    profil.Email = edit.Email;
                    profil.Picture = edit.Picture;
                }
            }

            foreach (User user in users)
            {
                if (user.Id == loggedUser.Id)
                {
                    user.Id = loggedUser.Id;
                    user.FullName = loggedUser.FullName;
                    user.UserRole = loggedUser.UserRole;
                    user.Username = loggedUser.Username;
                    user.Password = loggedUser.Password;
                }
            }


            this.OverWrite(profils);
            userRepo.OverWrite(users);
        }
    }
}
