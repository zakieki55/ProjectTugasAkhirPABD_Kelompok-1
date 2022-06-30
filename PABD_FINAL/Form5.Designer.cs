namespace PABD_FINAL
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglSewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biayaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableTransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atim_MoviesDataSet2 = new PABD_FINAL.Atim_MoviesDataSet2();
            this.txtidtrx = new System.Windows.Forms.TextBox();
            this.txtidcst = new System.Windows.Forms.TextBox();
            this.txtidfilm = new System.Windows.Forms.TextBox();
            this.txttanggal = new System.Windows.Forms.TextBox();
            this.txtbiaya = new System.Windows.Forms.TextBox();
            this.table_TransaksiTableAdapter = new PABD_FINAL.Atim_MoviesDataSet2TableAdapters.Table_TransaksiTableAdapter();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTransaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atim_MoviesDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn12
            // 
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(532, 215);
            this.btn12.Margin = new System.Windows.Forms.Padding(2);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(118, 32);
            this.btn12.TabIndex = 60;
            this.btn12.Text = "Hapus";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn11
            // 
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(532, 170);
            this.btn11.Margin = new System.Windows.Forms.Padding(2);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(118, 35);
            this.btn11.TabIndex = 59;
            this.btn11.Text = "Edit";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(532, 123);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(118, 32);
            this.btn9.TabIndex = 58;
            this.btn9.Text = "Tambah";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(172, 31);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 28);
            this.button4.TabIndex = 57;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(172, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Biaya";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(172, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Tanggal Sewa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(172, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "ID Film";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(172, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "ID Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(172, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "ID Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(209, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Transaksi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransaksiDataGridViewTextBoxColumn,
            this.idPelangganDataGridViewTextBoxColumn,
            this.idFilmDataGridViewTextBoxColumn,
            this.tglSewaDataGridViewTextBoxColumn,
            this.biayaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableTransaksiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(130, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 167);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idTransaksiDataGridViewTextBoxColumn
            // 
            this.idTransaksiDataGridViewTextBoxColumn.DataPropertyName = "Id_Transaksi";
            this.idTransaksiDataGridViewTextBoxColumn.HeaderText = "Id_Transaksi";
            this.idTransaksiDataGridViewTextBoxColumn.Name = "idTransaksiDataGridViewTextBoxColumn";
            // 
            // idPelangganDataGridViewTextBoxColumn
            // 
            this.idPelangganDataGridViewTextBoxColumn.DataPropertyName = "Id_Pelanggan";
            this.idPelangganDataGridViewTextBoxColumn.HeaderText = "Id_Pelanggan";
            this.idPelangganDataGridViewTextBoxColumn.Name = "idPelangganDataGridViewTextBoxColumn";
            // 
            // idFilmDataGridViewTextBoxColumn
            // 
            this.idFilmDataGridViewTextBoxColumn.DataPropertyName = "Id_Film";
            this.idFilmDataGridViewTextBoxColumn.HeaderText = "Id_Film";
            this.idFilmDataGridViewTextBoxColumn.Name = "idFilmDataGridViewTextBoxColumn";
            // 
            // tglSewaDataGridViewTextBoxColumn
            // 
            this.tglSewaDataGridViewTextBoxColumn.DataPropertyName = "Tgl_Sewa";
            this.tglSewaDataGridViewTextBoxColumn.HeaderText = "Tgl_Sewa";
            this.tglSewaDataGridViewTextBoxColumn.Name = "tglSewaDataGridViewTextBoxColumn";
            // 
            // biayaDataGridViewTextBoxColumn
            // 
            this.biayaDataGridViewTextBoxColumn.DataPropertyName = "Biaya";
            this.biayaDataGridViewTextBoxColumn.HeaderText = "Biaya";
            this.biayaDataGridViewTextBoxColumn.Name = "biayaDataGridViewTextBoxColumn";
            // 
            // tableTransaksiBindingSource
            // 
            this.tableTransaksiBindingSource.DataMember = "Table_Transaksi";
            this.tableTransaksiBindingSource.DataSource = this.atim_MoviesDataSet2;
            // 
            // atim_MoviesDataSet2
            // 
            this.atim_MoviesDataSet2.DataSetName = "Atim_MoviesDataSet2";
            this.atim_MoviesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtidtrx
            // 
            this.txtidtrx.Location = new System.Drawing.Point(297, 84);
            this.txtidtrx.Name = "txtidtrx";
            this.txtidtrx.Size = new System.Drawing.Size(219, 20);
            this.txtidtrx.TabIndex = 62;
            // 
            // txtidcst
            // 
            this.txtidcst.Location = new System.Drawing.Point(297, 123);
            this.txtidcst.Name = "txtidcst";
            this.txtidcst.Size = new System.Drawing.Size(219, 20);
            this.txtidcst.TabIndex = 63;
            // 
            // txtidfilm
            // 
            this.txtidfilm.Location = new System.Drawing.Point(297, 159);
            this.txtidfilm.Name = "txtidfilm";
            this.txtidfilm.Size = new System.Drawing.Size(219, 20);
            this.txtidfilm.TabIndex = 64;
            // 
            // txttanggal
            // 
            this.txttanggal.Location = new System.Drawing.Point(297, 196);
            this.txttanggal.Name = "txttanggal";
            this.txttanggal.Size = new System.Drawing.Size(219, 20);
            this.txttanggal.TabIndex = 65;
            // 
            // txtbiaya
            // 
            this.txtbiaya.Location = new System.Drawing.Point(297, 234);
            this.txtbiaya.Name = "txtbiaya";
            this.txtbiaya.Size = new System.Drawing.Size(219, 20);
            this.txtbiaya.TabIndex = 66;
            // 
            // table_TransaksiTableAdapter
            // 
            this.table_TransaksiTableAdapter.ClearBeforeFill = true;
            // 
            // cmdCopy
            // 
            this.cmdCopy.Location = new System.Drawing.Point(29, 341);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(75, 23);
            this.cmdCopy.TabIndex = 67;
            this.cmdCopy.Text = "Copy Data";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdCopy);
            this.Controls.Add(this.txtbiaya);
            this.Controls.Add(this.txttanggal);
            this.Controls.Add(this.txtidfilm);
            this.Controls.Add(this.txtidcst);
            this.Controls.Add(this.txtidtrx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTransaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atim_MoviesDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtidtrx;
        private System.Windows.Forms.TextBox txtidcst;
        private System.Windows.Forms.TextBox txtidfilm;
        private System.Windows.Forms.TextBox txttanggal;
        private System.Windows.Forms.TextBox txtbiaya;
        private Atim_MoviesDataSet2 atim_MoviesDataSet2;
        private System.Windows.Forms.BindingSource tableTransaksiBindingSource;
        private Atim_MoviesDataSet2TableAdapters.Table_TransaksiTableAdapter table_TransaksiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglSewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biayaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button cmdCopy;
        private System.Windows.Forms.Button button1;
    }
}