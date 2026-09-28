using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cau3_StudentGradeEntry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Tắt hiệu ứng nhấp nháy ErrorProvider
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Đăng ký Enter để chuyển field
            DangKyEnterChuyenField();
        }

        // ==================================================
        // ENTER -> CHUYỂN SANG FIELD TIẾP THEO
        // ==================================================
        private void DangKyEnterChuyenField()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox txt)
                {
                    txt.KeyPress += TextBox_KeyPress;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                // Riêng ô Điểm Anh -> tự động bấm Lưu
                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl(
                        (Control)sender,
                        true,
                        true,
                        true,
                        true
                    );
                }
            }
        }

        // ==================================================
        // FOCUS VÀO Ô ĐIỂM -> BÔI XANH TOÀN BỘ
        // ==================================================
        private void txtDiem_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt != null)
            {
                txt.SelectAll();
            }
        }

        // ==================================================
        // KIỂM TRA ĐIỂM
        // ==================================================
        private bool KiemTraDiem(
            TextBox txt,
            string tenMon,
            out decimal diem)
        {
            if (!decimal.TryParse(txt.Text, out diem))
            {
                errorProvider1.SetError(
                    txt,
                    "Điểm " + tenMon + " phải là số"
                );

                txt.BackColor = Color.MistyRose;

                return false;
            }

            if (diem < 0 || diem > 10)
            {
                errorProvider1.SetError(
                    txt,
                    "Điểm " + tenMon + " phải từ 0 đến 10"
                );

                txt.BackColor = Color.MistyRose;

                return false;
            }

            errorProvider1.SetError(txt, "");
            txt.BackColor = Color.Honeydew;

            return true;
        }

        // ==================================================
        // NÚT LƯU
        // ==================================================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool hopLe = true;

            decimal toan;
            decimal van;
            decimal anh;

            // Kiểm tra mã học sinh
            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                errorProvider1.SetError(
                    txtMaHS,
                    "Mã học sinh không được để trống"
                );

                hopLe = false;
            }

            // Kiểm tra họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(
                    txtHoTen,
                    "Họ tên không được để trống"
                );

                hopLe = false;
            }

            // Kiểm tra 3 điểm
            if (!KiemTraDiem(txtToan, "Toán", out toan))
            {
                hopLe = false;
            }

            if (!KiemTraDiem(txtVan, "Văn", out van))
            {
                hopLe = false;
            }

            if (!KiemTraDiem(txtAnh, "Anh", out anh))
            {
                hopLe = false;
            }

            if (!hopLe)
            {
                return;
            }

            // Thêm vào ListBox đúng format đề
            string dong =
                txtMaHS.Text.Trim() +
                " | " +
                txtHoTen.Text.Trim() +
                " | T:" + toan +
                " V:" + van +
                " A:" + anh;

            lstDanhSach.Items.Add(dong);

            // Xóa trắng sau khi lưu
            XoaTrang();

            // Quay về Mã HS
            txtMaHS.Focus();
        }

        // ==================================================
        // NÚT XÓA TRẮNG
        // ==================================================
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
            txtMaHS.Focus();
        }

        private void XoaTrang()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            txtMaHS.BackColor = Color.White;
            txtHoTen.BackColor = Color.White;
            txtToan.BackColor = Color.White;
            txtVan.BackColor = Color.White;
            txtAnh.BackColor = Color.White;

            errorProvider1.Clear();
        }
    }
}