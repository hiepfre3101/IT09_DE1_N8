namespace IT09_DE1_N8.Forms
{
    partial class FormHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.TextBox txtMaChiSo, txtSoTien;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete;
        private System.Windows.Forms.Label lblMaChiSo, lblSoTien, lblTrangThai;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvHoaDon = new DataGridView();
            groupBoxInfo = new GroupBox();
            lblMaChiSo = new Label();
            txtMaChiSo = new TextBox();
            lblSoTien = new Label();
            txtSoTien = new TextBox();
            lblTrangThai = new Label();
            chkTrangThai = new CheckBox();
            pnlButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            groupBoxInfo.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();


            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            // 
            // dgvHoaDon
            // 
            dgvHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.Location = new Point(12, 170);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(760, 270);
            dgvHoaDon.TabIndex = 2;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(lblMaChiSo);
            groupBoxInfo.Controls.Add(txtMaChiSo);
            groupBoxInfo.Controls.Add(lblSoTien);
            groupBoxInfo.Controls.Add(txtSoTien);
            groupBoxInfo.Controls.Add(lblTrangThai);
            groupBoxInfo.Controls.Add(chkTrangThai);
            groupBoxInfo.Location = new Point(12, 12);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(760, 100);
            groupBoxInfo.TabIndex = 0;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Thông tin Hóa đơn";
            // 
            // lblMaChiSo
            // 
            lblMaChiSo.AutoSize = true;
            lblMaChiSo.Location = new Point(20, 30);
            lblMaChiSo.Name = "lblMaChiSo";
            lblMaChiSo.Size = new Size(74, 15);
            lblMaChiSo.TabIndex = 0;
            lblMaChiSo.Text = "Mã hóa đơn:";
            // 
            // txtMaChiSo
            // 
            txtMaChiSo.Location = new Point(100, 27);
            txtMaChiSo.Name = "txtMaChiSo";
            txtMaChiSo.Size = new Size(200, 23);
            txtMaChiSo.TabIndex = 1;
            // 
            // lblSoTien
            // 
            lblSoTien.AutoSize = true;
            lblSoTien.Location = new Point(340, 30);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(46, 15);
            lblSoTien.TabIndex = 2;
            lblSoTien.Text = "Số tiền:";
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(400, 27);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(200, 23);
            txtSoTien.TabIndex = 3;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(20, 65);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(62, 15);
            lblTrangThai.TabIndex = 4;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Location = new Point(100, 63);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(101, 19);
            chkTrangThai.TabIndex = 5;
            chkTrangThai.Text = "Đã thanh toán";
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
            btnUpdate.Location = new Point(109, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(215, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // FormHoaDon
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(groupBoxInfo);
            Controls.Add(pnlButtons);
            Controls.Add(dgvHoaDon);
            Name = "FormHoaDon";
            Text = "Quản lý Hóa đơn";
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
