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
    public partial class AddMessage : Form
    {
        User loggedUser;
        public AddMessage()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxTitel.Text != "" && richTextBoxBody.Text != "" && comboBoxTo.Text != "")
            {
                MessageRepo repo = new MessageRepo();
                MyMessage message = new MyMessage();

                message.From = textBoxFrom.Text;
                message.To = comboBoxTo.Text;
                message.Tittle = textBoxTitel.Text;

                string text = "";
                foreach (string item in richTextBoxBody.Lines)
                {
                    text += item + @"\n";
                }

                message.Content = text;
                message.seen = false;

                repo.Insert(message);

                DialogResult result = MessageBox.Show("Съобщението беше изпратено, желаете ли да напишете друго съобщение?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    comboBoxTo.Text = null;
                    textBoxTitel.Text = "";
                    richTextBoxBody.Text = "";
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Всички полета са задължителни!");
            }
        }

        internal void GetProfil(User user)
        {
            loggedUser = user;

            textBoxFrom.Text = loggedUser.FullName;
        }

        private void AddMessage_Load(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            List<User> users = repo.GetAll();

            foreach (User user in users)
            {
                comboBoxTo.Items.Add(user.FullName);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
