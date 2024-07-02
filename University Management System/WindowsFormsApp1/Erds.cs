using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Erds : Form
    {
        public Erds()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filepath = openFileDialog1.FileName;
            pictureBox1.Image=Image.FromFile(filepath);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login it = new Login();
            it.Show();
        }
    }
}
