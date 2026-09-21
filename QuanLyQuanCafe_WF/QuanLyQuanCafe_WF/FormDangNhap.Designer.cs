namespace QuanLyQuanCafe_WF
{
    partial class FormDangNhap
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
            label1 = new Label();
            label2 = new Label();
            txtMaNV = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(44, 62, 80);
            lblTieuDe.Location = new Point(0, 40);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(400, 40);
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Text = "QUAN LY QUAN CAFE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(60, 120);
            label1.Name = "label1";
            label1.Size = new Size(95, 19);
            label1.Text = "Ma nhan vien:";
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 10F);
            txtMaNV.Location = new Point(165, 117);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(175, 25);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(60, 165);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.Text = "Mat khau:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 10F);
            txtMatKhau.Location = new Point(165, 162);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(175, 25);
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(52, 152, 219);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(140, 220);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(120, 40);
            btnDangNhap.Text = "DANG NHAP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 300);
            Controls.Add(lblTieuDe);
            Controls.Add(label1);
            Controls.Add(txtMaNV);
            Controls.Add(label2);
            Controls.Add(txtMatKhau);
            Controls.Add(btnDangNhap);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dang nhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label label1;
        private Label label2;
        private TextBox txtMaNV;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
    }
}