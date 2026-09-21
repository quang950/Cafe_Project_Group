namespace QuanLyQuanCafe;

public class ComboKhuyenMai : SanPham, IKhuyenMai
{
    public int PhanTramGiam;

    public ComboKhuyenMai(string maSP, string tenSP, int giaGoc, int phanTramGiam) : base(maSP, tenSP, giaGoc)
    {
        PhanTramGiam = phanTramGiam;
    }

    //*Override lại abstract bên SanPham
    public override int TinhThanhTien(int soLuong)
    {
        int tongGoc = GiaGoc * soLuong;
        int tienGiam = TinhSoTienGiam(tongGoc);     //tiền giảm tính theo công thức hàm bên dưới
        return tongGoc - tienGiam;
    }

    public override string LayThongTinRieng()
    {
        return PhanTramGiam.ToString();
    }

    //*bắt buộc viết lại 2 hàm này vì :IKhuyenMai
    public int TinhSoTienGiam(int tongTien)     //tính số tiền được giảm = giá * % giảm
    {
        return tongTien * PhanTramGiam / 100;
    }

    public string LayThongTinKhuyenMai()
    {
        return "Giam " + PhanTramGiam + "%";
    }
}