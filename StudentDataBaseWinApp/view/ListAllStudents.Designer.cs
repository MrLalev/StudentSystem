namespace StudentDataBaseWinApp.view
{
    partial class ListAllStudents
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFnumber = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.buttonAlphaSort = new System.Windows.Forms.Button();
            this.buttonFnumberSort = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelEgn = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelMark = new System.Windows.Forms.Label();
            this.labelSpec = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelId.Location = new System.Drawing.Point(10, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(41, 15);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID       ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelName.Location = new System.Drawing.Point(50, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(199, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "                 Име на студента                  ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFnumber
            // 
            this.labelFnumber.AutoSize = true;
            this.labelFnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFnumber.Location = new System.Drawing.Point(248, 9);
            this.labelFnumber.Name = "labelFnumber";
            this.labelFnumber.Size = new System.Drawing.Size(106, 15);
            this.labelFnumber.TabIndex = 2;
            this.labelFnumber.Text = "Факултетен номер";
            this.labelFnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCourse.Location = new System.Drawing.Point(852, 9);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(33, 15);
            this.labelCourse.TabIndex = 4;
            this.labelCourse.Text = "Курс";
            this.labelCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAlphaSort
            // 
            this.buttonAlphaSort.Location = new System.Drawing.Point(955, 12);
            this.buttonAlphaSort.Name = "buttonAlphaSort";
            this.buttonAlphaSort.Size = new System.Drawing.Size(129, 24);
            this.buttonAlphaSort.TabIndex = 5;
            this.buttonAlphaSort.Text = "По азбучен ред";
            this.buttonAlphaSort.UseVisualStyleBackColor = true;
            this.buttonAlphaSort.Click += new System.EventHandler(this.buttonAlphaSort_Click);
            // 
            // buttonFnumberSort
            // 
            this.buttonFnumberSort.Location = new System.Drawing.Point(955, 42);
            this.buttonFnumberSort.Name = "buttonFnumberSort";
            this.buttonFnumberSort.Size = new System.Drawing.Size(129, 24);
            this.buttonFnumberSort.TabIndex = 6;
            this.buttonFnumberSort.Text = "По факултетен номер";
            this.buttonFnumberSort.UseVisualStyleBackColor = true;
            this.buttonFnumberSort.Click += new System.EventHandler(this.buttonFnumberSort_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(957, 230);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(129, 24);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(955, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "По ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, -13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 22);
            this.panel1.TabIndex = 9;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(957, 175);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(129, 20);
            this.textSearch.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(987, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Търсене по:";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(957, 148);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(129, 21);
            this.comboBoxSearch.TabIndex = 12;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(957, 201);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(129, 23);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Търси";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelEgn
            // 
            this.labelEgn.AutoSize = true;
            this.labelEgn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEgn.Location = new System.Drawing.Point(352, 9);
            this.labelEgn.Name = "labelEgn";
            this.labelEgn.Size = new System.Drawing.Size(108, 15);
            this.labelEgn.TabIndex = 14;
            this.labelEgn.Text = "             ЕГН             ";
            this.labelEgn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGender.Location = new System.Drawing.Point(457, 9);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(38, 15);
            this.labelGender.TabIndex = 15;
            this.labelGender.Text = " Пол  ";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEmail.Location = new System.Drawing.Point(494, 9);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(181, 15);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "                         E-mail                       ";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMark.Location = new System.Drawing.Point(884, 9);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(47, 15);
            this.labelMark.TabIndex = 17;
            this.labelMark.Text = "Оценка";
            this.labelMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSpec.Location = new System.Drawing.Point(673, 9);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(180, 15);
            this.labelSpec.TabIndex = 19;
            this.labelSpec.Text = "                  Специалност                 ";
            this.labelSpec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(955, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 24);
            this.button2.TabIndex = 20;
            this.button2.Text = "По оценка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelSpec);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelEgn);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonFnumberSort);
            this.Controls.Add(this.buttonAlphaSort);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelFnumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListAllStudents";
            this.Text = "ListAllStudents";
            this.Load += new System.EventHandler(this.ListAllStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFnumber;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Button buttonAlphaSort;
        private System.Windows.Forms.Button buttonFnumberSort;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelEgn;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Button button2;
    }
}