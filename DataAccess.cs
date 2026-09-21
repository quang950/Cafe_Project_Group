using MySqlConnector;
using QuanLyQuanCafe;
using System.Linq;
using System.Collections.Generic;
using System;

namespace QuanLyQuanCafe_WinForms;

public static class DataAccess
{
    private static string connectionString = "Server=localhost;Port=3306;Database=quanlyquancafe;Uid=root;Pwd=123456;";

    public static bool KiemTraKetNoi()
    {
        try
        {
            using MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            return true;
        }
        catch //(Exception ex)
        {
           // MessageBox.Show(ex.Message);
            return false;
        }
    }

    //*Đọc toàn bộ sản phẩm từ bảng sanpham, tái tạo đúng loại (DoUong/DoAn/ComboKhuyenMai)
    public static List<SanPham> LayDanhSachSanPham()
    {
        List<SanPham> ketQua = new List<SanPham>();

        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();

        string sql = "SELECT MaSP, Loai, TenSP, GiaGoc, ThuocTinhRieng, SoLuongTon FROM sanpham";
        using MySqlCommand cmd = new MySqlCommand(sql, conn);
        using MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            string maSP = reader.GetString("MaSP");
            string loai = reader.GetString("Loai");
            string tenSP = reader.GetString("TenSP");
            int giaGoc = reader.GetInt32("GiaGoc");
            string thuocTinhRieng = reader.IsDBNull(reader.GetOrdinal("ThuocTinhRieng")) ? "" : reader.GetString("ThuocTinhRieng");
            int soLuongTon = reader.GetInt32("SoLuongTon");

            SanPham sp;

            if (loai == "DoUong")
            {
                char size = thuocTinhRieng[0];
                sp = new DoUong(maSP, tenSP, giaGoc, size);
            }
            else if (loai == "DoAn")
            {
                bool cay = bool.Parse(thuocTinhRieng);
                sp = new DoAn(maSP, tenSP, giaGoc, cay);
            }
            else // Combo
            {
                int phanTramGiam = int.Parse(thuocTinhRieng);
                sp = new ComboKhuyenMai(maSP, tenSP, giaGoc, phanTramGiam);
            }

            sp.SoLuongTon = soLuongTon;
            ketQua.Add(sp);
        }

