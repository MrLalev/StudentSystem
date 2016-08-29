using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StudentDataBaseWinApp.Enteties;
using StudentDataBaseWinApp.Repo;
using System.Net.Mail;
using System.Net;

namespace StudentDataBaseWinApp.view
{
    public partial class MessageView : Form
    {
        Profil loggedProfil = new Profil();
        public MessageView()
        {
            InitializeComponent();
        }


        private void buttonSend_Click(object sender, EventArgs e)
        {
            using (MailMessage mail = new MailMessage())
            {
                if (textBoxFrom.Text.Contains("@gmail.com"))
                {
                    try
                    {
                        mail.From = new MailAddress(textBoxFrom.Text);
                        mail.To.Add(textBoxTo.Text);
                        mail.Subject = textBoxTitel.Text;
                        mail.Body = richTextBoxBody.Text;
                        if (textBoxAdd.Text != "")
                        {
                            mail.Attachments.Add(new Attachment(textBoxAdd.Text));
                        }

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new NetworkCredential(textBoxFrom.Text, textBoxPassword.Text);
                            smtp.EnableSsl = true;
                            smtp.Send(mail);

                            MessageBox.Show("Вашето исъбщение беше изпратено!");

                            textBoxFrom.Text = "";
                            textBoxTo.Text = "";
                            textBoxTitel.Text = "";
                            textBoxPassword.Text = "";
                            richTextBoxBody.Text = "";
                            textBoxAdd.Text = "";
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Грешна парола, ако сте сигурни в паролата си проверете и променете настройките си за \"По-малко сигурни приложения\". За повече информация: www.google.com/settings/security/lesssecureapps");
                    }
                }
                else
                {
                    MessageBox.Show("Използвайте gmail акаунт!");
                }
              
            }
        }

        internal void GetProfil(User user)
        {
            //Repository repo = new Repository();
            //List<Profil> profils = repo.AllProfils();

            //foreach (Profil profil in profils)
            //{
            //    if (profil.Username == user.Username)
            //    {
            //        loggedProfil = profil;
            //        break;
            //    }
            //}

            //textBoxFrom.Text = loggedProfil.Email;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxAdd.Text = fileDialog.FileName;
            }
        }
    }
}
