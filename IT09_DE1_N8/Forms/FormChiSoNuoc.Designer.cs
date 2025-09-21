namespace IT09_DE1_N8.Forms
{
    partial class FormChiSoNuoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvChiSo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvChiSo = new DataGridView();
            groupBoxInfo = new GroupBox();
            txtSdtNv = new TextBox();
            lblSdtNV = new Label();
            txtTenNv = new TextBox();
            lblTenNV = new Label();
            txtSoHieu = new TextBox();
            lblSoHieu = new Label();
            txtNgayLap = new TextBox();
            lblNgayLap = new Label();
            lblMaNhanVien = new Label();
            cboMaNhanVien = new ComboBox();
            lblDongHo = new Label();
            lblThangChiSo = new Label();
            cboMaDongHo = new ComboBox();
            txtThangChiSo = new TextBox();
            lblNamChiSo = new Label();
            txtNamChiSo = new TextBox();
            lblChiSoCu = new Label();
            txtChiSoCu = new TextBox();
            lblChiSoMoi = new Label();
            txtChiSoMoi = new TextBox();
            pnlButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblChucVu = new Label();
            txtChucVu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvChiSo).BeginInit();
            groupBoxInfo.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dgvChiSo
            // 
            dgvChiSo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChiSo.Location = new Point(-4, 341);
            dgvChiSo.Name = "dgvChiSo";
            dgvChiSo.Size = new Size(1272, 389);
            dgvChiSo.TabIndex = 0;
            dgvChiSo.CellClick += dgvChiSo_CellContentClick;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(txtChucVu);
            groupBoxInfo.Controls.Add(lblChucVu);
            groupBoxInfo.Controls.Add(txtSdtNv);
            groupBoxInfo.Controls.Add(lblSdtNV);
            groupBoxInfo.Controls.Add(txtTenNv);
            groupBoxInfo.Controls.Add(lblTenNV);
            groupBoxInfo.Controls.Add(txtSoHieu);
            groupBoxInfo.Controls.Add(lblSoHieu);
            groupBoxInfo.Controls.Add(txtNgayLap);
            groupBoxInfo.Controls.Add(lblNgayLap);
            groupBoxInfo.Controls.Add(lblMaNhanVien);
            groupBoxInfo.Controls.Add(cboMaNhanVien);
            groupBoxInfo.Controls.Add(lblDongHo);
            groupBoxInfo.Controls.Add(lblThangChiSo);
            groupBoxInfo.Controls.Add(cboMaDongHo);
            groupBoxInfo.Controls.Add(txtThangChiSo);
            groupBoxInfo.Controls.Add(lblNamChiSo);
            groupBoxInfo.Controls.Add(txtNamChiSo);
            groupBoxInfo.Controls.Add(lblChiSoCu);
            groupBoxInfo.Controls.Add(txtChiSoCu);
            groupBoxInfo.Controls.Add(lblChiSoMoi);
            groupBoxInfo.Controls.Add(txtChiSoMoi);
            groupBoxInfo.Location = new Point(12, 12);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(760, 280);
            groupBoxInfo.TabIndex = 16;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Thông tin Chỉ số nước";
            // 
            // txtSdtNv
            // 
            txtSdtNv.Enabled = false;
            txtSdtNv.Location = new Point(480, 186);
            txtSdtNv.Name = "txtSdtNv";
            txtSdtNv.Size = new Size(240, 23);
            txtSdtNv.TabIndex = 27;
            // 
            // lblSdtNV
            // 
            lblSdtNV.AutoSize = true;
            lblSdtNV.Location = new Point(380, 186);
            lblSdtNV.Name = "lblSdtNV";
            lblSdtNV.Size = new Size(29, 15);
            lblSdtNV.TabIndex = 26;
            lblSdtNV.Text = "SDT:";
            lblSdtNV.UseWaitCursor = true;
            // 
            // txtTenNv
            // 
            txtTenNv.Enabled = false;
            txtTenNv.Location = new Point(480, 152);
            txtTenNv.Name = "txtTenNv";
            txtTenNv.Size = new Size(240, 23);
            txtTenNv.TabIndex = 25;
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Location = new Point(380, 152);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(83, 15);
            lblTenNV.TabIndex = 24;
            lblTenNV.Text = "Tên nhân viên:";
            lblTenNV.UseWaitCursor = true;
            // 
            // txtSoHieu
            // 
            txtSoHieu.Enabled = false;
            txtSoHieu.Location = new Point(120, 186);
            txtSoHieu.Name = "txtSoHieu";
            txtSoHieu.Size = new Size(200, 23);
            txtSoHieu.TabIndex = 23;
            // 
            // lblSoHieu
            // 
            lblSoHieu.AutoSize = true;
            lblSoHieu.Location = new Point(20, 186);
            lblSoHieu.Name = "lblSoHieu";
            lblSoHieu.Size = new Size(49, 15);
            lblSoHieu.TabIndex = 22;
            lblSoHieu.Text = "Số hiệu:";
            lblSoHieu.UseWaitCursor = true;
            // 
            // txtNgayLap
            // 
            txtNgayLap.Enabled = false;
            txtNgayLap.Location = new Point(120, 152);
            txtNgayLap.Name = "txtNgayLap";
            txtNgayLap.Size = new Size(200, 23);
            txtNgayLap.TabIndex = 0;
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Location = new Point(20, 152);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(57, 15);
            lblNgayLap.TabIndex = 21;
            lblNgayLap.Text = "Ngày lắp:";
            lblNgayLap.UseWaitCursor = true;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Location = new Point(380, 115);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(82, 15);
            lblMaNhanVien.TabIndex = 19;
            lblMaNhanVien.Text = "Mã nhân viên:";
            lblMaNhanVien.UseWaitCursor = true;
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaNhanVien.Location = new Point(480, 112);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(240, 23);
            cboMaNhanVien.TabIndex = 20;
            cboMaNhanVien.SelectionChangeCommitted += cboMaNhanVien_SelectedChangedCommited;
            // 
            // lblDongHo
            // 
            lblDongHo.AutoSize = true;
            lblDongHo.Location = new Point(20, 115);
            lblDongHo.Name = "lblDongHo";
            lblDongHo.Size = new Size(76, 15);
            lblDongHo.TabIndex = 17;
            lblDongHo.Text = "Mã Đồng hồ:";
            lblDongHo.UseWaitCursor = true;
            // 
            // lblThangChiSo
            // 
            lblThangChiSo.AutoSize = true;
            lblThangChiSo.Location = new Point(20, 30);
            lblThangChiSo.Name = "lblThangChiSo";
            lblThangChiSo.Size = new Size(43, 15);
            lblThangChiSo.TabIndex = 0;
            lblThangChiSo.Text = "Tháng:";
            // 
            // cboMaDongHo
            // 
            cboMaDongHo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaDongHo.Location = new Point(120, 112);
            cboMaDongHo.Name = "cboMaDongHo";
            cboMaDongHo.Size = new Size(200, 23);
            cboMaDongHo.TabIndex = 18;
            cboMaDongHo.SelectionChangeCommitted += cboMaDongHo_SelectedChangedCommited;
            // 
            // txtThangChiSo
            // 
            txtThangChiSo.Location = new Point(120, 27);
            txtThangChiSo.Name = "txtThangChiSo";
            txtThangChiSo.Size = new Size(200, 23);
            txtThangChiSo.TabIndex = 1;
            // 
            // lblNamChiSo
            // 
            lblNamChiSo.AutoSize = true;
            lblNamChiSo.Location = new Point(380, 30);
            lblNamChiSo.Name = "lblNamChiSo";
            lblNamChiSo.Size = new Size(36, 15);
            lblNamChiSo.TabIndex = 2;
            lblNamChiSo.Text = "Năm:";
            // 
            // txtNamChiSo
            // 
            txtNamChiSo.Location = new Point(480, 27);
            txtNamChiSo.Name = "txtNamChiSo";
            txtNamChiSo.Size = new Size(240, 23);
            txtNamChiSo.TabIndex = 3;
            // 
            // lblChiSoCu
            // 
            lblChiSoCu.AutoSize = true;
            lblChiSoCu.Location = new Point(20, 70);
            lblChiSoCu.Name = "lblChiSoCu";
            lblChiSoCu.Size = new Size(59, 15);
            lblChiSoCu.TabIndex = 4;
            lblChiSoCu.Text = "Chỉ số cũ:";
            // 
            // txtChiSoCu
            // 
            txtChiSoCu.Location = new Point(120, 67);
            txtChiSoCu.Name = "txtChiSoCu";
            txtChiSoCu.Size = new Size(200, 23);
            txtChiSoCu.TabIndex = 5;
            // 
            // lblChiSoMoi
            // 
            lblChiSoMoi.AutoSize = true;
            lblChiSoMoi.Location = new Point(380, 70);
            lblChiSoMoi.Name = "lblChiSoMoi";
            lblChiSoMoi.Size = new Size(67, 15);
            lblChiSoMoi.TabIndex = 6;
            lblChiSoMoi.Text = "Chỉ số mới:";
            // 
            // txtChiSoMoi
            // 
            txtChiSoMoi.Location = new Point(480, 67);
            txtChiSoMoi.Name = "txtChiSoMoi";
            txtChiSoMoi.Size = new Size(240, 23);
            txtChiSoMoi.TabIndex = 7;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Location = new Point(12, 295);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(760, 40);
            pnlButtons.TabIndex = 17;
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
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(380, 220);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(54, 15);
            lblChucVu.TabIndex = 28;
            lblChucVu.Text = "Chức vụ:";
            lblChucVu.UseWaitCursor = true;
            // 
            // txtChucVu
            // 
            txtChucVu.Enabled = false;
            txtChucVu.Location = new Point(480, 220);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(240, 23);
            txtChucVu.TabIndex = 29;
            // 
            // FormChiSoNuoc
            // 
            ClientSize = new Size(1269, 730);
            Controls.Add(pnlButtons);
            Controls.Add(groupBoxInfo);
            Controls.Add(dgvChiSo);
            Name = "FormChiSoNuoc";
            Text = "Quản lý Chỉ số nước";
            ((System.ComponentModel.ISupportInitialize)dgvChiSo).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
        private GroupBox groupBoxInfo;
        private Label lblThangChiSo;
        private TextBox txtThangChiSo;
        private Label lblNamChiSo;
        private TextBox txtNamChiSo;
        private Label lblChiSoCu;
        private TextBox txtChiSoCu;
        private Label lblChiSoMoi;
        private TextBox txtChiSoMoi;
        private Label lblDongHo;
        private ComboBox cboMaDongHo;
        private Label lblMaNhanVien;
        private ComboBox cboMaNhanVien;
        private FlowLayoutPanel pnlButtons;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblNgayLap;
        private Label lblSoHieu;
        private TextBox txtNgayLap;
        private TextBox txtTenNv;
        private Label lblTenNV;
        private TextBox txtSoHieu;
        private TextBox txtSdtNv;
        private Label lblSdtNV;
        private TextBox txtChucVu;
        private Label lblChucVu;
    }
}
