using QuanLyQuanCafe;
using QuanLyQuanCafe_WinForms;
using System.Linq;

namespace QuanLyQuanCafe_WF;

public partial class FormHoaDon : Form
{
    private List<SanPham> danhSachSanPham = new List<SanPham>();
    private string maHDHienTai = "";     // giữ mã hóa đơn đang thao tác
    private NhanVien nvDangNhap;         // truyền từ FormChinh qua để biết ai đang tạo hóa đơn

    public FormHoaDon(NhanVien nv)
    {
        InitializeComponent();
        nvDangNhap = nv;
    }

    private void FormHoaDon_Load(object sender, EventArgs e)
    {
        danhSachSanPham = DataAccess.LayDanhSachSanPham();

        // đổ danh sách tên sản phẩm vào ComboBox
        cboSanPham.DataSource = danhSachSanPham
            .Select(sp => sp.MaSP + " - " + sp.TenSP)
            .ToList();
    }

    private void btnTaoHoaDon_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtSoBan.Text.Trim(), out int soBan))
        {
            MessageBox.Show("So ban phai la so.");
            return;
        }

        maHDHienTai = DataAccess.TaoHoaDonMoi(soBan, nvDangNhap.MaNV);
        lblMaHD.Text = "Ma hoa don: " + maHDHienTai;
        MessageBox.Show("Da tao hoa don " + maHDHienTai);
    }

    private void btnThemMon_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(maHDHienTai))
        {
            MessageBox.Show("Ban phai tao hoa don truoc.");
            return;
        }

        if (cboSanPham.SelectedIndex < 0)
        {
            MessageBox.Show("Chua chon san pham.");
            return;
        }

        if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
        {
            MessageBox.Show("So luong khong hop le.");
            return;
        }

        SanPham sp = danhSachSanPham[cboSanPham.SelectedIndex];   // lấy đúng sản phẩm theo vị trí đang chọn

        bool ok = DataAccess.ThemMonVaoHoaDon(maHDHienTai, sp, soLuong);
        if (!ok)
        {
            MessageBox.Show("Khong du hang ton kho.");
            return;
        }

        sp.SoLuongTon -= soLuong;   // cập nhật luôn trong bộ nhớ để lần thêm sau kiểm tra đúng
        CapNhatBangChiTiet();
    }

    private void CapNhatBangChiTiet()
    {
        List<ChiTietHoaDon> chiTiet = DataAccess.LayChiTietTheoMaHD(maHDHienTai);   // viết thêm hàm này bên dưới

        dgvChiTiet.DataSource = null;
        dgvChiTiet.DataSource = chiTiet
            .Select(ct => new { ct.MaSP, ct.TenSP, ct.SoLuong, ct.DonGia, ct.ThanhTien })
            .ToList();

        int tongTien = chiTiet.Sum(ct => ct.ThanhTien);   // LINQ Sum thay cho vòng for TinhTongTien() cũ
        lblTongTien.Text = "Tong tien: " + tongTien.ToString("N0") + " d";
    }
}