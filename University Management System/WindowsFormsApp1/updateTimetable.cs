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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class updateTimetable : Form
    {
        public updateTimetable()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";
            String myquery = "Select * from TimeTable where Day = '" + search.Text + "'";
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
                check.Text = "Particular ID Found Successfully";
                slot1.Text = (ds.Tables[0].Rows[0]["Slot_1"].ToString()).Trim();
                slot2.Text = (ds.Tables[0].Rows[0]["Slot_2"].ToString()).Trim();
                slot3.Text = (ds.Tables[0].Rows[0]["Slot_3"].ToString()).Trim();
                slot4.Text = (ds.Tables[0].Rows[0]["Slot_4"].ToString()).Trim();
                slot5.Text = (ds.Tables[0].Rows[0]["Slot_5"].ToString()).Trim();
                

            }
            else
            {
                check.Text = "Particular ID Not Found - Search Again";
                slot1.Text = "";
                slot2.Text = "";
                slot3.Text = "";
                slot4.Text = "";
                slot5.Text = "";
                


            }
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214";
            String updatedata = "Update TimeTable set slot_1='" + slot1.Text + "', Slot_2='" + slot2.Text + "', slot_3='" + slot3.Text + "', slot_4 = '" + slot4.Text + "',slot_5 = '" + slot5.Text + "' where Day='" + search.Text + "'";



            OracleConnection con = new OracleConnection(mycon);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            check.Text = "Data Has Been Updated";
            slot1.Text = "";
            slot2.Text = "";
            slot3.Text = "";
            slot4.Text = "";
            slot5.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimeTable t1 = new TimeTable();
            t1.Show();
        }

        private void updateTimetable_Load(object sender, EventArgs e)
        {

        }
    }
}
