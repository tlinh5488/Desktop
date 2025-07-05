using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quanlybay
{
    public partial class FormNV : Form
    {
        string connectionString = "Data Source=J4F\\THUYLINH;Initial Catalog=quanlybay;Integrated Security=True;Encrypt=False";

        public FormNV()
        {
            InitializeComponent();
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            // KHÔNG gọi LoadData ở đây để khi vừa đăng nhập thì KHÔNG thấy dữ liệu khách
            dataGridView1.CellClick += dataGridView1_CellClick; // đăng ký sự kiện click
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM khach";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO khach (id, hoten, gioitinh, ngaysinh, diachi) VALUES (@id, @hoten, @gioitinh, @ngaysinh, @diachi)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", tbid.Text.Trim());
                    cmd.Parameters.AddWithValue("@hoten", tbhoten.Text.Trim());
                    cmd.Parameters.AddWithValue("@gioitinh", tbgt.Text.Trim());
                    cmd.Parameters.AddWithValue("@ngaysinh", dtp1.Value);
                    cmd.Parameters.AddWithValue("@diachi", tbdiachi.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                LoadData();
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE khach SET hoten = @hoten, gioitinh = @gioitinh, ngaysinh = @ngaysinh, diachi = @diachi WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", tbid.Text.Trim());
                    cmd.Parameters.AddWithValue("@hoten", tbhoten.Text.Trim());
                    cmd.Parameters.AddWithValue("@gioitinh", tbgt.Text.Trim());
                    cmd.Parameters.AddWithValue("@ngaysinh", dtp1.Value);
                    cmd.Parameters.AddWithValue("@diachi", tbdiachi.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                LoadData();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM khach WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", tbid.Text.Trim());

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    LoadData();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                tbid.Text = row.Cells["id"].Value.ToString();
                tbhoten.Text = row.Cells["hoten"].Value.ToString();
                tbgt.Text = row.Cells["gioitinh"].Value.ToString();
                dtp1.Value = Convert.ToDateTime(row.Cells["ngaysinh"].Value);
                tbdiachi.Text = row.Cells["diachi"].Value.ToString();
            }
        }

        private void thôngTinĐặtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNV2 formDatVe = new formNV2(); // Khởi tạo form thông tin đặt vé
            formDatVe.ShowDialog(); // Mở form ở chế độ modal (chặn form hiện tại)
        }


        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn FormNV hiện tại
            Form1 formDangNhap = new Form1(); // Quay về form đăng nhập
            formDangNhap.Show();
        }

    }
}
