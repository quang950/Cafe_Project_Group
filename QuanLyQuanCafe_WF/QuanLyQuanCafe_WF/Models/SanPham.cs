namespace QuanLyQuanCafe;

public abstract class SanPham
{
    private static int soLuongSanPham = 0;

    public string MaSP;
    public string TenSP;
    public int GiaGoc;
    public int SoLuongTon;
    
    //Dùng protected để chỉ lớp con mới gọi được qua base
    public SanPham(string MaSP, string TenSP, int GiaGoc)
    {
        this.MaSP = MaSP;
        this.TenSP = TenSP;
        this.GiaGoc = GiaGoc;
        soLuongSanPham += 1;
    }

    public abstract int TinhThanhTien(int soLuong);
    public abstract string LayThongTinRieng();

    //Class con thích thì override ko thì dùng lại code trong hàm này cũng đc
    //*Dùng ở Menu hiện toàn bộ sản phẩm theo cái format này
    public virtual string HienThiThongTin()
    {
        return MaSP + " - " + TenSP + " - " + GiaGoc + "VND" + " - Ton kho: " + SoLuongTon;
    }

    //Output ex: DU007 / DA007 | ToString("D3") sẽ viết theo dạng 7 -> 007
    public static string TaoMaTuDong(string tienTo, int soThuTu)
    {
        string soDem = soThuTu.ToString("D3");
        return tienTo + soDem;
    }
}