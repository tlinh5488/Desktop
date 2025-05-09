using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLcanbo
{
    public partial class Form3 : Form
    {
        private string connectstring = "Data Source=J4F\\THUYLINH;Initial Catalog=QLcanbo;Integrated Security=True;Encrypt=False";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadDonVi();
            TinhTongLuong();
        }

        private void LoadDonVi()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    string query = "SELECT * FROM DonVi";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách đơn vị: " + ex.Message);
            }
        }

        private void TinhTongLuong()
        {
            using (SqlConnection con = new SqlConnection(connectstring))
            {
                string query = "SELECT SUM(CAST(HeSoLuong AS FLOAT)) FROM CanBo";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    double tongHeSo = Convert.ToDouble(result);
                    double tongLuong = tongHeSo * 2500000;
                    lblTongLuong.Text = "Tổng lương cán bộ: " + tongLuong.ToString("N0") + " VND";
                }
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            TinhTongLuong();
        }

        private void lblTongLuong_Click(object sender, EventArgs e)
        {

        }
    }
}
