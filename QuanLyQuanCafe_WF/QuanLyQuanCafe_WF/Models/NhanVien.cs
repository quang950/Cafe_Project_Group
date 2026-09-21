namespace QuanLyQuanCafe;

//*Nhân viên chỉ sử dụng với mục đích đăng nhập hệ thống | mã NV trong hóa đơn
public class NhanVien
{
    public string MaNV;
    public string TenNV;
    public string MatKhau;

    public NhanVien(string maNV, string tenNV, string matKhau)
    {
        MaNV = maNV;
        TenNV = tenNV;
        MatKhau = matKhau;
    }
}