using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Cau2_HotelBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.BlinkRate = 0;
        }

        // ============================
        // HỌ TÊN
        // ============================
        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống");
                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtHoTen, "");
                txtHoTen.BackColor = Color.Honeydew;
            }
        }

        // ============================
        // CCCD
        // ============================
        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();

            if (cccd.Length != 12 || !long.TryParse(cccd, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtCCCD,
                    "CCCD phải gồm đúng 12 chữ số"
                );

                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCCCD, "");
                txtCCCD.BackColor = Color.Honeydew;
            }
        }

        // ============================
        // NGÀY NHẬN PHÒNG
        // ============================
        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;

            bool dungDinhDang = DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan
            );

            if (!dungDinhDang)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày nhận phải có định dạng dd/MM/yyyy"
                );

                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày nhận không được nhỏ hơn ngày hôm nay"
                );

                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNgayNhan, "");
                txtNgayNhan.BackColor = Color.Honeydew;
            }
        }

        // ============================
        // NGÀY TRẢ PHÒNG
        // ============================
        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;
            DateTime ngayTra;

            bool nhanHopLe = DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan
            );

            bool traHopLe = DateTime.TryParseExact(
                txtNgayTra.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayTra
            );

            if (!traHopLe)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày trả phải có định dạng dd/MM/yyyy"
                );

                txtNgayTra.BackColor = Color.MistyRose;
            }
            else if (!nhanHopLe || ngayTra <= ngayNhan)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày trả phải sau ngày nhận"
                );

                txtNgayTra.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNgayTra, "");
                txtNgayTra.BackColor = Color.Honeydew;
            }
        }

        // ============================
        // SỐ NGƯỜI LỚN
        // ============================
        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            int soNguoiLon;

            if (!int.TryParse(txtSoNguoiLon.Text, out soNguoiLon)
                || soNguoiLon < 1
                || soNguoiLon > 4)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtSoNguoiLon,
                    "Số người lớn phải từ 1 đến 4"
                );

                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSoNguoiLon, "");
                txtSoNguoiLon.BackColor = Color.Honeydew;
            }
        }

        // ============================
        // SỐ TRẺ EM
        // ============================
        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            int soTreEm;

            if (!int.TryParse(txtSoTreEm.Text, out soTreEm)
                || soTreEm < 0
                || soTreEm > 3)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtSoTreEm,
                    "Số trẻ em phải từ 0 đến 3"
                );

                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSoTreEm, "");
                txtSoTreEm.BackColor = Color.Honeydew;
            }
        }

        // ============================
        // VALIDATED
        // ============================
        private void TextBox_Validated(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt != null)
            {
                txt.BackColor = Color.Honeydew;
            }
        }

        // ============================
        // BUTTON ĐẶT PHÒNG
        // ============================
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );

            DateTime ngayTra = DateTime.ParseExact(
                txtNgayTra.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );

            int soDem = (ngayTra - ngayNhan).Days;

            MessageBox.Show(
                "Đặt phòng thành công!\n\n" +
                "Khách hàng: " + txtHoTen.Text.Trim() + "\n" +
                "Số đêm: " + soDem + "\n" +
                "Số người lớn: " + txtSoNguoiLon.Text + "\n" +
                "Số trẻ em: " + txtSoTreEm.Text,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}