namespace Login
{
    partial class SinhVien
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbtimkiemgv = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dgvdanhsachhocsinh = new System.Windows.Forms.DataGridView();
            this.gbthongtinhocsinh = new System.Windows.Forms.GroupBox();
            this.cmbGiaoVien = new System.Windows.Forms.ComboBox();
            this.txthocluc = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txthanhkiem = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.cmblop = new System.Windows.Forms.ComboBox();
            this.rdbnu = new System.Windows.Forms.RadioButton();
            this.radbnam = new System.Windows.Forms.RadioButton();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmahs = new System.Windows.Forms.TextBox();
            this.lblgiaovienchunhiem = new System.Windows.Forms.Label();
            this.lblchucvu = new System.Windows.Forms.Label();
            this.lblhanhkiem = new System.Windows.Forms.Label();
            this.lbllop = new System.Windows.Forms.Label();
            this.lblhocluc = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblmahocsinh = new System.Windows.Forms.Label();
            this.lbltieude = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbtimkiemgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachhocsinh)).BeginInit();
            this.gbthongtinhocsinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(796, 341);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 30);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Location = new System.Drawing.Point(706, 341);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 30);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Location = new System.Drawing.Point(611, 341);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 30);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // gbtimkiemgv
            // 
            this.gbtimkiemgv.Controls.Add(this.btntimkiem);
            this.gbtimkiemgv.Controls.Add(this.txttimkiem);
            this.gbtimkiemgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtimkiemgv.Location = new System.Drawing.Point(63, 291);
            this.gbtimkiemgv.Name = "gbtimkiemgv";
            this.gbtimkiemgv.Size = new System.Drawing.Size(535, 44);
            this.gbtimkiemgv.TabIndex = 22;
            this.gbtimkiemgv.TabStop = false;
            this.gbtimkiemgv.Text = "tìm kiếm";
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btntimkiem.Location = new System.Drawing.Point(370, 15);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 1;
            this.btntimkiem.Text = "tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(6, 16);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(358, 22);
            this.txttimkiem.TabIndex = 0;
            this.txttimkiem.Text = "Nhập vào nội dung cần tìm.......";
            // 
            // dgvdanhsachhocsinh
            // 
            this.dgvdanhsachhocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachhocsinh.Location = new System.Drawing.Point(63, 341);
            this.dgvdanhsachhocsinh.Name = "dgvdanhsachhocsinh";
            this.dgvdanhsachhocsinh.Size = new System.Drawing.Size(527, 189);
            this.dgvdanhsachhocsinh.TabIndex = 18;
            // 
            // gbthongtinhocsinh
            // 
            this.gbthongtinhocsinh.Controls.Add(this.cmbGiaoVien);
            this.gbthongtinhocsinh.Controls.Add(this.txthocluc);
            this.gbthongtinhocsinh.Controls.Add(this.txtchucvu);
            this.gbthongtinhocsinh.Controls.Add(this.txthanhkiem);
            this.gbthongtinhocsinh.Controls.Add(this.txtdiachi);
            this.gbthongtinhocsinh.Controls.Add(this.lbldiachi);
            this.gbthongtinhocsinh.Controls.Add(this.cmblop);
            this.gbthongtinhocsinh.Controls.Add(this.rdbnu);
            this.gbthongtinhocsinh.Controls.Add(this.radbnam);
            this.gbthongtinhocsinh.Controls.Add(this.dtpngaysinh);
            this.gbthongtinhocsinh.Controls.Add(this.txthoten);
            this.gbthongtinhocsinh.Controls.Add(this.txtmahs);
            this.gbthongtinhocsinh.Controls.Add(this.lblgiaovienchunhiem);
            this.gbthongtinhocsinh.Controls.Add(this.lblchucvu);
            this.gbthongtinhocsinh.Controls.Add(this.lblhanhkiem);
            this.gbthongtinhocsinh.Controls.Add(this.lbllop);
            this.gbthongtinhocsinh.Controls.Add(this.lblhocluc);
            this.gbthongtinhocsinh.Controls.Add(this.lblgioitinh);
            this.gbthongtinhocsinh.Controls.Add(this.lblngaysinh);
            this.gbthongtinhocsinh.Controls.Add(this.lblhoten);
            this.gbthongtinhocsinh.Controls.Add(this.lblmahocsinh);
            this.gbthongtinhocsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbthongtinhocsinh.Location = new System.Drawing.Point(49, 58);
            this.gbthongtinhocsinh.Name = "gbthongtinhocsinh";
            this.gbthongtinhocsinh.Size = new System.Drawing.Size(853, 227);
            this.gbthongtinhocsinh.TabIndex = 17;
            this.gbthongtinhocsinh.TabStop = false;
            this.gbthongtinhocsinh.Text = "thông tin học sinh";
            // 
            // cmbGiaoVien
            // 
            this.cmbGiaoVien.FormattingEnabled = true;
            this.cmbGiaoVien.Location = new System.Drawing.Point(682, 139);
            this.cmbGiaoVien.Name = "cmbGiaoVien";
            this.cmbGiaoVien.Size = new System.Drawing.Size(121, 24);
            this.cmbGiaoVien.TabIndex = 18;
            // 
            // txthocluc
            // 
            this.txthocluc.Location = new System.Drawing.Point(305, 77);
            this.txthocluc.Name = "txthocluc";
            this.txthocluc.Size = new System.Drawing.Size(191, 23);
            this.txthocluc.TabIndex = 17;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(682, 90);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(135, 23);
            this.txtchucvu.TabIndex = 16;
            // 
            // txthanhkiem
            // 
            this.txthanhkiem.Location = new System.Drawing.Point(682, 40);
            this.txthanhkiem.Name = "txthanhkiem";
            this.txthanhkiem.Size = new System.Drawing.Size(135, 23);
            this.txthanhkiem.TabIndex = 16;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(305, 160);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(191, 59);
            this.txtdiachi.TabIndex = 15;
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(237, 163);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(49, 17);
            this.lbldiachi.TabIndex = 14;
            this.lbldiachi.Text = "địa chỉ";
            // 
            // cmblop
            // 
            this.cmblop.FormattingEnabled = true;
            this.cmblop.Location = new System.Drawing.Point(305, 119);
            this.cmblop.Name = "cmblop";
            this.cmblop.Size = new System.Drawing.Size(191, 24);
            this.cmblop.TabIndex = 13;
            // 
            // rdbnu
            // 
            this.rdbnu.AutoSize = true;
            this.rdbnu.Location = new System.Drawing.Point(384, 32);
            this.rdbnu.Name = "rdbnu";
            this.rdbnu.Size = new System.Drawing.Size(42, 21);
            this.rdbnu.TabIndex = 12;
            this.rdbnu.TabStop = true;
            this.rdbnu.Text = "nữ";
            this.rdbnu.UseVisualStyleBackColor = true;
            // 
            // radbnam
            // 
            this.radbnam.AutoSize = true;
            this.radbnam.Checked = true;
            this.radbnam.Location = new System.Drawing.Point(325, 30);
            this.radbnam.Name = "radbnam";
            this.radbnam.Size = new System.Drawing.Size(53, 21);
            this.radbnam.TabIndex = 12;
            this.radbnam.TabStop = true;
            this.radbnam.Text = "nam";
            this.radbnam.UseVisualStyleBackColor = true;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinh.Location = new System.Drawing.Point(75, 111);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(146, 23);
            this.dtpngaysinh.TabIndex = 11;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(62, 71);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(146, 23);
            this.txthoten.TabIndex = 10;
            // 
            // txtmahs
            // 
            this.txtmahs.Location = new System.Drawing.Point(62, 30);
            this.txtmahs.Name = "txtmahs";
            this.txtmahs.Size = new System.Drawing.Size(146, 23);
            this.txtmahs.TabIndex = 9;
            // 
            // lblgiaovienchunhiem
            // 
            this.lblgiaovienchunhiem.AutoSize = true;
            this.lblgiaovienchunhiem.Location = new System.Drawing.Point(542, 142);
            this.lblgiaovienchunhiem.Name = "lblgiaovienchunhiem";
            this.lblgiaovienchunhiem.Size = new System.Drawing.Size(134, 17);
            this.lblgiaovienchunhiem.TabIndex = 8;
            this.lblgiaovienchunhiem.Text = "giáo viên chủ nhiệm";
            // 
            // lblchucvu
            // 
            this.lblchucvu.AutoSize = true;
            this.lblchucvu.Location = new System.Drawing.Point(542, 90);
            this.lblchucvu.Name = "lblchucvu";
            this.lblchucvu.Size = new System.Drawing.Size(57, 17);
            this.lblchucvu.TabIndex = 7;
            this.lblchucvu.Text = "chức vụ";
            // 
            // lblhanhkiem
            // 
            this.lblhanhkiem.AutoSize = true;
            this.lblhanhkiem.Location = new System.Drawing.Point(542, 40);
            this.lblhanhkiem.Name = "lblhanhkiem";
            this.lblhanhkiem.Size = new System.Drawing.Size(73, 17);
            this.lblhanhkiem.TabIndex = 6;
            this.lblhanhkiem.Text = "hạnh kiểm";
            // 
            // lbllop
            // 
            this.lbllop.AutoSize = true;
            this.lbllop.Location = new System.Drawing.Point(249, 111);
            this.lbllop.Name = "lbllop";
            this.lbllop.Size = new System.Drawing.Size(27, 17);
            this.lbllop.TabIndex = 5;
            this.lbllop.Text = "lớp";
            // 
            // lblhocluc
            // 
            this.lblhocluc.AutoSize = true;
            this.lblhocluc.Location = new System.Drawing.Point(249, 77);
            this.lblhocluc.Name = "lblhocluc";
            this.lblhocluc.Size = new System.Drawing.Size(53, 17);
            this.lblhocluc.TabIndex = 4;
            this.lblhocluc.Text = "học lực";
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(245, 30);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(57, 17);
            this.lblgioitinh.TabIndex = 3;
            this.lblgioitinh.Text = "giới tính";
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Location = new System.Drawing.Point(0, 111);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(69, 17);
            this.lblngaysinh.TabIndex = 2;
            this.lblngaysinh.Text = "ngày sinh";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(6, 71);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(48, 17);
            this.lblhoten.TabIndex = 1;
            this.lblhoten.Text = "họ tên";
            // 
            // lblmahocsinh
            // 
            this.lblmahocsinh.AutoSize = true;
            this.lblmahocsinh.Location = new System.Drawing.Point(6, 30);
            this.lblmahocsinh.Name = "lblmahocsinh";
            this.lblmahocsinh.Size = new System.Drawing.Size(50, 17);
            this.lblmahocsinh.TabIndex = 0;
            this.lblmahocsinh.Text = "Mã HS";
            // 
            // lbltieude
            // 
            this.lbltieude.AutoSize = true;
            this.lbltieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.Location = new System.Drawing.Point(412, 8);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(233, 31);
            this.lbltieude.TabIndex = 16;
            this.lbltieude.Text = "Quản Lý Học Sinh";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(611, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbtimkiemgv);
            this.Controls.Add(this.dgvdanhsachhocsinh);
            this.Controls.Add(this.gbthongtinhocsinh);
            this.Controls.Add(this.lbltieude);
            this.Name = "SinhVien";
            this.Text = "SinhVien";
            this.gbtimkiemgv.ResumeLayout(false);
            this.gbtimkiemgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachhocsinh)).EndInit();
            this.gbthongtinhocsinh.ResumeLayout(false);
            this.gbthongtinhocsinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbtimkiemgv;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DataGridView dgvdanhsachhocsinh;
        private System.Windows.Forms.GroupBox gbthongtinhocsinh;
        private System.Windows.Forms.ComboBox cmbGiaoVien;
        private System.Windows.Forms.TextBox txthocluc;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.TextBox txthanhkiem;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.ComboBox cmblop;
        private System.Windows.Forms.RadioButton rdbnu;
        private System.Windows.Forms.RadioButton radbnam;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmahs;
        private System.Windows.Forms.Label lblgiaovienchunhiem;
        private System.Windows.Forms.Label lblchucvu;
        private System.Windows.Forms.Label lblhanhkiem;
        private System.Windows.Forms.Label lbllop;
        private System.Windows.Forms.Label lblhocluc;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblmahocsinh;
        private System.Windows.Forms.Label lbltieude;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}