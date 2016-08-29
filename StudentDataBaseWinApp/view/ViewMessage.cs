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
    public partial class ViewMessage : Form
    {
        User loggedUser = new User();
        public ViewMessage()
        {
            InitializeComponent();
        }

        private void ViewMessage_Load(object sender, EventArgs e)
        {
            MessageRepo repo = new MessageRepo();
            List<MyMessage> messages = repo.GetAll();
            List<MyMessage> readed = new List<MyMessage>();
            List<MyMessage> unReaded = new List<MyMessage>();

            foreach (MyMessage message in messages)
            {
                if (message.To == loggedUser.FullName)
                {
                    
                    if (message.seen == true)
                    {
                        readed.Add(message);
                    }
                    else
                    {
                        unReaded.Add(message);
                    }
                }
            }

            foreach (MyMessage message in readed)
            {
               checkedListBoxReaded.Items.Add(message.Id, true);
            }

            foreach (MyMessage message in unReaded)
            {
                checkedListBoxUnReaded.Items.Add(message.Id);
            }

        }

        internal void GetProfil(User userNew)
        {
            UserRepo repo = new UserRepo();
            List<User> users = repo.GetAll();

            foreach (User user in users)
            {
                if (user.Username == userNew.Username)
                {
                    loggedUser = user;
                    break;
                }
            }

            textBoxTo.Text = loggedUser.FullName;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageRepo repo = new MessageRepo();
            if (textBoxId.Text != "")
            {
                repo.Delete(Convert.ToInt32(textBoxId.Text));
                foreach (var item in checkedListBoxReaded.Items)
                {
                    if (item.ToString() == textBoxId.Text)
                    {
                        checkedListBoxReaded.Items.Remove(item.ToString());
                    }
                }

                List<MyMessage> messagesNew = repo.GetAll();
                List<MyMessage> readed = new List<MyMessage>();
                List<MyMessage> unReaded = new List<MyMessage>();

                foreach (MyMessage message in messagesNew)
                {
                    if (message.To == loggedUser.FullName)
                    {
                        if (message.seen == true)
                        {
                            readed.Add(message);
                        }
                        else
                        {
                            unReaded.Add(message);
                        }
                    }
                }

                checkedListBoxReaded.Items.Clear();
                foreach (MyMessage message in readed)
                {
                    checkedListBoxReaded.Items.Add(message.Id, true);
                }

                checkedListBoxUnReaded.Items.Clear();
                foreach (MyMessage message in unReaded)
                {

                    checkedListBoxUnReaded.Items.Add(message.Id);
                }
            }
            else
            {
                MessageBox.Show("Изберете съобщение, което искате да бъде изтрито!");
            }

            MessageBox.Show("Съобщението беше изтрито! ");

            textBoxId.Text = "";
            richTextBoxBody.Text = "";
            textBoxTitel.Text = "";
            richTextBoxBody.Enabled = false;
            textBoxTo.Text = "";
            textBoxFrom.Text = "";
            buttonAnswer.Enabled = false;
            buttonSend.Enabled = false;
            buttonDelete.Enabled = false;

        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            textBoxTo.Text = textBoxFrom.Text;
            textBoxFrom.Text = loggedUser.FullName;
            textBoxTitel.Text += "- Re";
            richTextBoxBody.Text += Environment.NewLine + "------------------------------------------------------------------------------------"+Environment.NewLine;
            richTextBoxBody.Enabled = true;
            buttonSend.Enabled = true;
            buttonAnswer.Enabled = false;
        }

        private void textBoxTitel_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxTitel.Text != "" && richTextBoxBody.Text != "" && textBoxTo.Text != "")
            {
                MessageRepo repo = new MessageRepo();
                MyMessage message = new MyMessage();
                message.From = textBoxFrom.Text;
                message.To = textBoxTo.Text;
                message.Tittle = textBoxTitel.Text;
                string text = "";
                foreach (string item in richTextBoxBody.Lines)
                {
                    text += item + @"\n";
                }
                message.Content = text;
                message.seen = false;

                repo.Insert(message);

                MessageBox.Show("Отговорът Ви беше изпратен успешно!");

                richTextBoxBody.Text = "";
                textBoxTitel.Text = "";
                richTextBoxBody.Enabled = false;
                textBoxTo.Text = "";
                textBoxFrom.Text = "";
                buttonAnswer.Enabled = false;
                buttonSend.Enabled = false;
                buttonDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Всички полета са задължителни!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBoxUnReaded_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxReaded.Items.Add(checkedListBoxUnReaded.SelectedItem,true);
            checkedListBoxUnReaded.Items.Remove(checkedListBoxUnReaded.SelectedItem.ToString());

            MessageRepo repo = new MessageRepo();
            List<MyMessage> messages = repo.GetAll();

            foreach (MyMessage message in messages)
            {
                if (message.Id == Convert.ToInt32(checkedListBoxUnReaded.SelectedItem))
                {
                    textBoxId.Text = message.Id.ToString();
                    textBoxFrom.Text = message.From;
                    textBoxTo.Text = message.To;
                    textBoxTitel.Text = message.Tittle;
                    richTextBoxBody.Text = message.Content.Replace(@"\n", Environment.NewLine);
                    message.seen = true;

                    repo.Edit(message);

                    buttonAnswer.Enabled = true;
                    buttonDelete.Enabled = true;

                }
            }

            List<MyMessage> messagesNew = repo.GetAll();
            List<MyMessage> readed = new List<MyMessage>();
            List<MyMessage> unReaded = new List<MyMessage>();

            foreach (MyMessage message in messagesNew)
            {
                if (message.To == loggedUser.FullName)
                {
                    if (message.seen == true)
                    {
                        readed.Add(message);
                    }
                    else
                    {
                        unReaded.Add(message);
                    }
                }
            }

            checkedListBoxReaded.Items.Clear();
            foreach (MyMessage message in readed)
            {
                checkedListBoxReaded.Items.Add(message.Id, true);
            }

            checkedListBoxUnReaded.Items.Clear();
            foreach (MyMessage message in unReaded)
            {

                checkedListBoxUnReaded.Items.Add(message.Id);
            }
        }

        private void checkedListBoxReaded_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageRepo repo = new MessageRepo();
            List<MyMessage> messages = repo.GetAll();

            foreach (MyMessage message in messages)
            {
                if (message.Id == Convert.ToInt32(checkedListBoxReaded.SelectedItem))
                {
                    textBoxId.Text = message.Id.ToString();
                    textBoxFrom.Text = message.From;
                    textBoxTo.Text = message.To;
                    textBoxTitel.Text = message.Tittle;
                    richTextBoxBody.Text = message.Content.Replace(@"\n", Environment.NewLine);
                    message.seen = true;

                    repo.Edit(message);

                    buttonAnswer.Enabled = true;
                    buttonDelete.Enabled = true;

                }
            }
        }
    }
}
