using QuanLyQuanCafe;
using QuanLyQuanCafe_WinForms;
using System.Linq;

namespace QuanLyQuanCafe_WF;

public partial class FormThongKe : Form
{
    private List<HoaDon> tatCaHoaDon = new List<HoaDon>();

    public FormThongKe()
    {
        InitializeComponent();
    }

    private void FormThongKe_Load(object sender, EventArgs e)
    {
        tatCaHoaDon = DataAccess.LayTatCaHoaDon();
    }

    private void btnTheoNgay_Click(object sender, EventArgs e)
    {
        DateTime ngay = dtpNgay.Value;

        int doanhThu = tatCaHoaDon
            .Where(hd => hd.NgayGioThang.Date == ngay.Date)
            .Sum(hd => hd.TinhTongTien());

        lblKetQua.Text = "Doanh thu ngay " + ngay.ToString("dd/MM/yyyy") + ": " + doanhThu.ToString("N0") + " d";
    }

    private void btnTheoThang_Click(object sender, EventArgs e)
    {
        int thang = (int)nudThang.Value;
        int nam = (int)nudNam1.Value;

        int doanhThu = tatCaHoaDon
            .Where(hd => hd.NgayGioThang.Month == thang && hd.NgayGioThang.Year == nam)
            .Sum(hd => hd.TinhTongTien());

        lblKetQua.Text = "Doanh thu thang " + thang + "/" + nam + ": " + doanhThu.ToString("N0") + " d";
    }

    private void btnTheoQuy_Click(object sender, EventArgs e)
    {
        int quy = (int)nudQuy.Value;
        int nam = (int)nudNam2.Value;
        int thangKetThuc = quy * 3;
        int thangBatDau = thangKetThuc - 2;

        int doanhThu = tatCaHoaDon
            .Where(hd => hd.NgayGioThang.Year == nam
                      && hd.NgayGioThang.Month >= thangBatDau
                      && hd.NgayGioThang.Month <= thangKetThuc)
            .Sum(hd => hd.TinhTongTien());

        lblKetQua.Text = "Doanh thu quy " + quy + "/" + nam + ": " + doanhThu.ToString("N0") + " d";
    }

    private void btnTheoNam_Click(object sender, EventArgs e)
    {
        int nam = (int)nudNam3.Value;

        int doanhThu = tatCaHoaDon
            .Where(hd => hd.NgayGioThang.Year == nam)
            .Sum(hd => hd.TinhTongTien());

        lblKetQua.Text = "Doanh thu nam " + nam + ": " + doanhThu.ToString("N0") + " d";
    }
}
