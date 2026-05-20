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

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuanLySinhVien;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuanLyLopHoc;
        private System.Windows.Forms.ToolStripMenuItem tsmiDangXuat;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlContent;

        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.tsmiQuanLySinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuanLyLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();

            this.menuMain.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();

            // menuMain
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQuanLySinhVien,
            this.tsmiQuanLyLopHoc,
            this.tsmiDangXuat});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1200, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Visible = false;

            // tsmiQuanLySinhVien
            this.tsmiQuanLySinhVien.Name = "tsmiQuanLySinhVien";
            this.tsmiQuanLySinhVien.Size = new System.Drawing.Size(130, 20);
            this.tsmiQuanLySinhVien.Text = "Quản lý Sinh Viên";
            this.tsmiQuanLySinhVien.Click += new System.EventHandler(this.tsmiQuanLySinhVien_Click);

            // tsmiQuanLyLopHoc
            this.tsmiQuanLyLopHoc.Name = "tsmiQuanLyLopHoc";
            this.tsmiQuanLyLopHoc.Size = new System.Drawing.Size(130, 20);
            this.tsmiQuanLyLopHoc.Text = "Quản lý Lớp Học";
            this.tsmiQuanLyLopHoc.Click += new System.EventHandler(this.tsmiQuanLyLopHoc_Click);

            // tsmiDangXuat
            this.tsmiDangXuat.ForeColor = System.Drawing.Color.Red;
            this.tsmiDangXuat.Name = "tsmiDangXuat";
            this.tsmiDangXuat.Size = new System.Drawing.Size(70, 20);
            this.tsmiDangXuat.Text = "Đăng xuất";
            this.tsmiDangXuat.Click += new System.EventHandler(this.tsmiDangXuat_Click);

            // pnlLogin
            this.pnlLogin.Controls.Add(this.lblUser);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.lblPass);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 24);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1200, 650);
            this.pnlLogin.TabIndex = 1;

            // lblUser
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 10);
            this.lblUser.Location = new System.Drawing.Point(450, 250);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(160, 16);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Email (0020068@st.huce.edu.vn):";

            // txtUsername
            this.txtUsername.Font = new System.Drawing.Font("Arial", 10);
            this.txtUsername.Location = new System.Drawing.Point(450, 270);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 23);
            this.txtUsername.TabIndex = 1;

            // lblPass
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Arial", 10);
            this.lblPass.Location = new System.Drawing.Point(450, 310);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(130, 16);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Mật khẩu (MSSV):";

            // txtPassword
            this.txtPassword.Font = new System.Drawing.Font("Arial", 10);
            this.txtPassword.Location = new System.Drawing.Point(450, 330);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 23);
            this.txtPassword.TabIndex = 3;

            // btnLogin
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(550, 380);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 24);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1200, 650);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.Visible = false;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 674);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
