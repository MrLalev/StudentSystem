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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool userName = true;

            User user = new User();
            UserRepo repo = new UserRepo();
            List<User> users = repo.GetAll();

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

            if (userName == true)
            {
                MessageBox.Show("Потребителското име вече съществува!");
                txtUsername.Text = null;
                user.Username = null;
            }


            if (txtUsername.Text != "" && txtPass.Text != "" && txtName.Text != "" && comboBoxAdminRole.Text != "")
            {
                repo.Insert(user);

                DialogResult result = MessageBox.Show("Данните бяха записани, желаете ли да добавите друг потребител?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
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

        private void AddUser_Load(object sender, EventArgs e)
        {
            comboBoxAdminRole.Items.Add("0");
            comboBoxAdminRole.Items.Add("1");
            comboBoxAdminRole.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
