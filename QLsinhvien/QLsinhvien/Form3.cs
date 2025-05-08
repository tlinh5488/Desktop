using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QLsinhvien
{
    public partial class Form3 : Form
    {
        
        string connectstring = "Data Source=J4F\\THUYLINH;Initial Catalog=QLsinhvien;Integrated Security=True;Encrypt=False";
        public Form3()
        {
            InitializeComponent();
        }


        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadMonHoc();
            TinhTongSoTiet();
        }

        private void LoadMonHoc()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    string query = "SELECT MaMH, TenMH, SoTiet FROM MonHoc";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải môn học: " + ex.Message);
            }
        }

        private void TinhTongSoTiet()
        {
            int tong = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["SoTiet"].Value != DBNull.Value && row.Cells["SoTiet"].Value != null)
                {
                    tong += Convert.ToInt32(row.Cells["SoTiet"].Value);
                }
            }

            lblTongSoTiet.Text = "Tổng số tiết: " + tong.ToString();
        }

        private void lblTongSoTiet_Click(object sender, EventArgs e)
        {
            
        }
    }
}
