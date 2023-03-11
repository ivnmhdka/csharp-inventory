
namespace ukk_oop2
{
    partial class Form1
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
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.nama_barang = new System.Windows.Forms.Label();
            this.jenis_barang = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.Label();
            this.tb_nama_barang = new System.Windows.Forms.TextBox();
            this.tb_jenis_barang = new System.Windows.Forms.TextBox();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.ed_nama_barang = new System.Windows.Forms.Label();
            this.ed_jenis_barang = new System.Windows.Forms.Label();
            this.ed_id = new System.Windows.Forms.Label();
            this.ed_harga = new System.Windows.Forms.Label();
            this.tb_ed_id = new System.Windows.Forms.TextBox();
            this.tb_ed_nama_barang = new System.Windows.Forms.TextBox();
            this.tb_ed_jenis_barang = new System.Windows.Forms.TextBox();
            this.tb_ed_harga = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(12, 253);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.Size = new System.Drawing.Size(643, 185);
            this.dgv_data.TabIndex = 0;
            this.dgv_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellClick);
            // 
            // nama_barang
            // 
            this.nama_barang.AutoSize = true;
            this.nama_barang.Location = new System.Drawing.Point(46, 53);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(72, 13);
            this.nama_barang.TabIndex = 1;
            this.nama_barang.Text = "Nama Barang";
            // 
            // jenis_barang
            // 
            this.jenis_barang.AutoSize = true;
            this.jenis_barang.Location = new System.Drawing.Point(46, 94);
            this.jenis_barang.Name = "jenis_barang";
            this.jenis_barang.Size = new System.Drawing.Size(68, 13);
            this.jenis_barang.TabIndex = 2;
            this.jenis_barang.Text = "Jenis Barang";
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.Location = new System.Drawing.Point(46, 137);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(36, 13);
            this.harga.TabIndex = 3;
            this.harga.Text = "Harga";
            // 
            // tb_nama_barang
            // 
            this.tb_nama_barang.Location = new System.Drawing.Point(166, 53);
            this.tb_nama_barang.Name = "tb_nama_barang";
            this.tb_nama_barang.Size = new System.Drawing.Size(136, 20);
            this.tb_nama_barang.TabIndex = 4;
            // 
            // tb_jenis_barang
            // 
            this.tb_jenis_barang.Location = new System.Drawing.Point(166, 94);
            this.tb_jenis_barang.Name = "tb_jenis_barang";
            this.tb_jenis_barang.Size = new System.Drawing.Size(136, 20);
            this.tb_jenis_barang.TabIndex = 5;
            // 
            // tb_harga
            // 
            this.tb_harga.Location = new System.Drawing.Point(166, 137);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(136, 20);
            this.tb_harga.TabIndex = 6;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(166, 181);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(75, 23);
            this.btn_tambah.TabIndex = 7;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // ed_nama_barang
            // 
            this.ed_nama_barang.AutoSize = true;
            this.ed_nama_barang.Location = new System.Drawing.Point(370, 52);
            this.ed_nama_barang.Name = "ed_nama_barang";
            this.ed_nama_barang.Size = new System.Drawing.Size(72, 13);
            this.ed_nama_barang.TabIndex = 8;
            this.ed_nama_barang.Text = "Nama Barang";
            this.ed_nama_barang.Click += new System.EventHandler(this.label1_Click);
            // 
            // ed_jenis_barang
            // 
            this.ed_jenis_barang.AutoSize = true;
            this.ed_jenis_barang.Location = new System.Drawing.Point(370, 95);
            this.ed_jenis_barang.Name = "ed_jenis_barang";
            this.ed_jenis_barang.Size = new System.Drawing.Size(68, 13);
            this.ed_jenis_barang.TabIndex = 9;
            this.ed_jenis_barang.Text = "Jenis Barang";
            // 
            // ed_id
            // 
            this.ed_id.AutoSize = true;
            this.ed_id.Location = new System.Drawing.Point(370, 11);
            this.ed_id.Name = "ed_id";
            this.ed_id.Size = new System.Drawing.Size(18, 13);
            this.ed_id.TabIndex = 10;
            this.ed_id.Text = "ID";
            // 
            // ed_harga
            // 
            this.ed_harga.AutoSize = true;
            this.ed_harga.Location = new System.Drawing.Point(370, 134);
            this.ed_harga.Name = "ed_harga";
            this.ed_harga.Size = new System.Drawing.Size(36, 13);
            this.ed_harga.TabIndex = 11;
            this.ed_harga.Text = "Harga";
            // 
            // tb_ed_id
            // 
            this.tb_ed_id.Location = new System.Drawing.Point(480, 8);
            this.tb_ed_id.Name = "tb_ed_id";
            this.tb_ed_id.Size = new System.Drawing.Size(136, 20);
            this.tb_ed_id.TabIndex = 12;
            // 
            // tb_ed_nama_barang
            // 
            this.tb_ed_nama_barang.Location = new System.Drawing.Point(480, 52);
            this.tb_ed_nama_barang.Name = "tb_ed_nama_barang";
            this.tb_ed_nama_barang.Size = new System.Drawing.Size(136, 20);
            this.tb_ed_nama_barang.TabIndex = 13;
            // 
            // tb_ed_jenis_barang
            // 
            this.tb_ed_jenis_barang.Location = new System.Drawing.Point(480, 95);
            this.tb_ed_jenis_barang.Name = "tb_ed_jenis_barang";
            this.tb_ed_jenis_barang.Size = new System.Drawing.Size(136, 20);
            this.tb_ed_jenis_barang.TabIndex = 14;
            // 
            // tb_ed_harga
            // 
            this.tb_ed_harga.Location = new System.Drawing.Point(480, 134);
            this.tb_ed_harga.Name = "tb_ed_harga";
            this.tb_ed_harga.Size = new System.Drawing.Size(136, 20);
            this.tb_ed_harga.TabIndex = 15;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(480, 181);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 16;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(373, 181);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Hapus";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cari";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(166, 218);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(450, 20);
            this.tb_search.TabIndex = 19;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.tb_ed_harga);
            this.Controls.Add(this.tb_ed_jenis_barang);
            this.Controls.Add(this.tb_ed_nama_barang);
            this.Controls.Add(this.tb_ed_id);
            this.Controls.Add(this.ed_harga);
            this.Controls.Add(this.ed_id);
            this.Controls.Add(this.ed_jenis_barang);
            this.Controls.Add(this.ed_nama_barang);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.tb_harga);
            this.Controls.Add(this.tb_jenis_barang);
            this.Controls.Add(this.tb_nama_barang);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.jenis_barang);
            this.Controls.Add(this.nama_barang);
            this.Controls.Add(this.dgv_data);
            this.Name = "Form1";
            this.Text = "Zeamart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Label nama_barang;
        private System.Windows.Forms.Label jenis_barang;
        private System.Windows.Forms.Label harga;
        private System.Windows.Forms.TextBox tb_nama_barang;
        private System.Windows.Forms.TextBox tb_jenis_barang;
        private System.Windows.Forms.TextBox tb_harga;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Label ed_nama_barang;
        private System.Windows.Forms.Label ed_jenis_barang;
        private System.Windows.Forms.Label ed_id;
        private System.Windows.Forms.Label ed_harga;
        private System.Windows.Forms.TextBox tb_ed_id;
        private System.Windows.Forms.TextBox tb_ed_nama_barang;
        private System.Windows.Forms.TextBox tb_ed_jenis_barang;
        private System.Windows.Forms.TextBox tb_ed_harga;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_search;
    }
}

