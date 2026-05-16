using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseMock.InitData();
            LoadDataLop();
            LoadDataSV();
            LoadComboBoxLop();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailSV = "0020068@st.huce.edu.vn";
            string mssv = "0020068";

            if (txtUsername.Text == emailSV && txtPassword.Text == mssv)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlLogin.Visible = false;
                menuMain.Visible = true;
                pnlSinhVien.Visible = true;
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiSinhVien_Click(object sender, EventArgs e)
        {
            pnlSinhVien.Visible = true;
            pnlLopHoc.Visible = false;
        }

        private void tsmiLopHoc_Click(object sender, EventArgs e)
        {
            pnlLopHoc.Visible = true;
            pnlSinhVien.Visible = false;
        }

        private void tsmiDangXuat_Click(object sender, EventArgs e)
        {
            pnlSinhVien.Visible = false;
            pnlLopHoc.Visible = false;
            menuMain.Visible = false;
            pnlLogin.Visible = true;
            txtUsername.Clear();
            txtPassword.Clear();
        }

        // --- QUẢN LÝ LỚP HỌC ---
        private void LoadDataLop()
        {
            dgvLopHoc.DataSource = null;
            dgvLopHoc.DataSource = DatabaseMock.DanhSachLop;
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            var lopMoi = new LopHoc()
            {
                MaID = int.TryParse(txtMaID.Text, out int id) ? id : 0,
                MaLop = txtMaLop.Text,
                TenLop = txtTenLop.Text,
                GhiChu = txtGhiChu.Text
            };
            DatabaseMock.DanhSachLop.Add(lopMoi);
            LoadDataLop();
            LoadComboBoxLop();
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            var lop = DatabaseMock.DanhSachLop.FirstOrDefault(l => l.MaID.ToString() == txtMaID.Text);
            if (lop != null)
            {
                lop.MaLop = txtMaLop.Text;
                lop.TenLop = txtTenLop.Text;
                lop.GhiChu = txtGhiChu.Text;
                LoadDataLop();
                LoadComboBoxLop();
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            var lop = DatabaseMock.DanhSachLop.FirstOrDefault(l => l.MaID.ToString() == txtMaID.Text);
            if (lop != null)
            {
                DatabaseMock.DanhSachLop.Remove(lop);
                LoadDataLop();
                LoadComboBoxLop();
                btnLamMoiLop_Click(null, null);
            }
        }

        private void btnLamMoiLop_Click(object sender, EventArgs e)
        {
            txtMaID.Clear(); txtMaLop.Clear(); txtTenLop.Clear(); txtGhiChu.Clear();
        }

        private void btnTimKiemLop_Click(object sender, EventArgs e)
        {
            var key = txtTimKiemLop.Text.ToLower();
            dgvLopHoc.DataSource = DatabaseMock.DanhSachLop.Where(l =>
                l.MaLop.ToLower().Contains(key) || l.TenLop.ToLower().Contains(key)).ToList();
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLopHoc.Rows.Count)
            {
                DataGridViewRow row = dgvLopHoc.Rows[e.RowIndex];
                txtMaID.Text = row.Cells["MaID"].Value?.ToString();
                txtMaLop.Text = row.Cells["MaLop"].Value?.ToString();
                txtTenLop.Text = row.Cells["TenLop"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
            }
        }

        // --- QUẢN LÝ SINH VIÊN ---
        private void LoadDataSV()
        {
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = DatabaseMock.DanhSachSV;
        }

        private void LoadComboBoxLop()
        {
            cmbLop.DataSource = null;
            cmbLop.DataSource = DatabaseMock.DanhSachLop;
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "MaLop";
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            var svMoi = new SinhVien()
            {
                MaSV = txtMaSV.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cmbGioiTinh.Text,
                MaLop = cmbLop.SelectedValue?.ToString()
            };
            DatabaseMock.DanhSachSV.Add(svMoi);
            LoadDataSV();
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            var sv = DatabaseMock.DanhSachSV.FirstOrDefault(s => s.MaSV == txtMaSV.Text);
            if (sv != null)
            {
                sv.HoTen = txtHoTen.Text;
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.GioiTinh = cmbGioiTinh.Text;
                sv.MaLop = cmbLop.SelectedValue?.ToString();
                LoadDataSV();
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            var sv = DatabaseMock.DanhSachSV.FirstOrDefault(s => s.MaSV == txtMaSV.Text);
            if (sv != null)
            {
                DatabaseMock.DanhSachSV.Remove(sv);
                LoadDataSV();
                btnLamMoiSV_Click(null, null);
            }
        }

        private void btnLamMoiSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear(); txtHoTen.Clear(); dtpNgaySinh.Value = DateTime.Now;
            cmbGioiTinh.SelectedIndex = -1; cmbLop.SelectedIndex = -1;
        }

        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            var key = txtTimKiemSV.Text.ToLower();
            dgvSinhVien.DataSource = DatabaseMock.DanhSachSV.Where(s =>
                s.MaSV.ToLower().Contains(key) || s.HoTen.ToLower().Contains(key)).ToList();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSinhVien.Rows.Count)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime ns)) dtpNgaySinh.Value = ns;
                cmbGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                cmbLop.SelectedValue = row.Cells["MaLop"].Value?.ToString();
            }
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
                DanhSachLop.Add(new LopHoc { MaID = 1, MaLop = "68PM1", TenLop = "Lớp 68PM1", GhiChu = "abc" });
                DanhSachLop.Add(new LopHoc { MaID = 2, MaLop = "68PM2", TenLop = "Lớp 68PM2", GhiChu = "xyz" });
            }
        }
    }
}