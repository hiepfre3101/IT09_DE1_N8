namespace IT09_DE1_N8.Forms
{
    partial class FormKhachHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtHoTenChuHo, txtDiaChi, txtDienThoai, txtSoHopDong;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete;
        private System.Windows.Forms.Label lblHoTenChuHo, lblDiaChi, lblDienThoai, lblSoHopDong;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvKhachHang = new DataGridView();
            groupBoxInfo = new GroupBox();
            lblHoTenChuHo = new Label();
            txtHoTenChuHo = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblDienThoai = new Label();
            txtDienThoai = new TextBox();
            lblSoHopDong = new Label();
            txtSoHopDong = new TextBox();
            pnlButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            groupBoxInfo.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.Location = new Point(12, 190);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(760, 294);
            dgvKhachHang.TabIndex = 2;
            dgvKhachHang.CellClick += dgvKhachHang_CellContentClick;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(lblHoTenChuHo);
            groupBoxInfo.Controls.Add(txtHoTenChuHo);
            groupBoxInfo.Controls.Add(lblDiaChi);
            groupBoxInfo.Controls.Add(txtDiaChi);
            groupBoxInfo.Controls.Add(lblDienThoai);
            groupBoxInfo.Controls.Add(txtDienThoai);
            groupBoxInfo.Controls.Add(lblSoHopDong);
            groupBoxInfo.Controls.Add(txtSoHopDong);
            groupBoxInfo.Location = new Point(12, 12);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(760, 120);
            groupBoxInfo.TabIndex = 0;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Thông tin khách hàng";
            // 
            // lblHoTenChuHo
            // 
            lblHoTenChuHo.AutoSize = true;
            lblHoTenChuHo.Location = new Point(20, 30);
            lblHoTenChuHo.Name = "lblHoTenChuHo";
            lblHoTenChuHo.Size = new Size(86, 15);
            lblHoTenChuHo.TabIndex = 0;
            lblHoTenChuHo.Text = "Họ tên chủ hộ:";
            // 
            // txtHoTenChuHo
            // 
            txtHoTenChuHo.Location = new Point(120, 27);
            txtHoTenChuHo.Name = "txtHoTenChuHo";
            txtHoTenChuHo.Size = new Size(200, 23);
            txtHoTenChuHo.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(380, 30);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(46, 15);
            lblDiaChi.TabIndex = 2;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(440, 27);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(280, 23);
            txtDiaChi.TabIndex = 3;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new Point(20, 70);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(64, 15);
            lblDienThoai.TabIndex = 4;
            lblDienThoai.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(120, 67);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(200, 23);
            txtDienThoai.TabIndex = 5;
            // 
            // lblSoHopDong
            // 
            lblSoHopDong.AutoSize = true;
            lblSoHopDong.Location = new Point(380, 70);
            lblSoHopDong.Name = "lblSoHopDong";
            lblSoHopDong.Size = new Size(78, 15);
            lblSoHopDong.TabIndex = 6;
            lblSoHopDong.Text = "Số hợp đồng:";
            // 
            // txtSoHopDong
            // 
            txtSoHopDong.Location = new Point(480, 67);
            txtSoHopDong.Name = "txtSoHopDong";
            txtSoHopDong.Size = new Size(240, 23);
            txtSoHopDong.TabIndex = 7;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Location = new Point(12, 140);
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
            // FormKhachHang
            // 
            ClientSize = new Size(784, 505);
            Controls.Add(groupBoxInfo);
            Controls.Add(pnlButtons);
            Controls.Add(dgvKhachHang);
            Name = "FormKhachHang";
            Text = "Quản lý Khách hàng";
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
