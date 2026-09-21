namespace QuanLyQuanCafe_WF
{
    partial class FormSanPham
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvSanPham = new DataGridView();
            grpThem = new GroupBox();
            lblLoaiSanPham = new Label();
            cboLoaiMoi = new ComboBox();
            lblTenSanPham = new Label();
            txtTenMoi = new TextBox();
            lblGiaSanPham = new Label();
            txtGiaMoi = new TextBox();
            lblThuocTinh = new Label();
            txtThuocTinhMoi = new TextBox();
            lblSoLuongSanPham = new Label();
            txtSoLuongTonMoi = new TextBox();
            btnThemSanPham = new Button();
            grpChinhSua = new GroupBox();
            lblDangChonTitle = new Label();
            lblMaDaChon = new Label();
            lblTenSuaTitle = new Label();
            txtTenSua = new TextBox();
            lblGiaSuaTitle = new Label();
            txtGiaSua = new TextBox();
            btnSua = new Button();
            btnXoa = new Button();
            grpNhapHang = new GroupBox();
            lblSoLuongNhapTitle = new Label();
            txtSoLuongNhap = new TextBox();
            btnNhapHang = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            grpThem.SuspendLayout();
            grpChinhSua.SuspendLayout();
            grpNhapHang.SuspendLayout();
            SuspendLayout();
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 9F);
            lblTimKiem.Location = new Point(20, 22);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(90, 19);
            lblTimKiem.Text = "Tìm kiếm tên:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(110, 19);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 25);
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(52, 152, 219);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.Location = new Point(320, 17);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 29);
            btnTimKiem.Text = "TÌM KIẾM";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(20, 60);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.Size = new Size(560, 490);
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // grpThem
            // 
            grpThem.Font = new Font("Segoe UI", 9F);
            grpThem.Location = new Point(600, 20);
            grpThem.Name = "grpThem";
            grpThem.Size = new Size(320, 260);
            grpThem.Text = "Thêm sản phẩm mới";
            grpThem.Controls.Add(lblLoaiSanPham);
            grpThem.Controls.Add(cboLoaiMoi);
            grpThem.Controls.Add(lblTenSanPham);
            grpThem.Controls.Add(txtTenMoi);
            grpThem.Controls.Add(lblGiaSanPham);
            grpThem.Controls.Add(txtGiaMoi);
            grpThem.Controls.Add(lblThuocTinh);
            grpThem.Controls.Add(txtThuocTinhMoi);
            grpThem.Controls.Add(lblSoLuongSanPham);
            grpThem.Controls.Add(txtSoLuongTonMoi);
            grpThem.Controls.Add(btnThemSanPham);
            // 
            // lblLoaiSanPham
            // 
            lblLoaiSanPham.AutoSize = true;
            lblLoaiSanPham.Location = new Point(15, 32);
            lblLoaiSanPham.Name = "lblLoaiSanPham";
            lblLoaiSanPham.Size = new Size(35, 19);
            lblLoaiSanPham.Text = "Loại:";
            // 
            // cboLoaiMoi
            // 
            cboLoaiMoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiMoi.Items.AddRange(new object[] { "DoUong", "DoAn", "Combo" });
            cboLoaiMoi.Location = new Point(120, 29);
            cboLoaiMoi.Name = "cboLoaiMoi";
            cboLoaiMoi.Size = new Size(170, 25);
            // 
            // lblTenSanPham
            // 
            lblTenSanPham.AutoSize = true;
            lblTenSanPham.Location = new Point(15, 68);
            lblTenSanPham.Name = "lblTenSanPham";
            lblTenSanPham.Size = new Size(30, 19);
            lblTenSanPham.Text = "Tên:";
            // 
            // txtTenMoi
            // 
            txtTenMoi.Location = new Point(120, 65);
            txtTenMoi.Name = "txtTenMoi";
            txtTenMoi.Size = new Size(170, 25);
            // 
            // lblGiaSanPham
            // 
            lblGiaSanPham.AutoSize = true;
            lblGiaSanPham.Location = new Point(15, 104);
            lblGiaSanPham.Name = "lblGiaSanPham";
            lblGiaSanPham.Size = new Size(28, 19);
            lblGiaSanPham.Text = "Giá:";
            // 
            // txtGiaMoi
            // 
            txtGiaMoi.Location = new Point(120, 101);
            txtGiaMoi.Name = "txtGiaMoi";
            txtGiaMoi.Size = new Size(170, 25);
            // 
            // lblThuocTinh
            // 
            lblThuocTinh.AutoSize = true;
            lblThuocTinh.Location = new Point(15, 140);
            lblThuocTinh.Name = "lblThuocTinh";
            lblThuocTinh.Size = new Size(100, 19);
            lblThuocTinh.Text = "Thuộc tính riêng:";
            // 
            // txtThuocTinhMoi
            // 
            txtThuocTinhMoi.Location = new Point(120, 137);
            txtThuocTinhMoi.Name = "txtThuocTinhMoi";
            txtThuocTinhMoi.Size = new Size(170, 25);
            // 
            // lblSoLuongSanPham
            // 
            lblSoLuongSanPham.AutoSize = true;
            lblSoLuongSanPham.Location = new Point(15, 176);
            lblSoLuongSanPham.Name = "lblSoLuongSanPham";
            lblSoLuongSanPham.Size = new Size(90, 19);
            lblSoLuongSanPham.Text = "Số lượng tồn:";
            // 
            // txtSoLuongTonMoi
            // 
            txtSoLuongTonMoi.Location = new Point(120, 173);
            txtSoLuongTonMoi.Name = "txtSoLuongTonMoi";
            txtSoLuongTonMoi.Size = new Size(170, 25);
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.BackColor = Color.FromArgb(46, 204, 113);
            btnThemSanPham.FlatStyle = FlatStyle.Flat;
            btnThemSanPham.FlatAppearance.BorderSize = 0;
            btnThemSanPham.ForeColor = Color.White;
            btnThemSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemSanPham.Location = new Point(15, 210);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(275, 33);
            btnThemSanPham.Text = "THÊM SẢN PHẨM";
            btnThemSanPham.UseVisualStyleBackColor = false;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // grpChinhSua
            // 
            grpChinhSua.Font = new Font("Segoe UI", 9F);
            grpChinhSua.Location = new Point(600, 265);
            grpChinhSua.Name = "grpChinhSua";
            grpChinhSua.Size = new Size(320, 210);
            grpChinhSua.Text = "Sửa / xóa sản phẩm đã chọn trong bảng";
            grpChinhSua.Controls.Add(lblDangChonTitle);
            grpChinhSua.Controls.Add(lblMaDaChon);
            grpChinhSua.Controls.Add(lblTenSuaTitle);
            grpChinhSua.Controls.Add(txtTenSua);
            grpChinhSua.Controls.Add(lblGiaSuaTitle);
            grpChinhSua.Controls.Add(txtGiaSua);
            grpChinhSua.Controls.Add(btnSua);
            grpChinhSua.Controls.Add(btnXoa);
            // 
            // lblDangChonTitle
            // 
            lblDangChonTitle.AutoSize = true;
            lblDangChonTitle.Location = new Point(15, 32);
            lblDangChonTitle.Name = "lblDangChonTitle";
            lblDangChonTitle.Size = new Size(85, 19);
            lblDangChonTitle.Text = "Đang chọn:";
            // 
            // lblMaDaChon
            // 
            lblMaDaChon.AutoSize = true;
            lblMaDaChon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaDaChon.ForeColor = Color.FromArgb(44, 62, 80);
            lblMaDaChon.Location = new Point(110, 32);
            lblMaDaChon.Name = "lblMaDaChon";
            lblMaDaChon.Size = new Size(90, 19);
            lblMaDaChon.Text = "chưa chọn";
            // 
            // lblTenSuaTitle
            // 
            lblTenSuaTitle.AutoSize = true;
            lblTenSuaTitle.Location = new Point(15, 68);
            lblTenSuaTitle.Name = "lblTenSuaTitle";
            lblTenSuaTitle.Size = new Size(30, 19);
            lblTenSuaTitle.Text = "Tên:";
            // 
            // txtTenSua
            // 
            txtTenSua.Location = new Point(120, 65);
            txtTenSua.Name = "txtTenSua";
            txtTenSua.Size = new Size(170, 25);
            // 
            // lblGiaSuaTitle
            // 
            lblGiaSuaTitle.AutoSize = true;
            lblGiaSuaTitle.Location = new Point(15, 104);
            lblGiaSuaTitle.Name = "lblGiaSuaTitle";
            lblGiaSuaTitle.Size = new Size(28, 19);
            lblGiaSuaTitle.Text = "Giá:";
            // 
            // txtGiaSua
            // 
            txtGiaSua.Location = new Point(120, 101);
            txtGiaSua.Name = "txtGiaSua";
            txtGiaSua.Size = new Size(170, 25);
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(52, 152, 219);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.ForeColor = Color.White;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Location = new Point(15, 140);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 33);
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(231, 76, 60);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.ForeColor = Color.White;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(160, 140);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 33);
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // grpNhapHang
            // 
            grpNhapHang.Font = new Font("Segoe UI", 9F);
            grpNhapHang.Location = new Point(600, 485);
            grpNhapHang.Name = "grpNhapHang";
            grpNhapHang.Size = new Size(320, 65);
            grpNhapHang.Text = "Nhập thêm hàng cho sp đã chọn";
            grpNhapHang.Controls.Add(lblSoLuongNhapTitle);
            grpNhapHang.Controls.Add(txtSoLuongNhap);
            grpNhapHang.Controls.Add(btnNhapHang);
            // 
            // lblSoLuongNhapTitle
            // 
            lblSoLuongNhapTitle.AutoSize = true;
            lblSoLuongNhapTitle.Location = new Point(15, 30);
            lblSoLuongNhapTitle.Name = "lblSoLuongNhapTitle";
            lblSoLuongNhapTitle.Size = new Size(70, 19);
            lblSoLuongNhapTitle.Text = "Số lượng:";
            // 
            // txtSoLuongNhap
            // 
            txtSoLuongNhap.Location = new Point(105, 27);
            txtSoLuongNhap.Name = "txtSoLuongNhap";
            txtSoLuongNhap.Size = new Size(80, 25);
            // 
            // btnNhapHang
            // 
            btnNhapHang.BackColor = Color.FromArgb(46, 204, 113);
            btnNhapHang.FlatStyle = FlatStyle.Flat;
            btnNhapHang.FlatAppearance.BorderSize = 0;
            btnNhapHang.ForeColor = Color.White;
            btnNhapHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhapHang.Location = new Point(195, 25);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Size = new Size(110, 29);
            btnNhapHang.Text = "NHẬP HÀNG";
            btnNhapHang.UseVisualStyleBackColor = false;
            btnNhapHang.Click += btnNhapHang_Click;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 570);
            Controls.Add(lblTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvSanPham);
            Controls.Add(grpThem);
            Controls.Add(grpChinhSua);
            Controls.Add(grpNhapHang);
            MinimumSize = new Size(850, 500);
            Name = "FormSanPham";
            Text = "Quản lý sản phẩm";
            Load += FormSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            grpThem.ResumeLayout(false);
            grpThem.PerformLayout();
            grpChinhSua.ResumeLayout(false);
            grpChinhSua.PerformLayout();
            grpNhapHang.ResumeLayout(false);
            grpNhapHang.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvSanPham;
        private GroupBox grpThem;
        private Label lblLoaiSanPham;
        private ComboBox cboLoaiMoi;
        private Label lblTenSanPham;
        private TextBox txtTenMoi;
        private Label lblGiaSanPham;
        private TextBox txtGiaMoi;
        private Label lblThuocTinh;
        private TextBox txtThuocTinhMoi;
        private Label lblSoLuongSanPham;
        private TextBox txtSoLuongTonMoi;
        private Button btnThemSanPham;
        private GroupBox grpChinhSua;
        private Label lblDangChonTitle;
        private Label lblMaDaChon;
        private Label lblTenSuaTitle;
        private TextBox txtTenSua;
        private Label lblGiaSuaTitle;
        private TextBox txtGiaSua;
        private Button btnSua;
        private Button btnXoa;
        private GroupBox grpNhapHang;
        private Label lblSoLuongNhapTitle;
        private TextBox txtSoLuongNhap;
        private Button btnNhapHang;
    }
}