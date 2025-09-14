namespace IT09_DE1_N8.Forms
{
    partial class FormDongHoNuoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDongHo;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.TextBox txtSoHieu;
        private System.Windows.Forms.DateTimePicker dtNgayLapDat;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete;
        private System.Windows.Forms.Label lblKhachHang, lblSoHieu, lblNgayLapDat;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvDongHo = new DataGridView();
            groupBoxInfo = new GroupBox();
            lblKhachHang = new Label();
            cboKhachHang = new ComboBox();
            lblSoHieu = new Label();
            txtSoHieu = new TextBox();
            lblNgayLapDat = new Label();
            dtNgayLapDat = new DateTimePicker();
            pnlButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvDongHo).BeginInit();
            groupBoxInfo.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Text = "Thông tin Đồng hồ nước";
            groupBoxInfo.Location = new Point(12, 12);
            groupBoxInfo.Size = new Size(760, 100);
            groupBoxInfo.Controls.Add(lblKhachHang);
            groupBoxInfo.Controls.Add(cboKhachHang);
            groupBoxInfo.Controls.Add(lblSoHieu);
            groupBoxInfo.Controls.Add(txtSoHieu);
            groupBoxInfo.Controls.Add(lblNgayLapDat);
            groupBoxInfo.Controls.Add(dtNgayLapDat);

            // 
            // lblKhachHang
            // 
            lblKhachHang.Text = "Khách hàng:";
            lblKhachHang.Location = new Point(20, 30);
            lblKhachHang.AutoSize = true;

            // 
            // cboKhachHang
            // 
            cboKhachHang.Location = new Point(100, 27);
            cboKhachHang.Size = new Size(200, 23);
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;

            // 
            // lblSoHieu
            // 
            lblSoHieu.Text = "Số hiệu:";
            lblSoHieu.Location = new Point(340, 30);
            lblSoHieu.AutoSize = true;

            // 
            // txtSoHieu
            // 
            txtSoHieu.Location = new Point(400, 27);
            txtSoHieu.Size = new Size(200, 23);

            // 
            // lblNgayLapDat
            // 
            lblNgayLapDat.Text = "Ngày lắp đặt:";
            lblNgayLapDat.Location = new Point(20, 65);
            lblNgayLapDat.AutoSize = true;

            // 
            // dtNgayLapDat
            // 
            dtNgayLapDat.Location = new Point(100, 63);
            dtNgayLapDat.Size = new Size(200, 23);

            // 
            // pnlButtons
            // 
            pnlButtons.Location = new Point(12, 120);
            pnlButtons.Size = new Size(760, 40);
            pnlButtons.FlowDirection = FlowDirection.LeftToRight;
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnDelete);

            // 
            // btnAdd
            // 
            btnAdd.Text = "Thêm";
            btnAdd.Size = new Size(100, 30);
            btnAdd.Click += btnAdd_Click;

            // 
            // btnUpdate
            // 
            btnUpdate.Text = "Sửa";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.Click += btnUpdate_Click;

            // 
            // btnDelete
            // 
            btnDelete.Text = "Xóa";
            btnDelete.Size = new Size(100, 30);
            btnDelete.Click += btnDelete_Click;

            // 
            // dgvDongHo
            // 
            dgvDongHo.Location = new Point(12, 170);
            dgvDongHo.Size = new Size(760, 270);
            dgvDongHo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvDongHo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDongHo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDongHo.MultiSelect = false;

            // 
            // FormDongHoNuoc
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(groupBoxInfo);
            Controls.Add(pnlButtons);
            Controls.Add(dgvDongHo);
            Name = "FormDongHoNuoc";
            Text = "Quản lý Đồng hồ nước";

            ((System.ComponentModel.ISupportInitialize)dgvDongHo).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
