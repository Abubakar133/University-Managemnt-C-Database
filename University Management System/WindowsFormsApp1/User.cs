using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword FP = new ForgetPassword();
            FP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            OracleConnection mycon = new OracleConnection("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=SUPER_PANEL;Password=1214");
            String query = "Select * from USERADMIN where username1 = '" + textBox1.Text.Trim() + "' and password1 = '" + textBox2.Text.Trim() + "'";
            OracleDataAdapter con = new OracleDataAdapter(query, mycon);
            DataTable dtb1 = new DataTable();
            con.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                try
                {
                    using (MailMessage mail = new MailMessage())
                    {
                        
                        mail.From = new MailAddress("f201023@cfd.nu.edu.pk");
                        
                        String query1 = "Select email from USERADMIN where username1 = '" + textBox1.Text.Trim() + "' and password1 = '" + textBox2.Text.Trim() + "'";
                        mail.To.Add("mehboobabubaker7@gmail.com");
                        mail.Subject = "User Login";
                        mail.Body = textBox1.Text + " is login to University Managment system.";


               

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new System.Net.NetworkCredential("f201023@cfd.nu.edu.pk", "03074659133");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                            label3.Text = "Mail sent!";
                        }
                    }
                }
                catch (Exception ex)
                {
                    label3.Text = ex.Message;
                }
                this.Hide();
                UserDashboard Sp = new UserDashboard(textBox1.Text, textBox2.Text);
                Sp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username and password. TRY AGAIN!");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
