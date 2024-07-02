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
using static System.Collections.Specialized.BitVector32;

namespace WindowsFormsApp1
{
    public partial class add_instructor : Form
    {
        public add_instructor()
        {
            InitializeComponent();
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

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_instructor it = new delete_instructor();
            it.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_instructor it = new admin_instructor();
            it.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214");
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "insert into Instructor values ('" + ID.Text + "','" + name.Text + "','" + password.Text + "','" + email.Text + "'," + cnic.Text + "," + phone.Text + ",'" + Degree.Text + "','" + Instructor.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully");
        }
    }
}
