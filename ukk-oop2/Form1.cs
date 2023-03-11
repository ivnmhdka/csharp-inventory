using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ukk_oop2
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = connection.getConnection();
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }
        public DataTable getData()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM mart", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public void filldataTable()
        {
            // menampilkan datatable ke gridview
            dgv_data.DataSource = getData();

            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Text = "Edit";
            colEdit.Name = "";
            dgv_data.Columns.Add(colEdit);

            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Text = "Delete";
            colDelete.Name = "";
            dgv_data.Columns.Add(colDelete);
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            //conn.Open()
            try
            {
                resetIncrement();

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "INSERT INTO mart(nama_barang,jenis_barang,harga) VALUE(@nama_barang, @jenis_barang, @harga)";
                cmd.Parameters.AddWithValue("@nama_barang", tb_nama_barang.Text);
                cmd.Parameters.AddWithValue("@jenis_barang", tb_jenis_barang.Text);
                cmd.Parameters.AddWithValue("@harga", tb_harga.Text);
                cmd.ExecuteNonQuery();
                // long id = cmd.LastiInsertId;
                koneksi.Close();

                dgv_data.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id := 0; UPDATE mart SET id = @id := (@id+1); " +
                    "ALTER TABLE mart AUTO_INCREMENT = 1;");
            script.Execute();
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==4)
            {
                int id = Convert.ToInt32(dgv_data.CurrentCell.RowIndex.ToString());
                tb_ed_id.Text = dgv_data.Rows[id].Cells[0].Value.ToString();
                tb_ed_nama_barang.Text = dgv_data.Rows[id].Cells[1].Value.ToString();
                tb_ed_jenis_barang.Text = dgv_data.Rows[id].Cells[2].Value.ToString();
                tb_ed_harga.Text = dgv_data.Rows[id].Cells[3].Value.ToString();

                tb_ed_nama_barang.Enabled = true;
                tb_ed_jenis_barang.Enabled = true;
                tb_ed_harga.Enabled = true;
                btn_edit.Enabled = true;
            }
            
            if (e.ColumnIndex ==5)
            {
                int id = Convert.ToInt32(dgv_data.CurrentCell.RowIndex.ToString());

                MySqlCommand cmd;
                try
                {
                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "DELETE FROM mart WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", dgv_data.Rows[id].Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil terhapus");
                    resetIncrement();
                    koneksi.Close();

                    dgv_data.Columns.Clear();
                    dataTable.Clear();
                    filldataTable();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            //koneksi.Open();

            try
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE mart SET nama_barang = @nama_barang, jenis_barang = @jenis_barang, harga = @harga WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", tb_ed_id.Text);
                cmd.Parameters.AddWithValue("@nama_barang", tb_ed_nama_barang.Text);
                cmd.Parameters.AddWithValue("@jenis_barang", tb_ed_jenis_barang.Text);
                cmd.Parameters.AddWithValue("@harga", tb_ed_harga.Text);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                dgv_data.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            { 
            }
        }

        public void searchData (string ValueToFind)
        {
            string searchQuery = "SELECT * FROM mart WHERE CONCAT(nama_barang, jenis_barang, harga) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv_data.DataSource = table;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            searchData(tb_search.Text);
        }
    }
}
