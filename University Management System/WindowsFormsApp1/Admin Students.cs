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
    public partial class Admin_Students : Form
    {

        String connectionstring = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";

        
        public Admin_Students()
        {
            InitializeComponent();

            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from Students", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv1.DataSource = dtb1;
            }

            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                string qu= "SELECT Section, COUNT(*)AS Number_of_Students FROM STUDENTS GROUP BY SECTION HAVING COUNT(*) > 0";
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter(qu, oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                d3.DataSource = dtb1;
            }

        }

        private void Admin_Students_Load(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            // add student
            this.Hide();
            // Item_Records it = new Item_Records();
            // it.Show();
            Form1 it = new Form1();
            it.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_student it = new update_student();
            it.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_student it = new delete_student();
            it.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard  it = new UserDashboard("","");
            it.Show();

        }
    }
}
