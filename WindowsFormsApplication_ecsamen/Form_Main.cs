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
    public partial class Form_Main : Form
    {
        const string webAppConnection_string = "server=mysql101.1gb.ru;user ID=gb_56132;Password=e26ca36ba;database=gb_56132;";
        MySqlConnection conn;
        
        Form_Instruction f_instr = new Form_Instruction();
        Form_Zayavka f_zayavka = new Form_Zayavka();
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void button_instruction_Click(object sender, EventArgs e)
        {
            f_instr.ShowDialog();
        }

        private void button_free_place_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(webAppConnection_string);
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();

            
            for(int i=1;i<4;i++){
            cmd.CommandText = "SELECT count( full_name )FROM `person` WHERE  room_namber='"+i+"';";
            conn.Close();
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int zanyat;
                    Int32.TryParse(reader.GetValue(0).ToString(), out zanyat);

                    int free = 2 - zanyat;
                    MessageBox.Show("В команате " + i.ToString() + " : " + free.ToString() + " свободных мест\n");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
                this.Close();
            }
            
            }
        }

        private void button_zayavka_Click(object sender, EventArgs e)
        {
            f_zayavka.ShowDialog();
        }

        private void statusStrip_Time_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = String.Format("{0} ({1})", DateTime.Now.ToString("dd.MM.yyyy - hh:mm"), DateTime.Now.DayOfWeek);
        }

        private void button_ListPerson_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(webAppConnection_string);
            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter select_adapter = new MySqlDataAdapter();
            string select_string = "SELECT * FROM `person` WHERE 1";
            select_adapter.SelectCommand = new MySqlCommand(select_string, conn);

            DataTable table = new DataTable();
            select_adapter.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView_ListPerson.DataSource = table;
        }



       

      
    }
}
