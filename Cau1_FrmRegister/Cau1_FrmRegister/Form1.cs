using System;
using System.Linq;
using System.Windows.Forms;

namespace Cau1_FrmRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool KiemTraHopLe()
        {
            bool hopLe = true;

            // 1. Kiểm tra họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(
                    txtHoTen,
                    "Họ tên không được để trống"
                );

                hopLe = false;
            }
            else if (txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(
                    txtHoTen,
                    "Họ tên phải có ít nhất 3 ký tự"
                );

                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // 2. Kiểm tra số điện thoại
            string sdt = txtSDT.Text.Trim();

            if (sdt.Length != 10 ||
                !sdt.StartsWith("0") ||
                !sdt.All(char.IsDigit))
            {
                errorProvider1.SetError(
                    txtSDT,
                    "Số điện thoại phải có 10 chữ số và bắt đầu bằng 0"
                );

                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // 3. Kiểm tra email
            string email = txtEmail.Text.Trim();
            int viTriA = email.IndexOf('@');

            if (viTriA <= 0 ||
                email.IndexOf('.', viTriA + 1) == -1)
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Email không đúng định dạng"
                );

                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // 4. Kiểm tra mật khẩu
            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(
                    txtMatKhau,
                    "Mật khẩu phải có ít nhất 6 ký tự"
                );

                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // 5. Kiểm tra xác nhận mật khẩu
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(
                    txtXacNhanMK,
                    "Mật khẩu xác nhận không khớp"
                );

                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show(
                "Đăng ký thành công! Chào mừng " + txtHoTen.Text.Trim(),
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Close();
        }
    }
}