namespace StudentDataBaseWinApp.view
{
    partial class StudentInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfo));
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.textBoxStudentLoad = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelMarkText = new System.Windows.Forms.Label();
            this.labelEmailText = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelGenderText = new System.Windows.Forms.Label();
            this.labelEgn = new System.Windows.Forms.Label();
            this.labelEgnText = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelSpec = new System.Windows.Forms.Label();
            this.labelFnum = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelCourseText = new System.Windows.Forms.Label();
            this.labelSpecText = new System.Windows.Forms.Label();
            this.labelFnumText = new System.Windows.Forms.Label();
            this.labelNames = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMark = new System.Windows.Forms.Label();
            this.panelMark = new System.Windows.Forms.Panel();
            this.labelDiscipline = new System.Windows.Forms.Label();
            this.labelStudentMark = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelComments = new System.Windows.Forms.Panel();
            this.labelAllComments = new System.Windows.Forms.Label();
            this.panelTry = new System.Windows.Forms.Panel();
            this.buttonGraduated = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto.Image")));
            this.pictureBoxPhoto.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(143, 184);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 0;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // textBoxStudentLoad
            // 
            this.textBoxStudentLoad.Location = new System.Drawing.Point(124, 11);
            this.textBoxStudentLoad.MaxLength = 10;
            this.textBoxStudentLoad.Name = "textBoxStudentLoad";
            this.textBoxStudentLoad.Size = new System.Drawing.Size(66, 20);
            this.textBoxStudentLoad.TabIndex = 1;
            this.textBoxStudentLoad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStudentLoad_KeyPress);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(196, 10);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(131, 21);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Зареди информация";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(315, 169);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(0, 13);
            this.labelAverage.TabIndex = 74;
            // 
            // labelMarkText
            // 
            this.labelMarkText.AutoSize = true;
            this.labelMarkText.Location = new System.Drawing.Point(161, 169);
            this.labelMarkText.Name = "labelMarkText";
            this.labelMarkText.Size = new System.Drawing.Size(151, 13);
            this.labelMarkText.TabIndex = 73;
            this.labelMarkText.Text = "Средноаритметична оценка:";
            // 
            // labelEmailText
            // 
            this.labelEmailText.AutoSize = true;
            this.labelEmailText.Location = new System.Drawing.Point(161, 109);
            this.labelEmailText.Name = "labelEmailText";
            this.labelEmailText.Size = new System.Drawing.Size(38, 13);
            this.labelEmailText.TabIndex = 72;
            this.labelEmailText.Text = "E-mail:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(194, 68);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(0, 13);
            this.labelGender.TabIndex = 71;
            // 
            // labelGenderText
            // 
            this.labelGenderText.AutoSize = true;
            this.labelGenderText.Location = new System.Drawing.Point(161, 68);
            this.labelGenderText.Name = "labelGenderText";
            this.labelGenderText.Size = new System.Drawing.Size(30, 13);
            this.labelGenderText.TabIndex = 70;
            this.labelGenderText.Text = "Пол:";
            // 
            // labelEgn
            // 
            this.labelEgn.AutoSize = true;
            this.labelEgn.Location = new System.Drawing.Point(195, 48);
            this.labelEgn.Name = "labelEgn";
            this.labelEgn.Size = new System.Drawing.Size(0, 13);
            this.labelEgn.TabIndex = 69;
            // 
            // labelEgnText
            // 
            this.labelEgnText.AutoSize = true;
            this.labelEgnText.Location = new System.Drawing.Point(161, 48);
            this.labelEgnText.Name = "labelEgnText";
            this.labelEgnText.Size = new System.Drawing.Size(31, 13);
            this.labelEgnText.TabIndex = 68;
            this.labelEgnText.Text = "ЕГН:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(193, 150);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(0, 13);
            this.labelCourse.TabIndex = 67;
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Location = new System.Drawing.Point(240, 129);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(0, 13);
            this.labelSpec.TabIndex = 66;
            // 
            // labelFnum
            // 
            this.labelFnum.AutoSize = true;
            this.labelFnum.Location = new System.Drawing.Point(268, 29);
            this.labelFnum.Name = "labelFnum";
            this.labelFnum.Size = new System.Drawing.Size(0, 13);
            this.labelFnum.TabIndex = 65;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(304, 7);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(0, 13);
            this.labelStudentName.TabIndex = 64;
            // 
            // labelCourseText
            // 
            this.labelCourseText.AutoSize = true;
            this.labelCourseText.BackColor = System.Drawing.SystemColors.Control;
            this.labelCourseText.Location = new System.Drawing.Point(161, 150);
            this.labelCourseText.Name = "labelCourseText";
            this.labelCourseText.Size = new System.Drawing.Size(34, 13);
            this.labelCourseText.TabIndex = 63;
            this.labelCourseText.Text = "Курс:";
            // 
            // labelSpecText
            // 
            this.labelSpecText.AutoSize = true;
            this.labelSpecText.Location = new System.Drawing.Point(161, 129);
            this.labelSpecText.Name = "labelSpecText";
            this.labelSpecText.Size = new System.Drawing.Size(76, 13);
            this.labelSpecText.TabIndex = 62;
            this.labelSpecText.Text = "Специалност:";
            // 
            // labelFnumText
            // 
            this.labelFnumText.AutoSize = true;
            this.labelFnumText.Location = new System.Drawing.Point(160, 28);
            this.labelFnumText.Name = "labelFnumText";
            this.labelFnumText.Size = new System.Drawing.Size(107, 13);
            this.labelFnumText.TabIndex = 61;
            this.labelFnumText.Text = "Факултетен номер:";
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Location = new System.Drawing.Point(160, 7);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(138, 13);
            this.labelNames.TabIndex = 60;
            this.labelNames.Text = "Трите имена на студента:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(201, 109);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 13);
            this.labelEmail.TabIndex = 75;
            // 
            // panelInfo
            // 
            this.panelInfo.AutoScroll = true;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.labelYear);
            this.panelInfo.Controls.Add(this.pictureBoxPhoto);
            this.panelInfo.Controls.Add(this.labelEmail);
            this.panelInfo.Controls.Add(this.labelNames);
            this.panelInfo.Controls.Add(this.labelAverage);
            this.panelInfo.Controls.Add(this.labelFnumText);
            this.panelInfo.Controls.Add(this.labelMarkText);
            this.panelInfo.Controls.Add(this.labelSpecText);
            this.panelInfo.Controls.Add(this.labelEmailText);
            this.panelInfo.Controls.Add(this.labelCourseText);
            this.panelInfo.Controls.Add(this.labelGender);
            this.panelInfo.Controls.Add(this.labelStudentName);
            this.panelInfo.Controls.Add(this.labelGenderText);
            this.panelInfo.Controls.Add(this.labelFnum);
            this.panelInfo.Controls.Add(this.labelEgn);
            this.panelInfo.Controls.Add(this.labelSpec);
            this.panelInfo.Controls.Add(this.labelEgnText);
            this.panelInfo.Controls.Add(this.labelCourse);
            this.panelInfo.Location = new System.Drawing.Point(4, 38);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(492, 200);
            this.panelInfo.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Години:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(210, 88);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(0, 13);
            this.labelYear.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Факултетен номер:";
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Location = new System.Drawing.Point(6, 241);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(159, 13);
            this.labelMark.TabIndex = 77;
            this.labelMark.Text = "Списък с оценки на студента:";
            // 
            // panelMark
            // 
            this.panelMark.AutoScroll = true;
            this.panelMark.Location = new System.Drawing.Point(4, 250);
            this.panelMark.Name = "panelMark";
            this.panelMark.Size = new System.Drawing.Size(471, 10);
            this.panelMark.TabIndex = 76;
            // 
            // labelDiscipline
            // 
            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDiscipline.Location = new System.Drawing.Point(4, 259);
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(334, 15);
            this.labelDiscipline.TabIndex = 0;
            this.labelDiscipline.Text = "                                       Учебна дисциплина                         " +
    "           ";
            // 
            // labelStudentMark
            // 
            this.labelStudentMark.AutoSize = true;
            this.labelStudentMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStudentMark.Location = new System.Drawing.Point(335, 259);
            this.labelStudentMark.Name = "labelStudentMark";
            this.labelStudentMark.Size = new System.Drawing.Size(140, 15);
            this.labelStudentMark.TabIndex = 1;
            this.labelStudentMark.Text = "               Оценкa                ";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(416, 10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(79, 21);
            this.buttonClose.TabIndex = 80;
            this.buttonClose.Text = "Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelComments
            // 
            this.panelComments.AutoScroll = true;
            this.panelComments.Location = new System.Drawing.Point(3, 397);
            this.panelComments.Name = "panelComments";
            this.panelComments.Size = new System.Drawing.Size(471, 10);
            this.panelComments.TabIndex = 83;
            // 
            // labelAllComments
            // 
            this.labelAllComments.AutoSize = true;
            this.labelAllComments.Location = new System.Drawing.Point(6, 387);
            this.labelAllComments.Name = "labelAllComments";
            this.labelAllComments.Size = new System.Drawing.Size(178, 13);
            this.labelAllComments.TabIndex = 84;
            this.labelAllComments.Text = "Списък с коментари на студента:";
            // 
            // panelTry
            // 
            this.panelTry.Location = new System.Drawing.Point(3, 406);
            this.panelTry.Name = "panelTry";
            this.panelTry.Size = new System.Drawing.Size(472, 41);
            this.panelTry.TabIndex = 88;
            // 
            // buttonGraduated
            // 
            this.buttonGraduated.Location = new System.Drawing.Point(335, 10);
            this.buttonGraduated.Name = "buttonGraduated";
            this.buttonGraduated.Size = new System.Drawing.Size(75, 22);
            this.buttonGraduated.TabIndex = 89;
            this.buttonGraduated.Text = "Завършил";
            this.buttonGraduated.UseVisualStyleBackColor = true;
            this.buttonGraduated.Click += new System.EventHandler(this.buttonGraduated_Click);
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 562);
            this.Controls.Add(this.buttonGraduated);
            this.Controls.Add(this.panelTry);
            this.Controls.Add(this.labelAllComments);
            this.Controls.Add(this.panelComments);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelStudentMark);
            this.Controls.Add(this.labelDiscipline);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.panelMark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxStudentLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.TextBox textBoxStudentLoad;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelMarkText;
        private System.Windows.Forms.Label labelEmailText;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelGenderText;
        private System.Windows.Forms.Label labelEgn;
        private System.Windows.Forms.Label labelEgnText;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Label labelFnum;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelCourseText;
        private System.Windows.Forms.Label labelSpecText;
        private System.Windows.Forms.Label labelFnumText;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Panel panelMark;
        private System.Windows.Forms.Label labelDiscipline;
        private System.Windows.Forms.Label labelStudentMark;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelComments;
        private System.Windows.Forms.Label labelAllComments;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTry;
        private System.Windows.Forms.Button buttonGraduated;
    }
}