namespace Cau1_FrmRegister
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblXacNhanMK;

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMK;

        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuy;

        private System.Windows.Forms.ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTieuDe = new Label();
            lblMoTa = new Label();
            lblHoTen = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblMatKhau = new Label();
            lblXacNhanMK = new Label();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.Location = new Point(40, 33);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(306, 37);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Đăng ký tài khoản mới";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.ForeColor = Color.DimGray;
            lblMoTa.Location = new Point(43, 87);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(214, 20);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(57, 160);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(57, 220);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(97, 20);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "Số điện thoại";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(57, 280);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(57, 340);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(70, 20);
            lblMatKhau.TabIndex = 5;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblXacNhanMK
            // 
            lblXacNhanMK.AutoSize = true;
            lblXacNhanMK.Location = new Point(57, 400);
            lblXacNhanMK.Name = "lblXacNhanMK";
            lblXacNhanMK.Size = new Size(134, 20);
            lblXacNhanMK.TabIndex = 6;
            lblXacNhanMK.Text = "Xác nhận mật khẩu";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(217, 153);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(285, 27);
            txtHoTen.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(217, 213);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(285, 27);
            txtSDT.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(217, 273);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(285, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(217, 333);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(285, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(217, 393);
            txtXacNhanMK.Margin = new Padding(3, 4, 3, 4);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(285, 27);
            txtXacNhanMK.TabIndex = 4;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(217, 467);
            btnDangKy.Margin = new Padding(3, 4, 3, 4);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(131, 53);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.CausesValidation = false;
            btnHuy.Location = new Point(371, 467);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(131, 53);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 587);
            Controls.Add(lblTieuDe);
            Controls.Add(lblMoTa);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblSDT);
            Controls.Add(txtSDT);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(lblXacNhanMK);
            Controls.Add(txtXacNhanMK);
            Controls.Add(btnDangKy);
            Controls.Add(btnHuy);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}