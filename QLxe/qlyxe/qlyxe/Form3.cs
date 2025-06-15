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
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadBienSo();
            LoadMaGoi();
            LoadThoiGian();
        }

        private void LoadBienSo()
        {
            comboBox1.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT bienso FROM xe";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải biển số: " + ex.Message);
            }
        }

        private void LoadMaGoi()
        {
            comboBox2.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT magoi FROM goibaoduong";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải mã gói: " + ex.Message);
            }
        }

        private void LoadThoiGian()
        {
            comboBox3.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT thoigianbaoduong FROM chitiet"; // Đảm bảo cột này tồn tại
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime thoiGian = reader.GetDateTime(0); // xử lý kiểu datetime
                            comboBox3.Items.Add(thoiGian.ToString("dd/MM/yyyy HH:mm"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thời gian: " + ex.Message);
            }
        }

        private string LayTenKhachHang(string bienSo)
        {
            string hoTen = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT hotenhachhang FROM xe WHERE bienso = @BienSo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BienSo", bienSo);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                hoTen = reader.GetString(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy tên khách hàng: " + ex.Message);
            }
            return hoTen;
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            string BienSo = comboBox1.SelectedItem?.ToString();
            string MaGoi = comboBox2.SelectedItem?.ToString();
            string ThoiGian = comboBox3.SelectedItem?.ToString();
            string Sokm = txtSokm.Text.Trim();
            string GiaTien = txtGiaTien.Text.Trim();

            if (string.IsNullOrEmpty(BienSo) || string.IsNullOrEmpty(MaGoi) || string.IsNullOrEmpty(ThoiGian)
                || string.IsNullOrEmpty(Sokm) || string.IsNullOrEmpty(GiaTien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!double.TryParse(GiaTien, out double giaTien))
            {
                MessageBox.Show("Giá tiền không hợp lệ.");
                return;
            }

            string tenKH = LayTenKhachHang(BienSo);

            dataGridView1.Rows.Add(BienSo, tenKH, Sokm, ThoiGian, giaTien.ToString("N0"));
        }

        private void btnTinhTongTien_Click(object sender, EventArgs e)
        {
            double tongTien = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                // Cột "Giá tiền" là cột thứ 5 → index = 4
                if (row.Cells.Count > 4 && double.TryParse(row.Cells[4].Value?.ToString()?.Replace(",", ""), out double tien))
                {
                    tongTien += tien;
                }
            }

            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} VND";
        }


        private void thôngTinXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bienSo = comboBox1.SelectedItem?.ToString();
            string tenKH = LayTenKhachHang(bienSo);
            MessageBox.Show("Khách hàng: " + tenKH);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Logic xử lý chọn mã gói, nếu cần
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Logic xử lý chọn thời gian, nếu cần
        }

    }
}
