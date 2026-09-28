using System;
using System.Windows.Forms;

namespace Cau6_NoteManager
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
            CapNhatSoGhiChu();
        }

        // ==========================================
        // MỞ GHI CHÚ MỚI
        // ==========================================
        private void mnuMoGhiChuMoi_Click(object sender, EventArgs e)
        {
            FormGhiChu ghiChu = new FormGhiChu();

            ghiChu.MdiParent = this;

            // Khi Form con đóng thì cập nhật số lượng
            ghiChu.FormClosed += GhiChu_FormClosed;

            ghiChu.Show();

            CapNhatSoGhiChu();
        }

        // ==========================================
        // FORM CON ĐÃ ĐÓNG
        // ==========================================
        private void GhiChu_FormClosed(
            object sender,
            FormClosedEventArgs e)
        {
            CapNhatSoGhiChu();
        }

        // ==========================================
        // SẮP XẾP CỬA SỔ
        // ==========================================
        private void mnuSapXep_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        // ==========================================
        // XẾP TẦNG
        // ==========================================
        private void mnuXepTang_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        // ==========================================
        // XẾP NGANG
        // ==========================================
        private void mnuXepNgang_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        // ==========================================
        // XẾP DỌC
        // ==========================================
        private void mnuXepDoc_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        // ==========================================
        // THOÁT
        // ==========================================
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ==========================================
        // CẬP NHẬT STATUSSTRIP
        // ==========================================
        private void CapNhatSoGhiChu()
        {
            lblSoGhiChu.Text =
                "Số ghi chú đang mở: " +
                MdiChildren.Length;
        }
    }
}