using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp1
{
    public partial class ClassManagementControl : UserControl
    {
        private List<LopHoc> classDataSource;

        public ClassManagementControl()
        {
            InitializeComponent();
            classDataSource = DatabaseMock.DanhSachLop;
        }

        public void LoadClassData()
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dgvClass.DataSource = null;
            dgvClass.DataSource = classDataSource.ToList();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (ValidateClassInput())
            {
                var newClass = new LopHoc
                {
                    MaID = DatabaseMock.DanhSachLop.Count + 1,
                    MaLop = txtMaLop.Text.Trim(),
                    TenLop = txtClassName.Text.Trim(),
                    GhiChu = txtNote.Text.Trim()
                };

                DatabaseMock.DanhSachLop.Add(newClass);
                MessageBox.Show("Thêm lớp học thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
                ClearInputs();
            }
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lớp để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateClassInput())
            {
                int selectedId = (int)dgvClass.SelectedRows[0].Cells["MaID"].Value;
                var classToEdit = DatabaseMock.DanhSachLop.FirstOrDefault(l => l.MaID == selectedId);

                if (classToEdit != null)
                {
                    classToEdit.MaLop = txtMaLop.Text.Trim();
                    classToEdit.TenLop = txtClassName.Text.Trim();
                    classToEdit.GhiChu = txtNote.Text.Trim();
                    MessageBox.Show("Sửa lớp học thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView();
                    ClearInputs();
                }
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lớp để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn chắc chắn muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int selectedId = (int)dgvClass.SelectedRows[0].Cells["MaID"].Value;
                var classToDelete = DatabaseMock.DanhSachLop.FirstOrDefault(l => l.MaID == selectedId);

                if (classToDelete != null)
                {
                    DatabaseMock.DanhSachLop.Remove(classToDelete);
                    MessageBox.Show("Xóa lớp học thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView();
                    ClearInputs();
                }
            }
        }

        private void btnClearClass_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lớp để xem sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLop = dgvClass.SelectedRows[0].Cells["MaLop"].Value?.ToString() ?? "";
            // Find parent form and try to display the student control filtered by class
            var parentForm = this.FindForm() as Form1;
            if (parentForm != null)
            {
                parentForm.DisplayStudentControlByClass(maLop);
            }
        }

        private void btnSearchClass_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchClass.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                RefreshDataGridView();
            }
            else
            {
                var results = classDataSource.Where(l =>
                    l.MaID.ToString().Contains(searchTerm) ||
                    l.MaLop.ToLower().Contains(searchTerm) ||
                    l.TenLop.ToLower().Contains(searchTerm) ||
                    l.GhiChu.ToLower().Contains(searchTerm)).ToList();

                dgvClass.DataSource = null;
                dgvClass.DataSource = results;
            }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClass.Rows[e.RowIndex];
                txtMaLop.Text = row.Cells["MaLop"].Value?.ToString() ?? "";
                txtClassName.Text = row.Cells["TenLop"].Value?.ToString() ?? "";
                txtNote.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";
            }
        }

        private bool ValidateClassInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên lớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtMaLop.Clear();
            txtClassName.Clear();
            txtNote.Clear();
            txtSearchClass.Clear();
            dgvClass.ClearSelection();
        }
    }
}
