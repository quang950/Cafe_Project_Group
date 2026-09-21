using QuanLyQuanCafe;
using QuanLyQuanCafe_WinForms;

namespace QuanLyQuanCafe_WF;

public partial class FormDangNhap : Form
{
    public FormDangNhap()
    {
        InitializeComponent();
    }

    private void btnDangNhap_Click(object sender, EventArgs e)
    {
        string maNV = txtMaNV.Text.Trim();
        string matKhau = txtMatKhau.Text.Trim();    

        if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(matKhau))
        {
            MessageBox.Show("Vui long nhap day du ma NV va mat khau.");
            return;
        }

        NhanVien nv = DataAccess.DangNhap(maNV, matKhau);
        if (nv == null)
        {
            MessageBox.Show("Sai ma nhan vien hoac mat khau.");
            return;
        }

        this.Hide();                 // ẩn form đăng nhập
        FormChinh fc = new FormChinh(nv);
        fc.ShowDialog();              // mở form chính, chờ đến khi form chính đóng
        this.Close();                 // đóng hẳn form đăng nhập khi form chính đã đóng
    }

}