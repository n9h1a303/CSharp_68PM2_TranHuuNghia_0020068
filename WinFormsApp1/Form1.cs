using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private ClassManagementControl classControl;
        private StudentManagementControl studentControl;
        private bool isLoggedIn = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseMock.InitData();
            InitializeUserControls();
            ShowLoginPanel();
        }

        private void InitializeUserControls()
        {
            classControl = new ClassManagementControl();
            studentControl = new StudentManagementControl();
        }

        private void ShowLoginPanel()
        {
            pnlLogin.Visible = true;
            pnlContent.Visible = false;
            menuMain.Visible = false;
            isLoggedIn = false;
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void ShowContentPanel()
        {
            pnlLogin.Visible = false;
            pnlContent.Visible = true;
            menuMain.Visible = true;
            isLoggedIn = true;
            DisplayStudentControl();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailSV = "0020068@st.huce.edu.vn";
            string mssv = "0020068";

            if (txtUsername.Text == emailSV && txtPassword.Text == mssv)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowContentPanel();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void tsmiQuanLySinhVien_Click(object sender, EventArgs e)
        {
            DisplayStudentControl();
        }

        private void tsmiQuanLyLopHoc_Click(object sender, EventArgs e)
        {
            DisplayClassControl();
        }

        private void tsmiDangXuat_Click(object sender, EventArgs e)
        {
            ShowLoginPanel();
        }

        private void DisplayStudentControl()
        {
            pnlContent.Controls.Clear();
            studentControl.LoadStudentData();
            studentControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(studentControl);
        }

        public void DisplayStudentControlByClass(string maLop)
        {
            pnlContent.Controls.Clear();
            studentControl.LoadStudentData();
            // filter students by class
            studentControl.FilterByClass(maLop);
            studentControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(studentControl);
        }

        private void DisplayClassControl()
        {
            pnlContent.Controls.Clear();
            classControl.LoadClassData();
            classControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(classControl);
        }
    }

    public class LopHoc
    {
        public int MaID { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string GhiChu { get; set; }
    }

    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string MaLop { get; set; }
    }

    public static class DatabaseMock
    {
        public static List<LopHoc> DanhSachLop = new List<LopHoc>();
        public static List<SinhVien> DanhSachSV = new List<SinhVien>();

        public static void InitData()
        {
            if (DanhSachLop.Count == 0)
            {
                DanhSachLop.Add(new LopHoc { MaID = 1, MaLop = "68PM1", TenLop = "Lớp Lập Trình 1", GhiChu = "Lớp buổi sáng" });
                DanhSachLop.Add(new LopHoc { MaID = 2, MaLop = "68PM2", TenLop = "Lớp Lập Trình 2", GhiChu = "Lớp buổi chiều" });
            }

            if (DanhSachSV.Count == 0)
            {
                DanhSachSV.Add(new SinhVien { MaSV = "1", HoTen = "hiếu", GioiTinh = "Nam", NgaySinh = new DateTime(2005, 11, 3), MaLop = "68PM1" });
                DanhSachSV.Add(new SinhVien { MaSV = "2", HoTen = "Nguyễn Văn B", GioiTinh = "Nam", NgaySinh = new DateTime(2005, 11, 3), MaLop = "68PM2" });
                DanhSachSV.Add(new SinhVien { MaSV = "3", HoTen = "Trần Văn C", GioiTinh = "Nam", NgaySinh = new DateTime(2005, 3, 21), MaLop = "68PM2" });
            }
        }
    }
}