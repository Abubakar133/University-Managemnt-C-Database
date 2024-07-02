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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{
    public partial class Uni_Info : Form
    {
        String connectionstring = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";

        public Uni_Info()
        {
            InitializeComponent();
            using (OracleConnection oraclecon = new OracleConnection(connectionstring))
            {
                oraclecon.Open();
                OracleDataAdapter oracledp = new OracleDataAdapter("select * from University", oraclecon);
                DataTable dtb1 = new DataTable();
                oracledp.Fill(dtb1);
                dgv1.DataSource = dtb1;
            }

            String mycon = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";
            String myquery = "Select * from University";
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

                name.Text = (ds.Tables[0].Rows[0]["Name"].ToString()).Trim();
                location.Text = (ds.Tables[0].Rows[0]["Location"].ToString()).Trim();
                email.Text = (ds.Tables[0].Rows[0]["Email"].ToString()).Trim();
                id.Text = (ds.Tables[0].Rows[0]["ID"].ToString()).Trim();
                phone.Text = (ds.Tables[0].Rows[0]["Phone_No"].ToString()).Trim();



            }
            else
            {

                MessageBox.Show("Not Found");
            }

        }

        private void Uni_Info_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

           



            String mycon = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";
            String updatedata = "Update University set Name='" + name.Text + "', ID='" + id.Text + "', Email='" + email.Text + "', Phone_No = " + phone.Text + ",Location = '" + location.Text + "'";



            OracleConnection con2 = new OracleConnection(mycon);
            con2.Open();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.CommandText = updatedata;
            cmd2.Connection = con2;
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Updated");
            
            name.Text = "";
            location.Text = "";
            email.Text = "";
            id.Text = "";
            phone.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperPanelDashboard it = new SuperPanelDashboard();
            it.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Uni_Info it = new Uni_Info();
            it.Show();
        }
    }
}
