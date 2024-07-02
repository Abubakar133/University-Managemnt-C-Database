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
    public partial class UserDashboard : Form
    {

       
        public UserDashboard(string e1, string e2)
        {
            InitializeComponent();
            name.Text = e1;
            password.Text = e2;
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            User us = new User();
            us.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Students it = new Admin_Students();
            it.Show();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_instructor sn = new admin_instructor ();
            sn.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Admin_University it = new Admin_University();
            it.Show();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Course up = new Admin_Course();
            up.Show();

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Transaction it = new Admin_Transaction();
            it.Show();
        }
    }
}
