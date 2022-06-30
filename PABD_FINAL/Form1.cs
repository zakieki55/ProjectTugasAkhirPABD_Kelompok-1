using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD_FINAL
{
    public partial class Form1 : Form
    {
        readonly String Username = "masuk";
        readonly String Password = "12345";
        public Form1()
        {
            InitializeComponent();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();

            if (txtbox1.Text == Username && txtbox2.Text == Password)
            {
                MessageBox.Show("Kamu Berhasil Login");
                menu.Show();
                this.Hide();
            }
            else if (txtbox1.Text == "" && txtbox2.Text == "")
            {
                MessageBox.Show("Username dan Password belum terisi");
            }
            else
            {
                MessageBox.Show("Username dan Password Salah");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
