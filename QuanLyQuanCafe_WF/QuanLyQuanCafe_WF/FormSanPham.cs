using QuanLyQuanCafe;
using QuanLyQuanCafe_WinForms;
using System.Linq;

namespace QuanLyQuanCafe_WF;

public partial class FormSanPham : Form
{
    private List<SanPham> danhSachGoc = new List<SanPham>();
    private string maSPDangChon = "";   // lưu mã sản phẩm đang được click chọn trên lưới

    public FormSanPham()
    {
        InitializeComponent();
    }

    private void FormSanPham_Load(object sender, EventArgs e)
    {
        danhSachGoc = DataAccess.LayDanhSachSanPham();
        HienThiLenLuoi(danhSachGoc);
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
        string tuKhoa = txtTimKiem.Text.Trim().ToLower();
        List<SanPham> ketQua = danhSachGoc.Where(sp => sp.TenSP.ToLower().Contains(tuKhoa)).ToList();
        HienThiLenLuoi(ketQua);
    }

    private void HienThiLenLuoi(List<SanPham> danhSach)
    {
        dgvSanPham.DataSource = null;
        dgvSanPham.DataSource = danhSach
            .Select(sp => new { sp.MaSP, sp.TenSP, sp.GiaGoc, sp.SoLuongTon, ThongTinRieng = sp.LayThongTinRieng() })
            .ToList();
    }

    // --- Chọn dòng trên lưới để chuẩn bị Sửa/Xóa/Nhập hàng ---
    private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;   // click vào header thì bỏ qua

        maSPDangChon = dgvSanPham.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
        lblMaDaChon.Text = "Da chon: " + maSPDangChon;

        SanPham sp = danhSachGoc.FirstOrDefault(s => s.MaSP == maSPDangChon);
        if (sp != null)
        {
            txtTenSua.Text = sp.TenSP;
            txtGiaSua.Text = sp.GiaGoc.ToString();
        }
    }

    // --- Thêm sản phẩm mới ---
    private void btnThemSanPham_Click(object sender, EventArgs e)
    {
        if (cboLoaiMoi.SelectedItem == null)
        {
            MessageBox.Show("Chua chon loai san pham.");
            return;
        }

        string ten = txtTenMoi.Text.Trim();
        if (string.IsNullOrEmpty(ten))
        {
            MessageBox.Show("Chua nhap ten san pham.");
            return;
        }

        if (!int.TryParse(txtGiaMoi.Text.Trim(), out int gia))
        {
            MessageBox.Show("Gia khong hop le.");
            return;
        }

        if (!int.TryParse(txtSoLuongTonMoi.Text.Trim(), out int soLuongTon))
        {
            soLuongTon = 0;
        }

        string loai = cboLoaiMoi.SelectedItem.ToString();
        string thuocTinh = txtThuocTinhMoi.Text.Trim();

        SanPham spMoi;
        try
        {
            if (loai == "DoUong")
            {
                char size = thuocTinh[0];
                string maMoi = DataAccess.TaoMaSanPhamMoi("DU");
                spMoi = new DoUong(maMoi, ten, gia, size);
            }
            else if (loai == "DoAn")
            {
                bool cay = bool.Parse(thuocTinh);
                string maMoi = DataAccess.TaoMaSanPhamMoi("DA");
                spMoi = new DoAn(maMoi, ten, gia, cay);
            }
            else
            {
                int phanTramGiam = int.Parse(thuocTinh);
                string maMoi = DataAccess.TaoMaSanPhamMoi("CB");
                spMoi = new ComboKhuyenMai(maMoi, ten, gia, phanTramGiam);
            }
        }
        catch
        {
            MessageBox.Show("Thuoc tinh rieng khong hop le voi loai da chon.\n" +
                             "DoUong: nhap 1 ky tu (S/M/L)\nDoAn: nhap true hoac false\nCombo: nhap so phan tram giam");
            return;
        }

        spMoi.SoLuongTon = soLuongTon;
        DataAccess.ThemSanPham(spMoi);

        MessageBox.Show("Da them san pham " + spMoi.MaSP);
        FormSanPham_Load(sender, e);   // load lại toàn bộ danh sách cho cập nhật
    }

    // --- Sửa tên + giá ---
    private void btnSua_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(maSPDangChon))
        {
            MessageBox.Show("Chua chon san pham nao tren luoi.");
            return;
        }

        string tenMoi = txtTenSua.Text.Trim();
        if (!int.TryParse(txtGiaSua.Text.Trim(), out int giaMoi))
        {
            MessageBox.Show("Gia khong hop le.");
            return;
        }

        bool ok = DataAccess.SuaTenGia(maSPDangChon, tenMoi, giaMoi);
        MessageBox.Show(ok ? "Da sua." : "Khong tim thay.");
        FormSanPham_Load(sender, e);
    }

    // --- Xóa ---
    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(maSPDangChon))
        {
            MessageBox.Show("Chua chon san pham nao tren luoi.");
            return;
        }

        DialogResult xacNhan = MessageBox.Show("Xac nhan xoa " + maSPDangChon + "?", "Xac nhan", MessageBoxButtons.YesNo);
        if (xacNhan != DialogResult.Yes) return;

        bool ok = DataAccess.XoaSanPham(maSPDangChon);
        MessageBox.Show(ok ? "Da xoa." : "Khong tim thay.");
        maSPDangChon = "";
        lblMaDaChon.Text = "Chua chon";
        FormSanPham_Load(sender, e);
    }

    // --- Nhập thêm hàng ---
    private void btnNhapHang_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(maSPDangChon))
        {
            MessageBox.Show("Chua chon san pham nao tren luoi.");
            return;
        }

        if (!int.TryParse(txtSoLuongNhap.Text.Trim(), out int soLuongNhap) || soLuongNhap <= 0)
        {
            MessageBox.Show("So luong nhap khong hop le.");
            return;
        }

        bool ok = DataAccess.NhapHang(maSPDangChon, soLuongNhap);
        MessageBox.Show(ok ? "Da nhap them hang." : "Khong tim thay.");
        FormSanPham_Load(sender, e);
    }
}