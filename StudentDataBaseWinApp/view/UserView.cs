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
    public partial class UserView : Form
    {
        User user;
        public UserView()
        {
            InitializeComponent();
        }

        internal void Validation(User loggedUser)
        {
            if (loggedUser.UserRole == 1)
            {
                usersToolStripMenuItem.Enabled = true;
                labelHi.Text = "Добре дошли, " + loggedUser.Username + " !";
            }
            else
            {
                labelHi.Text = "Добре дошли, " + loggedUser.Username + " !";
            }

            textBoxFullName.Text = loggedUser.FullName;
            user = loggedUser;
        }



        private void UserView_Load(object sender, EventArgs e)
        {
            ProfileRepo repo = new ProfileRepo();
            List<Profil> profils = repo.GetAll();

            comboBoxGender.Items.Add("Жена");
            comboBoxGender.Items.Add("Мъж");

            foreach (Profil profil in profils)
	        {
		        if (profil.Username == user.Username)
                    {
                        textBoxAge.Text = profil.Age.ToString();
                        comboBoxGender.Text = profil.Gender;
                        textBoxFacultet.Text = profil.Facultet;
                        textBoxDescipline.Text = profil.Discipline;
                        textBoxEmail.Text = profil.Email;
                        using (FileStream fs = new FileStream(profil.Picture, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            byte[] buffer = new byte[fs.Length];
                            fs.Read(buffer, 0, (int)fs.Length);
                            using (MemoryStream ms = new MemoryStream(buffer))
                            this.pictureBoxUserPhoto.Image = Image.FromStream(ms);
                        }
                        textBoxPicturePath.Text = profil.Picture;
                    }
	        }

            MessageRepo messageRepo = new MessageRepo();
            List<MyMessage> messages = messageRepo.GetAll();
            Label newLabel = new Label();
            newLabel.Width = 17;
            newLabel.Height = 16;
            newLabel.Left = 0;
            newLabel.Top = 0;
            newLabel.BackColor = Color.FromArgb(192, 0, 0);
            newLabel.ForeColor = SystemColors.ControlLightLight;
            newLabel.TextAlign = ContentAlignment.MiddleCenter;
            panelMessage.Controls.Add(newLabel);

            int cout = 0;
            foreach (MyMessage message in messages)
            {
                if (message.To == user.FullName && message.seen == false)
                {
                    cout++;
                }
            }

            if (cout == 0)
            {
                newLabel.Visible = false;
                panelMessage.Visible = false;
            }
            else
            {
                newLabel.Text = cout.ToString();
            }        
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxFullName.Enabled = true;
            textBoxAge.Enabled = true;
            comboBoxGender.Enabled = true;
            textBoxFacultet.Enabled = true;
            textBoxDescipline.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxChangePass.Enabled = false;
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            textBoxFullName.Enabled = false;
            textBoxAge.Enabled = false;
            comboBoxGender.Enabled = false;
            textBoxFacultet.Enabled = false;
            textBoxDescipline.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxChangePass.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ProfileRepo repo = new ProfileRepo();
            List<Profil> profils = repo.GetAll();
            UserRepo userRepo = new UserRepo();

            int count = 0;
            Profil loggedProfil = new Profil();

                foreach (Profil profil in profils)
                {
                    if (profil.Username == user.Username)
                    {
                        loggedProfil = profil;
                        count++;
                        break;
                    }
                }
                if (textBoxFullName.Enabled == true || textBoxPicturePath.Text != loggedProfil.Picture)
                {
                    if (textBoxDescipline.Text != "" && textBoxAge.Text != "" && Convert.ToInt32(textBoxAge.Text) >= 18 && textBoxEmail.Text != ""
                    && textBoxFacultet.Text != "" && textBoxFullName.Text != "" && comboBoxGender.Text != "")
                    {
                        if (count != 0)
                        {
                            if (textBoxFullName.Enabled == true)
                            {
                                string pictureFlie = Application.StartupPath + @"\Profils\" + user.Username + ".jpg";
                                Profil newProfil = new Profil();
 
                                newProfil.Id = loggedProfil.Id;
                                newProfil.Username = user.Username;
                                newProfil.FullName = textBoxFullName.Text;
                                newProfil.Age = Convert.ToInt32(textBoxAge.Text);
                                newProfil.Gender = comboBoxGender.SelectedItem.ToString();
                                newProfil.Facultet = textBoxFacultet.Text;
                                newProfil.Discipline = textBoxDescipline.Text;
                                newProfil.Email = textBoxEmail.Text;
                                newProfil.Picture = pictureFlie;

                                User loggedUser = new User();

                                loggedUser.Id = user.Id;
                                loggedUser.FullName = textBoxFullName.Text;
                                loggedUser.Password = user.Password;
                                loggedUser.Username = user.Username;
                                loggedUser.UserRole = user.UserRole;

                                repo.EditProfil(newProfil, loggedUser);


                                if (textBoxPicturePath.Text != loggedProfil.Picture)
                                {
                                    File.Delete(pictureFlie);
                                    File.Copy(@textBoxPicturePath.Text, pictureFlie);
                                }

                            }
                            else if (textBoxPicturePath.Text != loggedProfil.Picture)
                            {
                                string pictureFlie = Application.StartupPath + @"\Profils\" + user.Username + ".jpg";
                                File.Delete(pictureFlie);
                                File.Copy(@textBoxPicturePath.Text, pictureFlie);
                            }

                            textBoxFullName.Enabled = false;
                            textBoxAge.Enabled = false;
                            comboBoxGender.Enabled = false;
                            textBoxFacultet.Enabled = false;
                            textBoxDescipline.Enabled = false;
                            textBoxEmail.Enabled = false;
                            textBoxChangePass.Enabled = false;

                        }
                        else
                        {
                            if (textBoxFullName.Enabled == true)
                            {
                                string pictureFlie = Application.StartupPath + @"\Profils\" + user.Username + ".jpg";

                                Profil newProfil = new Profil();

                                newProfil.Username = user.Username;
                                newProfil.FullName = textBoxFullName.Text;
                                newProfil.Age = Convert.ToInt32(textBoxAge.Text);
                                newProfil.Gender = comboBoxGender.SelectedItem.ToString();
                                newProfil.Facultet = textBoxFacultet.Text;
                                newProfil.Discipline = textBoxDescipline.Text;
                                newProfil.Email = textBoxEmail.Text;
                                newProfil.Picture = pictureFlie;

                                repo.Insert(newProfil);
                                if (textBoxPicturePath.Text != "")
                                {
                                    File.Copy(@textBoxPicturePath.Text, pictureFlie);
                                }
                                else
                                {
                                    File.Copy(Application.StartupPath + @"\Profils\default.jpeg", pictureFlie);
                                }

                                textBoxFullName.Enabled = false;
                                textBoxAge.Enabled = false;
                                comboBoxGender.Enabled = false;
                                textBoxFacultet.Enabled = false;
                                textBoxDescipline.Enabled = false;
                                textBoxEmail.Enabled = false;
                                textBoxChangePass.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Всички полета са задължителни! Уверете се, че сте въвели години над 18!");
                    }
                }
                else if(textBoxChangePass.Enabled == true && textBoxChangePass.Text != "")
                {
                    if (count != 0)
                    {
                        user.Password = textBoxChangePass.Text;
                        userRepo.Edit(user);

                        textBoxFullName.Enabled = false;
                        textBoxAge.Enabled = false;
                        comboBoxGender.Enabled = false;
                        textBoxFacultet.Enabled = false;
                        textBoxDescipline.Enabled = false;
                        textBoxEmail.Enabled = false;
                        textBoxChangePass.Enabled = false;

                        string pictureFlie = Application.StartupPath + @"\Profils\" + user.Username + ".jpg";
                        if (textBoxPicturePath.Text != pictureFlie)
                        {
                            File.Delete(pictureFlie);
                            File.Copy(@textBoxPicturePath.Text, pictureFlie);
                        }
                    }
                    else
                    {
                        user.Password = textBoxChangePass.Text;
                        userRepo.Edit(user);

                        textBoxFullName.Enabled = false;
                        textBoxAge.Enabled = false;
                        comboBoxGender.Enabled = false;
                        textBoxFacultet.Enabled = false;
                        textBoxDescipline.Enabled = false;
                        textBoxEmail.Enabled = false;
                        textBoxChangePass.Enabled = false;

                    }
                }
                else
                {
                    MessageBox.Show("Всички полета са задължителни за създаване на профил, освен промяна на паролата! Уверете се, че сте въвели години над 18!");
                }
                
                
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxPicturePath.Text = fileDialog.FileName;
                pictureBoxUserPhoto.Image = new Bitmap(fileDialog.FileName);
            }
           
        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            MessageView massageview = new MessageView();
            massageview.Show();
            massageview.GetProfil(user);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void usersAddToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.ShowDialog();
        }

        private void usersEditToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EditUser edituser = new EditUser();
            edituser.ShowDialog();
        }

        private void usersDeleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeleteUser deleteuser = new DeleteUser();
            deleteuser.ShowDialog();
        }

        private void usersListToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ListAllUsers listallusers = new ListAllUsers();
            listallusers.ShowDialog();
        }

        private void marksAddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddMark addmark = new AddMark();
            addmark.ShowDialog();
        }

        private void marksEditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditMark editmark = new EditMark();
            editmark.ShowDialog();
        }

        private void marksDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteMark deletemark = new DeleteMark();
            deletemark.ShowDialog();
        }

        private void marksListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListAllMarks listallmarks = new ListAllMarks();
            listallmarks.ShowDialog();
        }

        private void studentsAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addstudent = new AddStudent();
            addstudent.ShowDialog();
        }

        private void studentsEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudent editstudent = new EditStudent();
            editstudent.ShowDialog();
        }

        private void studentsDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent deletestudent = new DeleteStudent();
            deletestudent.ShowDialog();
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAllStudents listallstudents = new ListAllStudents();
            listallstudents.ShowDialog();
        }

        private void studentsInfoЗаСтудентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentInfo studentinfo = new StudentInfo();
            studentinfo.ShowDialog();
        }

        private void commentsAddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddComment addcomment = new AddComment();
            addcomment.Validation(user);
            addcomment.ShowDialog();
        }

        private void commentsEditToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditComment editcomment = new EditComment();
            editcomment.Validation(user);
            editcomment.ShowDialog();
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void commentsLitsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListAllComments listcomments = new ListAllComments();
            listcomments.Show();
        }

        private void WriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMessage massageview = new AddMessage();
            massageview.GetProfil(user);
            massageview.ShowDialog();

            MessageRepo repo = new MessageRepo();
            List<MyMessage> messages = repo.GetAll();
            Panel newPanel = new Panel();
            newPanel.Location = new Point(386,4);
            newPanel.Width = 17;
            newPanel.Height = 16;
            this.Controls.Add(newPanel);
            newPanel.BringToFront();

            Label newLabel = new Label();
            newLabel.Width = 17;
            newLabel.Height = 16;
            newLabel.Left = 0;
            newLabel.Top = 0;
            newLabel.BackColor = Color.FromArgb(192, 0, 0);
            newLabel.ForeColor = SystemColors.ControlLightLight;
            newLabel.TextAlign = ContentAlignment.MiddleCenter;
            newLabel.BringToFront();
            newPanel.Controls.Add(newLabel);
            panelMessage.Visible = false;

            int cout = 0;
            foreach (MyMessage message in messages)
            {
                if (message.To == user.FullName && message.seen == false)
                {
                    cout++;
                }
            }


            newLabel.Text = cout.ToString();
           
        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMessage massageview = new ViewMessage();
            massageview.GetProfil(user);
            massageview.ShowDialog();

            MessageRepo repo = new MessageRepo();
            List<MyMessage> messages = repo.GetAll();

            Panel newPanel = new Panel();
            newPanel.Location = new Point(386, 4);
            newPanel.Width = 17;
            newPanel.Height = 16;
            this.Controls.Add(newPanel);
            newPanel.BringToFront();

            Label newLabel = new Label();
            newLabel.Width = 17;
            newLabel.Height = 16;
            newLabel.Left = 0;
            newLabel.Top = 0;
            newLabel.BackColor = Color.FromArgb(192, 0, 0);
            newLabel.ForeColor = SystemColors.ControlLightLight;
            newLabel.TextAlign = ContentAlignment.MiddleCenter;
            newPanel.Controls.Add(newLabel);
            panelMessage.Visible = false;

            int cout = 0;
            foreach (MyMessage message in messages)
            {
                if (message.To == user.FullName && message.seen == false)
                {
                    cout++;
                }
            }

            newLabel.Text = cout.ToString();
           
        }

        private void commentsDeleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteComment deletecomment = new DeleteComment();
            deletecomment.Validation(user);
            deletecomment.ShowDialog();
        }
    }
}
