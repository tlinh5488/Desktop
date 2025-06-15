namespace qlyxe
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.txtNhanHieu = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinBảoDưỡngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnhienthi
            // 
            this.btnhienthi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhienthi.Location = new System.Drawing.Point(53, 86);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(102, 37);
            this.btnhienthi.TabIndex = 0;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(53, 180);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(102, 37);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.Location = new System.Drawing.Point(53, 277);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(102, 37);
            this.btncapnhat.TabIndex = 2;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(53, 369);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(102, 35);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BienSo,
            this.HoTenKH,
            this.NhanHieu,
            this.DiaChi,
            this.GioiTinh});
            this.dataGridView1.Location = new System.Drawing.Point(239, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(823, 136);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BienSo
            // 
            this.BienSo.DataPropertyName = "bienso";
            this.BienSo.HeaderText = "Biển số";
            this.BienSo.MinimumWidth = 6;
            this.BienSo.Name = "BienSo";
            this.BienSo.Width = 125;
            // 
            // HoTenKH
            // 
            this.HoTenKH.DataPropertyName = "hotenhachhang";
            this.HoTenKH.HeaderText = "Họ tên KH";
            this.HoTenKH.MinimumWidth = 6;
            this.HoTenKH.Name = "HoTenKH";
            this.HoTenKH.Width = 125;
            // 
            // NhanHieu
            // 
            this.NhanHieu.DataPropertyName = "nhanhieu";
            this.NhanHieu.HeaderText = "Nhãn hiệu";
            this.NhanHieu.MinimumWidth = 6;
            this.NhanHieu.Name = "NhanHieu";
            this.NhanHieu.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "diachi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "gioitinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "THÔNG TIN XE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ tên KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(678, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Biển số";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(678, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nhãn hiệu";
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(347, 89);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(228, 22);
            this.txtHoTenKH.TabIndex = 12;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(347, 148);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(228, 22);
            this.txtGioiTinh.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(347, 209);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(641, 22);
            this.txtDiaChi.TabIndex = 14;
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(775, 89);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(213, 22);
            this.txtBienSo.TabIndex = 15;
            // 
            // txtNhanHieu
            // 
            this.txtNhanHieu.Location = new System.Drawing.Point(775, 148);
            this.txtNhanHieu.Name = "txtNhanHieu";
            this.txtNhanHieu.Size = new System.Drawing.Size(213, 22);
            this.txtNhanHieu.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinXeToolStripMenuItem,
            this.thôngTinBảoDưỡngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinXeToolStripMenuItem
            // 
            this.thôngTinXeToolStripMenuItem.Name = "thôngTinXeToolStripMenuItem";
            this.thôngTinXeToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.thôngTinXeToolStripMenuItem.Text = "Thông tin xe";
            // 
            // thôngTinBảoDưỡngToolStripMenuItem
            // 
            this.thôngTinBảoDưỡngToolStripMenuItem.Name = "thôngTinBảoDưỡngToolStripMenuItem";
            this.thôngTinBảoDưỡngToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.thôngTinBảoDưỡngToolStripMenuItem.Text = "Thông tin bảo dưỡng";
            this.thôngTinBảoDưỡngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinBảoDưỡngToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1089, 444);
            this.Controls.Add(this.txtNhanHieu);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtHoTenKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.TextBox txtNhanHieu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinBảoDưỡngToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
    }
}