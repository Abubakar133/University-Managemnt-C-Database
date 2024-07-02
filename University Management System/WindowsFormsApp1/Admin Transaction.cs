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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Admin_Transaction : Form
    {
        String connectionstring = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";

        public Admin_Transaction()
        {
            InitializeComponent();

            
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from Uni_Transections", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv4.DataSource = dtb1;
                oraclecon.Close();
            }

        }

        private void Admin_Transaction_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214");
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "insert into Uni_Transections values ('" + roll.Text + "','" + fees.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully");
            con.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard it = new UserDashboard("","");
            it.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Transaction t1 = new Admin_Transaction();
            t1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimeTable t1=new TimeTable();
            t1.Show();
        }
    }
}
