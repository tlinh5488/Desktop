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

namespace qlsach
{ 
    public partial class Form1 : Form
    {
        String connectstring = "Data Source=J4F\\THUYLINH;Initial Catalog=qlsach;Integrated Security=True;Encrypt=False";
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            try
            {
                con.Open();


                string query = "SELECT COUNT(*) FROM account WHERE username = @username AND pass = @pass";

                using (SqlCommand btnLogin = new SqlCommand(query, con))
                {

                    btnLogin.Parameters.AddWithValue("@username", username);
                    btnLogin.Parameters.AddWithValue("@pass", pass);

                    int result = (int)btnLogin.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!");

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