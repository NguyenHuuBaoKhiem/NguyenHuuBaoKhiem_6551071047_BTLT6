namespace Cau6_NoteManager
{
    partial class FormGhiChu
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDeForm;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Label lblMucDoUuTien;

        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtNoiDung;

        private System.Windows.Forms.ComboBox cboMucDoUuTien;

        private System.Windows.Forms.Button btnLuuGhiChu;

        private System.Windows.Forms.ErrorProvider errorProvider1;

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
            components =
                new System.ComponentModel.Container();

            lblTieuDeForm = new Label();
            lblTieuDe = new Label();
            lblNoiDung = new Label();
            lblMucDoUuTien = new Label();

            txtTieuDe = new TextBox();
            txtNoiDung = new TextBox();

            cboMucDoUuTien = new ComboBox();

            btnLuuGhiChu = new Button();

            errorProvider1 =
                new ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)
                errorProvider1).BeginInit();

            SuspendLayout();

            // ==========================================
            // TIÊU ĐỀ FORM
            // ==========================================

            lblTieuDeForm.AutoSize = true;

            lblTieuDeForm.Font =
                new Font(
                    "Segoe UI",
                    14F,
                    FontStyle.Bold
                );

            lblTieuDeForm.Location =
                new Point(20, 15);

            lblTieuDeForm.Name =
                "lblTieuDeForm";

            lblTieuDeForm.Text =
                "Ghi chú công việc";

            lblTieuDeForm.Cursor =
                Cursors.Hand;

            lblTieuDeForm.MouseDoubleClick +=
                lblTieuDeForm_MouseDoubleClick;


            // ==========================================
            // LABEL TIÊU ĐỀ
            // ==========================================

            lblTieuDe.AutoSize = true;

            lblTieuDe.Location =
                new Point(20, 65);

            lblTieuDe.Text =
                "Tiêu đề";


            // ==========================================
            // TEXTBOX TIÊU ĐỀ
            // ==========================================

            txtTieuDe.Location =
                new Point(20, 92);

            txtTieuDe.Name =
                "txtTieuDe";

            txtTieuDe.Size =
                new Size(430, 30);

            txtTieuDe.TabIndex = 0;

            txtTieuDe.Validating +=
                txtTieuDe_Validating;

            txtTieuDe.Validated +=
                txtTieuDe_Validated;

            txtTieuDe.TextChanged +=
                DuLieu_TextChanged;


            // ==========================================
            // LABEL NỘI DUNG
            // ==========================================

            lblNoiDung.AutoSize = true;

            lblNoiDung.Location =
                new Point(20, 140);

            lblNoiDung.Text =
                "Nội dung";


            // ==========================================
            // TEXTBOX NỘI DUNG
            // ==========================================

            txtNoiDung.Location =
                new Point(20, 167);

            txtNoiDung.Name =
                "txtNoiDung";

            txtNoiDung.Size =
                new Size(430, 210);

            txtNoiDung.Multiline = true;

            txtNoiDung.ScrollBars =
                ScrollBars.Vertical;

            txtNoiDung.AcceptsReturn = true;

            txtNoiDung.TabIndex = 1;

            txtNoiDung.KeyPress +=
                txtNoiDung_KeyPress;

            txtNoiDung.TextChanged +=
                DuLieu_TextChanged;


            // ==========================================
            // MỨC ĐỘ ƯU TIÊN
            // ==========================================

            lblMucDoUuTien.AutoSize = true;

            lblMucDoUuTien.Location =
                new Point(20, 400);

            lblMucDoUuTien.Text =
                "Mức độ ưu tiên";


            // ==========================================
            // COMBOBOX
            // ==========================================

            cboMucDoUuTien.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboMucDoUuTien.Items.AddRange(
                new object[]
                {
                    "Thấp",
                    "Trung bình",
                    "Cao"
                }
            );

            cboMucDoUuTien.Location =
                new Point(20, 427);

            cboMucDoUuTien.Name =
                "cboMucDoUuTien";

            cboMucDoUuTien.Size =
                new Size(200, 31);

            cboMucDoUuTien.TabIndex = 2;

            cboMucDoUuTien.SelectedIndexChanged +=
                cboMucDoUuTien_SelectedIndexChanged;


            // ==========================================
            // BUTTON LƯU
            // ==========================================

            btnLuuGhiChu.Location =
                new Point(330, 420);

            btnLuuGhiChu.Name =
                "btnLuuGhiChu";

            btnLuuGhiChu.Size =
                new Size(120, 40);

            btnLuuGhiChu.TabIndex = 3;

            btnLuuGhiChu.Text =
                "Lưu";

            btnLuuGhiChu.UseVisualStyleBackColor =
                false;

            btnLuuGhiChu.Click +=
                btnLuuGhiChu_Click;

            btnLuuGhiChu.MouseEnter +=
                btnLuuGhiChu_MouseEnter;

            btnLuuGhiChu.MouseLeave +=
                btnLuuGhiChu_MouseLeave;


            // ==========================================
            // ERROR PROVIDER
            // ==========================================

            errorProvider1.ContainerControl =
                this;


            // ==========================================
            // FORM GHI CHÚ
            // ==========================================

            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(480, 490);

            Controls.Add(lblTieuDeForm);

            Controls.Add(lblTieuDe);
            Controls.Add(txtTieuDe);

            Controls.Add(lblNoiDung);
            Controls.Add(txtNoiDung);

            Controls.Add(lblMucDoUuTien);
            Controls.Add(cboMucDoUuTien);

            Controls.Add(btnLuuGhiChu);

            Font =
                new Font("Segoe UI", 10F);

            // QUAN TRỌNG
            KeyPreview = true;

            Name =
                "FormGhiChu";

            Text =
                "Ghi chú mới";

            FormClosing +=
                FormGhiChu_FormClosing;

            KeyDown +=
                FormGhiChu_KeyDown;

            ((System.ComponentModel.ISupportInitialize)
                errorProvider1).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}