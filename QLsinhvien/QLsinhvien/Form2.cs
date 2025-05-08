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
    public partial class Form2 : Form
    {
        String connectstring = "Data Source=J4F\\THUYLINH;Initial Catalog=QLsinhvien;Integrated Security=True;Encrypt=False";

        public Form2()
        {
            InitializeComponent();
            //this.Load += new EventHandler(Form2_Load);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiMonHoc();
        }

        private void HienThiMonHoc()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    string query = @"
                SELECT 
                    sv.MaSo,
                    sv.HoTen,
                    sv.NgaySinh,
                    sv.GioiTinh,
                    k.TenKhoa,
                    mh.TenMH,
                    sv.DiaChi,
                    sv.DienThoai,
                    mh.SoTiet
                FROM SinhVien AS sv
                JOIN MonHoc AS mh ON sv.MaMH = mh.MaMH
                JOIN Khoa AS k ON sv.MaKhoa = k.MaKhoa";


                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    MessageBox.Show("Số dòng lấy được: " + dt.Rows.Count.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }


        
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();

                    string query = @"
                SELECT 
                    sv.MaSo,
                    sv.HoTen,
                    sv.NgaySinh,
                    sv.GioiTinh,
                     k.TenKhoa,
                    mh.TenMH,
                    sv.DiaChi,
                    sv.DienThoai,
                    mh.SoTiet
                FROM SinhVien sv
                JOIN Khoa k ON sv.MaKhoa = k.MaKhoa
                JOIN MonHoc mh ON sv.MaMH = mh.MaMH
                WHERE sv.MaSo LIKE '%' + @maso + '%'
            ";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@maso", cboMaSo.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Tìm thấy " + dt.Rows.Count.ToString() + " sinh viên.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tra cứu: " + ex.Message);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void danhMụcCácMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();  // tạo đối tượng form 3
            f3.ShowDialog();         // mở form dưới dạng hộp thoại (modal)
        }

    }
}
