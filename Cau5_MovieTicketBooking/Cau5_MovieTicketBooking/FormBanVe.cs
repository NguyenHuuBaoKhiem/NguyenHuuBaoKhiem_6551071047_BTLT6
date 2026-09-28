using System;
using System.Windows.Forms;

namespace Cau5_MovieTicketBooking
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();

            // Dữ liệu mẫu
            cboPhim.Items.Add("Chiến binh cuối cùng");
            cboPhim.Items.Add("Avengers");
            cboPhim.Items.Add("Doraemon");
            cboPhim.Items.Add("Conan");

            cboSuatChieu.Items.Add("09:00");
            cboSuatChieu.Items.Add("13:30");
            cboSuatChieu.Items.Add("16:00");
            cboSuatChieu.Items.Add("19:00");
            cboSuatChieu.Items.Add("21:30");

            cboPhim.SelectedIndex = 0;
            cboSuatChieu.SelectedIndex = 0;
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg =
                new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên khách.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTenKhach.Focus();
                return;
            }

            if (cboPhim.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn phim.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cboSuatChieu.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn suất chiếu.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn ghế.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            MessageBox.Show(
                "ĐẶT VÉ THÀNH CÔNG!\n\n" +
                "Tên khách: " + txtTenKhach.Text + "\n" +
                "Phim: " + cboPhim.Text + "\n" +
                "Suất chiếu: " + cboSuatChieu.Text + "\n" +
                "Ghế: " + txtGheDaChon.Text + "\n" +
                "Giá vé: 75.000đ",
                "Thông tin vé",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            txtGheDaChon.Clear();

            cboPhim.SelectedIndex = 0;
            cboSuatChieu.SelectedIndex = 0;

            txtTenKhach.Focus();
        }
    }
}