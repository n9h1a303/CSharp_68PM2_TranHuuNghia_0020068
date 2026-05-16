namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.tsmiSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDangXuat = new System.Windows.Forms.ToolStripMenuItem();

            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();

            this.pnlLopHoc = new System.Windows.Forms.Panel();
            this.lblThongTinLop = new System.Windows.Forms.Label();
            this.txtMaID = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnLamMoiLop = new System.Windows.Forms.Button();
            this.txtTimKiemLop = new System.Windows.Forms.TextBox();
            this.btnTimKiemLop = new System.Windows.Forms.Button();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();

            this.pnlSinhVien = new System.Windows.Forms.Panel();
            this.lblThongTinSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.btnSuaSV = new System.Windows.Forms.Button();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnLamMoiSV = new System.Windows.Forms.Button();
            this.txtTimKiemSV = new System.Windows.Forms.TextBox();
            this.btnTimKiemSV = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();

            this.menuMain.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlLopHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.pnlSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();

            // MenuMain
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSinhVien,
            this.tsmiLopHoc,
            this.tsmiDangXuat});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1000, 24);
            this.menuMain.Visible = false;

            this.tsmiSinhVien.Text = "Quản lý Sinh Viên";
            this.tsmiSinhVien.Click += new System.EventHandler(this.tsmiSinhVien_Click);
            this.tsmiLopHoc.Text = "Quản lý Lớp Học";
            this.tsmiLopHoc.Click += new System.EventHandler(this.tsmiLopHoc_Click);
            this.tsmiDangXuat.Text = "Đăng xuất";
            this.tsmiDangXuat.ForeColor = System.Drawing.Color.Red;
            this.tsmiDangXuat.Click += new System.EventHandler(this.tsmiDangXuat_Click);

            // pnlLogin
            this.pnlLogin.Controls.Add(this.lblUser);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.lblPass);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblUser.Text = "Tên đăng nhập (Email):";
            this.lblUser.Location = new System.Drawing.Point(350, 200);
            this.lblUser.Size = new System.Drawing.Size(150, 20);
            this.txtUsername.Location = new System.Drawing.Point(350, 220);
            this.txtUsername.Size = new System.Drawing.Size(300, 20);

            this.lblPass.Text = "Mật khẩu (MSSV):";
            this.lblPass.Location = new System.Drawing.Point(350, 260);
            this.lblPass.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.Location = new System.Drawing.Point(350, 280);
            this.txtPassword.Size = new System.Drawing.Size(300, 20);
            this.txtPassword.PasswordChar = '*';

            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.Location = new System.Drawing.Point(450, 320);
            this.btnLogin.Size = new System.Drawing.Size(100, 35);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // pnlLopHoc
            this.pnlLopHoc.Controls.Add(this.lblThongTinLop);
            this.pnlLopHoc.Controls.Add(this.txtMaID);
            this.pnlLopHoc.Controls.Add(this.txtMaLop);
            this.pnlLopHoc.Controls.Add(this.txtTenLop);
            this.pnlLopHoc.Controls.Add(this.txtGhiChu);
            this.pnlLopHoc.Controls.Add(this.btnThemLop);
            this.pnlLopHoc.Controls.Add(this.btnSuaLop);
            this.pnlLopHoc.Controls.Add(this.btnXoaLop);
            this.pnlLopHoc.Controls.Add(this.btnLamMoiLop);
            this.pnlLopHoc.Controls.Add(this.txtTimKiemLop);
            this.pnlLopHoc.Controls.Add(this.btnTimKiemLop);
            this.pnlLopHoc.Controls.Add(this.dgvLopHoc);
            this.pnlLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLopHoc.Visible = false;

            this.lblThongTinLop.Text = "Thông tin lớp học";
            this.lblThongTinLop.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.lblThongTinLop.Location = new System.Drawing.Point(20, 40);
            this.lblThongTinLop.Size = new System.Drawing.Size(150, 20);

            this.txtMaID.Location = new System.Drawing.Point(20, 70);
            this.txtMaID.Size = new System.Drawing.Size(250, 20);
            this.txtMaID.Text = "Mã ID";

            this.txtMaLop.Location = new System.Drawing.Point(20, 110);
            this.txtMaLop.Size = new System.Drawing.Size(250, 20);
            this.txtMaLop.Text = "Mã lớp";

            this.txtTenLop.Location = new System.Drawing.Point(20, 150);
            this.txtTenLop.Size = new System.Drawing.Size(250, 20);
            this.txtTenLop.Text = "Tên lớp";

            this.txtGhiChu.Location = new System.Drawing.Point(20, 190);
            this.txtGhiChu.Size = new System.Drawing.Size(250, 20);
            this.txtGhiChu.Text = "Ghi chú";

            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(20, 240);
            this.btnThemLop.Size = new System.Drawing.Size(115, 35);
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);

            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuaLop.ForeColor = System.Drawing.Color.White;
            this.btnSuaLop.Location = new System.Drawing.Point(155, 240);
            this.btnSuaLop.Size = new System.Drawing.Size(115, 35);
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);

            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.BackColor = System.Drawing.Color.Tomato;
            this.btnXoaLop.ForeColor = System.Drawing.Color.White;
            this.btnXoaLop.Location = new System.Drawing.Point(20, 290);
            this.btnXoaLop.Size = new System.Drawing.Size(115, 35);
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);

            this.btnLamMoiLop.Text = "Làm mới";
            this.btnLamMoiLop.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoiLop.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiLop.Location = new System.Drawing.Point(155, 290);
            this.btnLamMoiLop.Size = new System.Drawing.Size(115, 35);
            this.btnLamMoiLop.Click += new System.EventHandler(this.btnLamMoiLop_Click);

            this.txtTimKiemLop.Location = new System.Drawing.Point(320, 40);
            this.txtTimKiemLop.Size = new System.Drawing.Size(300, 20);
            this.btnTimKiemLop.Text = "Tìm";
            this.btnTimKiemLop.Location = new System.Drawing.Point(630, 38);
            this.btnTimKiemLop.Size = new System.Drawing.Size(80, 25);
            this.btnTimKiemLop.Click += new System.EventHandler(this.btnTimKiemLop_Click);

            this.dgvLopHoc.Location = new System.Drawing.Point(320, 70);
            this.dgvLopHoc.Size = new System.Drawing.Size(650, 400);
            this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHoc_CellClick);

            // pnlSinhVien
            this.pnlSinhVien.Controls.Add(this.lblThongTinSV);
            this.pnlSinhVien.Controls.Add(this.txtMaSV);
            this.pnlSinhVien.Controls.Add(this.txtHoTen);
            this.pnlSinhVien.Controls.Add(this.dtpNgaySinh);
            this.pnlSinhVien.Controls.Add(this.cmbGioiTinh);
            this.pnlSinhVien.Controls.Add(this.cmbLop);
            this.pnlSinhVien.Controls.Add(this.btnThemSV);
            this.pnlSinhVien.Controls.Add(this.btnSuaSV);
            this.pnlSinhVien.Controls.Add(this.btnXoaSV);
            this.pnlSinhVien.Controls.Add(this.btnLamMoiSV);
            this.pnlSinhVien.Controls.Add(this.txtTimKiemSV);
            this.pnlSinhVien.Controls.Add(this.btnTimKiemSV);
            this.pnlSinhVien.Controls.Add(this.dgvSinhVien);
            this.pnlSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSinhVien.Visible = false;

            this.lblThongTinSV.Text = "Thông tin sinh viên";
            this.lblThongTinSV.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.lblThongTinSV.Location = new System.Drawing.Point(20, 40);
            this.lblThongTinSV.Size = new System.Drawing.Size(150, 20);

            this.txtMaSV.Location = new System.Drawing.Point(20, 70);
            this.txtMaSV.Size = new System.Drawing.Size(250, 20);
            this.txtMaSV.Text = "Mã sinh viên";

            this.txtHoTen.Location = new System.Drawing.Point(20, 110);
            this.txtHoTen.Size = new System.Drawing.Size(250, 20);
            this.txtHoTen.Text = "Họ và tên";

            this.dtpNgaySinh.Location = new System.Drawing.Point(20, 150);
            this.dtpNgaySinh.Size = new System.Drawing.Size(250, 20);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.cmbGioiTinh.Location = new System.Drawing.Point(20, 190);
            this.cmbGioiTinh.Size = new System.Drawing.Size(250, 20);
            this.cmbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });

            this.cmbLop.Location = new System.Drawing.Point(20, 230);
            this.cmbLop.Size = new System.Drawing.Size(250, 20);

            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemSV.ForeColor = System.Drawing.Color.White;
            this.btnThemSV.Location = new System.Drawing.Point(20, 280);
            this.btnThemSV.Size = new System.Drawing.Size(115, 35);
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);

            this.btnSuaSV.Text = "Sửa";
            this.btnSuaSV.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuaSV.ForeColor = System.Drawing.Color.White;
            this.btnSuaSV.Location = new System.Drawing.Point(155, 280);
            this.btnSuaSV.Size = new System.Drawing.Size(115, 35);
            this.btnSuaSV.Click += new System.EventHandler(this.btnSuaSV_Click);

            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.BackColor = System.Drawing.Color.Tomato;
            this.btnXoaSV.ForeColor = System.Drawing.Color.White;
            this.btnXoaSV.Location = new System.Drawing.Point(20, 330);
            this.btnXoaSV.Size = new System.Drawing.Size(115, 35);
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);

            this.btnLamMoiSV.Text = "Làm mới";
            this.btnLamMoiSV.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoiSV.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiSV.Location = new System.Drawing.Point(155, 330);
            this.btnLamMoiSV.Size = new System.Drawing.Size(115, 35);
            this.btnLamMoiSV.Click += new System.EventHandler(this.btnLamMoiSV_Click);

            this.txtTimKiemSV.Location = new System.Drawing.Point(320, 40);
            this.txtTimKiemSV.Size = new System.Drawing.Size(300, 20);
            this.btnTimKiemSV.Text = "Tìm";
            this.btnTimKiemSV.Location = new System.Drawing.Point(630, 38);
            this.btnTimKiemSV.Size = new System.Drawing.Size(80, 25);
            this.btnTimKiemSV.Click += new System.EventHandler(this.btnTimKiemSV_Click);

            this.dgvSinhVien.Location = new System.Drawing.Point(320, 70);
            this.dgvSinhVien.Size = new System.Drawing.Size(650, 400);
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlSinhVien);
            this.Controls.Add(this.pnlLopHoc);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlLopHoc.ResumeLayout(false);
            this.pnlLopHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.pnlSinhVien.ResumeLayout(false);
            this.pnlSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSinhVien;
        private System.Windows.Forms.ToolStripMenuItem tsmiLopHoc;
        private System.Windows.Forms.ToolStripMenuItem tsmiDangXuat;

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;

        private System.Windows.Forms.Panel pnlLopHoc;
        private System.Windows.Forms.Label lblThongTinLop;
        private System.Windows.Forms.TextBox txtMaID;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnLamMoiLop;
        private System.Windows.Forms.TextBox txtTimKiemLop;
        private System.Windows.Forms.Button btnTimKiemLop;
        private System.Windows.Forms.DataGridView dgvLopHoc;

        private System.Windows.Forms.Panel pnlSinhVien;
        private System.Windows.Forms.Label lblThongTinSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Button btnSuaSV;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Button btnLamMoiSV;
        private System.Windows.Forms.TextBox txtTimKiemSV;
        private System.Windows.Forms.Button btnTimKiemSV;
        private System.Windows.Forms.DataGridView dgvSinhVien;
    }
}