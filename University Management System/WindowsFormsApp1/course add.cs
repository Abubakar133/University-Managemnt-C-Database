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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class course_add : Form
    {
        public course_add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            course_add up = new course_add();
            up.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
           delete_course up = new delete_course();
            up.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
           Admin_Course up = new Admin_Course();
            up.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214");
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "insert into Course values ('" + id.Text + "','" + name.Text + "','" + prereq.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully");
        }

        private void course_add_Load(object sender, EventArgs e)
        {

        }
    }
}
