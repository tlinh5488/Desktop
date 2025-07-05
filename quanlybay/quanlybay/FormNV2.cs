using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quanlybay
{
    public partial class formNV2 : Form
    {
        string connStr = "Data Source=J4F\\THUYLINH;Initial Catalog=quanlybay;Integrated Security=True;Encrypt=False";

        public formNV2()
        {
            InitializeComponent();
            this.Load += formNV2_Load; // Gắn sự kiện Load
        }

        private void formNV2_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT id, hoten FROM khach";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbkhach.DisplayMember = "hoten";
                cbkhach.ValueMember = "id";
                cbkhach.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    cbkhach.SelectedIndex = 0;
                }
            }
        }

        private void LoadVe()
        {
            if (cbkhach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = @"
                    SELECT DV.machuyen, CB.tenchuyenbay, DV.giatien, DV.thoigiandatve 
                    FROM datve DV 
                    JOIN chuyenbay CB ON DV.machuyen = CB.machuyen 
                    WHERE DV.id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", cbkhach.SelectedValue);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Debug: Hiển thị số dòng tìm thấy
                MessageBox.Show("Số vé tìm thấy: " + dt.Rows.Count);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadVe();
        }

        private void btnThemVe_Click(object sender, EventArgs e)
        {
            if (cbkhach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"
                    INSERT INTO datve (id, machuyen, giatien, thoigiandatve) 
                    VALUES (@id, @machuyen, @giatien, @thoigiandatve)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", cbkhach.SelectedValue);
                cmd.Parameters.AddWithValue("@machuyen", txtmachuyen.Text);
                cmd.Parameters.AddWithValue("@giatien", Convert.ToDecimal(txtgiatien.Text));
                cmd.Parameters.AddWithValue("@thoigiandatve", dtp1.Value);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đặt vé thành công!");
                    LoadVe(); // Hiển thị lại sau khi thêm
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi đặt vé: " + ex.Message);
                }
            }
        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            if (cbkhach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT SUM(giatien) FROM datve WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", cbkhach.SelectedValue);

                object result = cmd.ExecuteScalar();
                decimal tongTien = result == DBNull.Value ? 0 : Convert.ToDecimal(result);

                MessageBox.Show("Tổng tiền đã đặt vé của khách là: " + tongTien.ToString("N0") + " VND");
            }
        }

        private void thôngTinKháchĐặtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNV formDatVe = new FormNV();
            formDatVe.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formDangNhap = new Form1();
            formDangNhap.Show();
        }

        private void cbkhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bạn có thể load vé theo khách tự động tại đây nếu muốn
            // LoadVe();
        }
    }
}
