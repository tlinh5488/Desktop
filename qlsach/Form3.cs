using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace qlsach
{
    public partial class Form3 : Form
    {
        string connectionString = @"Data Source=J4F\THUYLINH;Initial Catalog=qlsach;Integrated Security=True;Encrypt=False";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT p.maphieumuon, t.masach, p.ngaymuon, p.ngaytra 
                                     FROM phieumuonsach p 
                                     INNER JOIN thongtinmuonsach t ON p.maphieumuon = t.maphieumuon";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = tbmaphieu.Text.Trim();
            string masach = tbmasach.Text.Trim();
            DateTime dmuon = dtmuon.Value;
            DateTime dtra = dttra.Value;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Kiểm tra phiếu mượn đã tồn tại chưa
                    SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM phieumuonsach WHERE maphieumuon = @id", con);
                    check.Parameters.AddWithValue("@id", id);
                    int exists = (int)check.ExecuteScalar();

                    if (exists == 0)
                    {
                        SqlCommand insertPhieu = new SqlCommand("INSERT INTO phieumuonsach (maphieumuon, ngaymuon, ngaytra) VALUES (@id, @muon, @tra)", con);
                        insertPhieu.Parameters.AddWithValue("@id", id);
                        insertPhieu.Parameters.AddWithValue("@muon", dmuon);
                        insertPhieu.Parameters.AddWithValue("@tra", dtra);
                        insertPhieu.ExecuteNonQuery();
                    }

                    SqlCommand checkDetail = new SqlCommand("SELECT COUNT(*) FROM thongtinmuonsach WHERE maphieumuon = @id AND masach = @masach", con);
                    checkDetail.Parameters.AddWithValue("@id", id);
                    checkDetail.Parameters.AddWithValue("@masach", masach);
                    int existDetail = (int)checkDetail.ExecuteScalar();

                    if (existDetail > 0)
                    {
                        MessageBox.Show("Bản ghi đã tồn tại trong chi tiết mượn sách.");
                    }
                    else
                    {
                        SqlCommand insertDetail = new SqlCommand("INSERT INTO thongtinmuonsach (maphieumuon, masach) VALUES (@id, @masach)", con);
                        insertDetail.Parameters.AddWithValue("@id", id);
                        insertDetail.Parameters.AddWithValue("@masach", masach);
                        insertDetail.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!");
                    }

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = tbmaphieu.Text.Trim();
            string masach = tbmasach.Text.Trim();
            DateTime dmuon = dtmuon.Value;
            DateTime dtra = dttra.Value;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Cập nhật bảng phieumuonsach (ngày mượn, ngày trả)
                    SqlCommand cmd = new SqlCommand("UPDATE phieumuonsach SET ngaymuon = @muon, ngaytra = @tra WHERE maphieumuon = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@muon", dmuon);
                    cmd.Parameters.AddWithValue("@tra", dtra);
                    cmd.ExecuteNonQuery();

                    // Cập nhật bảng thongtinmuonsach (mã sách)
                    SqlCommand cmd2 = new SqlCommand("UPDATE thongtinmuonsach SET masach = @masach WHERE maphieumuon = @id", con);
                    cmd2.Parameters.AddWithValue("@id", id);
                    cmd2.Parameters.AddWithValue("@masach", masach);
                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = tbmaphieu.Text.Trim();
            string masach = tbmasach.Text.Trim();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand deleteChiTiet = new SqlCommand("DELETE FROM thongtinmuonsach WHERE maphieumuon = @id AND masach = @masach", con);
                    deleteChiTiet.Parameters.AddWithValue("@id", id);
                    deleteChiTiet.Parameters.AddWithValue("@masach", masach);
                    deleteChiTiet.ExecuteNonQuery();

                    SqlCommand checkChiTiet = new SqlCommand("SELECT COUNT(*) FROM thongtinmuonsach WHERE maphieumuon = @id", con);
                    checkChiTiet.Parameters.AddWithValue("@id", id);
                    int count = (int)checkChiTiet.ExecuteScalar();

                    if (count == 0)
                    {
                        SqlCommand deletePhieu = new SqlCommand("DELETE FROM phieumuonsach WHERE maphieumuon = @id", con);
                        deletePhieu.Parameters.AddWithValue("@id", id);
                        deletePhieu.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xoá thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xoá: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                tbmaphieu.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                tbmasach.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                dtmuon.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[2].Value);
                dttra.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[3].Value);
            }
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            if (dataGridView1.AllowUserToAddRows) count -= 1;
            MessageBox.Show("Tổng số lượt mượn: " + count);
        }
    }
}
