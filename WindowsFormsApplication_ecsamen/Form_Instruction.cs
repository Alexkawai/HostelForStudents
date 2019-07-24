using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication_ecsamen
{
    public partial class Form_Instruction : Form
    {
        public Form_Instruction()
        {
            InitializeComponent();
        }

        private void Form_Instruction_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\lehai\Desktop\html\instruction.html");
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Format("{0} ({1})", DateTime.Now.ToString("dd.MM.yyyy - hh:mm"), DateTime.Now.DayOfWeek);
        }
        
    }
}
