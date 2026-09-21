namespace QuanLyQuanCafe_WF
{
    partial class FormHoaDon
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
            grpTaoHoaDon = new GroupBox();
            lblSoBan = new Label();
            txtSoBan = new TextBox();
            btnTaoHoaDon = new Button();
            lblMaHD = new Label();
            grpThemMon = new GroupBox();
            lblChonSanPham = new Label();
            cboSanPham = new ComboBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            btnThemMon = new Button();
            dgvChiTiet = new DataGridView();
            lblTongTien = new Label();
            grpTaoHoaDon.SuspendLayout();
            grpThemMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // grpTaoHoaDon
            // 
            grpTaoHoaDon.Font = new Font("Segoe UI", 9F);
            grpTaoHoaDon.Location = new Point(20, 20);
            grpTaoHoaDon.Name = "grpTaoHoaDon";
            grpTaoHoaDon.Size = new Size(350, 90);
            grpTaoHoaDon.Text = "Tao hoa don";
            grpTaoHoaDon.Controls.Add(lblSoBan);
            grpTaoHoaDon.Controls.Add(txtSoBan);
            grpTaoHoaDon.Controls.Add(btnTaoHoaDon);
            grpTaoHoaDon.Controls.Add(lblMaHD);
            // 
            // lblSoBan
            // 
            lblSoBan.AutoSize = true;
            lblSoBan.Location = new Point(15, 32);
            lblSoBan.Name = "lblSoBan";
            lblSoBan.Size = new Size(50, 19);
            lblSoBan.Text = "So ban:";
            // 
            // txtSoBan
            // 
            txtSoBan.Location = new Point(75, 29);
            txtSoBan.Name = "txtSoBan";
            txtSoBan.Size = new Size(70, 25);
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.BackColor = Color.FromArgb(46, 204, 113);
            btnTaoHoaDon.FlatStyle = FlatStyle.Flat;
            btnTaoHoaDon.FlatAppearance.BorderSize = 0;
            btnTaoHoaDon.ForeColor = Color.White;
            btnTaoHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTaoHoaDon.Location = new Point(160, 25);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(160, 33);
            btnTaoHoaDon.Text = "TAO HOA DON MOI";
            btnTaoHoaDon.UseVisualStyleBackColor = false;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaHD.ForeColor = Color.FromArgb(44, 62, 80);
            lblMaHD.Location = new Point(15, 63);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(140, 19);
            lblMaHD.Text = "Chua tao hoa don";
            // 
            // grpThemMon
            // 
            grpThemMon.Font = new Font("Segoe UI", 9F);
            grpThemMon.Location = new Point(390, 20);
            grpThemMon.Name = "grpThemMon";
            grpThemMon.Size = new Size(340, 90);
            grpThemMon.Text = "Them mon vao hoa don";
            grpThemMon.Controls.Add(lblChonSanPham);
            grpThemMon.Controls.Add(cboSanPham);
            grpThemMon.Controls.Add(lblSoLuong);
            grpThemMon.Controls.Add(txtSoLuong);
            grpThemMon.Controls.Add(btnThemMon);
            // 
            // lblChonSanPham
            // 
            lblChonSanPham.AutoSize = true;
            lblChonSanPham.Location = new Point(15, 28);
            lblChonSanPham.Name = "lblChonSanPham";
            lblChonSanPham.Size = new Size(75, 19);
            lblChonSanPham.Text = "San pham:";
            // 
            // cboSanPham
            // 
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.Location = new Point(95, 25);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(150, 25);
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(15, 62);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(70, 19);
            lblSoLuong.Text = "So luong:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(95, 59);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(60, 25);
            // 
            // btnThemMon
            // 
            btnThemMon.BackColor = Color.FromArgb(52, 152, 219);
            btnThemMon.FlatStyle = FlatStyle.Flat;
            btnThemMon.FlatAppearance.BorderSize = 0;
            btnThemMon.ForeColor = Color.White;
            btnThemMon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemMon.Location = new Point(165, 57);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(160, 30);
            btnThemMon.Text = "THEM MON";
            btnThemMon.UseVisualStyleBackColor = false;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(20, 125);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.Size = new Size(710, 350);
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.FromArgb(231, 76, 60);
            lblTongTien.Location = new Point(430, 485);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(300, 30);
            lblTongTien.TextAlign = ContentAlignment.MiddleRight;
            lblTongTien.Text = "Tong tien: 0 d";
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            Controls.Add(grpTaoHoaDon);
            Controls.Add(grpThemMon);
            Controls.Add(dgvChiTiet);
            Controls.Add(lblTongTien);
            MinimumSize = new Size(650, 450);
            Name = "FormHoaDon";
            Text = "Tao hoa don";
            Load += FormHoaDon_Load;
            grpTaoHoaDon.ResumeLayout(false);
            grpTaoHoaDon.PerformLayout();
            grpThemMon.ResumeLayout(false);
            grpThemMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTaoHoaDon;
        private Label lblSoBan;
        private TextBox txtSoBan;
        private Button btnTaoHoaDon;
        private Label lblMaHD;
        private GroupBox grpThemMon;
        private Label lblChonSanPham;
        private ComboBox cboSanPham;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Button btnThemMon;
        private DataGridView dgvChiTiet;
        private Label lblTongTien;
    }
}