namespace WindowsFormsApplication_ecsamen
{
    partial class Form_Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_free_place = new System.Windows.Forms.Button();
            this.button_instruction = new System.Windows.Forms.Button();
            this.button_zayavka = new System.Windows.Forms.Button();
            this.statusStrip_Time = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_ListPerson = new System.Windows.Forms.Button();
            this.dataGridView_ListPerson = new System.Windows.Forms.DataGridView();
            this.statusStrip_Time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // button_free_place
            // 
            this.button_free_place.Location = new System.Drawing.Point(90, 29);
            this.button_free_place.Name = "button_free_place";
            this.button_free_place.Size = new System.Drawing.Size(151, 57);
            this.button_free_place.TabIndex = 0;
            this.button_free_place.Text = "Свободные места";
            this.button_free_place.UseVisualStyleBackColor = true;
            this.button_free_place.Click += new System.EventHandler(this.button_free_place_Click);
            // 
            // button_instruction
            // 
            this.button_instruction.Location = new System.Drawing.Point(476, 29);
            this.button_instruction.Name = "button_instruction";
            this.button_instruction.Size = new System.Drawing.Size(148, 57);
            this.button_instruction.TabIndex = 1;
            this.button_instruction.Text = "Инструкция пользователя";
            this.button_instruction.UseVisualStyleBackColor = true;
            this.button_instruction.Click += new System.EventHandler(this.button_instruction_Click);
            // 
            // button_zayavka
            // 
            this.button_zayavka.Location = new System.Drawing.Point(288, 29);
            this.button_zayavka.Name = "button_zayavka";
            this.button_zayavka.Size = new System.Drawing.Size(143, 57);
            this.button_zayavka.TabIndex = 2;
            this.button_zayavka.Text = "Заявка на заселение";
            this.button_zayavka.UseVisualStyleBackColor = true;
            this.button_zayavka.Click += new System.EventHandler(this.button_zayavka_Click);
            // 
            // statusStrip_Time
            // 
            this.statusStrip_Time.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip_Time.Location = new System.Drawing.Point(0, 402);
            this.statusStrip_Time.Name = "statusStrip_Time";
            this.statusStrip_Time.Size = new System.Drawing.Size(716, 22);
            this.statusStrip_Time.TabIndex = 3;
            this.statusStrip_Time.Text = "statusStrip";
            this.statusStrip_Time.MouseMove += new System.Windows.Forms.MouseEventHandler(this.statusStrip_Time_MouseMove);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // button_ListPerson
            // 
            this.button_ListPerson.Location = new System.Drawing.Point(280, 117);
            this.button_ListPerson.Name = "button_ListPerson";
            this.button_ListPerson.Size = new System.Drawing.Size(151, 57);
            this.button_ListPerson.TabIndex = 4;
            this.button_ListPerson.Text = "Список проживающих";
            this.button_ListPerson.UseVisualStyleBackColor = true;
            this.button_ListPerson.Click += new System.EventHandler(this.button_ListPerson_Click);
            // 
            // dataGridView_ListPerson
            // 
            this.dataGridView_ListPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListPerson.Location = new System.Drawing.Point(29, 229);
            this.dataGridView_ListPerson.Name = "dataGridView_ListPerson";
            this.dataGridView_ListPerson.Size = new System.Drawing.Size(658, 142);
            this.dataGridView_ListPerson.TabIndex = 5;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 424);
            this.Controls.Add(this.dataGridView_ListPerson);
            this.Controls.Add(this.button_ListPerson);
            this.Controls.Add(this.statusStrip_Time);
            this.Controls.Add(this.button_zayavka);
            this.Controls.Add(this.button_instruction);
            this.Controls.Add(this.button_free_place);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.statusStrip_Time.ResumeLayout(false);
            this.statusStrip_Time.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_free_place;
        private System.Windows.Forms.Button button_instruction;
        private System.Windows.Forms.Button button_zayavka;
        private System.Windows.Forms.StatusStrip statusStrip_Time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button_ListPerson;
        private System.Windows.Forms.DataGridView dataGridView_ListPerson;
    }
}

