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
            // 
            // dgvDongHo
            // 
            dgvDongHo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDongHo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDongHo.Location = new Point(12, 170);
            dgvDongHo.MultiSelect = false;
            dgvDongHo.Name = "dgvDongHo";
            dgvDongHo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDongHo.Size = new Size(760, 270);
            dgvDongHo.TabIndex = 2;
            dgvDongHo.CellClick += dgvDongHo_SelectionChanged;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(lblKhachHang);
            groupBoxInfo.Controls.Add(cboKhachHang);
            groupBoxInfo.Controls.Add(lblSoHieu);
            groupBoxInfo.Controls.Add(txtSoHieu);
            groupBoxInfo.Controls.Add(lblNgayLapDat);
            groupBoxInfo.Controls.Add(dtNgayLapDat);
            groupBoxInfo.Location = new Point(12, 12);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(760, 100);
            groupBoxInfo.TabIndex = 0;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Thông tin Đồng hồ nước";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Location = new Point(20, 30);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(73, 15);
            lblKhachHang.TabIndex = 0;
            lblKhachHang.Text = "Khách hàng:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.Location = new Point(100, 27);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(200, 23);
            cboKhachHang.TabIndex = 1;
            // 
            // lblSoHieu
            // 
            lblSoHieu.AutoSize = true;
            lblSoHieu.Location = new Point(340, 30);
            lblSoHieu.Name = "lblSoHieu";
            lblSoHieu.Size = new Size(49, 15);
            lblSoHieu.TabIndex = 2;
            lblSoHieu.Text = "Số hiệu:";
            // 
            // txtSoHieu
            // 
            txtSoHieu.Location = new Point(400, 27);
            txtSoHieu.Name = "txtSoHieu";
            txtSoHieu.Size = new Size(200, 23);
            txtSoHieu.TabIndex = 3;
            // 
            // lblNgayLapDat
            // 
            lblNgayLapDat.AutoSize = true;
            lblNgayLapDat.Location = new Point(20, 65);
            lblNgayLapDat.Name = "lblNgayLapDat";
            lblNgayLapDat.Size = new Size(77, 15);
            lblNgayLapDat.TabIndex = 4;
            lblNgayLapDat.Text = "Ngày lắp đặt:";
            // 
            // dtNgayLapDat
            // 
            dtNgayLapDat.Location = new Point(100, 63);
            dtNgayLapDat.Name = "dtNgayLapDat";
            dtNgayLapDat.Size = new Size(200, 23);
            dtNgayLapDat.TabIndex = 5;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Location = new Point(12, 120);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(760, 40);
            pnlButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(109, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(215, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
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
