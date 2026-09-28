namespace Cau5_MovieTicketBooking
{
    partial class FormBanVe
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.Label lblSuatChieu;
        private System.Windows.Forms.Label lblGheDaChon;

        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtGheDaChon;

        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.ComboBox cboSuatChieu;

        private System.Windows.Forms.Button btnChonGhe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnHuy;

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
            lblTenKhach = new Label();
            lblPhim = new Label();
            lblSuatChieu = new Label();
            lblGheDaChon = new Label();

            txtTenKhach = new TextBox();
            txtGheDaChon = new TextBox();

            cboPhim = new ComboBox();
            cboSuatChieu = new ComboBox();

            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();

            SuspendLayout();

            // Tên khách
            lblTenKhach.AutoSize = true;
            lblTenKhach.Location = new Point(25, 25);
            lblTenKhach.Text = "Tên khách:";

            txtTenKhach.Location = new Point(25, 52);
            txtTenKhach.Size = new Size(360, 30);
            txtTenKhach.Name = "txtTenKhach";

            // Phim
            lblPhim.AutoSize = true;
            lblPhim.Location = new Point(25, 100);
            lblPhim.Text = "Phim:";

            cboPhim.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboPhim.Location = new Point(25, 127);
            cboPhim.Size = new Size(360, 31);
            cboPhim.Name = "cboPhim";

            // Suất chiếu
            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Location = new Point(25, 175);
            lblSuatChieu.Text = "Suất chiếu:";

            cboSuatChieu.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboSuatChieu.Location = new Point(25, 202);
            cboSuatChieu.Size = new Size(360, 31);
            cboSuatChieu.Name = "cboSuatChieu";

            // Ghế đã chọn
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Location = new Point(25, 250);
            lblGheDaChon.Text = "Ghế đã chọn:";

            txtGheDaChon.Location = new Point(25, 277);
            txtGheDaChon.Size = new Size(360, 30);
            txtGheDaChon.Name = "txtGheDaChon";

            txtGheDaChon.ReadOnly = true;

            // Chọn ghế
            btnChonGhe.Location =
                new Point(25, 340);

            btnChonGhe.Size =
                new Size(110, 40);

            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Text = "Chọn ghế";

            btnChonGhe.Click +=
                btnChonGhe_Click;

            // Đặt vé
            btnDatVe.Location =
                new Point(150, 340);

            btnDatVe.Size =
                new Size(110, 40);

            btnDatVe.Name = "btnDatVe";
            btnDatVe.Text = "Đặt vé";

            btnDatVe.Click +=
                btnDatVe_Click;

            // Hủy
            btnHuy.Location =
                new Point(275, 340);

            btnHuy.Size =
                new Size(110, 40);

            btnHuy.Name = "btnHuy";
            btnHuy.Text = "Hủy";

            btnHuy.Click +=
                btnHuy_Click;

            // FORM
            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(415, 410);

            Controls.Add(lblTenKhach);
            Controls.Add(txtTenKhach);

            Controls.Add(lblPhim);
            Controls.Add(cboPhim);

            Controls.Add(lblSuatChieu);
            Controls.Add(cboSuatChieu);

            Controls.Add(lblGheDaChon);
            Controls.Add(txtGheDaChon);

            Controls.Add(btnChonGhe);
            Controls.Add(btnDatVe);
            Controls.Add(btnHuy);

            Font = new Font("Segoe UI", 10F);

            FormBorderStyle =
                FormBorderStyle.FixedSingle;

            MaximizeBox = false;

            Name = "FormBanVe";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text = "Bán vé xem phim";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}