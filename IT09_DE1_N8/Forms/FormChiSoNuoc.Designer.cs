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
            ((System.ComponentModel.ISupportInitialize)dgvChiSo).BeginInit();
            groupBoxInfo.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dgvChiSo
            // 
            dgvChiSo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChiSo.Location = new Point(-4, 258);
            dgvChiSo.Name = "dgvChiSo";
            dgvChiSo.Size = new Size(793, 253);
            dgvChiSo.TabIndex = 0;
            dgvChiSo.CellClick += dgvChiSo_CellContentClick;
            // 
            // groupBoxInfo
            // 
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
            groupBoxInfo.Size = new Size(760, 172);
            groupBoxInfo.TabIndex = 16;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Thông tin Chỉ số nước";
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
            lblThangChiSo.Size = new Size(44, 15);
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
            pnlButtons.Location = new Point(12, 201);
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
            // FormChiSoNuoc
            // 
            ClientSize = new Size(790, 511);
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
    }
}
