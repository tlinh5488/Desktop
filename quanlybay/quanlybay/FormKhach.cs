using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quanlybay
{
    public partial class FormKhach : Form
    {
        string connStr = "Data Source=J4F\\THUYLINH;Initial Catalog=quanlybay;Integrated Security=True;Encrypt=False";
        private string idKhach;

        public FormKhach(string idKhach)
        {
            InitializeComponent();
            this.idKhach = idKhach;
            this.Load += FormKhach_Load;
        }

        private void FormKhach_Load(object sender, EventArgs e)
        {
            LoadMaChuyenBay();
            LoadSoLuongVe();
        }

        private void LoadMaChuyenBay()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT machuyen, tenchuyenbay FROM chuyenbay";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbmachuyen.DisplayMember = "machuyen";
                cbmachuyen.ValueMember = "machuyen";
                cbmachuyen.DataSource = dt;

                cbmachuyen.SelectedIndexChanged += (s, ev) =>
                {
                    if (cbmachuyen.SelectedValue != null)
                    {
                        DataRowView drv = (DataRowView)cbmachuyen.SelectedItem;
                        txttenchuyenbay.Text = drv["tenchuyenbay"].ToString();
                    }
                };
            }
        }

        private void LoadSoLuongVe()
        {
            domainUpDown1.Items.Clear();
            for (int i = 1; i <= 10; i++)
                domainUpDown1.Items.Add(i.ToString());

            domainUpDown1.SelectedIndex = 0;
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (cbmachuyen.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã chuyến bay.");
                return;
            }

            string machuyen = cbmachuyen.SelectedValue.ToString();
            int soluong = int.Parse(domainUpDown1.Text);

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand getGiaTienCmd = new SqlCommand("SELECT giatien FROM datve WHERE machuyen = @machuyen", conn);
                getGiaTienCmd.Parameters.AddWithValue("@machuyen", machuyen);
                object gia = getGiaTienCmd.ExecuteScalar();

                if (gia == null)
                {
                    MessageBox.Show("Không tìm thấy giá tiền.");
                    return;
                }

                decimal giatien = Convert.ToDecimal(gia);

                for (int i = 0; i < soluong; i++)
                {
                    SqlCommand insertCmd = new SqlCommand(@"
                INSERT INTO datve (id, machuyen, giatien, thoigiandatve)
                VALUES (@id, @machuyen, @giatien, @thoigiandatve)", conn);

                    insertCmd.Parameters.AddWithValue("@id", idKhach);
                    insertCmd.Parameters.AddWithValue("@machuyen", machuyen);
                    insertCmd.Parameters.AddWithValue("@giatien", giatien);
                    insertCmd.Parameters.AddWithValue("@thoigiandatve", DateTime.Now);
                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đặt " + soluong + " vé thành công!");

                // ✅ Hiển thị tổng tiền sau khi đặt
                SqlCommand tongTienCmd = new SqlCommand("SELECT SUM(giatien) FROM datve WHERE id = @id", conn);
                tongTienCmd.Parameters.AddWithValue("@id", idKhach);
                object tong = tongTienCmd.ExecuteScalar();
                decimal tongTien = tong != DBNull.Value ? Convert.ToDecimal(tong) : 0;

                MessageBox.Show("Tổng tiền khách đã đặt là: " + tongTien.ToString("N0") + " VND", "Thông báo");
            }
        }


        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formDangNhap = new Form1();
            formDangNhap.Show();
        }
    }
}

