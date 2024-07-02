using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class student_info : Form
    {
        String id2;
        String connectionstring = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";

        public student_info(string id)
        {id2=id;
            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from Students Where ID ='"+id+"'" , oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv4.DataSource = dtb1;
            }
        }

        private void student_info_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Course it = new Register_Course(id2);
            it.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            flexportal it = new flexportal(id2);
            it.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_info it = new student_info(id2);
            it.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Login it = new Student_Login();
            it.Show();
        }
    }
}
