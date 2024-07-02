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
    
    public partial class section_info : Form
    {
        String connectionstring = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";
        string id;
        public section_info(string id)
        {
            InitializeComponent();
            this.id = id; 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                String query = "SELECT Students.*, RegisterCourses.* FROM Students Join RegisterCourses ON Students.ID = RegisterCourses.S_ID And Students.Section = '"+name.Text+ "' And RegisterCourses.Name='"+name2.Text+ "'";
                OracleDataAdapter oracledp = new OracleDataAdapter(query, oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv4.DataSource = dtb1;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_info it = new Instructor_info(id);
            it.Show();
        }

        private void section_info_Load(object sender, EventArgs e)
        {

        }
    }
}
