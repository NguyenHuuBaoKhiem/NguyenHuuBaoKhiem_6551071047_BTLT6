namespace Cau4_PhoneBookManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblSDT;

        private System.Windows.Forms.ListBox lstLienHe;

        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSDT;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstLienHe = new ListBox();

            lblTen = new Label();
            txtTen = new TextBox();

            lblSDT = new Label();
            txtSDT = new TextBox();

            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();

            SuspendLayout();

            // =========================================
            // LISTBOX DANH SÁCH LIÊN HỆ
            // =========================================

            lstLienHe.Font = new Font(
                "Segoe UI",
                10F
            );

            lstLienHe.FormattingEnabled = true;

            lstLienHe.ItemHeight = 23;

            lstLienHe.Location = new Point(
                15,
                15
            );

            lstLienHe.Name = "lstLienHe";

            lstLienHe.Size = new Size(
                390,
                349
            );

            lstLienHe.TabIndex = 0;


            // =========================================
            // LABEL TÊN
            // =========================================

            lblTen.AutoSize = true;

            lblTen.Location = new Point(
                420,
                15
            );

            lblTen.Name = "lblTen";

            lblTen.Size = new Size(
                36,
                23
            );

            lblTen.Text = "Tên";


            // =========================================
            // TEXTBOX TÊN
            // =========================================

            txtTen.Location = new Point(
                420,
                42
            );

            txtTen.Name = "txtTen";

            txtTen.Size = new Size(
                310,
                30
            );

            txtTen.TabIndex = 1;


            // =========================================
            // LABEL SỐ ĐIỆN THOẠI
            // =========================================

            lblSDT.AutoSize = true;

            lblSDT.Location = new Point(
                420,
                90
            );

            lblSDT.Name = "lblSDT";

            lblSDT.Size = new Size(
                111,
                23
            );

            lblSDT.Text = "Số điện thoại";


            // =========================================
            // TEXTBOX SỐ ĐIỆN THOẠI
            // =========================================

            txtSDT.Location = new Point(
                420,
                117
            );

            txtSDT.Name = "txtSDT";

            txtSDT.Size = new Size(
                310,
                30
            );

            txtSDT.TabIndex = 2;


            // =========================================
            // BUTTON THÊM
            // =========================================

            btnThem.Location = new Point(
                570,
                175
            );

            btnThem.Name = "btnThem";

            btnThem.Size = new Size(
                160,
                36
            );

            btnThem.TabIndex = 3;

            btnThem.Text = "Thêm";

            btnThem.UseVisualStyleBackColor = true;

            btnThem.Click += btnThem_Click;


            // =========================================
            // BUTTON SỬA
            // =========================================

            btnSua.Location = new Point(
                570,
                220
            );

            btnSua.Name = "btnSua";

            btnSua.Size = new Size(
                160,
                36
            );

            btnSua.TabIndex = 4;

            btnSua.Text = "Sửa";

            btnSua.UseVisualStyleBackColor = true;

            btnSua.Click += btnSua_Click;


            // =========================================
            // BUTTON XÓA
            // =========================================

            btnXoa.Location = new Point(
                570,
                265
            );

            btnXoa.Name = "btnXoa";

            btnXoa.Size = new Size(
                160,
                36
            );

            btnXoa.TabIndex = 5;

            btnXoa.Text = "Xóa";

            btnXoa.UseVisualStyleBackColor = true;

            btnXoa.Click += btnXoa_Click;


            // =========================================
            // BUTTON THOÁT
            // =========================================

            btnThoat.Location = new Point(
                570,
                328
            );

            btnThoat.Name = "btnThoat";

            btnThoat.Size = new Size(
                160,
                36
            );

            btnThoat.TabIndex = 6;

            btnThoat.Text = "Thoát";

            btnThoat.UseVisualStyleBackColor = true;

            btnThoat.Click += btnThoat_Click;


            // =========================================
            // FORM
            // =========================================

            AutoScaleDimensions = new SizeF(
                9F,
                23F
            );

            AutoScaleMode =
                AutoScaleMode.Font;

            // Nền giống giao diện Windows mặc định
            BackColor =
                SystemColors.Control;

            ClientSize = new Size(
                750,
                390
            );

            Controls.Add(lstLienHe);

            Controls.Add(lblTen);
            Controls.Add(txtTen);

            Controls.Add(lblSDT);
            Controls.Add(txtSDT);

            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);

            Font = new Font(
                "Segoe UI",
                10F
            );

            FormBorderStyle =
                FormBorderStyle.FixedSingle;

            MaximizeBox = false;

            Name = "Form1";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text = "Quản lý danh bạ";

            // Sự kiện kiểm tra dữ liệu chưa lưu khi thoát
            FormClosing += Form1_FormClosing;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}