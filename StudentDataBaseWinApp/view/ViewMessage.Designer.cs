namespace StudentDataBaseWinApp.view
{
    partial class ViewMessage
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.richTextBoxBody = new System.Windows.Forms.RichTextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.checkedListBoxUnReaded = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxReaded = new System.Windows.Forms.CheckedListBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(87, 332);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(54, 23);
            this.buttonBack.TabIndex = 33;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Съдържание:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Тема:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Получател:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "От: ";
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Enabled = false;
            this.buttonAnswer.Location = new System.Drawing.Point(218, 332);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(65, 23);
            this.buttonAnswer.TabIndex = 28;
            this.buttonAnswer.Text = "Отговори";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Enabled = false;
            this.textBoxTitel.Location = new System.Drawing.Point(87, 165);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(261, 20);
            this.textBoxTitel.TabIndex = 27;
            this.textBoxTitel.TextChanged += new System.EventHandler(this.textBoxTitel_TextChanged);
            // 
            // richTextBoxBody
            // 
            this.richTextBoxBody.Enabled = false;
            this.richTextBoxBody.Location = new System.Drawing.Point(87, 192);
            this.richTextBoxBody.Name = "richTextBoxBody";
            this.richTextBoxBody.Size = new System.Drawing.Size(261, 135);
            this.richTextBoxBody.TabIndex = 26;
            this.richTextBoxBody.Text = "";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Enabled = false;
            this.textBoxFrom.Location = new System.Drawing.Point(87, 113);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(261, 20);
            this.textBoxFrom.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "ID: ";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(147, 332);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(65, 23);
            this.buttonDelete.TabIndex = 37;
            this.buttonDelete.Text = "Изтрии";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Enabled = false;
            this.textBoxTo.Location = new System.Drawing.Point(87, 139);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(261, 20);
            this.textBoxTo.TabIndex = 38;
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(289, 332);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(59, 23);
            this.buttonSend.TabIndex = 39;
            this.buttonSend.Text = "Изпрати";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // checkedListBoxUnReaded
            // 
            this.checkedListBoxUnReaded.FormattingEnabled = true;
            this.checkedListBoxUnReaded.Location = new System.Drawing.Point(87, 33);
            this.checkedListBoxUnReaded.Name = "checkedListBoxUnReaded";
            this.checkedListBoxUnReaded.Size = new System.Drawing.Size(76, 49);
            this.checkedListBoxUnReaded.TabIndex = 40;
            this.checkedListBoxUnReaded.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxUnReaded_SelectedIndexChanged);
            // 
            // checkedListBoxReaded
            // 
            this.checkedListBoxReaded.FormattingEnabled = true;
            this.checkedListBoxReaded.Location = new System.Drawing.Point(172, 33);
            this.checkedListBoxReaded.Name = "checkedListBoxReaded";
            this.checkedListBoxReaded.Size = new System.Drawing.Size(76, 49);
            this.checkedListBoxReaded.TabIndex = 41;
            this.checkedListBoxReaded.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxReaded_SelectedIndexChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(87, 88);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(58, 20);
            this.textBoxId.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Не прочетени:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Прочетени: ";
            // 
            // ViewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 367);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.checkedListBoxReaded);
            this.Controls.Add(this.checkedListBoxUnReaded);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.textBoxTitel);
            this.Controls.Add(this.richTextBoxBody);
            this.Controls.Add(this.textBoxFrom);
            this.Name = "ViewMessage";
            this.Text = "ViewMessage";
            this.Load += new System.EventHandler(this.ViewMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.RichTextBox richTextBoxBody;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.CheckedListBox checkedListBoxUnReaded;
        private System.Windows.Forms.CheckedListBox checkedListBoxReaded;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}