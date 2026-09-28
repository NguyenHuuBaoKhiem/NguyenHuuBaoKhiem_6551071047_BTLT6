using System;
using System.Windows.Forms;

namespace Cau4_PhoneBookManager
{
    public partial class Form1 : Form
    {
        // -1 nghĩa là hiện tại không sửa liên hệ nào
        private int _indexDangSua = -1;

        public Form1()
        {
            InitializeComponent();
        }

        // ==========================================
        // THÊM / CẬP NHẬT LIÊN HỆ
        // ==========================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên liên hệ.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show(
                    "Vui lòng nhập số điện thoại.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSDT.Focus();
                return;
            }

            string lienHe = ten + " - " + sdt;

            // Nếu đang ở chế độ sửa
            if (_indexDangSua >= 0)
            {
                lstLienHe.Items[_indexDangSua] = lienHe;

                MessageBox.Show(
                    "Cập nhật thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                _indexDangSua = -1;
                btnThem.Text = "Thêm";
            }
            else
            {
                lstLienHe.Items.Add(lienHe);

                MessageBox.Show(
                    "Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            XoaDuLieuNhap();
        }

        // ==========================================
        // SỬA LIÊN HỆ
        // ==========================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để sửa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;

            string lienHe =
                lstLienHe.Items[_indexDangSua].ToString() ?? "";

            int viTriPhanCach = lienHe.LastIndexOf(" - ");

            if (viTriPhanCach >= 0)
            {
                txtTen.Text =
                    lienHe.Substring(0, viTriPhanCach);

                txtSDT.Text =
                    lienHe.Substring(viTriPhanCach + 3);
            }

            btnThem.Text = "Cập nhật";

            txtTen.Focus();
            txtTen.SelectAll();
        }

        // ==========================================
        // XÓA LIÊN HỆ
        // ==========================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để xóa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int index = lstLienHe.SelectedIndex;

            string lienHe =
                lstLienHe.Items[index].ToString() ?? "";

            string ten = lienHe;

            int viTriPhanCach = lienHe.LastIndexOf(" - ");

            if (viTriPhanCach >= 0)
            {
                ten = lienHe.Substring(0, viTriPhanCach);
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa liên hệ " + ten +
                "?\n\nThao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(index);

                // Nếu xóa đúng item đang sửa
                if (_indexDangSua == index)
                {
                    _indexDangSua = -1;
                    btnThem.Text = "Thêm";
                    XoaDuLieuNhap();
                }
                else if (_indexDangSua > index)
                {
                    _indexDangSua--;
                }

                MessageBox.Show(
                    "Xóa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // ==========================================
        // NÚT THOÁT
        // ==========================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ==========================================
        // FORM CLOSING
        // ==========================================
        private void Form1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            bool coDuLieuChuaLuu =
                !string.IsNullOrWhiteSpace(txtTen.Text) ||
                !string.IsNullOrWhiteSpace(txtSDT.Text);

            if (!coDuLieuChuaLuu)
            {
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có dữ liệu chưa được lưu.\n" +
                "Bạn muốn thoát không?",
                "Cảnh báo",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );

            if (ketQua == DialogResult.Yes)
            {
                // Thoát và bỏ dữ liệu chưa lưu
                return;
            }

            if (ketQua == DialogResult.No)
            {
                // Theo yêu cầu đề:
                // xóa TextBox rồi thoát
                XoaDuLieuNhap();
                return;
            }

            // Cancel -> không cho đóng Form
            e.Cancel = true;
        }

        // ==========================================
        // HÀM XÓA DỮ LIỆU NHẬP
        // ==========================================
        private void XoaDuLieuNhap()
        {
            txtTen.Clear();
            txtSDT.Clear();

            txtTen.Focus();
        }
    }
}