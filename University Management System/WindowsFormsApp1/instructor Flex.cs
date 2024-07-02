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
    public partial class instructor_Flex : Form
    {
        string id2;
        public instructor_Flex(string id)
        {
            id2 = id;
            InitializeComponent();
        }

        private void instructor_Flex_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://flex.nu.edu.pk/Login");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_info it = new Instructor_info(id2);
            it.Show();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = e.Url.ToString() + "is Loading...........";
        }
    }
}
