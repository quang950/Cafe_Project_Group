namespace QuanLyQuanCafe_WF
{
    partial class FormChinh
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
            lblTieuDe = new Label();
            lblNhanVien = new Label();
            btnSanPham = new Button();
            btnHoaDon = new Button();
            btnThongKe = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(44, 62, 80);
            lblTieuDe.Location = new Point(0, 50);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(500, 50);
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Text = "QUAN LY QUAN CAFE";
            // 
            // lblNhanVien
            // 
            lblNhanVien.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblNhanVien.ForeColor = Color.FromArgb(52, 152, 219);
            lblNhanVien.Location = new Point(0, 95);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(500, 35);
            lblNhanVien.TextAlign = ContentAlignment.MiddleCenter;
            lblNhanVien.Text = "";
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.FromArgb(52, 152, 219);
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSanPham.ForeColor = Color.White;
            btnSanPham.Location = new Point(125, 150);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(250, 60);
            btnSanPham.Text = "QUAN LY SAN PHAM";
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.FromArgb(46, 204, 113);
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.Location = new Point(125, 230);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(250, 60);
            btnHoaDon.Text = "TAO HOA DON";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(155, 89, 182);
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(125, 310);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(250, 60);
            btnThongKe.Text = "THONG KE DOANH THU";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 450);
            Controls.Add(lblTieuDe);
            Controls.Add(lblNhanVien);
            Controls.Add(btnSanPham);
            Controls.Add(btnHoaDon);
            Controls.Add(btnThongKe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quan ly quan cafe";
            Load += FormChinh_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTieuDe;
        private Label lblNhanVien;
        private Button btnSanPham;
        private Button btnHoaDon;
        private Button btnThongKe;
    }
}