using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RTRWMultimedia.Database;

namespace RTRWMultimedia
{
    public partial class frmWarga : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int idWarga = 0;

        public frmWarga()
        {
            InitializeComponent();
        }

        private void frmWarga_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void TampilData()
        {
            conn = Koneksi.GetConnection();
            da = new SqlDataAdapter("SELECT * FROM tb_warga", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvWarga.DataSource = dt;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            conn = Koneksi.GetConnection();
            conn.Open();
            string sql = @"INSERT INTO tb_warga (nik, nama, alamat, no_hp, status_warga) VALUES (@nik, @nama, @alamat, @hp, @status)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nik", txtNik.Text);
            cmd.Parameters.AddWithValue("@nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
            cmd.Parameters.AddWithValue("@hp", txtHp.Text);
            cmd.Parameters.AddWithValue("@status", cboStatus.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Berhasil Disimpan");
            TampilData();
            Bersih();
        }

        private void Bersih()
        {
            txtNik.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtHp.Clear();
            cboStatus.SelectedIndex = -1;
            txtNik.Focus();
        }

        private void dgvWarga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvWarga.Rows[e.RowIndex];
                idWarga = Convert.ToInt32(row.Cells["id_warga"].Value);
                txtNik.Text = row.Cells["nik"].Value.ToString();
                txtNama.Text = row.Cells["nama"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat"].Value.ToString();
                txtHp.Text = row.Cells["no_hp"].Value.ToString();
                cboStatus.Text = row.Cells["status_warga"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn = Koneksi.GetConnection();
            conn.Open();
            string sql = @"UPDATE tb_warga SET nik=@nik, nama=@nama, alamat=@alamat, no_hp=@hp, status_warga=@status WHERE id_warga=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nik", txtNik.Text);
            cmd.Parameters.AddWithValue("@nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
            cmd.Parameters.AddWithValue("@hp", txtHp.Text);
            cmd.Parameters.AddWithValue("@status", cboStatus.Text);
            cmd.Parameters.AddWithValue("@id", idWarga);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Berhasil Diubah");
            TampilData();
            Bersih();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult jawab = MessageBox.Show("Yakin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (jawab == DialogResult.Yes)
            {
                conn = Koneksi.GetConnection();
                conn.Open();
                string sql = "DELETE FROM tb_warga WHERE id_warga=@id";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idWarga);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Berhasil Dihapus");
                TampilData();
                Bersih();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Bersih();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            conn = Koneksi.GetConnection();
            da = new SqlDataAdapter("SELECT * FROM tb_warga WHERE nama LIKE '%" + txtCari.Text + "%'", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvWarga.DataSource = dt;
        }
    }
}
