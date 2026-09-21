using System;

namespace QuanLyQuanCafe;

public class HoaDon
{
    private static int soLuongHoaDon = 0;   //số lượng hóa đơn trong kho
    private int sucChuaChiTiet;     //*tổng số chi tiết tối đa trên 1 hóa đơn

    public string MaHD;
    public DateTime NgayGioThang;
    public int SoBan;
    public ChiTietHoaDon[] DanhSachChiTiet;
    public int SoLuongChiTiet;  //*số chi tiết trên hóa đơn vừa lập

    public string MaNV;

    //*Dừng ở Quản lý hóa đơn khi cần new 1 cái hóa đơn mới có sẵn mã tự động
    public HoaDon(int soBan, string maNV)    //constructor | do các tham số kia là tự động nên không cần viết, soBan do người dùng nhập vào
    {
        soLuongHoaDon += 1;     //mỗi lần new là số lượng tăng lên
        MaHD = TaoMaHoaDon();
        NgayGioThang = DateTime.Now;
        SoBan = soBan;
        MaNV = maNV;
        sucChuaChiTiet = 50;    //khai báo giá trị trước, nếu chi tiết trên 1 hóa đơn vượt quá số này thì dùng hàm mở rộng bên dưới
        DanhSachChiTiet = new ChiTietHoaDon[sucChuaChiTiet];
        SoLuongChiTiet = 0;
    }

    //*Dùng khi đọc lại hóa đơn đã có sẵn từ MySQL, không sinh mã mới, chỉ cập nhật lại bộ đếm cho đúng
    public HoaDon(string maHD, DateTime ngayGioThang, int soBan, string maNV)
    {
        MaHD = maHD;
        NgayGioThang = ngayGioThang;
        SoBan = soBan;
        MaNV = maNV;
        sucChuaChiTiet = 50;
        DanhSachChiTiet = new ChiTietHoaDon[sucChuaChiTiet];
        SoLuongChiTiet = 0;

        CapNhatSoLuongHoaDonSauKhiDoc(maHD);
    }

    private static string TaoMaHoaDon()
    {
        string soDem = soLuongHoaDon.ToString("D3");
        return "HD" + soDem;
    }

    //*Nếu muốn mỗi lần thêm thì tăng mảng lên 1 thì phải copy mảng cũ qua mảng mới nhiều lần -> giảm hiệu năng -> nên ban đầu cho số 50 là tối đa, max thì gấp đôi lên
    private void MoRongMangChiTiet()    //khi số lượng chi tiết trên 1 hóa đơn vượt quá 50 thì cần dùng tới hàm này
    {
        sucChuaChiTiet *= 2;
        Array.Resize(ref DanhSachChiTiet, sucChuaChiTiet);
    }

    //*Đảm bảo số lượng hóa đơn luôn = mã số hóa đơn lớn nhất | 
    //*nếu mảng chỉ có 20 hóa đơn HD001... HD020 mà thêm trực tiếp HD099 bằng tay thì soLuongHoaDon sẽ nhảy lên 99 và hóa đơn sau đó sẽ là HD100 | 
    //*chỉ ảnh hưởng đến mã hóa đơn tạo sau đó không ảnh hưởng đến các hàm tính toán nào
    //*Dùng ở constructor ở trên
    private static void CapNhatSoLuongHoaDonSauKhiDoc(string maHD)
    {
        string phanSo = maHD.Substring(2);  //cắt 2 ký tự đầu của mã HD ra "HD" để chỉ lấy phần số
        int soThuTu = int.Parse(phanSo);
        if (soThuTu > soLuongHoaDon)    //đảm bảo không bị trùng mã khi tạo hóa đơn tiếp theo sau khi đã đọc qua nhiều hóa đơn trong file
        {
            soLuongHoaDon = soThuTu;
        }
    }

    //*Khi thêm chi tiết vào 1 hóa đơn đang được tạo
    public void ThemChiTiet(SanPham sp, int soLuong)    
    {
        if(SoLuongChiTiet >= sucChuaChiTiet)
        {
            MoRongMangChiTiet();
        }
        DanhSachChiTiet[SoLuongChiTiet] = new ChiTietHoaDon(MaHD, sp, soLuong);
        SoLuongChiTiet += 1;
    }

    //*Khi đọc dữ liệu cũ từ chitiet_hoadon.txt đã có sẵn đầy đủ thông tin và không cần đến đối tượng SanPham gốc, 
    //*dùng ở hàm đọc dữ liệu trong Quản lý hóa đơn để thêm chi tiết vào bộ nhớ nhanh hơn
    public void ThemChiTietDaCo(ChiTietHoaDon ct)
    {
        if(SoLuongChiTiet >= sucChuaChiTiet)
        {
            MoRongMangChiTiet();
        }
        DanhSachChiTiet[SoLuongChiTiet] = ct;
        SoLuongChiTiet += 1;
    }

    //*Tính tổng tiền từ các chi tiết hóa đơn
    public int TinhTongTien()
    {
        int tong = 0;
        for (int i = 0; i < SoLuongChiTiet; i++)
        {
            tong += DanhSachChiTiet[i].ThanhTien;
        }
        return tong;
    }
}