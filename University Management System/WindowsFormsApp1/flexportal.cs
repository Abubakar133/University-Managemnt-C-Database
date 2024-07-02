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
    public partial class flexportal : Form
    {
        string id2;
        public flexportal(string id)
        {
            id2 = id;
            InitializeComponent();
        }

        private void flexportal_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://flexstudent.nu.edu.pk/Login");
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = e.Url.ToString() + "is Loading...........";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_info it = new student_info(id2);
            it.Show();
        }
    }
}
