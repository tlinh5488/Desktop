using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qlsach
{
    public partial class Form2 : Form
    {
        string connectstring = "Data Source=J4F\\THUYLINH;Initial Catalog=qlsach;Integrated Security=True;Encrypt=False";
        SqlConnection con;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
            LoadData();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void LoadData()
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                string query = "SELECT * FROM sach";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                // Cập nhật combobox lọc
                cbloc.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string masach = row["masach"].ToString();
                    if (!cbloc.Items.Contains(masach))
                        cbloc.Items.Add(masach);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbnamxb.Text, out int namXB))
            {
                MessageBox.Show("Năm xuất bản phải là số nguyên.");
                return;
            }

            if (!float.TryParse(tbtrigia.Text, out float triGia))
            {
                MessageBox.Show("Trị giá phải là số.");
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                // Kiểm tra trùng mã sách
                string checkQuery = "SELECT COUNT(*) FROM sach WHERE masach = @masach";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@masach", tbmasach.Text);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Mã sách đã tồn tại. Không thể thêm trùng.");
                    return;
                }

                // Thêm sách
                string query = "INSERT INTO sach (masach, tensach, tacgia, namxuatban, nhaxuatban, trigia, ngaynhap) " +
                               "VALUES (@masach, @tensach, @tacgia, @namxuatban, @nhaxuatban, @trigia, @ngaynhap)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@masach", tbmasach.Text);
                cmd.Parameters.AddWithValue("@tensach", tbtensach.Text);
                cmd.Parameters.AddWithValue("@tacgia", tbtacgia.Text);
                cmd.Parameters.Add("@namxuatban", SqlDbType.Int).Value = namXB;
                cmd.Parameters.AddWithValue("@nhaxuatban", tbnxb.Text);
                cmd.Parameters.Add("@trigia", SqlDbType.Float).Value = triGia;
                cmd.Parameters.AddWithValue("@ngaynhap", dtp1.Value.Date);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbnamxb.Text, out int namXB))
            {
                MessageBox.Show("Năm xuất bản phải là số nguyên.");
                return;
            }

            if (!float.TryParse(tbtrigia.Text, out float triGia))
            {
                MessageBox.Show("Trị giá phải là số.");
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                string query = "UPDATE sach SET tensach=@tensach, tacgia=@tacgia, namxuatban=@namxuatban, nhaxuatban=@nhaxuatban, trigia=@trigia, ngaynhap=@ngaynhap WHERE masach=@masach";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@masach", tbmasach.Text);
                cmd.Parameters.AddWithValue("@tensach", tbtensach.Text);
                cmd.Parameters.AddWithValue("@tacgia", tbtacgia.Text);
                cmd.Parameters.Add("@namxuatban", SqlDbType.Int).Value = namXB;
                cmd.Parameters.AddWithValue("@nhaxuatban", tbnxb.Text);
                cmd.Parameters.Add("@trigia", SqlDbType.Float).Value = triGia;
                cmd.Parameters.AddWithValue("@ngaynhap", dtp1.Value.Date);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    string query = "DELETE FROM sach WHERE masach=@masach";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@masach", tbmasach.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open) con.Close();
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                string query = "SELECT * FROM sach WHERE masach = @masach";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@masach", cbloc.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbmasach.Text = row.Cells["masach"].Value.ToString();
                tbtensach.Text = row.Cells["tensach"].Value.ToString();
                tbtacgia.Text = row.Cells["tacgia"].Value.ToString();
                tbnamxb.Text = row.Cells["namxuatban"].Value.ToString();
                tbnxb.Text = row.Cells["nhaxuatban"].Value.ToString();
                tbtrigia.Text = row.Cells["trigia"].Value.ToString();
                dtp1.Value = Convert.ToDateTime(row.Cells["ngaynhap"].Value);
            }
        }

        private void quảnLýMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }
    }
}
