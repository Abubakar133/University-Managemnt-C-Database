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
    public partial class Instructor_info : Form
    {
        string id2;
        String connectionstring = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";

        public Instructor_info(string id)
        {
            id2 = id;
            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from Instructor Where ID ='" + id + "'", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv4.DataSource = dtb1;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_info it = new Instructor_info(id2);
            it.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            instructor_Flex it = new instructor_Flex(id2);
            it.Show();
        }

        private void Instructor_info_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            section_info it = new section_info(id2);
            it.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            instructor_Login it = new instructor_Login();
            it.Show();
        }
    }
}
