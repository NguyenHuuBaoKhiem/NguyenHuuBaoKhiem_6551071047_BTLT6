using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cau6_NoteManager
{
    public partial class FormGhiChu : Form
    {
        // Dùng để biết nội dung có thay đổi hay không
        private bool _daThayDoi = false;

        // Dùng để tránh hỏi 2 lần khi đang đóng
        private bool _choPhepDong = false;

        public FormGhiChu()
        {
            InitializeComponent();

            cboMucDoUuTien.SelectedIndex = 1;
        }

        // ==========================================
        // ĐÁNH DẤU DỮ LIỆU ĐÃ THAY ĐỔI
        // ==========================================
        private void DuLieu_TextChanged(
            object sender,
            EventArgs e)
        {
            _daThayDoi = true;
        }

        private void cboMucDoUuTien_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            _daThayDoi = true;
        }

        // ==========================================
        // VALIDATING TIÊU ĐỀ
        // ==========================================
        private void txtTieuDe_Validating(
            object sender,
            CancelEventArgs e)
        {
            string tieuDe =
                txtTieuDe.Text.Trim();

            if (string.IsNullOrWhiteSpace(tieuDe))
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề không được để trống"
                );

                txtTieuDe.BackColor =
                    Color.MistyRose;

                return;
            }

            if (tieuDe.Length > 50)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề không được vượt quá 50 ký tự"
                );

                txtTieuDe.BackColor =
                    Color.MistyRose;

                return;
            }

            e.Cancel = false;

            errorProvider1.SetError(
                txtTieuDe,
                ""
            );
        }

        // ==========================================
        // VALIDATED
        // ==========================================
        private void txtTieuDe_Validated(
            object sender,
            EventArgs e)
        {
            txtTieuDe.BackColor =
                Color.White;

            errorProvider1.SetError(
                txtTieuDe,
                ""
            );
        }

        // ==========================================
        // LƯU GHI CHÚ
        // ==========================================
        private void btnLuuGhiChu_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            Text =
                txtTieuDe.Text.Trim();

            _daThayDoi = false;

            MessageBox.Show(
                "Đã lưu ghi chú",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // ==========================================
        // CTRL + S VÀ ESCAPE
        // ==========================================
        private void FormGhiChu_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            // Ctrl + S
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;

                btnLuuGhiChu.PerformClick();

                return;
            }

            // Escape
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;

                if (_daThayDoi)
                {
                    DialogResult ketQua =
                        MessageBox.Show(
                            "Nội dung đã thay đổi.\n" +
                            "Bạn có chắc muốn đóng ghi chú?",
                            "Xác nhận",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                    if (ketQua == DialogResult.Yes)
                    {
                        _choPhepDong = true;

                        Close();
                    }
                }
                else
                {
                    _choPhepDong = true;

                    Close();
                }
            }
        }

        // ==========================================
        // GIỚI HẠN NỘI DUNG 500 KÝ TỰ
        // ==========================================
        private void txtNoiDung_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            // Cho phép Backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Nếu đã đủ 500 ký tự thì không cho nhập thêm
            if (txtNoiDung.Text.Length >= 500)
            {
                e.Handled = true;
            }
        }

        // ==========================================
        // DOUBLE CLICK TIÊU ĐỀ
        // ==========================================
        private void lblTieuDeForm_MouseDoubleClick(
            object sender,
            MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState =
                    FormWindowState.Normal;
            }
            else
            {
                WindowState =
                    FormWindowState.Maximized;
            }
        }

        // ==========================================
        // HOVER NÚT LƯU
        // ==========================================
        private void btnLuuGhiChu_MouseEnter(
            object sender,
            EventArgs e)
        {
            btnLuuGhiChu.BackColor =
                Color.SeaGreen;

            btnLuuGhiChu.ForeColor =
                Color.White;
        }

        private void btnLuuGhiChu_MouseLeave(
            object sender,
            EventArgs e)
        {
            btnLuuGhiChu.BackColor =
                SystemColors.Control;

            btnLuuGhiChu.ForeColor =
                Color.Black;
        }

        // ==========================================
        // ĐÓNG FORM
        // ==========================================
        private void FormGhiChu_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            if (_choPhepDong)
            {
                return;
            }

            if (!_daThayDoi)
            {
                return;
            }

            DialogResult ketQua =
                MessageBox.Show(
                    "Nội dung ghi chú đã thay đổi.\n" +
                    "Bạn có chắc muốn đóng?",
                    "Xác nhận đóng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (ketQua == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}