namespace qlyxe
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinBảoDưỡngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtSokm = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnTinhTongTien = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sokm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinXeToolStripMenuItem,
            this.thôngTinBảoDưỡngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinXeToolStripMenuItem
            // 
            this.thôngTinXeToolStripMenuItem.Name = "thôngTinXeToolStripMenuItem";
            this.thôngTinXeToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.thôngTinXeToolStripMenuItem.Text = "Thông tin xe";
            this.thôngTinXeToolStripMenuItem.Click += new System.EventHandler(this.thôngTinXeToolStripMenuItem_Click);
            // 
            // thôngTinBảoDưỡngToolStripMenuItem
            // 
            this.thôngTinBảoDưỡngToolStripMenuItem.Name = "thôngTinBảoDưỡngToolStripMenuItem";
            this.thôngTinBảoDưỡngToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.thôngTinBảoDưỡngToolStripMenuItem.Text = "Thông tin bảo dưỡng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN BẢO DƯỠNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Biển số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã gói";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 418);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giá tiền";
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiTiet.Location = new System.Drawing.Point(159, 561);
            this.btnThemChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(194, 46);
            this.btnThemChiTiet.TabIndex = 6;
            this.btnThemChiTiet.Text = "Thêm chi tiết";
            this.btnThemChiTiet.UseVisualStyleBackColor = true;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(205, 412);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(354, 22);
            this.txtGiaTien.TabIndex = 7;
            // 
            // txtSokm
            // 
            this.txtSokm.Location = new System.Drawing.Point(205, 363);
            this.txtSokm.Margin = new System.Windows.Forms.Padding(4);
            this.txtSokm.Name = "txtSokm";
            this.txtSokm.Size = new System.Drawing.Size(354, 22);
            this.txtSokm.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BienSo,
            this.HoTen,
            this.Sokm,
            this.ThoiGian,
            this.GiaTien});
            this.dataGridView1.Location = new System.Drawing.Point(16, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(917, 149);
            this.dataGridView1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 465);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thời gian";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(16, 516);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(76, 17);
            this.lblTongTien.TabIndex = 13;
            this.lblTongTien.Text = "Tổng tiền:";
            this.lblTongTien.Click += new System.EventHandler(this.btnTinhTongTien_Click);
            // 
            // btnTinhTongTien
            // 
            this.btnTinhTongTien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTongTien.Location = new System.Drawing.Point(528, 561);
            this.btnTinhTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinhTongTien.Name = "btnTinhTongTien";
            this.btnTinhTongTien.Size = new System.Drawing.Size(210, 46);
            this.btnTinhTongTien.TabIndex = 15;
            this.btnTinhTongTien.Text = "Tính tổng tiền";
            this.btnTinhTongTien.UseVisualStyleBackColor = true;
            this.btnTinhTongTien.Click += new System.EventHandler(this.btnTinhTongTien_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "78-A10512 ",
            "77-L15485 "});
            this.comboBox1.Location = new System.Drawing.Point(189, 87);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(744, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "N01",
            "N02"});
            this.comboBox2.Location = new System.Drawing.Point(205, 313);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(569, 24);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "13/06/2025",
            "14/06/2025"});
            this.comboBox3.Location = new System.Drawing.Point(205, 458);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(569, 24);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // BienSo
            // 
            this.BienSo.DataPropertyName = "bienso";
            this.BienSo.HeaderText = "Biển số";
            this.BienSo.MinimumWidth = 6;
            this.BienSo.Name = "BienSo";
            this.BienSo.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "hotenhachhang";
            this.HoTen.HeaderText = "Họ tên KH";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // Sokm
            // 
            this.Sokm.DataPropertyName = "sokm";
            this.Sokm.HeaderText = "Số km";
            this.Sokm.MinimumWidth = 6;
            this.Sokm.Name = "Sokm";
            this.Sokm.Width = 125;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "thoigianbaoduong";
            this.ThoiGian.HeaderText = "Thời gian bảo dưỡng";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Width = 125;
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "giatien";
            this.GiaTien.HeaderText = "Giá tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(974, 620);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnTinhTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSokm);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.btnThemChiTiet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinBảoDưỡngToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtSokm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnTinhTongTien;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sokm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
    }
}