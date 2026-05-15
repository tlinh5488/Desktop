using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLquanan
{
    public partial class Form2 : Form
    {
        String connectstring = "Data Source=J4F\\THUYLINH;Initial Catalog=QLquanan;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

            private void LoadData()
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectstring))
                    {
                        string query = "SELECT * FROM nhanvien";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message);
                }
            }

            private void btnhienthi_Click(object sender, EventArgs e)
            {
                LoadData();
            }

            private void btnthem_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtmanv.Text))
                {
                    MessageBox.Show("Vui lòng nhập biển số.");
                    return;
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectstring))
                    {
                        string query = "INSERT INTO nhanvien (manv, hoten, ngaysinh , diachi, sdt) VALUES (@manv, @hoten, @ngaysinh , @diachi, @sdt)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@manv", txtmanv.Text.Trim());
                        cmd.Parameters.AddWithValue("@hoten", txthoten.Text.Trim());
                        cmd.Parameters.AddWithValue("@ngaysinh", dtp1.Text.Trim());
                        cmd.Parameters.AddWithValue("@diachi", txtdiachi.Text.Trim());
                        cmd.Parameters.AddWithValue("@sdt", txtsdt.Text.Trim());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm nhân viên thành công!");
                        LoadData();
                        //ClearTextBoxes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message);
                }
            }

            private void btnsua_Click(object sender, EventArgs e)
            {
                //if (string.IsNullOrWhiteSpace(txtBienSo.Text))
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");
                    return;
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectstring))
                    {
                        string query = @"
                        UPDATE nhanvien
                        SET hoten = @hoten,
                            diachi = @diachi,
                            ngaysinh  = @ngaysinh ,
                            sdt = @sdt
                        WHERE manv = @manv";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@manv", txtmanv.Text.Trim());
                        cmd.Parameters.AddWithValue("@hoten", txthoten.Text.Trim());
                        cmd.Parameters.AddWithValue("@ngaysinh ", dtp1.Text.Trim());
                        cmd.Parameters.AddWithValue("@diachi", txtdiachi.Text.Trim());
                        cmd.Parameters.AddWithValue("@sdt", txtsdt.Text.Trim());

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            LoadData();
                           
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy xe để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message);
                }
            }

            private void btnxoa_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtmanv.Text))
                {
                    MessageBox.Show("Vui lòng chọn xe để xóa.");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có muốn xóa xe này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectstring))
                        {
                            string query = "DELETE FROM nhanvien WHERE manv = @manv";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@manv", txtmanv.Text.Trim());
                            conn.Open();
                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                                MessageBox.Show("Xóa thành công!");
                            else
                                MessageBox.Show("Không tìm thấy xe để xóa.");

                            LoadData();
                           
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                int i = e.RowIndex;
                if (i >= 0)
                {
                    txtmanv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();       
                    txthoten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();      
                    dtp1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();     
                    txtdiachi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();       
                    txtsdt.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();     

                }
            }


            private void label2_Click(object sender, EventArgs e)
            {

            }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void quảnLýMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.FormClosed += (s, args) => this.Show();
            form3.Show();
        }
    }
    }
