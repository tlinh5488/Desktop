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

namespace QLNV
{
    public partial class Form1 : Form
    {
        String connectstring = "Data Source=J4F\\THUYLINH;Initial Catalog=QLNV;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
     
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
        }
        private void cmd_OK_Click(object sender, EventArgs e)
        {
            // Lấy thông tin người dùng nhập từ giao diện
            string username = txtUser.Text.Trim(); // txtUsername là TextBox người dùng nhập tên đăng nhập
            string password = txtPass.Text.Trim(); // txtPassword là TextBox người dùng nhập mật khẩu

            try
            {
                con.Open(); // Mở kết nối SQL

                // Câu truy vấn kiểm tra thông tin đăng nhập
                string query = "SELECT COUNT(*) FROM account WHERE username = @username AND password = @password";

                using (SqlCommand cmd_OK = new SqlCommand(query, con))
                {
                    // Truyền tham số để tránh SQL Injection
                    cmd_OK.Parameters.AddWithValue("@username", username);
                    cmd_OK.Parameters.AddWithValue("@password", password);

                    int result = (int)cmd_OK.ExecuteScalar(); // Trả về số dòng thỏa mãn điều kiện

                    if (result > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        // TODO: Chuyển sang form chính hoặc thực hiện hành động tiếp theo
                        Form2 f2 = new Form2();
                        this.Hide();
                        f2.ShowDialog();
                        this.Show();
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
                con.Close(); // Đóng kết nối SQL
            }
        }

    }
}
