namespace StudentDataBaseWinApp.view
{
    partial class ListAllUsers
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
            this.labelAdmin = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
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
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdmin.Location = new System.Drawing.Point(352, 8);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(139, 15);
            this.labelAdmin.TabIndex = 13;
            this.labelAdmin.Text = "Администраторски права";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFullName.Location = new System.Drawing.Point(248, 8);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(107, 15);
            this.labelFullName.TabIndex = 12;
            this.labelFullName.Text = "   Име и фамилия   ";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUserName.Location = new System.Drawing.Point(50, 8);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(200, 15);
            this.labelUserName.TabIndex = 11;
            this.labelUserName.Text = "               Потребителско име               ";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelId.Location = new System.Drawing.Point(10, 8);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(41, 15);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "ID       ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "По ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(518, 196);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(129, 24);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonFnumberSort
            // 
            this.buttonFnumberSort.Location = new System.Drawing.Point(518, 38);
            this.buttonFnumberSort.Name = "buttonFnumberSort";
            this.buttonFnumberSort.Size = new System.Drawing.Size(129, 24);
            this.buttonFnumberSort.TabIndex = 15;
            this.buttonFnumberSort.Text = "По админ. права";
            this.buttonFnumberSort.UseVisualStyleBackColor = true;
            this.buttonFnumberSort.Click += new System.EventHandler(this.buttonFnumberSort_Click);
            // 
            // buttonAlphaSort
            // 
            this.buttonAlphaSort.Location = new System.Drawing.Point(518, 8);
            this.buttonAlphaSort.Name = "buttonAlphaSort";
            this.buttonAlphaSort.Size = new System.Drawing.Size(129, 24);
            this.buttonAlphaSort.TabIndex = 14;
            this.buttonAlphaSort.Text = "По име и фамилия";
            this.buttonAlphaSort.UseVisualStyleBackColor = true;
            this.buttonAlphaSort.Click += new System.EventHandler(this.buttonAlphaSort_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(9, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 14);
            this.panel1.TabIndex = 18;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(518, 167);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(129, 23);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.Text = "Търси";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(518, 114);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(129, 21);
            this.comboBoxSearch.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Търсене по:";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(518, 141);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(129, 20);
            this.textSearch.TabIndex = 19;
            // 
            // ListAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 261);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonFnumberSort);
            this.Controls.Add(this.buttonAlphaSort);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListAllUsers";
            this.Text = "ListAllUsers";
            this.Load += new System.EventHandler(this.ListAllUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelUserName;
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