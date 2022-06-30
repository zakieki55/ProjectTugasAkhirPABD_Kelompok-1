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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog = Atim_Movies;Persist Security Info = True;User ID=sa;Password=eki123");
        private static string GetConnectionString()
        {
            return "Data Source=MSI;Initial Catalog = Atim_Movies;Persist Security Info = True;User ID=sa;Password=eki123";
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atim_MoviesDataSet.Table_Pelanggan' table. You can move, or remove it, as needed.
            this.table_PelangganTableAdapter.Fill(this.atim_MoviesDataSet.Table_Pelanggan);



            /*this.reportViewer1.RefreshReport();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String idCustomer = txtidc.Text;
            String namaPel = txtnama.Text;
            String notelp = txtnotelp.Text;
            String alamat = txtalamat.Text;
            con.Open();

            SqlCommand c = new SqlCommand("exec InsertTable_Pelanggan '" + idCustomer + "', '" + namaPel + "', '" + notelp + "','" + alamat + "'", con);
            c.ExecuteNonQuery();

            MessageBox.Show("Berhasil Di Tambahkan");
            GetTable_Pelanggan();
            con.Close();
        }
        void GetTable_Pelanggan()
        {
            SqlCommand c = new SqlCommand("exec ListTable_Pelanggan", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt1 = new DataTable();
            sd.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            String idCustomer = txtidc.Text;
            String namaPel = txtnama.Text;
            String notelp = txtnotelp.Text;
            String alamat = txtalamat.Text;
            con.Open();

            SqlCommand c = new SqlCommand("exec UpdateTable_Pelanggan '" + idCustomer + "', '" + namaPel + "', '" + notelp + "','" + alamat + "'", con);
            c.ExecuteNonQuery();

            MessageBox.Show("Berhasil Di Update");
            GetTable_Pelanggan();

            con.Close();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            String idCustomer = txtidc.Text;
            con.Open();

            SqlCommand c = new SqlCommand("exec DeleteTable_Pelanggan '" + idCustomer + "'", con);
            c.ExecuteNonQuery();

            MessageBox.Show("Berhasil Di Hapus");
            GetTable_Pelanggan();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            using (SqlConnection sourceConnection = new SqlConnection(connectionString))
            {
                sourceConnection.Open();
                SqlCommand commandSourceData = new SqlCommand("SELECT * FROM Table_Pelanggan", sourceConnection);
                SqlDataReader reader = commandSourceData.ExecuteReader();
                using(SqlConnection destinationConnection = new SqlConnection(connectionString))
                {
                    destinationConnection.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection))
                    {
                        bulkCopy.DestinationTableName = "Table_Pelanggan_Copy";

                        try
                        {
                            bulkCopy.WriteToServer(reader);
                        }
                        catch(Exception ex)
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
