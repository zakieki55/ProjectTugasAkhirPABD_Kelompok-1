﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=Atim;Persist Security Info=True;User ID=sa;Password=eki123");
        private static string GetConnectionString()
        {
            return "Data Source=MSI;Initial Catalog=Atim;Persist Security Info=True;User ID=sa;Password=eki123";
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atimDataSet4.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter1.Fill(this.atimDataSet4.Transaksi);
           
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            String idtrx = txtidtrx.Text;
            String idpeminjaman = txtidpeminjaman.Text;
            String totalHarga = txttotharga.Text;
            String tanggalsewa = txttanggalsewa.Text;
            String tglKembali = txttglkembali.Text;
            con.Open();

            SqlCommand c = new SqlCommand("exec Transaksi_insert '" + idtrx + "', '" + idpeminjaman + "', '" + totalHarga + "','" + tanggalsewa + "','" + tglKembali + "'", con);
            c.ExecuteNonQuery();

            MessageBox.Show("Berhasil Di Tambahkan");
            GetTable_trx();
            con.Close();
        }
        void GetTable_trx()
        {
            SqlCommand c = new SqlCommand("exec Transaksi_view", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt1 = new DataTable();
            sd.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            String idtrx = txtidtrx.Text;
            String idpeminjaman = txtidpeminjaman.Text;
            String totalHarga = txttotharga.Text;
            String tanggalsewa = txttanggalsewa.Text;
            String tglKembali = txttglkembali.Text;
            con.Open();

            SqlCommand c = new SqlCommand("exec Transaksi_update '" + idtrx + "', '" + idpeminjaman + "', '" + totalHarga + "','" + tanggalsewa + "','" + tglKembali + "'", con);
            c.ExecuteNonQuery();

            MessageBox.Show("Berhasil Di Update");
            GetTable_trx();
            con.Close();
        }
        private void btn12_Click(object sender, EventArgs e)
        {
            String idtrx = txtidtrx.Text;
            con.Open();

            SqlCommand c = new SqlCommand("exec Transaksi_delete '" + idtrx + "'", con);
            c.ExecuteNonQuery();

            MessageBox.Show("Berhasil Di Delete");
            GetTable_trx();
            con.Close();
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            using (SqlConnection sourceConnection = new SqlConnection(connectionString))
            {
                sourceConnection.Open();
                SqlCommand commandSourceData = new SqlCommand("SELECT * FROM Transaksi", sourceConnection);
                SqlDataReader reader = commandSourceData.ExecuteReader();
                using (SqlConnection destinationConnection = new SqlConnection(connectionString))
                {
                    destinationConnection.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection))
                    {
                        bulkCopy.DestinationTableName = "Transaksi_Copy";

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 report = new Form6();
            report.Show();
            this.Hide();
        }
    }
}
