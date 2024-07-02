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
    public partial class Student_Login : Form
    {
        public Student_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            String ST = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";

            OracleConnection mycon = new OracleConnection(ST);
            String query = "Select * from Students where ID = '" + username.Text.Trim() + "' and password = '" + password.Text.Trim() + "'";
            OracleDataAdapter con = new OracleDataAdapter(query, mycon);
            DataTable dtb1 = new DataTable();
            con.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                this.Hide();
                student_info Sp = new student_info(username.Text.Trim());
                Sp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username and password. TRY AGAIN!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login it = new Login();
            it.Show();
        }

        private void Student_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
