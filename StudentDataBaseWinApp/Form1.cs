using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentDataBaseWinApp.Repo;
using StudentDataBaseWinApp.Enteties;
using StudentDataBaseWinApp.view;

namespace StudentDataBaseWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPass.Text;
            string fNumber = textUsername.Text;

            ProfileRepo profileRepo = new ProfileRepo();
            UserRepo userRepo = new UserRepo();
            StudentRepo studentRepo = new StudentRepo();

            User loggedUser = UserRepo.GetByUsernameAndPassword(username, password);
            Student loggedStudent = StudentRepo.GetByFNumber(fNumber);
            List<User> users = userRepo.GetAll();
            List<Profil> profils = profileRepo.GetAll();
            List<Profil> newProfils = new List<Profil>();
            List<Student> students = studentRepo.GetAll();
            List<Student> newStudents = new List<Student>();

            foreach (User user in users)
            {
                foreach (Profil profil in profils)
                {
                    if (user.Username == profil.Username)
                    {
                        string pictureFlie = Application.StartupPath + @"\Profils\" + user.Username + ".jpg";
                        profil.Picture = pictureFlie;

                        newProfils.Add(profil);
                    }
                }

            }

            foreach (Student student in students)
            {
                  string pictureFlie = Application.StartupPath + @"\Students\" + student.fNumber + ".jpg";
                  student.Photo = pictureFlie;

                  newStudents.Add(student);
            }

            studentRepo.OverWrite(newStudents);
            profileRepo.OverWrite(newProfils);

            if (loggedUser != null && loggedUser.UserRole == 1)
            {
                UserView userView = new UserView();
                userView.Validation(loggedUser);
                textUsername.Text = null;
                textPass.Text = null;
                userView.ShowDialog();
            }
            else if (loggedUser != null && loggedUser.UserRole == 0)
            {
                UserView userView = new UserView();
                userView.Validation(loggedUser);
                textUsername.Text = null;
                textPass.Text = null;
                userView.ShowDialog();
            }
            else if (loggedStudent != null)
            {
                StudentView studentView = new StudentView();
                studentView.TakeStudent(loggedStudent);
                textUsername.Text = null;
                textPass.Text = null;
                studentView.ShowDialog();

            }
            else
            {
               MessageBox.Show("Грешно име, парола или факултетен номер!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
