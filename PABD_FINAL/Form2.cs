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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 film = new Form4();
            film.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 cst = new Form3();
            cst.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 trx = new Form5();
            trx.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 peminjaman = new Form7();
            peminjaman.Show();
            this.Hide();
        }
    }
}
