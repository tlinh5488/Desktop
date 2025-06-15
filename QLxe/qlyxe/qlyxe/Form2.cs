using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qlyxe
{
    public partial class Form2 : Form
    {
        string connectionString = @"Data Source=J4F\THUYLINH;Initial Catalog=quanlyxe;Integrated Security=True;Encrypt=False";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM xe";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message);
            }
        }

        private void ClearTextBoxes()
        {
            txtBienSo.Clear();
            txtHoTenKH.Clear();
            txtNhanHieu.Clear();
            txtDiaChi.Clear();
            txtGioiTinh.Clear();
            txtBienSo.Enabled = true;
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBienSo.Text))
            {
                MessageBox.Show("Vui lòng nhập biển số.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO xe (bienso, hotenhachhang, nhanhieu, diachi, gioitinh) VALUES (@BienSo, @TenKH, @NhanHieu, @DiaChi, @GioiTinh)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BienSo", txtBienSo.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenKH", txtHoTenKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@NhanHieu", txtNhanHieu.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm xe thành công!");
                    LoadData();
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message);
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBienSo.Text))
            {
                MessageBox.Show("Vui lòng chọn một xe để sửa.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        UPDATE xe
                        SET hotenhachhang = @TenKH,
                            nhanhieu = @NhanHieu,
                            diachi = @DiaChi,
                            gioitinh = @GioiTinh
                        WHERE bienso = @BienSo";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BienSo", txtBienSo.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenKH", txtHoTenKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@NhanHieu", txtNhanHieu.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text.Trim());

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadData();
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy xe để cập nhật.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBienSo.Text))
            {
                MessageBox.Show("Vui lòng chọn xe để xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa xe này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM xe WHERE bienso = @BienSo";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@BienSo", txtBienSo.Text.Trim());
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                            MessageBox.Show("Xóa thành công!");
                        else
                            MessageBox.Show("Không tìm thấy xe để xóa.");

                        LoadData();
                        ClearTextBoxes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtBienSo.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();       // bienso
                txtHoTenKH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();      // hotenhachhang
                txtNhanHieu.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();     // nhanhieu
                txtDiaChi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();       // diachi
                txtGioiTinh.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();     // gioitinh

                txtBienSo.Enabled = false; // khóa khóa chính khi sửa
            }
        }


        private void thôngTinBảoDưỡngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.FormClosed += (s, args) => this.Show(); // hiện lại form2 khi form3 đóng
            form3.Show();
        }
    }
}
