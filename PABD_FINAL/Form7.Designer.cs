namespace PABD_FINAL
{
    partial class Form7
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
            this.cmdCopy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtidPeminjaman = new System.Windows.Forms.TextBox();
            this.txtidcst = new System.Windows.Forms.TextBox();
            this.txtidfilm = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.txttotharga = new System.Windows.Forms.TextBox();
            this.atimDataSet3 = new PABD_FINAL.AtimDataSet3();
            this.peminjamanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peminjamanTableAdapter = new PABD_FINAL.AtimDataSet3TableAdapters.PeminjamanTableAdapter();
            this.idpeminjamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atimDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peminjamanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCopy
            // 
            this.cmdCopy.Location = new System.Drawing.Point(62, 330);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(75, 23);
            this.cmdCopy.TabIndex = 85;
            this.cmdCopy.Text = "Copy Data";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpeminjamanDataGridViewTextBoxColumn,
            this.idcustomerDataGridViewTextBoxColumn,
            this.idfilmDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.totalhargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.peminjamanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(163, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 167);
            this.dataGridView1.TabIndex = 79;
            // 
            // btn12
            // 
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(562, 191);
            this.btn12.Margin = new System.Windows.Forms.Padding(2);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(118, 32);
            this.btn12.TabIndex = 78;
            this.btn12.Text = "Hapus";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn11
            // 
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(562, 146);
            this.btn11.Margin = new System.Windows.Forms.Padding(2);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(118, 35);
            this.btn11.TabIndex = 77;
            this.btn11.Text = "Edit";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(562, 99);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(118, 32);
            this.btn9.TabIndex = 76;
            this.btn9.Text = "Tambah";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(73, 29);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 28);
            this.button4.TabIndex = 75;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(202, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(202, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Id Film";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(202, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "ID Peminjaman";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(202, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "ID Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(110, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Peminjaman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(202, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Total Harga";
            // 
            // txtidPeminjaman
            // 
            this.txtidPeminjaman.Location = new System.Drawing.Point(353, 60);
            this.txtidPeminjaman.Name = "txtidPeminjaman";
            this.txtidPeminjaman.Size = new System.Drawing.Size(202, 20);
            this.txtidPeminjaman.TabIndex = 87;
            // 
            // txtidcst
            // 
            this.txtidcst.Location = new System.Drawing.Point(353, 99);
            this.txtidcst.Name = "txtidcst";
            this.txtidcst.Size = new System.Drawing.Size(202, 20);
            this.txtidcst.TabIndex = 88;
            // 
            // txtidfilm
            // 
            this.txtidfilm.Location = new System.Drawing.Point(353, 135);
            this.txtidfilm.Name = "txtidfilm";
            this.txtidfilm.Size = new System.Drawing.Size(202, 20);
            this.txtidfilm.TabIndex = 89;
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(353, 172);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(202, 20);
            this.qty.TabIndex = 90;
            // 
            // txttotharga
            // 
            this.txttotharga.Location = new System.Drawing.Point(353, 210);
            this.txttotharga.Name = "txttotharga";
            this.txttotharga.Size = new System.Drawing.Size(202, 20);
            this.txttotharga.TabIndex = 91;
            // 
            // atimDataSet3
            // 
            this.atimDataSet3.DataSetName = "AtimDataSet3";
            this.atimDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peminjamanBindingSource
            // 
            this.peminjamanBindingSource.DataMember = "Peminjaman";
            this.peminjamanBindingSource.DataSource = this.atimDataSet3;
            // 
            // peminjamanTableAdapter
            // 
            this.peminjamanTableAdapter.ClearBeforeFill = true;
            // 
            // idpeminjamanDataGridViewTextBoxColumn
            // 
            this.idpeminjamanDataGridViewTextBoxColumn.DataPropertyName = "Id_peminjaman";
            this.idpeminjamanDataGridViewTextBoxColumn.HeaderText = "Id_peminjaman";
            this.idpeminjamanDataGridViewTextBoxColumn.Name = "idpeminjamanDataGridViewTextBoxColumn";
            // 
            // idcustomerDataGridViewTextBoxColumn
            // 
            this.idcustomerDataGridViewTextBoxColumn.DataPropertyName = "Id_customer";
            this.idcustomerDataGridViewTextBoxColumn.HeaderText = "Id_customer";
            this.idcustomerDataGridViewTextBoxColumn.Name = "idcustomerDataGridViewTextBoxColumn";
            // 
            // idfilmDataGridViewTextBoxColumn
            // 
            this.idfilmDataGridViewTextBoxColumn.DataPropertyName = "Id_film";
            this.idfilmDataGridViewTextBoxColumn.HeaderText = "Id_film";
            this.idfilmDataGridViewTextBoxColumn.Name = "idfilmDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // totalhargaDataGridViewTextBoxColumn
            // 
            this.totalhargaDataGridViewTextBoxColumn.DataPropertyName = "Total_harga";
            this.totalhargaDataGridViewTextBoxColumn.HeaderText = "Total_harga";
            this.totalhargaDataGridViewTextBoxColumn.Name = "totalhargaDataGridViewTextBoxColumn";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttotharga);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.txtidfilm);
            this.Controls.Add(this.txtidcst);
            this.Controls.Add(this.txtidPeminjaman);
            this.Controls.Add(this.cmdCopy);
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
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atimDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peminjamanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdCopy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidPeminjaman;
        private System.Windows.Forms.TextBox txtidcst;
        private System.Windows.Forms.TextBox txtidfilm;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox txttotharga;
        private AtimDataSet3 atimDataSet3;
        private System.Windows.Forms.BindingSource peminjamanBindingSource;
        private AtimDataSet3TableAdapters.PeminjamanTableAdapter peminjamanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpeminjamanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalhargaDataGridViewTextBoxColumn;
    }
}