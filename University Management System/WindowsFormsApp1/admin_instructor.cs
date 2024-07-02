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
    public partial class admin_instructor : Form
    {
        String connectionstring = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";

        public admin_instructor()
        {
            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from Instructor", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv1.DataSource = dtb1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_instructor it = new add_instructor();
            it.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_instructor it = new update_instructor();
            it.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            this.Hide();
            add_instructor it = new add_instructor();
            it.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_instructor it = new delete_instructor();
            it.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
           UserDashboard up = new UserDashboard("","");
            up.Show();
        }

        private void admin_instructor_Load(object sender, EventArgs e)
        {

        }
    }
}
