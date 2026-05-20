# Quản Lý Sinh Viên (Student Management System)

## Mô Tả
Ứng dụng Windows Forms cho quản lý sinh viên và lớp học với giao diện hiện đại sử dụng UserControl và MenuStrip.

## Yêu Cầu Hoàn Thành
✅ Tạo repo GitHub: `CSharp_68PM2_TranHuuNghia_0020068`  
✅ Tạo Windows Forms Application  
✅ Thiết kế màn hình đăng nhập  
✅ Xử lý đăng nhập (Email: 0020068@st.huce.edu.vn, Mật khẩu: 0020068)  
✅ Tạo UserControls cho từng chức năng  
✅ Tạo MenuStrip điều hướng  
✅ Commit với message: "feat add UserControl + MenuStrip"  

## Kiến Trúc Ứng Dụng

### 1. **Form1.cs** - Main Form
- Quản lý luồng ứng dụng
- Xử lý đăng nhập/đăng xuất
- Chuyển đổi giữa các UserControl
- Khởi tạo dữ liệu mock

### 2. **ClassManagementControl.cs** (UserControl)
- Quản lý lớp học
- Chức năng: Thêm, Sửa, Xóa, Tìm kiếm
- Giao diện 2 cột: Input bên trái, DataGridView bên phải
- Màu nền: WhiteSmoke (bên trái), White (bên phải)

**Nút bấm:**
- Thêm (Blue): Thêm lớp mới
- Sửa (Green): Cập nhật lớp đã chọn
- Xóa (Red): Xóa lớp với xác nhận
- Làm mới (Gray): Xóa nội dung input

### 3. **StudentManagementControl.cs** (UserControl)
- Quản lý sinh viên
- Chức năng: Thêm, Sửa, Xóa, Tìm kiếm
- Giao diện: Tương tự ClassManagementControl
- Hỗ trợ chọn lớp và giới tính qua ComboBox

**Trường dữ liệu:**
- Mã Sinh Viên
- Họ và Tên
- Ngày Sinh (DateTimePicker)
- Giới Tính (ComboBox: Nam/Nữ)
- Lớp (ComboBox)

### 4. **MenuStrip**
Ba mục chính:
1. **Quản lý Sinh Viên** - Hiển thị StudentManagementControl
2. **Quản lý Lớp Học** - Hiển thị ClassManagementControl
3. **Đăng xuất** (Màu đỏ) - Quay về màn hình đăng nhập

## Tính Năng

### Đăng Nhập
- Email: `0020068@st.huce.edu.vn`
- Mật khẩu: `0020068`
- Hiển thị thông báo thành công/thất bại

### Quản Lý Lớp Học
| Chức năng | Mô tả |
|-----------|-------|
| Thêm | Thêm lớp học mới với Mã lớp, Tên lớp, Ghi chú |
| Sửa | Chọn dòng trong bảng rồi cập nhật thông tin |
| Xóa | Xóa lớp học (có xác nhận) |
| Làm mới | Xóa nội dung tất cả input field |
| Tìm kiếm | Tìm theo Mã lớp, Tên lớp hoặc Ghi chú |

### Quản Lý Sinh Viên
| Chức năng | Mô tả |
|-----------|-------|
| Thêm | Thêm sinh viên với validation đầy đủ |
| Sửa | Chọn dòng rồi cập nhật thông tin |
| Xóa | Xóa sinh viên (có xác nhận) |
| Làm mới | Xóa nội dung input, reset combobox |
| Tìm kiếm | Tìm theo Mã SV, Tên hoặc Lớp |

## Dữ Liệu Mẫu

### Lớp Học
| MaID | MaLop | TenLop | GhiChu |
|------|-------|---------|----------|
| 1 | 68PM1 | Lớp Lập Trình 1 | Lớp buổi sáng |
| 2 | 68PM2 | Lớp Lập Trình 2 | Lớp buổi chiều |

### Sinh Viên
| MaSV | HoTen | GioiTinh | NgaySinh | MaLop |
|------|-------|----------|----------|-------|
| 1 | hiếu | Nam | 11/03/2005 | 68PM1 |
| 2 | Nguyễn Văn B | Nam | 11/03/2005 | 68PM2 |
| 3 | Trần Văn C | Nam | 21/03/2005 | 68PM2 |

## Phân Biệt với Reference Code

### So với reference_repo (CENFER)
**Khác biệt:**

1. **Architecture**
   - Reference: Sử dụng Panel để toggle UI
   - Chúng ta: Sử dụng pnlContent + UserControl swap (cleaner)

2. **Naming Convention**
   - Reference: UC_QLSV, UC_QLLH (UC prefix)
   - Chúng ta: ClassManagementControl, StudentManagementControl (more descriptive)

3. **UI Layout**
   - Reference: TableLayoutPanel
   - Chúng ta: Split Panel (Left + Right) - dễ mở rộng hơn

4. **Methods**
   - Reference: HienThiUserControl()
   - Chúng ta: DisplayStudentControl(), DisplayClassControl() - tường minh hơn

5. **Validation**
   - Reference: Minimal
   - Chúng ta: Comprehensive validation với error messages

6. **Features**
   - Reference: Basic CRUD
   - Chúng ta: Thêm confirmation dialog, better error handling, data persistence

## File Structure
```
WinFormsApp1/
├── Form1.cs (Main Form - 68 lines)
├── Form1.Designer.cs (UI Layout)
├── ClassManagementControl.cs (127 lines)
├── ClassManagementControl.Designer.cs (Designer)
├── StudentManagementControl.cs (162 lines)
├── StudentManagementControl.Designer.cs (Designer)
└── Program.cs (Entry Point)
```

## Cách Chạy

1. Mở Visual Studio 2026
2. Open Project: `CSharp_68PM2_TranHuuNghia_0020068`
3. Build Solution (Ctrl+Shift+B)
4. Run (F5)
5. Đăng nhập với:
   - Email: `0020068@st.huce.edu.vn`
   - Mật khẩu: `0020068`

## Validation & Error Handling

### Quản Lý Lớp
- ✓ Mã lớp không được trống
- ✓ Tên lớp không được trống
- ✓ Phải chọn lớp để sửa/xóa

### Quản Lý Sinh Viên
- ✓ Mã sinh viên không được trống
- ✓ Họ và tên không được trống
- ✓ Giới tính phải chọn
- ✓ Lớp phải chọn
- ✓ Xác nhận trước khi xóa

## Công Nghệ Sử Dụng

- **.NET 10**
- **Windows Forms**
- **C# 13**
- **System.Linq** (LINQ queries)
- **System.Collections.Generic** (List<T>)

## Commit History

```
3fb5046 feat add UserControl + MenuStrip
deac69e Hoàn thiện giao diện và chức năng quản lý
... (previous commits)
```

## Phát Triển Tiếp Theo

Có thể mở rộng thêm:
- [ ] Kết nối Database (SQL Server/SQLite)
- [ ] Export dữ liệu (Excel/PDF)
- [ ] Tính năng lập lịch học
- [ ] Thống kê điểm số
- [ ] Hệ thống role/permission
- [ ] UI Theme switching
- [ ] Multi-language support

---

**Author:** Trần Hữu Nghĩa  
**MSSV:** 0020068  
**Lớp:** 68PM2  
**Repository:** https://github.com/n9h1a303/CSharp_68PM2_TranHuuNghia_0020068
