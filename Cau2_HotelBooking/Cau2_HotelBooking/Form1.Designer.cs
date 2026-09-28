namespace Cau2_HotelBooking
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblNgayNhan;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblSoNguoiLon;
        private System.Windows.Forms.Label lblSoTreEm;

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtNgayNhan;
        private System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.TextBox txtSoNguoiLon;
        private System.Windows.Forms.TextBox txtSoTreEm;

        private System.Windows.Forms.Button btnDatPhong;

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

            lblTieuDe = new System.Windows.Forms.Label();
            lblHoTen = new System.Windows.Forms.Label();
            lblCCCD = new System.Windows.Forms.Label();
            lblNgayNhan = new System.Windows.Forms.Label();
            lblNgayTra = new System.Windows.Forms.Label();
            lblSoNguoiLon = new System.Windows.Forms.Label();
            lblSoTreEm = new System.Windows.Forms.Label();

            txtHoTen = new System.Windows.Forms.TextBox();
            txtCCCD = new System.Windows.Forms.TextBox();
            txtNgayNhan = new System.Windows.Forms.TextBox();
            txtNgayTra = new System.Windows.Forms.TextBox();
            txtSoNguoiLon = new System.Windows.Forms.TextBox();
            txtSoTreEm = new System.Windows.Forms.TextBox();

            btnDatPhong = new System.Windows.Forms.Button();

            errorProvider1 =
                new System.Windows.Forms.ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)
                errorProvider1).BeginInit();

            SuspendLayout();

            // =============================
            // TIÊU ĐỀ
            // =============================
            lblTieuDe.AutoSize = true;

            lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI",
                16F,
                System.Drawing.FontStyle.Bold
            );

            lblTieuDe.Location =
                new System.Drawing.Point(35, 25);

            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Text = "Đặt phòng khách sạn";

            // =============================
            // HỌ TÊN
            // =============================
            lblHoTen.AutoSize = true;
            lblHoTen.Location =
                new System.Drawing.Point(45, 90);

            lblHoTen.Text = "Họ tên";

            txtHoTen.Location =
                new System.Drawing.Point(180, 85);

            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size =
                new System.Drawing.Size(280, 23);

            txtHoTen.TabIndex = 0;

            txtHoTen.Validating +=
                new System.ComponentModel.CancelEventHandler(
                    txtHoTen_Validating
                );

            txtHoTen.Validated +=
                new System.EventHandler(TextBox_Validated);

            // =============================
            // CCCD
            // =============================
            lblCCCD.AutoSize = true;
            lblCCCD.Location =
                new System.Drawing.Point(45, 135);

            lblCCCD.Text = "Số CCCD";

            txtCCCD.Location =
                new System.Drawing.Point(180, 130);

            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size =
                new System.Drawing.Size(280, 23);

            txtCCCD.TabIndex = 1;

            txtCCCD.Validating +=
                new System.ComponentModel.CancelEventHandler(
                    txtCCCD_Validating
                );

            txtCCCD.Validated +=
                new System.EventHandler(TextBox_Validated);

            // =============================
            // NGÀY NHẬN
            // =============================
            lblNgayNhan.AutoSize = true;
            lblNgayNhan.Location =
                new System.Drawing.Point(45, 180);

            lblNgayNhan.Text = "Ngày nhận phòng";

            txtNgayNhan.Location =
                new System.Drawing.Point(180, 175);

            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size =
                new System.Drawing.Size(280, 23);

            txtNgayNhan.TabIndex = 2;

            txtNgayNhan.PlaceholderText = "dd/MM/yyyy";

            txtNgayNhan.Validating +=
                new System.ComponentModel.CancelEventHandler(
                    txtNgayNhan_Validating
                );

            txtNgayNhan.Validated +=
                new System.EventHandler(TextBox_Validated);

            // =============================
            // NGÀY TRẢ
            // =============================
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location =
                new System.Drawing.Point(45, 225);

            lblNgayTra.Text = "Ngày trả phòng";

            txtNgayTra.Location =
                new System.Drawing.Point(180, 220);

            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size =
                new System.Drawing.Size(280, 23);

            txtNgayTra.TabIndex = 3;

            txtNgayTra.PlaceholderText = "dd/MM/yyyy";

            txtNgayTra.Validating +=
                new System.ComponentModel.CancelEventHandler(
                    txtNgayTra_Validating
                );

            txtNgayTra.Validated +=
                new System.EventHandler(TextBox_Validated);

            // =============================
            // SỐ NGƯỜI LỚN
            // =============================
            lblSoNguoiLon.AutoSize = true;
            lblSoNguoiLon.Location =
                new System.Drawing.Point(45, 270);

            lblSoNguoiLon.Text = "Số người lớn";

            txtSoNguoiLon.Location =
                new System.Drawing.Point(180, 265);

            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size =
                new System.Drawing.Size(280, 23);

            txtSoNguoiLon.TabIndex = 4;

            txtSoNguoiLon.Validating +=
                new System.ComponentModel.CancelEventHandler(
                    txtSoNguoiLon_Validating
                );

            txtSoNguoiLon.Validated +=
                new System.EventHandler(TextBox_Validated);

            // =============================
            // SỐ TRẺ EM
            // =============================
            lblSoTreEm.AutoSize = true;
            lblSoTreEm.Location =
                new System.Drawing.Point(45, 315);

            lblSoTreEm.Text = "Số trẻ em";

            txtSoTreEm.Location =
                new System.Drawing.Point(180, 310);

            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size =
                new System.Drawing.Size(280, 23);

            txtSoTreEm.TabIndex = 5;

            txtSoTreEm.Validating +=
                new System.ComponentModel.CancelEventHandler(
                    txtSoTreEm_Validating
                );

            txtSoTreEm.Validated +=
                new System.EventHandler(TextBox_Validated);

            // =============================
            // BUTTON ĐẶT PHÒNG
            // =============================
            btnDatPhong.Location =
                new System.Drawing.Point(180, 365);

            btnDatPhong.Name = "btnDatPhong";

            btnDatPhong.Size =
                new System.Drawing.Size(280, 42);

            btnDatPhong.TabIndex = 6;

            btnDatPhong.Text = "Đặt phòng";

            btnDatPhong.UseVisualStyleBackColor = true;

            btnDatPhong.Click +=
                new System.EventHandler(btnDatPhong_Click);

            // =============================
            // ERROR PROVIDER
            // =============================
            errorProvider1.ContainerControl = this;
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider1.BlinkRate = 0;

            // =============================
            // FORM
            // =============================
            AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            ClientSize =
                new System.Drawing.Size(540, 455);

            BackColor = System.Drawing.Color.Honeydew;

            Controls.Add(lblTieuDe);

            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);

            Controls.Add(lblCCCD);
            Controls.Add(txtCCCD);

            Controls.Add(lblNgayNhan);
            Controls.Add(txtNgayNhan);

            Controls.Add(lblNgayTra);
            Controls.Add(txtNgayTra);

            Controls.Add(lblSoNguoiLon);
            Controls.Add(txtSoNguoiLon);

            Controls.Add(lblSoTreEm);
            Controls.Add(txtSoTreEm);

            Controls.Add(btnDatPhong);

            Font =
                new System.Drawing.Font("Segoe UI", 9F);

            FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            MaximizeBox = false;

            Name = "Form1";

            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            Text = "Đặt phòng khách sạn";

            ((System.ComponentModel.ISupportInitialize)
                errorProvider1).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}