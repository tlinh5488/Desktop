using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quanlybay
{
    public partial class Form1 : Form
    {
        string connectstring = "Data Source=J4F\\THUYLINH;Initial Catalog=quanlybay;Integrated Security=True;Encrypt=False";
        SqlConnection con;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
            string username = tbtemail.Text.Trim();
            string password = tbtpass.Text.Trim();

            try
            {
                con.Open();

                // Lấy quyền truy cập
                string query = "SELECT quyentruycap FROM nhanvien WHERE email = @email AND matkhau = @matkhau";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", username);
                    cmd.Parameters.AddWithValue("@matkhau", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string quyen = result.ToString().Trim().ToLower();

                        if (quyen == "nhân viên")
                        {
                            MessageBox.Show("Nhân viên: Đăng nhập thành công!");
                            FormNV fnv = new FormNV();
                            this.Hide();
                            fnv.ShowDialog();
                            this.Show();
                        }
                        else if (quyen == "khách")
                        {
                            // Truy vấn mã khách hàng
                            string queryId = "SELECT manv FROM nhanvien WHERE email = @email AND matkhau = @matkhau";
                            using (SqlCommand cmdId = new SqlCommand(queryId, con))
                            {
                                cmdId.Parameters.AddWithValue("@email", username);
                                cmdId.Parameters.AddWithValue("@matkhau", password);

                                object idObj = cmdId.ExecuteScalar();
                                if (idObj != null)
                                {
                                    string idKhach = idObj.ToString(); // giữ kiểu string
                                    MessageBox.Show("Khách: Đăng nhập thành công!");
                                    FormKhach fkhach = new FormKhach(idKhach);
                                    this.Hide();
                                    fkhach.ShowDialog();
                                    this.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy thông tin khách hàng.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Quyền truy cập không hợp lệ.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc truy vấn SQL: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
