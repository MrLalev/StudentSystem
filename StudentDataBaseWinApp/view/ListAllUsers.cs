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
    public partial class ListAllUsers : Form
    {
        public ListAllUsers()
        {
            InitializeComponent();
        }

        private void ListAllUsers_Load(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            List<User> users = repo.GetAll();

            comboBoxSearch.Items.Add("Потребителско име");
            comboBoxSearch.Items.Add("Име и фамилия");

            Print(users);

        }

        private void Print(List<User> users)
        {
            Panel panel = new Panel();
            panel.AutoScroll = true;
            panel.Left = 0;
            panel.Width = 513;
            panel.Height = 243;
            this.Controls.Add(panel);
            panel.BringToFront();

            for (int i = 0; i < users.Count; i++)
            {
                Label label = new Label();
                label.Text = String.Format(users[i].Id.ToString());
                label.Left = 10;
                label.Width = 41;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Top = (i + 1) * 22;
                label.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label);
                //this.Controls.Add(label);
                label.BringToFront();

                Label label1 = new Label();
                label1.Text = String.Format(users[i].Username);
                label1.Left = 50;
                label1.Width = 199;
                label1.TextAlign = ContentAlignment.MiddleLeft;
                label1.Top = (i + 1) * 22;
                label1.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label1);
                //this.Controls.Add(label1);
                label1.BringToFront();

                Label label2 = new Label();
                label2.Text = String.Format(users[i].FullName);
                label2.Left = 248;
                label2.Width = 106;
                label2.TextAlign = ContentAlignment.MiddleLeft;
                label2.Top = (i + 1) * 22;
                label2.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label2);
                //this.Controls.Add(label2);
                label2.BringToFront();

                Label label3 = new Label();
                label3.Text = String.Format(users[i].UserRole.ToString());
                label3.Left = 352;
                label3.Width = 139;
                label3.TextAlign = ContentAlignment.MiddleRight;
                label3.Top = (i + 1) * 22;
                label3.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label3);
                //this.Controls.Add(label3);
                label3.BringToFront();
            }
            panel1.BringToFront();
            labelId.BringToFront();
            labelUserName.BringToFront();
            labelFullName.BringToFront();
            labelAdmin.BringToFront();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlphaSort_Click(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            List<User> users = repo.GetAll();

            List<User> orderedAlphabetically = users.OrderBy(user => user.FullName).ToList();

            Print(orderedAlphabetically);

        }

        private void buttonFnumberSort_Click(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            List<User> users = repo.GetAll();

            List<User> orderedAdmin = users.OrderByDescending(user => user.UserRole).ToList();

            Print(orderedAdmin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            List<User> users = repo.GetAll();

            List<User> orderedId = users.OrderBy(user => user.Id).ToList();

            Print(orderedId);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textSearch.Text != "" && comboBoxSearch.Text != "")
            {
                string search = textSearch.Text;

                switch (comboBoxSearch.SelectedIndex)
                {
                    case 0:
                        {

                            UserRepo repo = new UserRepo();
                            List<User> users = repo.GetAll();

                            List<User> searched = new List<User>();

                            foreach (User item in users)
                            {
                                if (item.Username.ToLower().Contains(search.ToLower()))
                                {
                                    User searchedUser = item;
                                    searched.Add(searchedUser);
                                }
                            }

                            Print(searched); 
                            break;
                        }
                    case 1:
                        {
                            UserRepo repo = new UserRepo();
                            List<User> users = repo.GetAll();

                            List<User> searched = new List<User>();

                            foreach (User item in users)
                            {
                                if (item.FullName.ToLower().Contains(search.ToLower()))
                                {
                                    User searchedUser = item;
                                    searched.Add(searchedUser);
                                }
                            }

                            Print(searched);

                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Изберете опция за търсене и критерии в полето за търсене!");
            }
        }
    }
}
