namespace quanlybay
{
    partial class formNV2
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
            this.thôngTinKháchĐặtVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinĐặtVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbkhach = new System.Windows.Forms.ComboBox();
            this.txtmachuyen = new System.Windows.Forms.TextBox();
            this.txtgiatien = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btnthemve = new System.Windows.Forms.Button();
            this.btntongtien = new System.Windows.Forms.Button();
            this.machuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchuyenbay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigiandatve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchĐặtVéToolStripMenuItem,
            this.thôngTinĐặtVéToolStripMenuItem,
            this.khácToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinKháchĐặtVéToolStripMenuItem
            // 
            this.thôngTinKháchĐặtVéToolStripMenuItem.Name = "thôngTinKháchĐặtVéToolStripMenuItem";
            this.thôngTinKháchĐặtVéToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.thôngTinKháchĐặtVéToolStripMenuItem.Text = "Thông tin khách đặt vé ";
            this.thôngTinKháchĐặtVéToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchĐặtVéToolStripMenuItem_Click);
            // 
            // thôngTinĐặtVéToolStripMenuItem
            // 
            this.thôngTinĐặtVéToolStripMenuItem.Name = "thôngTinĐặtVéToolStripMenuItem";
            this.thôngTinĐặtVéToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.thôngTinĐặtVéToolStripMenuItem.Text = "Thông tin đặt vé";
            // 
            // khácToolStripMenuItem
            // 
            this.khácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.khácToolStripMenuItem.Name = "khácToolStripMenuItem";
            this.khácToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.khácToolStripMenuItem.Text = "Khác";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machuyen,
            this.tenchuyenbay,
            this.giatien,
            this.thoigiandatve});
            this.dataGridView1.Location = new System.Drawing.Point(12, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(832, 205);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ ĐẶT VÉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã chuyến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thời gian đặt";
            // 
            // cbkhach
            // 
            this.cbkhach.FormattingEnabled = true;
            this.cbkhach.Location = new System.Drawing.Point(203, 84);
            this.cbkhach.Name = "cbkhach";
            this.cbkhach.Size = new System.Drawing.Size(372, 24);
            this.cbkhach.TabIndex = 7;
            this.cbkhach.SelectedIndexChanged += new System.EventHandler(this.cbkhach_SelectedIndexChanged);
            // 
            // txtmachuyen
            // 
            this.txtmachuyen.Location = new System.Drawing.Point(203, 137);
            this.txtmachuyen.Name = "txtmachuyen";
            this.txtmachuyen.Size = new System.Drawing.Size(372, 22);
            this.txtmachuyen.TabIndex = 8;
            // 
            // txtgiatien
            // 
            this.txtgiatien.Location = new System.Drawing.Point(203, 186);
            this.txtgiatien.Name = "txtgiatien";
            this.txtgiatien.Size = new System.Drawing.Size(372, 22);
            this.txtgiatien.TabIndex = 9;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(203, 232);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(372, 22);
            this.dtp1.TabIndex = 10;
            // 
            // btnhienthi
            // 
            this.btnhienthi.BackColor = System.Drawing.Color.LightCoral;
            this.btnhienthi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhienthi.Location = new System.Drawing.Point(635, 84);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(174, 45);
            this.btnhienthi.TabIndex = 11;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = false;
            this.btnhienthi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnthemve
            // 
            this.btnthemve.BackColor = System.Drawing.Color.LightCoral;
            this.btnthemve.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemve.Location = new System.Drawing.Point(635, 176);
            this.btnthemve.Name = "btnthemve";
            this.btnthemve.Size = new System.Drawing.Size(174, 42);
            this.btnthemve.TabIndex = 12;
            this.btnthemve.Text = "Thêm vé";
            this.btnthemve.UseVisualStyleBackColor = false;
            this.btnthemve.Click += new System.EventHandler(this.btnThemVe_Click);
            // 
            // btntongtien
            // 
            this.btntongtien.BackColor = System.Drawing.Color.LightCoral;
            this.btntongtien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntongtien.Location = new System.Drawing.Point(312, 505);
            this.btntongtien.Name = "btntongtien";
            this.btntongtien.Size = new System.Drawing.Size(210, 41);
            this.btntongtien.TabIndex = 13;
            this.btntongtien.Text = "Tổng tiền";
            this.btntongtien.UseVisualStyleBackColor = false;
            this.btntongtien.Click += new System.EventHandler(this.btnTongTien_Click);
            // 
            // machuyen
            // 
            this.machuyen.DataPropertyName = "machuyen";
            this.machuyen.HeaderText = "Mã chuyến";
            this.machuyen.MinimumWidth = 6;
            this.machuyen.Name = "machuyen";
            this.machuyen.Width = 125;
            // 
            // tenchuyenbay
            // 
            this.tenchuyenbay.DataPropertyName = "tenchuyenbay";
            this.tenchuyenbay.HeaderText = "Tên chuyến bay";
            this.tenchuyenbay.MinimumWidth = 6;
            this.tenchuyenbay.Name = "tenchuyenbay";
            this.tenchuyenbay.Width = 200;
            // 
            // giatien
            // 
            this.giatien.DataPropertyName = "giatien";
            this.giatien.HeaderText = "Giá tiền";
            this.giatien.MinimumWidth = 6;
            this.giatien.Name = "giatien";
            this.giatien.Width = 125;
            // 
            // thoigiandatve
            // 
            this.thoigiandatve.DataPropertyName = "thoigiandatve";
            this.thoigiandatve.HeaderText = "Thời gian đặt vé";
            this.thoigiandatve.MinimumWidth = 6;
            this.thoigiandatve.Name = "thoigiandatve";
            this.thoigiandatve.Width = 200;
            // 
            // formNV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(856, 569);
            this.Controls.Add(this.btntongtien);
            this.Controls.Add(this.btnthemve);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.txtgiatien);
            this.Controls.Add(this.txtmachuyen);
            this.Controls.Add(this.cbkhach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formNV2";
            this.Text = "FormNV2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchĐặtVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinĐặtVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbkhach;
        private System.Windows.Forms.TextBox txtmachuyen;
        private System.Windows.Forms.TextBox txtgiatien;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btnthemve;
        private System.Windows.Forms.Button btntongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn machuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchuyenbay;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatien;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigiandatve;
    }
}