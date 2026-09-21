using QuanLyQuanCafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe_WF
{
    public partial class FormChinh : Form
    {
        private NhanVien nvDangNhap;
        public FormChinh(NhanVien nv)
        {
            InitializeComponent();
            nvDangNhap = nv;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FormSanPham fsp = new FormSanPham();
            fsp.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon fhd = new FormHoaDon(nvDangNhap);
            fhd.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe ftk = new FormThongKe();
            ftk.ShowDialog();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            lblNhanVien.Text = "Xin chào " + nvDangNhap.TenNV;
        }
    }
}
