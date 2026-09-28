namespace Cau5_MovieTicketBooking
{
    partial class FormChonGhe
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox lstGhe;

        private System.Windows.Forms.Label lblGheDaChon;

        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnBoQua;

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
            lstGhe = new ListBox();

            lblGheDaChon = new Label();

            btnXacNhan = new Button();
            btnBoQua = new Button();

            SuspendLayout();

            // =====================================
            // DANH SÁCH GHẾ
            // =====================================

            lstGhe.Font =
                new Font("Segoe UI", 12F);

            lstGhe.FormattingEnabled = true;

            lstGhe.ItemHeight = 28;

            lstGhe.Location =
                new Point(20, 20);

            lstGhe.Name = "lstGhe";

            lstGhe.Size =
                new Size(280, 172);

            lstGhe.TabIndex = 0;

            lstGhe.SelectedIndexChanged +=
                lstGhe_SelectedIndexChanged;


            // =====================================
            // GHẾ ĐANG CHỌN
            // =====================================

            lblGheDaChon.AutoSize = true;

            lblGheDaChon.Location =
                new Point(20, 215);

            lblGheDaChon.Name =
                "lblGheDaChon";

            lblGheDaChon.Text =
                "Đang chọn: Chưa chọn";


            // =====================================
            // XÁC NHẬN
            // =====================================

            btnXacNhan.Location =
                new Point(55, 260);

            btnXacNhan.Name =
                "btnXacNhan";

            btnXacNhan.Size =
                new Size(115, 38);

            btnXacNhan.Text =
                "Xác nhận";

            btnXacNhan.Click +=
                btnXacNhan_Click;


            // =====================================
            // BỎ QUA
            // =====================================

            btnBoQua.Location =
                new Point(185, 260);

            btnBoQua.Name =
                "btnBoQua";

            btnBoQua.Size =
                new Size(115, 38);

            btnBoQua.Text =
                "Bỏ qua";

            btnBoQua.Click +=
                btnBoQua_Click;


            // =====================================
            // FORM
            // =====================================

            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(325, 325);

            Controls.Add(lstGhe);
            Controls.Add(lblGheDaChon);
            Controls.Add(btnXacNhan);
            Controls.Add(btnBoQua);

            Font =
                new Font("Segoe UI", 10F);

            FormBorderStyle =
                FormBorderStyle.FixedDialog;

            MaximizeBox = false;
            MinimizeBox = false;

            Name = "FormChonGhe";

            StartPosition =
                FormStartPosition.CenterParent;

            Text = "Chọn ghế";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}