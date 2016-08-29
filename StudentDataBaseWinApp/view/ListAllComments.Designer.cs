namespace StudentDataBaseWinApp.view
{
    partial class ListAllComments
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonFnumberSort = new System.Windows.Forms.Button();
            this.buttonAlphaSort = new System.Windows.Forms.Button();
            this.panelTry = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(759, 165);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(127, 23);
            this.buttonSearch.TabIndex = 32;
            this.buttonSearch.Text = "Търси";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(759, 112);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(127, 21);
            this.comboBoxSearch.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Търсене по:";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(759, 139);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(127, 20);
            this.textSearch.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 24);
            this.button1.TabIndex = 27;
            this.button1.Text = "По ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(758, 194);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(129, 24);
            this.buttonBack.TabIndex = 26;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonFnumberSort
            // 
            this.buttonFnumberSort.Location = new System.Drawing.Point(758, 36);
            this.buttonFnumberSort.Name = "buttonFnumberSort";
            this.buttonFnumberSort.Size = new System.Drawing.Size(129, 24);
            this.buttonFnumberSort.TabIndex = 25;
            this.buttonFnumberSort.Text = "По факултетен номер";
            this.buttonFnumberSort.UseVisualStyleBackColor = true;
            this.buttonFnumberSort.Click += new System.EventHandler(this.buttonFnumberSort_Click);
            // 
            // buttonAlphaSort
            // 
            this.buttonAlphaSort.Location = new System.Drawing.Point(758, 6);
            this.buttonAlphaSort.Name = "buttonAlphaSort";
            this.buttonAlphaSort.Size = new System.Drawing.Size(129, 24);
            this.buttonAlphaSort.TabIndex = 24;
            this.buttonAlphaSort.Text = "По дата";
            this.buttonAlphaSort.UseVisualStyleBackColor = true;
            this.buttonAlphaSort.Click += new System.EventHandler(this.buttonAlphaSort_Click);
            // 
            // panelTry
            // 
            this.panelTry.Location = new System.Drawing.Point(10, 6);
            this.panelTry.Name = "panelTry";
            this.panelTry.Size = new System.Drawing.Size(722, 42);
            this.panelTry.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 24);
            this.panel1.TabIndex = 30;
            // 
            // ListAllComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTry);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonFnumberSort);
            this.Controls.Add(this.buttonAlphaSort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListAllComments";
            this.Text = "ListAllComments";
            this.Load += new System.EventHandler(this.ListAllComments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonFnumberSort;
        private System.Windows.Forms.Button buttonAlphaSort;
        private System.Windows.Forms.Panel panelTry;
        private System.Windows.Forms.Panel panel1;

    }
}