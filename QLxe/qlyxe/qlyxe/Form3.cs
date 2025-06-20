using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qlyxe
{
    public partial class Form3 : Form
    {
        private string connectionString = @"Data Source=J4F\THUYLINH;Initial Catalog=quanlyxe;Integrated Security=True;Encrypt=False";

        public Form3()
        {
            InitializeComponent();
            this.Load += Form3_Load;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadBienSo();
            LoadMaGoi();
            LoadChiTietTheoBienSo("");
        }

        private void LoadBienSo()
        {
            comboBox1.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT bienso FROM xe";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["bienso"].ToString());
                    }
                }
            }
        }

        private void LoadMaGoi()
        {
            comboBox2.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT magoi FROM goibaoduong";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader["magoi"].ToString());
                    }
                }
            }
        }

        private void LoadChiTietTheoBienSo(string bienSo)
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT c.bienso, x.hotenhachhang, c.sokmbaoduong, c.thoigianbaoduong, c.giatien FROM chitiet c JOIN xe x ON c.bienso = x.bienso"
                    + (!string.IsNullOrEmpty(bienSo) ? " WHERE c.bienso = @BienSo" : "");

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(bienSo))
                        cmd.Parameters.AddWithValue("@BienSo", bienSo);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bs = reader["bienso"].ToString();
                            string tenKH = reader["hotenhachhang"].ToString();
                            string sokm = reader["sokmbaoduong"].ToString();
                            string thoigian = reader["thoigianbaoduong"] != DBNull.Value ? Convert.ToDateTime(reader["thoigianbaoduong"]).ToString("dd/MM/yyyy HH:mm") : "";
                            string giatien = reader["giatien"] != DBNull.Value ? Convert.ToDouble(reader["giatien"]).ToString("N0") : "0";
                            dataGridView1.Rows.Add(bs, tenKH, sokm, thoigian, giatien);
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bienSo = comboBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(bienSo))
                LoadChiTietTheoBienSo(bienSo);
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            string BienSo = comboBox1.SelectedItem?.ToString();
            string MaGoi = comboBox2.SelectedItem?.ToString();
            string Sokm = txtSokm.Text.Trim();
            string GiaTienStr = txtGiaTien.Text.Trim();

            if (string.IsNullOrEmpty(BienSo) || string.IsNullOrEmpty(MaGoi) || string.IsNullOrEmpty(Sokm) || string.IsNullOrEmpty(GiaTienStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!double.TryParse(GiaTienStr.Replace(",", ""), out double GiaTien))
            {
                MessageBox.Show("Giá tiền không hợp lệ.");
                return;
            }

            DateTime ThoiGian = DateTime.Now;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string insertQuery = @"INSERT INTO chitiet (bienso, magoi, sokmbaoduong, thoigianbaoduong, giatien) VALUES (@BienSo, @MaGoi, @SoKm, @ThoiGian, @GiaTien)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@BienSo", BienSo);
                    cmd.Parameters.AddWithValue("@MaGoi", MaGoi);
                    cmd.Parameters.AddWithValue("@SoKm", Sokm);
                    cmd.Parameters.AddWithValue("@ThoiGian", ThoiGian);
                    cmd.Parameters.AddWithValue("@GiaTien", GiaTien);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadChiTietTheoBienSo(BienSo);
            MessageBox.Show("Thêm chi tiết thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa.");
                return;
            }

            string bienSo = comboBox1.SelectedItem?.ToString();
            string maGoi = comboBox2.SelectedItem?.ToString();
            string soKm = txtSokm.Text.Trim();
            string giaTienStr = txtGiaTien.Text.Trim();
            DateTime thoiGianMoi = dateTimePicker1.Value;

            if (string.IsNullOrEmpty(maGoi))
            {
                MessageBox.Show("Vui lòng chọn mã gói.");
                return;
            }

            if (!double.TryParse(giaTienStr.Replace(",", ""), out double giaTien))
            {
                MessageBox.Show("Giá tiền không hợp lệ.");
                return;
            }

            string thoiGianCuStr = dataGridView1.CurrentRow.Cells[3].Value?.ToString();
            if (!DateTime.TryParseExact(thoiGianCuStr, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime thoiGianCu))
            {
                MessageBox.Show("Lỗi định dạng thời gian cũ.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = @"UPDATE chitiet SET magoi = @MaGoi, sokmbaoduong = @SoKm, thoigianbaoduong = @ThoiGianMoi, giatien = @GiaTien WHERE bienso = @BienSo AND thoigianbaoduong = @ThoiGianCu";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MaGoi", maGoi);
                    cmd.Parameters.AddWithValue("@SoKm", soKm);
                    cmd.Parameters.AddWithValue("@ThoiGianMoi", thoiGianMoi);
                    cmd.Parameters.AddWithValue("@GiaTien", giaTien);
                    cmd.Parameters.AddWithValue("@BienSo", bienSo);
                    cmd.Parameters.AddWithValue("@ThoiGianCu", thoiGianCu);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cập nhật thành công!");
            LoadChiTietTheoBienSo(bienSo);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            string BienSo = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
            DateTime.TryParse(dataGridView1.CurrentRow.Cells[3].Value?.ToString(), out DateTime ThoiGian);

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mục này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string deleteQuery = @"DELETE FROM chitiet WHERE bienso = @BienSo AND thoigianbaoduong = @ThoiGian";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@BienSo", BienSo);
                    cmd.Parameters.AddWithValue("@ThoiGian", ThoiGian);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadChiTietTheoBienSo(BienSo);
            MessageBox.Show("Xóa thành công!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells.Count >= 5)
            {
                txtSokm.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
                txtGiaTien.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString();
            }
        }

        private void btnTinhTongTien_Click(object sender, EventArgs e)
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (double.TryParse(row.Cells[4].Value?.ToString()?.Replace(",", ""), out double tien))
                {
                    tongTien += tien;
                }
            }
            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} VND";
        }

        private void thôngTinXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
