namespace QuanLyQuanCafe;

public class DoUong : SanPham
{
    public char Size;

    //Vì constructor SanPham là protected và có tham số nên phải gọi base(tham số giống constructor)
    public DoUong(string maSP, string tenSP, int giaGoc, char size) : base(maSP, tenSP, giaGoc)
    {
        Size = size;
    }

    private int LayHeSo()
    {
        if (Size == 'S') return 1;
        else if (Size == 'M') return 2;
        else return 3;
    }

    //Override lại 2 phương thức abstract ở SanPham
    public override int TinhThanhTien(int soLuong)
    {
        return GiaGoc * soLuong * LayHeSo();
    }

    public override string LayThongTinRieng()
    {
        return Size.ToString();
    }
}