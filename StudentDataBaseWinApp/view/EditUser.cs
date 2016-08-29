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

namespace StudentDataBaseWinApp.view
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool userName = true;

            UserRepo repo = new UserRepo();
            List<User> users = repo.GetAll();

            User user = new User();
            user.Username = txtUsername.Text;
            user.Password = txtPass.Text;
            user.FullName = txtName.Text;

            foreach (User item in users)
            {
                if (item.Username != user.Username)
                {
                    userName = false;
                }
                else
                {
                    userName = true;
                    break;
                }
            }

            if (comboBoxAdminRole.Text != "")
            {
                user.UserRole = Convert.ToInt32(comboBoxAdminRole.Text);
            }

            if (comboBoxId.Text != "" )
            {
                user.Id = Convert.ToInt32(comboBoxId.Text);
            }


            if (comboBoxId.Text != "" && txtName.Text != "" && txtUsername.Text != "" && txtPass.Text != "" && comboBoxAdminRole.Text != "")
            {
                repo.Edit(user);

                DialogResult result = MessageBox.Show("Данните бяха редактирани, желаете ли да редактирате друг потребител?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    comboBoxId.Text = "";
                    txtUsername.Text = null;
                    txtPass.Text = null;
                    txtName.Text = null;
                    comboBoxAdminRole.SelectedItem = 0;
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

        private void EditUser_Load(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            List<User> users = repo.GetAll();

            foreach (User item in users)
            {
                comboBoxId.Items.Add(item.Id);
            }
            comboBoxId.DropDownHeight = 55;
            comboBoxAdminRole.Items.Add("0");
            comboBoxAdminRole.Items.Add("1");
            comboBoxAdminRole.SelectedIndex = 0;
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

            txtName.Text = user.FullName;
            txtUsername.Text = user.Username;
            txtPass.Text = user.Password;
            comboBoxAdminRole.Text = user.UserRole.ToString();
        }
    }
}
