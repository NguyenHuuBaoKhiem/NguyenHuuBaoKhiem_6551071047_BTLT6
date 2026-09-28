namespace Cau3_StudentGradeEntry
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblToan;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.Label lblAnh;

        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.TextBox txtVan;
        private System.Windows.Forms.TextBox txtAnh;

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaTrang;

        private System.Windows.Forms.ListBox lstDanhSach;

        private System.Windows.Forms.ErrorProvider errorProvider1;

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
            components = new System.ComponentModel.Container();

            lblTieuDe = new Label();
            lblMaHS = new Label();
            lblHoTen = new Label();
            lblToan = new Label();
            lblVan = new Label();
            lblAnh = new Label();

            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();

            btnLuu = new Button();
            btnXoaTrang = new Button();

            lstDanhSach = new ListBox();

            errorProvider1 = new ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)errorProvider1)
                .BeginInit();

            SuspendLayout();

            // ==========================================
            // TIÊU ĐỀ
            // ==========================================

            lblTieuDe.AutoSize = true;

            lblTieuDe.Font = new Font(
                "Segoe UI",
                16F,
                FontStyle.Bold
            );

            lblTieuDe.Location = new Point(25, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(270, 37);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Nhập điểm học sinh";


            // ==========================================
            // LABEL MÃ HS
            // ==========================================

            lblMaHS.AutoSize = true;
            lblMaHS.Location = new Point(25, 80);
            lblMaHS.Name = "lblMaHS";
            lblMaHS.Size = new Size(60, 23);
            lblMaHS.TabIndex = 1;
            lblMaHS.Text = "Mã HS";


            // ==========================================
            // TEXTBOX MÃ HS
            // ==========================================

            txtMaHS.Location = new Point(25, 105);
            txtMaHS.Name = "txtMaHS";

            txtMaHS.Size = new Size(
                100,
                30
            );

            txtMaHS.TabIndex = 0;


            // ==========================================
            // LABEL HỌ TÊN
            // ==========================================

            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(145, 80);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(62, 23);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";


            // ==========================================
            // TEXTBOX HỌ TÊN
            // ==========================================

            txtHoTen.Location = new Point(145, 105);
            txtHoTen.Name = "txtHoTen";

            // Tăng độ rộng để nhập họ tên dài
            txtHoTen.Size = new Size(
                300,
                30
            );

            txtHoTen.TabIndex = 1;


            // ==========================================
            // LABEL ĐIỂM TOÁN
            // ==========================================

            lblToan.AutoSize = true;

            lblToan.Location = new Point(
                465,
                80
            );

            lblToan.Name = "lblToan";
            lblToan.Size = new Size(91, 23);
            lblToan.TabIndex = 3;
            lblToan.Text = "Điểm Toán";


            // ==========================================
            // TEXTBOX ĐIỂM TOÁN
            // ==========================================

            txtToan.Location = new Point(
                465,
                105
            );

            txtToan.Name = "txtToan";

            txtToan.Size = new Size(
                90,
                30
            );

            txtToan.TabIndex = 2;

            txtToan.Enter += txtDiem_Enter;


            // ==========================================
            // LABEL ĐIỂM VĂN
            // ==========================================

            lblVan.AutoSize = true;

            lblVan.Location = new Point(
                575,
                80
            );

            lblVan.Name = "lblVan";
            lblVan.Size = new Size(84, 23);
            lblVan.TabIndex = 4;
            lblVan.Text = "Điểm Văn";


            // ==========================================
            // TEXTBOX ĐIỂM VĂN
            // ==========================================

            txtVan.Location = new Point(
                575,
                105
            );

            txtVan.Name = "txtVan";

            txtVan.Size = new Size(
                90,
                30
            );

            txtVan.TabIndex = 3;

            txtVan.Enter += txtDiem_Enter;


            // ==========================================
            // LABEL ĐIỂM ANH
            // ==========================================

            lblAnh.AutoSize = true;

            lblAnh.Location = new Point(
                685,
                80
            );

            lblAnh.Name = "lblAnh";
            lblAnh.Size = new Size(86, 23);
            lblAnh.TabIndex = 5;
            lblAnh.Text = "Điểm Anh";


            // ==========================================
            // TEXTBOX ĐIỂM ANH
            // ==========================================

            txtAnh.Location = new Point(
                685,
                105
            );

            txtAnh.Name = "txtAnh";

            txtAnh.Size = new Size(
                90,
                30
            );

            txtAnh.TabIndex = 4;

            txtAnh.Enter += txtDiem_Enter;


            // ==========================================
            // BUTTON LƯU
            // ==========================================

            btnLuu.BackColor = Color.MediumSeaGreen;

            btnLuu.FlatAppearance.BorderSize = 0;

            btnLuu.FlatStyle = FlatStyle.Flat;

            btnLuu.ForeColor = Color.White;

            btnLuu.Location = new Point(
                25,
                155
            );

            btnLuu.Name = "btnLuu";

            btnLuu.Size = new Size(
                105,
                38
            );

            btnLuu.TabIndex = 5;

            btnLuu.Text = "Lưu";

            btnLuu.UseVisualStyleBackColor = false;

            btnLuu.Click += btnLuu_Click;


            // ==========================================
            // BUTTON XÓA TRẮNG
            // ==========================================

            btnXoaTrang.Location = new Point(
                145,
                155
            );

            btnXoaTrang.Name = "btnXoaTrang";

            btnXoaTrang.Size = new Size(
                120,
                38
            );

            btnXoaTrang.TabIndex = 6;

            btnXoaTrang.Text = "Xóa trắng";

            btnXoaTrang.UseVisualStyleBackColor = true;

            btnXoaTrang.Click += btnXoaTrang_Click;


            // ==========================================
            // LISTBOX DANH SÁCH
            // ==========================================

            lstDanhSach.Font = new Font(
                "Consolas",
                10F
            );

            lstDanhSach.Location = new Point(
                25,
                215
            );

            lstDanhSach.Name = "lstDanhSach";

            // Tăng chiều rộng ListBox theo Form
            lstDanhSach.Size = new Size(
                750,
                204
            );

            lstDanhSach.TabIndex = 7;


            // ==========================================
            // ERROR PROVIDER
            // ==========================================

            errorProvider1.ContainerControl = this;

            // Không cho icon lỗi nhấp nháy
            errorProvider1.BlinkStyle =
                ErrorBlinkStyle.NeverBlink;

            errorProvider1.BlinkRate = 0;


            // ==========================================
            // FORM
            // ==========================================

            AutoScaleDimensions = new SizeF(
                9F,
                23F
            );

            AutoScaleMode =
                AutoScaleMode.Font;

            // Nền xanh nhạt
            BackColor =
                Color.Honeydew;

            // Tăng chiều rộng Form
            ClientSize = new Size(
                810,
                470
            );

            Controls.Add(lblTieuDe);

            Controls.Add(lblMaHS);
            Controls.Add(txtMaHS);

            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);

            Controls.Add(lblToan);
            Controls.Add(txtToan);

            Controls.Add(lblVan);
            Controls.Add(txtVan);

            Controls.Add(lblAnh);
            Controls.Add(txtAnh);

            Controls.Add(btnLuu);
            Controls.Add(btnXoaTrang);

            Controls.Add(lstDanhSach);

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

            Text = "Nhập điểm học sinh";

            ((System.ComponentModel.ISupportInitialize)errorProvider1)
                .EndInit();

            ResumeLayout(false);

            PerformLayout();
        }
    }
}