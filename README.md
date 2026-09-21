# Quản Lý Quán Cà Phê

Ứng dụng desktop **Windows Forms (C#)** hỗ trợ quản lý quán cà phê: đăng nhập nhân viên, quản lý sản phẩm, lập hóa đơn và xem thống kê. Dữ liệu được lưu trong **MySQL**.

> Đồ án nhóm – môn học: _(điền tên môn)_ – Giảng viên: _(điền tên giảng viên)_

## Chức năng chính

- **Đăng nhập** bằng mã nhân viên và mật khẩu (`FormDangNhap`)
- **Màn hình chính** điều hướng đến các chức năng (`FormChinh`)
- **Quản lý sản phẩm** (`FormSanPham`):
  - Xem danh sách sản phẩm gồm đồ uống, đồ ăn và combo khuyến mãi
  - Tìm kiếm sản phẩm theo tên
  - Thêm, sửa, xóa sản phẩm
  - Nhập thêm hàng (tăng số lượng tồn) cho sản phẩm đã chọn
- **Hóa đơn** (`FormHoaDon`)
- **Thống kê** (`FormThongKe`)

## Công nghệ sử dụng

| Thành phần | Chi tiết |
| --- | --- |
| Ngôn ngữ | C# |
| Framework | .NET 9 (`net9.0-windows`), Windows Forms |
| Database | MySQL 8, kết nối qua thư viện `MySql.Data` |
| Công cụ | Visual Studio / VS Code, MySQL Workbench |

## Cấu trúc thư mục

```
Cafe_Project_Group/
├── Models/                  # Các class dữ liệu (SanPham, ...)
├── DataAccess.cs            # Lớp truy cập database (connection string + truy vấn)
├── ComboKhuyenMai.cs        # Class combo khuyến mãi
├── FormDangNhap.cs          # Màn hình đăng nhập
├── FormChinh.cs             # Màn hình chính
├── FormSanPham.cs           # Quản lý sản phẩm
├── FormHoaDon.cs            # Hóa đơn
├── FormThongKe.cs           # Thống kê
├── Program.cs               # Điểm bắt đầu của ứng dụng
└── QuanLyQuanCafe_WF.csproj # File project
```

Các file `*.Designer.cs` và `*.resx` là code giao diện do Visual Studio tự sinh, thường không cần chỉnh tay.

## Yêu cầu cài đặt

- Windows 10/11
- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- MySQL Server 8.x và MySQL Workbench
- Visual Studio 2022 (workload **.NET desktop development**) hoặc VS Code có extension C# Dev Kit

## Hướng dẫn chạy project

### 1. Clone repo

```bash
git clone https://github.com/quang950/Cafe_Project_Group.git
cd Cafe_Project_Group
```

### 2. Tạo database

File script SQL không được đưa lên repo (đã nằm trong `.gitignore` vì chứa dữ liệu thật). Hãy xin file `.sql` từ người phụ trách database của nhóm, sau đó:

1. Mở MySQL Workbench và kết nối vào server local.
2. Chọn **Server → Data Import**, chọn **Import from Self-Contained File**, trỏ đến file `.sql`.
3. Tạo (hoặc chọn) schema tên `quanlyquancafe` rồi bấm **Start Import**.
4. Kiểm tra bằng lệnh `SHOW TABLES;`, phải thấy các bảng như `nhanvien`, `sanpham`, ...

### 3. Cấu hình connection string

Mở `DataAccess.cs`, tìm biến `connectionString` và sửa cho khớp với máy của bạn:

```csharp
private static string connectionString =
    "Server=localhost;Port=3306;Database=quanlyquancafe;Uid=<user>;Pwd=<password>;";
```

- `Uid` / `Pwd`: user và password MySQL trên máy bạn (thường là `root`).
- `Database`: tên schema bạn đã tạo ở bước 2.

> **Lưu ý:** không commit password thật của bạn lên GitHub.

### 4. Build và chạy

```bash
dotnet restore
dotnet build
dotnet run
```

Hoặc mở file `QuanLyQuanCafe_WF.csproj` bằng Visual Studio rồi nhấn **F5**.

### 5. Đăng nhập

Dùng một tài khoản có sẵn trong bảng `nhanvien` (mã nhân viên và mật khẩu). Kiểm tra bằng Workbench:

```sql
SELECT MaNV, TenNV FROM nhanvien;
```

## Thành viên nhóm

| Họ tên | Vai trò |
| --- | --- |
| _(điền tên)_ | _(điền vai trò)_ |
| _(điền tên)_ | _(điền vai trò)_ |
