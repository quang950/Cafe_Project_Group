namespace QuanLyQuanCafe;

public class DoAn : SanPham
{
    public bool Cay;

    //Vì constructor SanPham là protected và có tham số nên phải gọi base(tham số giống constructor)
    public DoAn(string maSP, string tenSP, int giaGoc, bool cay) : base(maSP, tenSP, giaGoc)
    {
        Cay = cay;
    }

    //Override lại 2 phương thức abstract ở SanPham
    public override int TinhThanhTien(int soLuong)
    {
        return GiaGoc * soLuong;
    }

    public override string LayThongTinRieng()
    {
        return Cay.ToString();
    }
}