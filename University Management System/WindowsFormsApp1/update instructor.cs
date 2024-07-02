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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{
    public partial class update_instructor : Form
    {
        public update_instructor()
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

        private void button1_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";
            String myquery = "Select * from Instructor where ID = '" + search.Text + "'";
            OracleConnection con = new OracleConnection(mycon);
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Check.Text = "Particular ID Found Successfully";
                name.Text = (ds.Tables[0].Rows[0]["Name"].ToString()).Trim();
                password.Text = (ds.Tables[0].Rows[0]["Password"].ToString()).Trim();
                email.Text = (ds.Tables[0].Rows[0]["Email"].ToString()).Trim();
                cnic.Text = (ds.Tables[0].Rows[0]["Cnic"].ToString()).Trim();
                phone.Text = (ds.Tables[0].Rows[0]["Phone_No"].ToString()).Trim();
                Degree.Text = (ds.Tables[0].Rows[0]["Degree"].ToString()).Trim();
                section.Text = (ds.Tables[0].Rows[0]["Class_Instructor"].ToString()).Trim();


            }
            else
            {
                Check.Text = "Particular ID Not Found - Search Again";
                name.Text = "";
                password.Text = "";
                email.Text = "";
                cnic.Text = "";
                phone.Text = "";
                Degree.Text = "";
                section.Text = "";


            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";
            String updatedata = "Update Instructor set Name='" + name.Text + "', Password='" + password.Text + "', Email='" + email.Text + "', Phone_No = " + phone.Text + ",Degree = '" + Degree.Text + "',Class_Instructor ='" + section.Text + "', Cnic= '" + cnic.Text + "' where ID= '" + search.Text + "'";



            OracleConnection con = new OracleConnection(mycon);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            check2.Text = "Data Has Been Updated";
            name.Text = "";
            password.Text = "";
            email.Text = "";
            cnic.Text = "";
            phone.Text = "";
        }
    }
}
