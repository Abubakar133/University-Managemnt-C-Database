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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_student it = new update_student();
            it.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Students it = new Admin_Students();
            it.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form1 it = new Form1();
            it.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_student it = new delete_student();
            it.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214");

            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "insert into Students values ('" + id.Text + "','" + name.Text + "','" + password.Text + "','" + email.Text + "'," + cnic.Text + ","+phone.Text+",'"+degree.Text+"','" + section.Text + "')";
           
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
           // con.Open();
            MessageBox.Show("successfully");

            /*OracleCommand cmd2 = new OracleCommand();
            string idc = id.Text;

           // GRANT INSERT, UPDATE, DELETE ON MyTable TO
            cmd2.CommandText = "GRANT INSERT, UPDATE, DELETE ON Students TO '" + name.Text+"' ";

            cmd2.Connection = con;
            cmd2.ExecuteNonQuery();

            con.Close();
            */

            
        }


    }
}
