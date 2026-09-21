namespace QuanLyQuanCafe_WF
{
    partial class FormThongKe
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
            grpNgay = new GroupBox();
            lblChonNgay = new Label();
            dtpNgay = new DateTimePicker();
            btnTheoNgay = new Button();
            grpThang = new GroupBox();
            lblThangTitle = new Label();
            nudThang = new NumericUpDown();
            lblNamThangTitle = new Label();
            nudNam1 = new NumericUpDown();
            btnTheoThang = new Button();
            grpQuy = new GroupBox();
            lblQuyTitle = new Label();
            nudQuy = new NumericUpDown();
            lblNamQuyTitle = new Label();
            nudNam2 = new NumericUpDown();
            btnTheoQuy = new Button();
            grpNam = new GroupBox();
            lblNamTitle = new Label();
            nudNam3 = new NumericUpDown();
            btnTheoNam = new Button();
            lblKetQua = new Label();
            grpNgay.SuspendLayout();
            grpThang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudThang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNam1).BeginInit();
            grpQuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNam2).BeginInit();
            grpNam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNam3).BeginInit();
            SuspendLayout();
            // 
            // grpNgay
            // 
            grpNgay.Font = new Font("Segoe UI", 9F);
            grpNgay.Location = new Point(20, 20);
            grpNgay.Name = "grpNgay";
            grpNgay.Size = new Size(280, 90);
            grpNgay.Text = "Doanh thu theo ngay";
            grpNgay.Controls.Add(lblChonNgay);
            grpNgay.Controls.Add(dtpNgay);
            grpNgay.Controls.Add(btnTheoNgay);
            // 
            // lblChonNgay
            // 
            lblChonNgay.AutoSize = true;
            lblChonNgay.Location = new Point(15, 30);
            lblChonNgay.Name = "lblChonNgay";
            lblChonNgay.Size = new Size(75, 19);
            lblChonNgay.Text = "Chon ngay:";
            // 
            // dtpNgay
            // 
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Location = new Point(15, 52);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(140, 25);
            // 
            // btnTheoNgay
            // 
            btnTheoNgay.BackColor = Color.FromArgb(52, 152, 219);
            btnTheoNgay.FlatStyle = FlatStyle.Flat;
            btnTheoNgay.FlatAppearance.BorderSize = 0;
            btnTheoNgay.ForeColor = Color.White;
            btnTheoNgay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTheoNgay.Location = new Point(165, 50);
            btnTheoNgay.Name = "btnTheoNgay";
            btnTheoNgay.Size = new Size(100, 29);
            btnTheoNgay.Text = "XEM";
            btnTheoNgay.UseVisualStyleBackColor = false;
            btnTheoNgay.Click += btnTheoNgay_Click;
            // 
            // grpThang
            // 
            grpThang.Font = new Font("Segoe UI", 9F);
            grpThang.Location = new Point(320, 20);
            grpThang.Name = "grpThang";
            grpThang.Size = new Size(280, 90);
            grpThang.Text = "Doanh thu theo thang";
            grpThang.Controls.Add(lblThangTitle);
            grpThang.Controls.Add(nudThang);
            grpThang.Controls.Add(lblNamThangTitle);
            grpThang.Controls.Add(nudNam1);
            grpThang.Controls.Add(btnTheoThang);
            // 
            // lblThangTitle
            // 
            lblThangTitle.AutoSize = true;
            lblThangTitle.Location = new Point(15, 30);
            lblThangTitle.Name = "lblThangTitle";
            lblThangTitle.Size = new Size(50, 19);
            lblThangTitle.Text = "Thang:";
            // 
            // nudThang
            // 
            nudThang.Location = new Point(15, 52);
            nudThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudThang.Name = "nudThang";
            nudThang.Size = new Size(50, 25);
            nudThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNamThangTitle
            // 
            lblNamThangTitle.AutoSize = true;
            lblNamThangTitle.Location = new Point(80, 30);
            lblNamThangTitle.Name = "lblNamThangTitle";
            lblNamThangTitle.Size = new Size(38, 19);
            lblNamThangTitle.Text = "Nam:";
            // 
            // nudNam1
            // 
            nudNam1.Location = new Point(80, 52);
            nudNam1.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudNam1.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudNam1.Name = "nudNam1";
            nudNam1.Size = new Size(70, 25);
            nudNam1.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // btnTheoThang
            // 
            btnTheoThang.BackColor = Color.FromArgb(52, 152, 219);
            btnTheoThang.FlatStyle = FlatStyle.Flat;
            btnTheoThang.FlatAppearance.BorderSize = 0;
            btnTheoThang.ForeColor = Color.White;
            btnTheoThang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTheoThang.Location = new Point(165, 50);
            btnTheoThang.Name = "btnTheoThang";
            btnTheoThang.Size = new Size(100, 29);
            btnTheoThang.Text = "XEM";
            btnTheoThang.UseVisualStyleBackColor = false;
            btnTheoThang.Click += btnTheoThang_Click;
            // 
            // grpQuy
            // 
            grpQuy.Font = new Font("Segoe UI", 9F);
            grpQuy.Location = new Point(620, 20);
            grpQuy.Name = "grpQuy";
            grpQuy.Size = new Size(280, 90);
            grpQuy.Text = "Doanh thu theo quy";
            grpQuy.Controls.Add(lblQuyTitle);
            grpQuy.Controls.Add(nudQuy);
            grpQuy.Controls.Add(lblNamQuyTitle);
            grpQuy.Controls.Add(nudNam2);
            grpQuy.Controls.Add(btnTheoQuy);
            // 
            // lblQuyTitle
            // 
            lblQuyTitle.AutoSize = true;
            lblQuyTitle.Location = new Point(15, 30);
            lblQuyTitle.Name = "lblQuyTitle";
            lblQuyTitle.Size = new Size(38, 19);
            lblQuyTitle.Text = "Quy:";
            // 
            // nudQuy
            // 
            nudQuy.Location = new Point(15, 52);
            nudQuy.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudQuy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuy.Name = "nudQuy";
            nudQuy.Size = new Size(50, 25);
            nudQuy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNamQuyTitle
            // 
            lblNamQuyTitle.AutoSize = true;
            lblNamQuyTitle.Location = new Point(80, 30);
            lblNamQuyTitle.Name = "lblNamQuyTitle";
            lblNamQuyTitle.Size = new Size(38, 19);
            lblNamQuyTitle.Text = "Nam:";
            // 
            // nudNam2
            // 
            nudNam2.Location = new Point(80, 52);
            nudNam2.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudNam2.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudNam2.Name = "nudNam2";
            nudNam2.Size = new Size(70, 25);
            nudNam2.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // btnTheoQuy
            // 
            btnTheoQuy.BackColor = Color.FromArgb(52, 152, 219);
            btnTheoQuy.FlatStyle = FlatStyle.Flat;
            btnTheoQuy.FlatAppearance.BorderSize = 0;
            btnTheoQuy.ForeColor = Color.White;
            btnTheoQuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTheoQuy.Location = new Point(165, 50);
            btnTheoQuy.Name = "btnTheoQuy";
            btnTheoQuy.Size = new Size(100, 29);
            btnTheoQuy.Text = "XEM";
            btnTheoQuy.UseVisualStyleBackColor = false;
            btnTheoQuy.Click += btnTheoQuy_Click;
            // 
            // grpNam
            // 
            grpNam.Font = new Font("Segoe UI", 9F);
            grpNam.Location = new Point(920, 20);
            grpNam.Name = "grpNam";
            grpNam.Size = new Size(200, 90);
            grpNam.Text = "Doanh thu theo nam";
            grpNam.Controls.Add(lblNamTitle);
            grpNam.Controls.Add(nudNam3);
            grpNam.Controls.Add(btnTheoNam);
            // 
            // lblNamTitle
            // 
            lblNamTitle.AutoSize = true;
            lblNamTitle.Location = new Point(15, 30);
            lblNamTitle.Name = "lblNamTitle";
            lblNamTitle.Size = new Size(38, 19);
            lblNamTitle.Text = "Nam:";
            // 
            // nudNam3
            // 
            nudNam3.Location = new Point(15, 52);
            nudNam3.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudNam3.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudNam3.Name = "nudNam3";
            nudNam3.Size = new Size(70, 25);
            nudNam3.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // btnTheoNam
            // 
            btnTheoNam.BackColor = Color.FromArgb(52, 152, 219);
            btnTheoNam.FlatStyle = FlatStyle.Flat;
            btnTheoNam.FlatAppearance.BorderSize = 0;
            btnTheoNam.ForeColor = Color.White;
            btnTheoNam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTheoNam.Location = new Point(95, 50);
            btnTheoNam.Name = "btnTheoNam";
            btnTheoNam.Size = new Size(90, 29);
            btnTheoNam.Text = "XEM";
            btnTheoNam.UseVisualStyleBackColor = false;
            btnTheoNam.Click += btnTheoNam_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.BackColor = Color.FromArgb(236, 240, 241);
            lblKetQua.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblKetQua.ForeColor = Color.FromArgb(231, 76, 60);
            lblKetQua.Location = new Point(20, 140);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(1100, 60);
            lblKetQua.TextAlign = ContentAlignment.MiddleCenter;
            lblKetQua.Text = "Chon 1 khoang thoi gian va bam XEM de xem doanh thu";
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 230);
            Controls.Add(grpNgay);
            Controls.Add(grpThang);
            Controls.Add(grpQuy);
            Controls.Add(grpNam);
            Controls.Add(lblKetQua);
            Name = "FormThongKe";
            Text = "Thong ke doanh thu";
            Load += FormThongKe_Load;
            grpNgay.ResumeLayout(false);
            grpNgay.PerformLayout();
            grpThang.ResumeLayout(false);
            grpThang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudThang).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNam1).EndInit();
            grpQuy.ResumeLayout(false);
            grpQuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNam2).EndInit();
            grpNam.ResumeLayout(false);
            grpNam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNam3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpNgay;
        private Label lblChonNgay;
        private DateTimePicker dtpNgay;
        private Button btnTheoNgay;
        private GroupBox grpThang;
        private Label lblThangTitle;
        private NumericUpDown nudThang;
        private Label lblNamThangTitle;
        private NumericUpDown nudNam1;
        private Button btnTheoThang;
        private GroupBox grpQuy;
        private Label lblQuyTitle;
        private NumericUpDown nudQuy;
        private Label lblNamQuyTitle;
        private NumericUpDown nudNam2;
        private Button btnTheoQuy;
        private GroupBox grpNam;
        private Label lblNamTitle;
        private NumericUpDown nudNam3;
        private Button btnTheoNam;
        private Label lblKetQua;
    }
}