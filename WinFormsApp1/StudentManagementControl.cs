using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp1
{
    public partial class StudentManagementControl : UserControl
    {
        private List<SinhVien> studentDataSource;

        public StudentManagementControl()
        {
            InitializeComponent();
            studentDataSource = DatabaseMock.DanhSachSV;
        }

        public void LoadStudentData()
        {
            LoadClassComboBox();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dgvStudent.DataSource = null;
            dgvStudent.DataSource = studentDataSource.ToList();
        }

        private void LoadClassComboBox()
        {
            cmbClass.DataSource = null;
            cmbClass.DataSource = DatabaseMock.DanhSachLop;
            cmbClass.DisplayMember = "TenLop";
            cmbClass.ValueMember = "MaLop";
            cmbClass.SelectedIndex = -1;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (ValidateStudentInput())
            {
                var newStudent = new SinhVien
                {
                    MaSV = txtStudentId.Text.Trim(),
                    HoTen = txtFullName.Text.Trim(),
                    NgaySinh = dtpBirthDate.Value,
                    GioiTinh = cmbGender.Text,
                    MaLop = cmbClass.SelectedValue?.ToString() ?? ""
                };

                DatabaseMock.DanhSachSV.Add(newStudent);
                MessageBox.Show("Thêm sinh viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
                ClearInputs();
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateStudentInput())
            {
                string selectedId = dgvStudent.SelectedRows[0].Cells["MaSV"].Value?.ToString();
                var studentToEdit = DatabaseMock.DanhSachSV.FirstOrDefault(s => s.MaSV == selectedId);

                if (studentToEdit != null)
                {
                    studentToEdit.HoTen = txtFullName.Text.Trim();
                    studentToEdit.NgaySinh = dtpBirthDate.Value;
                    studentToEdit.GioiTinh = cmbGender.Text;
                    studentToEdit.MaLop = cmbClass.SelectedValue?.ToString() ?? "";
                    MessageBox.Show("Sửa sinh viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView();
                    ClearInputs();
                }
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string selectedId = dgvStudent.SelectedRows[0].Cells["MaSV"].Value?.ToString();
                var studentToDelete = DatabaseMock.DanhSachSV.FirstOrDefault(s => s.MaSV == selectedId);

                if (studentToDelete != null)
                {
                    DatabaseMock.DanhSachSV.Remove(studentToDelete);
                    MessageBox.Show("Xóa sinh viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView();
                    ClearInputs();
                }
            }
        }

        private void btnClearStudent_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchStudent.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                RefreshDataGridView();
            }
            else
            {
                var results = studentDataSource.Where(s =>
                    s.MaSV.ToLower().Contains(searchTerm) ||
                    s.HoTen.ToLower().Contains(searchTerm) ||
                    s.MaLop.ToLower().Contains(searchTerm)).ToList();

                dgvStudent.DataSource = null;
                dgvStudent.DataSource = results;
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                txtStudentId.Text = row.Cells["MaSV"].Value?.ToString() ?? "";
                txtFullName.Text = row.Cells["HoTen"].Value?.ToString() ?? "";

                if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime birthDate))
                {
                    dtpBirthDate.Value = birthDate;
                }

                cmbGender.Text = row.Cells["GioiTinh"].Value?.ToString() ?? "";
                cmbClass.SelectedValue = row.Cells["MaLop"].Value?.ToString() ?? "";
            }
        }

        private bool ValidateStudentInput()
        {
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtStudentId.Clear();
            txtFullName.Clear();
            txtSearchStudent.Clear();
            dtpBirthDate.Value = DateTime.Now;
            cmbGender.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            dgvStudent.ClearSelection();
        }
    }
}
