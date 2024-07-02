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
    public partial class Admin_Course : Form
    {
        String connectionstring = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";

        public Admin_Course()
        {

            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from Course", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv1.DataSource = dtb1;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            course_add up = new course_add();
            up.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_course up = new delete_course();
            up.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard up = new UserDashboard("","");
            up.Show();
        }

        private void Admin_Course_Load(object sender, EventArgs e)
        {

        }
    }
}
