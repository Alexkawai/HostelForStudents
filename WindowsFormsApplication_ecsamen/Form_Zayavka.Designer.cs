namespace WindowsFormsApplication_ecsamen
{
    partial class Form_Zayavka
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_fio = new System.Windows.Forms.Label();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.radioButton_stud = new System.Windows.Forms.RadioButton();
            this.radioButton_sotr = new System.Windows.Forms.RadioButton();
            this.label_groop = new System.Windows.Forms.Label();
            this.textBox_groop = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label_mail = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.button_sent = new System.Windows.Forms.Button();
            this.label_numb = new System.Windows.Forms.Label();
            this.textBox_numb = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(648, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip_Time";
            this.statusStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.statusStrip1_MouseMove);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label_fio
            // 
            this.label_fio.AutoSize = true;
            this.label_fio.Location = new System.Drawing.Point(46, 45);
            this.label_fio.Name = "label_fio";
            this.label_fio.Size = new System.Drawing.Size(34, 13);
            this.label_fio.TabIndex = 1;
            this.label_fio.Text = "ФИО";
            // 
            // textBox_fio
            // 
            this.textBox_fio.Location = new System.Drawing.Point(113, 42);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(220, 20);
            this.textBox_fio.TabIndex = 2;
            // 
            // radioButton_stud
            // 
            this.radioButton_stud.AutoSize = true;
            this.radioButton_stud.Checked = true;
            this.radioButton_stud.Location = new System.Drawing.Point(70, 96);
            this.radioButton_stud.Name = "radioButton_stud";
            this.radioButton_stud.Size = new System.Drawing.Size(65, 17);
            this.radioButton_stud.TabIndex = 3;
            this.radioButton_stud.TabStop = true;
            this.radioButton_stud.Text = "Студент";
            this.radioButton_stud.UseVisualStyleBackColor = true;
            // 
            // radioButton_sotr
            // 
            this.radioButton_sotr.AutoSize = true;
            this.radioButton_sotr.Location = new System.Drawing.Point(191, 95);
            this.radioButton_sotr.Name = "radioButton_sotr";
            this.radioButton_sotr.Size = new System.Drawing.Size(78, 17);
            this.radioButton_sotr.TabIndex = 4;
            this.radioButton_sotr.Text = "Сотрудник";
            this.radioButton_sotr.UseVisualStyleBackColor = true;
            // 
            // label_groop
            // 
            this.label_groop.AutoSize = true;
            this.label_groop.Location = new System.Drawing.Point(93, 148);
            this.label_groop.Name = "label_groop";
            this.label_groop.Size = new System.Drawing.Size(42, 13);
            this.label_groop.TabIndex = 5;
            this.label_groop.Text = "Группа";
            // 
            // textBox_groop
            // 
            this.textBox_groop.Location = new System.Drawing.Point(144, 141);
            this.textBox_groop.Name = "textBox_groop";
            this.textBox_groop.Size = new System.Drawing.Size(153, 20);
            this.textBox_groop.TabIndex = 6;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(83, 197);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(52, 13);
            this.label_phone.TabIndex = 7;
            this.label_phone.Text = "Телефон";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(144, 194);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(153, 20);
            this.textBox_phone.TabIndex = 8;
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(98, 247);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(37, 13);
            this.label_mail.TabIndex = 9;
            this.label_mail.Text = "Почта";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(144, 244);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(153, 20);
            this.textBox_mail.TabIndex = 10;
            // 
            // button_sent
            // 
            this.button_sent.Location = new System.Drawing.Point(414, 141);
            this.button_sent.Name = "button_sent";
            this.button_sent.Size = new System.Drawing.Size(162, 82);
            this.button_sent.TabIndex = 11;
            this.button_sent.Text = "Добавить";
            this.button_sent.UseVisualStyleBackColor = true;
            this.button_sent.Click += new System.EventHandler(this.button_sent_Click);
            // 
            // label_numb
            // 
            this.label_numb.AutoSize = true;
            this.label_numb.Location = new System.Drawing.Point(46, 283);
            this.label_numb.Name = "label_numb";
            this.label_numb.Size = new System.Drawing.Size(89, 13);
            this.label_numb.TabIndex = 12;
            this.label_numb.Text = "Номер комнаты";
            // 
            // textBox_numb
            // 
            this.textBox_numb.Location = new System.Drawing.Point(144, 280);
            this.textBox_numb.Name = "textBox_numb";
            this.textBox_numb.Size = new System.Drawing.Size(153, 20);
            this.textBox_numb.TabIndex = 13;
            // 
            // Form_Zayavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 362);
            this.Controls.Add(this.textBox_numb);
            this.Controls.Add(this.label_numb);
            this.Controls.Add(this.button_sent);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.textBox_groop);
            this.Controls.Add(this.label_groop);
            this.Controls.Add(this.radioButton_sotr);
            this.Controls.Add(this.radioButton_stud);
            this.Controls.Add(this.textBox_fio);
            this.Controls.Add(this.label_fio);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form_Zayavka";
            this.Text = "Form_Zayavka";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label_fio;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.RadioButton radioButton_stud;
        private System.Windows.Forms.RadioButton radioButton_sotr;
        private System.Windows.Forms.Label label_groop;
        private System.Windows.Forms.TextBox textBox_groop;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Button button_sent;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label_numb;
        private System.Windows.Forms.TextBox textBox_numb;
    }
}