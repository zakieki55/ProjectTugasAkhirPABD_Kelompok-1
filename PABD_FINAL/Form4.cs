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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=Atim;Persist Security Info=True;User ID=sa;Password=eki123");

        private static string GetConnectionString()
        {
            return "Data Source=MSI;Initial Catalog=Atim;Persist Security Info=True;User ID=sa;Password=eki123";
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atimDataSet1.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.atimDataSet1.Film);
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            String idFilm = txtidfilm.Text;
            String judul = txtjudul.Text;
            String genre = txtgenre.Text;
            con.Open();

            SqlCommand c = new SqlCommand("exec Film_insert '" + idFilm + "', '" + judul + "', '" + genre + "'", con);
            c.ExecuteNonQuery();

            MessageBox.Show("Berhasil Di Tambahkan");
            GetTable_Film();
            con.Close();
        }
        void GetTable_Film()
        {
            SqlCommand c = new SqlCommand("exec Film_view", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt1 = new DataTable();
            sd.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            String idFilm = txtidfilm.Text;
            String judul = txtjudul.Text;
            String genre = txtgenre.Text;
            con.Open();

            SqlCommand c = new SqlCommand("exec Film_update '" + idFilm + "', '" + judul + "', '" + genre + "'", con);
            c.ExecuteNonQuery();

            MessageBox.Show("Berhasil Di Update");
            GetTable_Film();
            con.Close();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            String idFilm = txtidfilm.Text;
            con.Open();

            SqlCommand c = new SqlCommand("exec Film_delete '" + idFilm + "'", con);
            c.ExecuteNonQuery();

            MessageBox.Show("Berhasil Di Hapus");
            GetTable_Film();
            con.Close();
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            using (SqlConnection sourceConnection = new SqlConnection(connectionString))
            {
                sourceConnection.Open();
                SqlCommand commandSourceData = new SqlCommand("SELECT * FROM Film", sourceConnection);
                SqlDataReader reader = commandSourceData.ExecuteReader();
                using (SqlConnection destinationConnection = new SqlConnection(connectionString))
                {
                    destinationConnection.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection))
                    {
                        bulkCopy.DestinationTableName = "Film_Copy";

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
