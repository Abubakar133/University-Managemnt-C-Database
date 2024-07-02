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
    public partial class TimeTable : Form
    {
        String connectionstring = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";

        public TimeTable()
        {
            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from TimeTable", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv4.DataSource = dtb1;
                oraclecon.Close();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Transaction t1 = new Admin_Transaction();
            t1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateTimetable t1=new updateTimetable();
            t1.Show();
        }
    }
}
