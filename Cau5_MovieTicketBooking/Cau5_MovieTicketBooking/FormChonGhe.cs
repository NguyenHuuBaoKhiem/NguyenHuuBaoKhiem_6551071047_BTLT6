using System;
using System.Windows.Forms;

namespace Cau5_MovieTicketBooking
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; } = "";

        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();

            string[] danhSachGhe =
            {
                "A1", "A2", "A3", "A4", "A5",
                "B1", "B2", "B3", "B4", "B5",
                "C1", "C2", "C3", "C4", "C5"
            };

            lstGhe.Items.AddRange(danhSachGhe);

            // Nếu đã chọn ghế trước đó
            // thì khi mở lại sẽ chọn sẵn
            if (!string.IsNullOrWhiteSpace(gheHienTai))
            {
                int index =
                    lstGhe.Items.IndexOf(gheHienTai);

                if (index >= 0)
                {
                    lstGhe.SelectedIndex = index;
                }
            }
        }

        private void lstGhe_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text =
                    "Đang chọn: " +
                    lstGhe.SelectedItem.ToString();
            }
            else
            {
                lblGheDaChon.Text =
                    "Đang chọn: Chưa chọn";
            }
        }

        private void btnXacNhan_Click(
            object sender,
            EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn một ghế.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            GheChon =
                lstGhe.SelectedItem.ToString() ?? "";

            DialogResult = DialogResult.OK;

            Close();
        }

        private void btnBoQua_Click(
            object sender,
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}