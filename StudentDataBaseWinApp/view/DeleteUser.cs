using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentDataBaseWinApp.Enteties;
using StudentDataBaseWinApp.Repo;
using System.IO;

namespace StudentDataBaseWinApp.view
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            UserRepo repo = new UserRepo();
            ProfileRepo profileRepo = new ProfileRepo();

            if (comboBoxId.Text != "")
            {
                id = Convert.ToInt32(comboBoxId.Text);
                List<User> users = repo.GetAll();
                List<Profil> profils = profileRepo.GetAll();
                User loggedUser = new User();

                foreach (User item in users)
                {
                    if (item.Id == id)
                    {
                        loggedUser = item;
                    }
                }
                foreach (Profil item in profils)
                {
                    if (item.Username == loggedUser.Username)
                    {
                        File.Delete(item.Picture);
                        profileRepo.Delete(item.Id);
                    }   
                }
                repo.Delete(id);

                DialogResult result = MessageBox.Show("Данните бяха изтрити, желаете ли да изтриете друг потребител?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    comboBoxId.Items.Remove(id);
                    comboBoxId.Text = "";
                    labelFullName.Text = "";
                    labelUserName.Text = "";
                    labelAdminRole.Text = "";
                }
                else
                {
                    this.Close();
                }      
            }
            else
            {
                MessageBox.Show("Не може да оставяте празни полета!");
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            List<User> users = repo.GetAll();

            foreach (User item in users)
            {
                comboBoxId.Items.Add(item.Id);
            }
            comboBoxId.DropDownHeight = 55;
        }

        private void comboBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            List<User> users = repo.GetAll();

            User user = new User();

            foreach (User item in users)
            {
                if (Convert.ToInt32(comboBoxId.Text) == item.Id)
                {
                    user = item;
                }
            }

            labelAdminRole.Text = user.UserRole.ToString();
            labelUserName.Text = user.Username;
            labelFullName.Text = user.FullName;

        }
    }
}
