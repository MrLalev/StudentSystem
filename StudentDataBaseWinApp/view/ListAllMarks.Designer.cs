namespace StudentDataBaseWinApp.view
{
    partial class ListAllMarks
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
            this.labelMark = new System.Windows.Forms.Label();
            this.labelDiscipline = new System.Windows.Forms.Label();
            this.labelFnumber = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonFnumberSort = new System.Windows.Forms.Button();
            this.buttonAlphaSort = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMark.Location = new System.Drawing.Point(531, 8);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(47, 15);
            this.labelMark.TabIndex = 9;
            this.labelMark.Text = "Оценка";
            this.labelMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDiscipline
            // 
            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDiscipline.Location = new System.Drawing.Point(352, 8);
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(181, 15);
            this.labelDiscipline.TabIndex = 8;
            this.labelDiscipline.Text = "            Учебна дисциплина            ";
            this.labelDiscipline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFnumber
            // 
            this.labelFnumber.AutoSize = true;
            this.labelFnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFnumber.Location = new System.Drawing.Point(248, 8);
            this.labelFnumber.Name = "labelFnumber";
            this.labelFnumber.Size = new System.Drawing.Size(106, 15);
            this.labelFnumber.TabIndex = 7;
            this.labelFnumber.Text = "Факултетен номер";
            this.labelFnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelName.Location = new System.Drawing.Point(50, 8);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(199, 15);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "                 Име на студента                  ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelId.Location = new System.Drawing.Point(10, 8);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(41, 15);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "ID       ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "По ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(602, 196);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(129, 24);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonFnumberSort
            // 
            this.buttonFnumberSort.Location = new System.Drawing.Point(602, 38);
            this.buttonFnumberSort.Name = "buttonFnumberSort";
            this.buttonFnumberSort.Size = new System.Drawing.Size(129, 24);
            this.buttonFnumberSort.TabIndex = 11;
            this.buttonFnumberSort.Text = "По факултетен номер";
            this.buttonFnumberSort.UseVisualStyleBackColor = true;
            this.buttonFnumberSort.Click += new System.EventHandler(this.buttonFnumberSort_Click);
            // 
            // buttonAlphaSort
            // 
            this.buttonAlphaSort.Location = new System.Drawing.Point(602, 8);
            this.buttonAlphaSort.Name = "buttonAlphaSort";
            this.buttonAlphaSort.Size = new System.Drawing.Size(129, 24);
            this.buttonAlphaSort.TabIndex = 10;
            this.buttonAlphaSort.Text = "По учебна дисциплина";
            this.buttonAlphaSort.UseVisualStyleBackColor = true;
            this.buttonAlphaSort.Click += new System.EventHandler(this.buttonAlphaSort_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 10);
            this.panel1.TabIndex = 14;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(603, 167);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(127, 23);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Търси";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(603, 114);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(127, 21);
            this.comboBoxSearch.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Търсене по:";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(603, 141);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(127, 20);
            this.textSearch.TabIndex = 15;
            // 
            // ListAllMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 261);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonFnumberSort);
            this.Controls.Add(this.buttonAlphaSort);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.labelDiscipline);
            this.Controls.Add(this.labelFnumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListAllMarks";
            this.Text = "ListAllMarks";
            this.Load += new System.EventHandler(this.ListAllMarks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Label labelDiscipline;
        private System.Windows.Forms.Label labelFnumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonFnumberSort;
        private System.Windows.Forms.Button buttonAlphaSort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
    }
}