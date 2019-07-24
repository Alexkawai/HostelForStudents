using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication_ecsamen
{
    public partial class Form_Zayavka : Form
    {
        const string webAppConnection_string = "server=mysql101.1gb.ru;user ID=gb_56132;Password=e26ca36ba;database=gb_56132;";
        MySqlConnection conn;
        MySqlCommand cmd;
        public Form_Zayavka()
        {
            InitializeComponent();
        }

        private void statusStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = String.Format("{0} ({1})", DateTime.Now.ToString("dd.MM.yyyy - hh:mm"), DateTime.Now.DayOfWeek);
        }


        private void InsertDB(int numberroom, string fio, string job, string groop, string phone, string mail/*, string nowdata*/)
        {
            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();
            
            string query_str = "INSERT INTO gb_56132.person (`room_namber`, `full_name`, `email`, `phone`, `group`, `job`, `date_In`, `date_Out`) VALUES (";
            query_str += numberroom.ToString() + ",'" + fio.ToString() + "','" + mail.ToString() + "','" + phone.ToString() + "','" + groop.ToString() + "','" + job.ToString() + "'," +"null"+ "," +"null" + ");";
            cmd = new MySqlCommand(query_str, conn);

            MySqlDataReader data_reader;
            try
            {
                data_reader = cmd.ExecuteReader();
            }
            catch (Exception exp)
            {
                string err_string = "Данные не записаны! Сообщение системы\n\"" + exp.ToString() + "\"";
                MessageBox.Show(err_string, "Ошибка записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            finally
            {
                conn.Close();
            }
        }
        private void button_sent_Click(object sender, EventArgs e)
        {
            int numberroom ;
            Int32.TryParse(textBox_numb.Text, out numberroom);
            string fio = textBox_fio.Text;
            string job;
            if (radioButton_stud.Checked)
            {
                job = "студент";
            }
            else {job = "преподаватель"; }
            string groop = textBox_groop.Text;
            string phone = textBox_phone.Text;
            string mail = textBox_mail.Text;
            //string nowdata = String.Format("{0}", DateTime.Now.ToString("dd.MM.yyyy - hh:mm"));


            InsertDB(numberroom, fio, job, groop, phone, mail/*,nowdata*/);
        }
    }
}
