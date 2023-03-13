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

namespace zeamart_app
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = connection.getConnection();
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable getDataPerhiasan()
        {
            //Menampilkan datatable di localhost
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM data_perhiasan", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader); 
            }

            return dataTable;   
        }

        public void filldataTable()
        {
            //Menampilkan data table ke data gridview
            data_jewelry.DataSource = getDataPerhiasan();

            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Text = "Edit";
            colEdit.Name = "";
            data_jewelry.Columns.Add(colEdit);

            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
            colDelete.UseColumnTextForButtonValue= true;
            colDelete.Text = "Delete";
            colDelete.Name = "";
            data_jewelry.Columns.Add(colDelete);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }


        private void tb_nama_Click(object sender, EventArgs e)
        {

        }

        private void tb_kode_Click(object sender, EventArgs e)
        {

        }

        private void tb_harga_Click(object sender, EventArgs e)
        {

        }

        private void tb_desk_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void tb_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void btn_add_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            //conn.Open();
            try
            {

                resetIncrement();
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "INSERT INTO data_perhiasan(nama,kode,harga,deskripsi) VALUE(@nama, @kode, @harga, @deskripsi)";
                cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("@kode", tb_kode.Text);
                cmd.Parameters.AddWithValue("@harga", tb_harga.Text);
                cmd.Parameters.AddWithValue("@deskripsi", tb_desk.Text);
                cmd.ExecuteNonQuery();

                koneksi.Close();

                data_jewelry.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }

            catch (Exception ex)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void btn_edit_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            //conn.Open();
            try
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE data_perhiasan SET nama = @nama, kode = @kode, harga = @harga ,deskripsi = @deskripsi WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", tb_id.Text);
                cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("@kode", tb_kode.Text);
                cmd.Parameters.AddWithValue("@harga", tb_harga.Text);
                cmd.Parameters.AddWithValue("@deskripsi", tb_desk.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah yaa");
                koneksi.Close();

                data_jewelry.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }

            catch (Exception ex)
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id :=0; UPDATE data_perhiasan SET id = @id := (@id + 1);" +
                "ALTER TABLE data_perhiasan AUTO_INCREMENT = 1;");
            script.Execute();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void data_jewelry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int id = Convert.ToInt32(data_jewelry.CurrentCell.RowIndex.ToString());
                tb_id.Text = data_jewelry.Rows[id].Cells[0].Value.ToString();
                tb_nama.Text = data_jewelry.Rows[id].Cells[1].Value.ToString();
                tb_kode.Text = data_jewelry.Rows[id].Cells[2].Value.ToString();
                tb_harga.Text = data_jewelry.Rows[id].Cells[3].Value.ToString();
                tb_desk.Text = data_jewelry.Rows[id].Cells[4].Value.ToString();

                tb_nama.Enabled = true;
                tb_kode.Enabled = true;
                tb_harga.Enabled = true;
                tb_desk.Enabled = true;
                btn_add.Enabled = true;
            }

            if (e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(data_jewelry.CurrentCell.RowIndex.ToString());

                MySqlCommand cmd;

                try
                {
                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "DELETE FROM data_perhiasan WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", data_jewelry.Rows[id].Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus");ada
                    resetIncrement();
                    koneksi.Close();

                    data_jewelry.Columns.Clear();
                    dataTable.Clear();
                    filldataTable();
                }

                catch (Exception ex)
                {

                }
            }
        }

        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM data_perhiasan WHERE CONCAT(nama, harga, kode, deskripsi) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            data_jewelry.DataSource = table;
        }

      

        private void tb_search_TextChanged_1(object sender, EventArgs e)
        {
            searchData(tb_search.Text);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}