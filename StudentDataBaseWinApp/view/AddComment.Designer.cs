namespace StudentDataBaseWinApp.view
{
    partial class AddComment
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
            this.buttonComment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTittle = new System.Windows.Forms.TextBox();
            this.textBoxFNumber = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(138, 204);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonComment
            // 
            this.buttonComment.Location = new System.Drawing.Point(264, 204);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(84, 23);
            this.buttonComment.TabIndex = 14;
            this.buttonComment.Text = "Коментирай";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Заглавие:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Коментар:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Факултетен номер:";
            // 
            // textBoxTittle
            // 
            this.textBoxTittle.Location = new System.Drawing.Point(138, 47);
            this.textBoxTittle.Name = "textBoxTittle";
            this.textBoxTittle.Size = new System.Drawing.Size(210, 20);
            this.textBoxTittle.TabIndex = 10;
            // 
            // textBoxFNumber
            // 
            this.textBoxFNumber.Location = new System.Drawing.Point(138, 12);
            this.textBoxFNumber.MaxLength = 10;
            this.textBoxFNumber.Name = "textBoxFNumber";
            this.textBoxFNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxFNumber.TabIndex = 8;
            this.textBoxFNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFNumber_KeyPress);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(138, 86);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(210, 112);
            this.textBoxComment.TabIndex = 17;
            // 
            // AddComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 241);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTittle);
            this.Controls.Add(this.textBoxFNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddComment";
            this.Text = "AddComment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTittle;
        private System.Windows.Forms.TextBox textBoxFNumber;
        private System.Windows.Forms.TextBox textBoxComment;
    }
}