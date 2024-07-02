using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{
    public partial class Register_Course : Form
    {
        String connectionstring = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";
        string id2;
        public Register_Course(string id)
        {
            id2 = id;
            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select Name,C_ID from RegisterCourses Where S_ID ='" + id + "'", oraclecon);
                OracleDataAdapter oracledp2 = new OracleDataAdapter("select * from Course", oraclecon);

                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dv3.DataSource = dtb1;

                DataTable dtb2 = new DataTable();
                oracledp2.Fill(dtb2);
                dgv4.DataSource = dtb2;
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Register_Course_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_info it = new student_info(id2);
            it.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            int c;
            string c1;
            using (OracleConnection thisConnection = new OracleConnection(connectionstring))
            {
                using (OracleCommand cmdCount = new OracleCommand("Select Count(*) from RegisterCourses", thisConnection))
                {
                    thisConnection.Open();
                    int rowCount = Convert.ToInt32(cmdCount.ExecuteScalar());
                    c = rowCount;
                   // c1 = c.ToString();
                   // MessageBox.Show(c1);
                }
                using (OracleConnection oraclecon = new OracleConnection(connectionstring))
                {

                    oraclecon.Open();

                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Select Count(*) from RegisterCourses";

                    c = c + 1;
                   // MessageBox.Show(c1);
                    cmd.CommandText = "insert into RegisterCourses values (" + c + ",'" + username.Text + "','" + username2.Text + "','" + id2 + "')";
                    cmd.Connection = oraclecon;
                    cmd.ExecuteNonQuery();
                    oraclecon.Close();
                    MessageBox.Show("successfully");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Course it = new Register_Course(id2);
            it.Show();
        }
    }
}