        return ketQua;
    }

    public static List<NhanVien> LayDanhSachNhanVien()
    {
        List<NhanVien> ketQua = new List<NhanVien>();

        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();

        string sql = "SELECT MaNV, TenNV, MatKhau FROM nhanvien";
        using MySqlCommand cmd = new MySqlCommand(sql, conn);
        using MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            string maNV = reader.GetString("MaNV");
            string tenNV = reader.GetString("TenNV");
            string matKhau = reader.GetString("MatKhau");
            ketQua.Add(new NhanVien(maNV, tenNV, matKhau));
        }

        return ketQua;
    }
    public static NhanVien DangNhap(string maNV, string matKhau)
    {
        List<NhanVien> danhSach = LayDanhSachNhanVien();
        return danhSach.FirstOrDefault(nv => nv.MaNV == maNV && nv.MatKhau == matKhau);
    }

    //*Sinh mã hóa đơn mới, dựa theo mã lớn nhất hiện có trong bảng hoadon (thay cho biến static soLuongHoaDon cũ)
    public static string TaoMaHoaDonMoi()
    {
        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();

        string sql = "SELECT MaHD FROM hoadon ORDER BY MaHD DESC LIMIT 1";
        using MySqlCommand cmd = new MySqlCommand(sql, conn);
        object ketQua = cmd.ExecuteScalar();   // ExecuteScalar: dùng khi chỉ cần lấy đúng 1 giá trị, không cần cả bảng

        int soThuTu = 0;
        if (ketQua != null)
        {
            string maCuoi = ketQua.ToString();          // vd "HD007"
            soThuTu = int.Parse(maCuoi.Substring(2));    // cắt "HD" lấy phần số
        }
        soThuTu += 1;
        return "HD" + soThuTu.ToString("D3");            // "HD008"
    }

    //*Tạo hóa đơn mới, lưu xuống bảng hoadon, trả về mã vừa tạo
    public static string TaoHoaDonMoi(int soBan, string maNV)
    {
        string maHD = TaoMaHoaDonMoi();

        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();

        string sql = "INSERT INTO hoadon (MaHD, NgayGioThang, SoBan, MaNV) VALUES (@maHD, @ngayGio, @soBan, @maNV)";
        using MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@maHD", maHD);
        cmd.Parameters.AddWithValue("@ngayGio", DateTime.Now);
        cmd.Parameters.AddWithValue("@soBan", soBan);
        cmd.Parameters.AddWithValue("@maNV", maNV);
        cmd.ExecuteNonQuery();      // ExecuteNonQuery: dùng cho INSERT/UPDATE/DELETE, không trả về dữ liệu

        return maHD;
    }

    //*Thêm 1 món vào hóa đơn: ghi chi tiết + trừ tồn kho, tái sử dụng logic tính tiền có sẵn từ class ChiTietHoaDon
    public static bool ThemMonVaoHoaDon(string maHD, SanPham sp, int soLuong)
    {
        if (sp.SoLuongTon < soLuong) return false;   // không đủ hàng

        ChiTietHoaDon ct = new ChiTietHoaDon(maHD, sp, soLuong);   // dùng đúng constructor cũ để tính ThanhTien/DonGia

        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();

        string sqlInsert = "INSERT INTO chitiethoadon (MaHD, MaSP, TenSP, SoLuong, DonGia, ThanhTien) " +
                            "VALUES (@maHD, @maSP, @tenSP, @soLuong, @donGia, @thanhTien)";
        using (MySqlCommand cmd = new MySqlCommand(sqlInsert, conn))
        {
            cmd.Parameters.AddWithValue("@maHD", ct.MaHD);
            cmd.Parameters.AddWithValue("@maSP", ct.MaSP);
            cmd.Parameters.AddWithValue("@tenSP", ct.TenSP);
            cmd.Parameters.AddWithValue("@soLuong", ct.SoLuong);
            cmd.Parameters.AddWithValue("@donGia", ct.DonGia);
            cmd.Parameters.AddWithValue("@thanhTien", ct.ThanhTien);
            cmd.ExecuteNonQuery();
        }

        string sqlUpdate = "UPDATE sanpham SET SoLuongTon = SoLuongTon - @soLuong WHERE MaSP = @maSP";
        using (MySqlCommand cmd2 = new MySqlCommand(sqlUpdate, conn))
        {
            cmd2.Parameters.AddWithValue("@soLuong", soLuong);
            cmd2.Parameters.AddWithValue("@maSP", sp.MaSP);
            cmd2.ExecuteNonQuery();
        }

        return true;
    }

    public static List<ChiTietHoaDon> LayChiTietTheoMaHD(string maHD)
    {
        List<ChiTietHoaDon> ketQua = new List<ChiTietHoaDon>();

        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();

        string sql = "SELECT MaHD, MaSP, TenSP, SoLuong, DonGia, ThanhTien FROM chitiethoadon WHERE MaHD = @maHD";
        using MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@maHD", maHD);
        using MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            ketQua.Add(new ChiTietHoaDon(
                reader.GetString("MaHD"),
                reader.GetString("MaSP"),
                reader.GetString("TenSP"),
                reader.GetInt32("SoLuong"),
                reader.GetInt32("DonGia"),
                reader.GetInt32("ThanhTien")
            ));
        }

        return ketQua;
    }

    //*Đọc toàn bộ hóa đơn + chi tiết, dựng lại giống hệt DocDuLieu() cũ trong QuanLyHoaDon
    public static List<HoaDon> LayTatCaHoaDon()
    {
        List<HoaDon> ketQua = new List<HoaDon>();

        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();

        string sqlHD = "SELECT MaHD, NgayGioThang, SoBan, MaNV FROM hoadon";
        using (MySqlCommand cmd = new MySqlCommand(sqlHD, conn))
        using (MySqlDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                string maHD = reader.GetString("MaHD");
                DateTime ngayGioThang = reader.GetDateTime("NgayGioThang");
                int soBan = reader.GetInt32("SoBan");
                string maNV = reader.IsDBNull(reader.GetOrdinal("MaNV")) ? "" : reader.GetString("MaNV");

                ketQua.Add(new HoaDon(maHD, ngayGioThang, soBan, maNV));   // dùng đúng constructor "đọc lại" cũ
            }
        }

        // đọc riêng toàn bộ chi tiết, rồi dùng LINQ tìm đúng hóa đơn để gắn vào
        string sqlCT = "SELECT MaHD, MaSP, TenSP, SoLuong, DonGia, ThanhTien FROM chitiethoadon";
        using (MySqlCommand cmd2 = new MySqlCommand(sqlCT, conn))
        using (MySqlDataReader reader2 = cmd2.ExecuteReader())
        {
            while (reader2.Read())
            {
                string maHD = reader2.GetString("MaHD");
                ChiTietHoaDon ct = new ChiTietHoaDon(
                    maHD,
                    reader2.GetString("MaSP"),
                    reader2.GetString("TenSP"),
                    reader2.GetInt32("SoLuong"),
                    reader2.GetInt32("DonGia"),
                    reader2.GetInt32("ThanhTien")
                );

                HoaDon hd = ketQua.FirstOrDefault(h => h.MaHD == maHD);
                hd?.ThemChiTietDaCo(ct);
            }
        }

        return ketQua;
    }

    //*Sinh mã sản phẩm mới, theo đúng logic TaoMaTuDong cũ (dựa trên tổng số sản phẩm hiện có)
    public static string TaoMaSanPhamMoi(string tienTo)
    {
        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();

        string sql = "SELECT COUNT(*) FROM sanpham";
        using MySqlCommand cmd = new MySqlCommand(sql, conn);
        long tongSo = (long)cmd.ExecuteScalar();

        int soThuTu = (int)tongSo + 1;
        return tienTo + soThuTu.ToString("D3");
    }

    //*Thêm sản phẩm mới (chung cho cả 3 loại, dựa vào kiểu thực tế của tham số sp)
    public static void ThemSanPham(SanPham sp)
    {
        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();

        string loai = sp is DoUong ? "DoUong" : sp is DoAn ? "DoAn" : "Combo";

        string sql = "INSERT INTO sanpham (MaSP, Loai, TenSP, GiaGoc, ThuocTinhRieng, SoLuongTon) " +
                     "VALUES (@maSP, @loai, @tenSP, @giaGoc, @thuocTinhRieng, @soLuongTon)";
        using MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@maSP", sp.MaSP);
        cmd.Parameters.AddWithValue("@loai", loai);
        cmd.Parameters.AddWithValue("@tenSP", sp.TenSP);
        cmd.Parameters.AddWithValue("@giaGoc", sp.GiaGoc);
        cmd.Parameters.AddWithValue("@thuocTinhRieng", sp.LayThongTinRieng());
        cmd.Parameters.AddWithValue("@soLuongTon", sp.SoLuongTon);
        cmd.ExecuteNonQuery();
    }

    //*Xóa sản phẩm theo mã, trả về true nếu xóa được (có dòng bị ảnh hưởng)
    public static bool XoaSanPham(string maSP)
    {
        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();

        string sql = "DELETE FROM sanpham WHERE MaSP = @maSP";
        using MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@maSP", maSP);

        int soDongBiAnhHuong = cmd.ExecuteNonQuery();
        return soDongBiAnhHuong > 0;
    }

    //*Sửa tên + giá (giữ đúng phạm vi giống SuaSanPham cũ, không cho sửa Loai/ThuocTinhRieng để tránh sai lệch dữ liệu)
    public static bool SuaTenGia(string maSP, string tenMoi, int giaMoi)
    {
        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();

        string sql = "UPDATE sanpham SET TenSP = @ten, GiaGoc = @gia WHERE MaSP = @maSP";
        using MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@ten", tenMoi);
        cmd.Parameters.AddWithValue("@gia", giaMoi);
        cmd.Parameters.AddWithValue("@maSP", maSP);

        int soDongBiAnhHuong = cmd.ExecuteNonQuery();
        return soDongBiAnhHuong > 0;
    }

    //*Nhập thêm hàng, cộng dồn vào SoLuongTon hiện có
    public static bool NhapHang(string maSP, int soLuongNhap)
    {
        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();

        string sql = "UPDATE sanpham SET SoLuongTon = SoLuongTon + @soLuong WHERE MaSP = @maSP";
        using MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@soLuong", soLuongNhap);
        cmd.Parameters.AddWithValue("@maSP", maSP);

        int soDongBiAnhHuong = cmd.ExecuteNonQuery();
        return soDongBiAnhHuong > 0;
    }
}