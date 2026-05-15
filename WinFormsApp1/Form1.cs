private void btnDangNhap_Click(object sender, EventArgs e)
{
    string email = txtEmail.Text;
    string password = txtPassword.Text;

    string studentEmail = "nghia@student.edu.vn";
    string studentId = "123456";

    if (email == studentEmail && password == studentId)
    {
        MessageBox.Show("Đăng nhập thành công");
    }
    else
    {
        MessageBox.Show("Đăng nhập thất bại");
    }
}