namespace qlsach
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trigia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbmasach = new System.Windows.Forms.TextBox();
            this.tbtensach = new System.Windows.Forms.TextBox();
            this.tbtacgia = new System.Windows.Forms.TextBox();
            this.tbnamxb = new System.Windows.Forms.TextBox();
            this.tbnxb = new System.Windows.Forms.TextBox();
            this.tbtrigia = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.cbloc = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnloc = new System.Windows.Forms.Button();
            this.btnre = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinSáchToolStripMenuItem,
            this.quảnLýMượnSáchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1153, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinSáchToolStripMenuItem
            // 
            this.thôngTinSáchToolStripMenuItem.Name = "thôngTinSáchToolStripMenuItem";
            this.thôngTinSáchToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.thôngTinSáchToolStripMenuItem.Text = "Thông tin sách";
            // 
            // quảnLýMượnSáchToolStripMenuItem
            // 
            this.quảnLýMượnSáchToolStripMenuItem.Name = "quảnLýMượnSáchToolStripMenuItem";
            this.quảnLýMượnSáchToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.quảnLýMượnSáchToolStripMenuItem.Text = "Quản lý mượn sách";
            this.quảnLýMượnSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMượnSáchToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.tensach,
            this.tacgia,
            this.namxuatban,
            this.nhaxuatban,
            this.trigia,
            this.ngaynhap});
            this.dataGridView1.Location = new System.Drawing.Point(12, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1129, 267);
            this.dataGridView1.TabIndex = 1;
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.MinimumWidth = 6;
            this.masach.Name = "masach";
            this.masach.Width = 125;
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "tensach";
            this.tensach.HeaderText = "Tên sách";
            this.tensach.MinimumWidth = 6;
            this.tensach.Name = "tensach";
            this.tensach.Width = 125;
            // 
            // tacgia
            // 
            this.tacgia.DataPropertyName = "tacgia";
            this.tacgia.HeaderText = "Tác giả";
            this.tacgia.MinimumWidth = 6;
            this.tacgia.Name = "tacgia";
            this.tacgia.Width = 125;
            // 
            // namxuatban
            // 
            this.namxuatban.DataPropertyName = "namxuatban";
            this.namxuatban.HeaderText = "Năm xuất bản";
            this.namxuatban.MinimumWidth = 6;
            this.namxuatban.Name = "namxuatban";
            this.namxuatban.Width = 125;
            // 
            // nhaxuatban
            // 
            this.nhaxuatban.DataPropertyName = "nhaxuatban";
            this.nhaxuatban.HeaderText = "NXB";
            this.nhaxuatban.MinimumWidth = 6;
            this.nhaxuatban.Name = "nhaxuatban";
            this.nhaxuatban.Width = 125;
            // 
            // trigia
            // 
            this.trigia.DataPropertyName = "trigia";
            this.trigia.HeaderText = "Trị giá";
            this.trigia.MinimumWidth = 6;
            this.trigia.Name = "trigia";
            this.trigia.Width = 125;
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.MinimumWidth = 6;
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(807, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Năm xuất bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "NXB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(810, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Trị giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ngày nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mã sách cần lọc";
            // 
            // tbmasach
            // 
            this.tbmasach.Location = new System.Drawing.Point(174, 89);
            this.tbmasach.Name = "tbmasach";
            this.tbmasach.Size = new System.Drawing.Size(107, 27);
            this.tbmasach.TabIndex = 11;
            // 
            // tbtensach
            // 
            this.tbtensach.Location = new System.Drawing.Point(408, 89);
            this.tbtensach.Name = "tbtensach";
            this.tbtensach.Size = new System.Drawing.Size(359, 27);
            this.tbtensach.TabIndex = 12;
            // 
            // tbtacgia
            // 
            this.tbtacgia.Location = new System.Drawing.Point(875, 89);
            this.tbtacgia.Name = "tbtacgia";
            this.tbtacgia.Size = new System.Drawing.Size(265, 27);
            this.tbtacgia.TabIndex = 13;
            // 
            // tbnamxb
            // 
            this.tbnamxb.Location = new System.Drawing.Point(174, 148);
            this.tbnamxb.Name = "tbnamxb";
            this.tbnamxb.Size = new System.Drawing.Size(107, 27);
            this.tbnamxb.TabIndex = 14;
            // 
            // tbnxb
            // 
            this.tbnxb.Location = new System.Drawing.Point(408, 145);
            this.tbnxb.Name = "tbnxb";
            this.tbnxb.Size = new System.Drawing.Size(359, 27);
            this.tbnxb.TabIndex = 15;
            // 
            // tbtrigia
            // 
            this.tbtrigia.Location = new System.Drawing.Point(875, 145);
            this.tbtrigia.Name = "tbtrigia";
            this.tbtrigia.Size = new System.Drawing.Size(265, 27);
            this.tbtrigia.TabIndex = 16;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(174, 201);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(593, 27);
            this.dtp1.TabIndex = 17;
            // 
            // cbloc
            // 
            this.cbloc.FormattingEnabled = true;
            this.cbloc.Location = new System.Drawing.Point(174, 249);
            this.cbloc.Name = "cbloc";
            this.cbloc.Size = new System.Drawing.Size(593, 27);
            this.cbloc.TabIndex = 18;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(100, 584);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(156, 39);
            this.btnthem.TabIndex = 19;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(476, 584);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(150, 39);
            this.btnsua.TabIndex = 20;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(875, 584);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(139, 39);
            this.btnxoa.TabIndex = 21;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnloc
            // 
            this.btnloc.Location = new System.Drawing.Point(849, 249);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(115, 27);
            this.btnloc.TabIndex = 22;
            this.btnloc.Text = "Lọc";
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnre
            // 
            this.btnre.Location = new System.Drawing.Point(1045, 248);
            this.btnre.Name = "btnre";
            this.btnre.Size = new System.Drawing.Size(95, 27);
            this.btnre.TabIndex = 23;
            this.btnre.Text = "Refresh";
            this.btnre.UseVisualStyleBackColor = true;
            this.btnre.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1153, 647);
            this.Controls.Add(this.btnre);
            this.Controls.Add(this.btnloc);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbloc);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.tbtrigia);
            this.Controls.Add(this.tbnxb);
            this.Controls.Add(this.tbnamxb);
            this.Controls.Add(this.tbtacgia);
            this.Controls.Add(this.tbtensach);
            this.Controls.Add(this.tbmasach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Thông Tin Sách";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnSáchToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn namxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn trigia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbmasach;
        private System.Windows.Forms.TextBox tbtensach;
        private System.Windows.Forms.TextBox tbtacgia;
        private System.Windows.Forms.TextBox tbnamxb;
        private System.Windows.Forms.TextBox tbnxb;
        private System.Windows.Forms.TextBox tbtrigia;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.ComboBox cbloc;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.Button btnre;
    }
}