namespace Cau6_NoteManager
{
    partial class FormChinh
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.ToolStripMenuItem mnuTep;
        private System.Windows.Forms.ToolStripMenuItem mnuMoGhiChuMoi;
        private System.Windows.Forms.ToolStripMenuItem mnuSapXep;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;

        private System.Windows.Forms.ToolStripMenuItem mnuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem mnuXepTang;
        private System.Windows.Forms.ToolStripMenuItem mnuXepNgang;
        private System.Windows.Forms.ToolStripMenuItem mnuXepDoc;

        private System.Windows.Forms.StatusStrip statusStrip1;

        private System.Windows.Forms.ToolStripStatusLabel lblSoGhiChu;

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
            menuStrip1 = new MenuStrip();

            mnuTep = new ToolStripMenuItem();
            mnuMoGhiChuMoi = new ToolStripMenuItem();
            mnuSapXep = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();

            mnuCuaSo = new ToolStripMenuItem();
            mnuXepTang = new ToolStripMenuItem();
            mnuXepNgang = new ToolStripMenuItem();
            mnuXepDoc = new ToolStripMenuItem();

            statusStrip1 = new StatusStrip();
            lblSoGhiChu = new ToolStripStatusLabel();

            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();

            SuspendLayout();

            // ==========================================
            // MENU STRIP
            // ==========================================

            menuStrip1.Items.AddRange(
                new ToolStripItem[]
                {
                    mnuTep,
                    mnuCuaSo
                }
            );

            menuStrip1.Location = new Point(0, 0);

            menuStrip1.Name = "menuStrip1";

            menuStrip1.Size =
                new Size(1000, 28);


            // ==========================================
            // MENU TỆP
            // ==========================================

            mnuTep.Name = "mnuTep";

            mnuTep.Text = "Tệp";

            mnuTep.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    mnuMoGhiChuMoi,
                    mnuSapXep,
                    new ToolStripSeparator(),
                    mnuThoat
                }
            );


            // ==========================================
            // MỞ GHI CHÚ MỚI
            // ==========================================

            mnuMoGhiChuMoi.Name =
                "mnuMoGhiChuMoi";

            mnuMoGhiChuMoi.Text =
                "Mở ghi chú mới";

            mnuMoGhiChuMoi.ShortcutKeys =
                Keys.Control | Keys.N;

            mnuMoGhiChuMoi.Click +=
                mnuMoGhiChuMoi_Click;


            // ==========================================
            // SẮP XẾP CỬA SỔ
            // ==========================================

            mnuSapXep.Name =
                "mnuSapXep";

            mnuSapXep.Text =
                "Sắp xếp cửa sổ";

            mnuSapXep.Click +=
                mnuSapXep_Click;


            // ==========================================
            // THOÁT
            // ==========================================

            mnuThoat.Name =
                "mnuThoat";

            mnuThoat.Text =
                "Thoát";

            mnuThoat.Click +=
                mnuThoat_Click;


            // ==========================================
            // MENU CỬA SỔ
            // ==========================================

            mnuCuaSo.Name =
                "mnuCuaSo";

            mnuCuaSo.Text =
                "Cửa sổ";

            mnuCuaSo.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    mnuXepTang,
                    mnuXepNgang,
                    mnuXepDoc
                }
            );


            // ==========================================
            // XẾP TẦNG
            // ==========================================

            mnuXepTang.Name =
                "mnuXepTang";

            mnuXepTang.Text =
                "Xếp tầng";

            mnuXepTang.Click +=
                mnuXepTang_Click;


            // ==========================================
            // XẾP NGANG
            // ==========================================

            mnuXepNgang.Name =
                "mnuXepNgang";

            mnuXepNgang.Text =
                "Xếp ngang";

            mnuXepNgang.Click +=
                mnuXepNgang_Click;


            // ==========================================
            // XẾP DỌC
            // ==========================================

            mnuXepDoc.Name =
                "mnuXepDoc";

            mnuXepDoc.Text =
                "Xếp dọc";

            mnuXepDoc.Click +=
                mnuXepDoc_Click;


            // ==========================================
            // STATUS STRIP
            // ==========================================

            statusStrip1.Items.AddRange(
                new ToolStripItem[]
                {
                    lblSoGhiChu
                }
            );

            statusStrip1.Location =
                new Point(0, 628);

            statusStrip1.Name =
                "statusStrip1";

            statusStrip1.Size =
                new Size(1000, 22);


            // ==========================================
            // STATUS LABEL
            // ==========================================

            lblSoGhiChu.Name =
                "lblSoGhiChu";

            lblSoGhiChu.Text =
                "Số ghi chú đang mở: 0";


            // ==========================================
            // FORM CHÍNH
            // ==========================================

            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(1000, 650);

            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);

            Font =
                new Font("Segoe UI", 10F);

            // QUAN TRỌNG:
            // biến Form này thành MDI Container
            IsMdiContainer = true;

            MainMenuStrip =
                menuStrip1;

            Name =
                "FormChinh";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Quản lý ghi chú công việc";

            WindowState =
                FormWindowState.Maximized;

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();

            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}