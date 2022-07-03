using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD_FINAL
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=Atim;Persist Security Info=True;User ID=sa;Password=eki123");
        private static string GetConnectionString()
        {
            return "Data Source=MSI;Initial Catalog=Atim;Persist Security Info=True;User ID=sa;Password=eki123";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atimDataSet3.Peminjaman' table. You can move, or remove it, as needed.
            this.peminjamanTableAdapter.Fill(this.atimDataSet3.Peminjaman);

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            String idpeminjaman = txtidPeminjaman.Text;
            String idcustomer = txtidcst.Text;
            String idFilm = txtidfilm.Text;
            String totHarga = txttotharga.Text;
            con.Open();

            SqlCommand c = new SqlCommand("exec Peminjaman_insert '" + idpeminjaman + "', '" + idcustomer + "', '" + idFilm + "', '" + int.Parse(qty.Text) + "', '" + totHarga + "'", con);
            c.ExecuteNonQuery();

            MessageBox.Show("Berhasil Di Tambahkan");
            GetTable_peminjaman();
            con.Close();
        }
        void GetTable_peminjaman()
        {
            SqlCommand c = new SqlCommand("exec Peminjaman_view", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt1 = new DataTable();
            sd.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            String idpeminjaman = txtidPeminjaman.Text;
            String idcustomer = txtidcst.Text;
            String idFilm = txtidfilm.Text;
            String totHarga = txttotharga.Text;
            con.Open();

            SqlCommand c = new SqlCommand("exec Peminjaman_update '" + idpeminjaman + "', '" + idcustomer + "', '" + idFilm + "', '" + int.Parse(qty.Text) + "'", con);
            c.ExecuteNonQuery();

            MessageBox.Show("Berhasil Di Update");
            GetTable_peminjaman();
            con.Close();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            String idpeminjaman = txtidPeminjaman.Text;
            con.Open();

            SqlCommand c = new SqlCommand("exec Film_delete '" + idpeminjaman + "'", con);
            c.ExecuteNonQuery();

            MessageBox.Show("Berhasil Di Hapus");
            GetTable_peminjaman();
            con.Close();
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            using (SqlConnection sourceConnection = new SqlConnection(connectionString))
            {
                sourceConnection.Open();
                SqlCommand commandSourceData = new SqlCommand("SELECT * FROM Peminjaman", sourceConnection);
                SqlDataReader reader = commandSourceData.ExecuteReader();
                using (SqlConnection destinationConnection = new SqlConnection(connectionString))
                {
                    destinationConnection.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection))
                    {
                        bulkCopy.DestinationTableName = "Peminjaman_Copy";

                        try
                        {
                            bulkCopy.WriteToServer(reader);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            MessageBox.Show("Data Telah Di Copy");
        }
    }
}
