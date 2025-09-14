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

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Text = "Thông tin khách hàng";
            groupBoxInfo.Location = new Point(12, 12);
            groupBoxInfo.Size = new Size(760, 120);
            groupBoxInfo.Controls.Add(lblHoTenChuHo);
            groupBoxInfo.Controls.Add(txtHoTenChuHo);
            groupBoxInfo.Controls.Add(lblDiaChi);
            groupBoxInfo.Controls.Add(txtDiaChi);
            groupBoxInfo.Controls.Add(lblDienThoai);
            groupBoxInfo.Controls.Add(txtDienThoai);
            groupBoxInfo.Controls.Add(lblSoHopDong);
            groupBoxInfo.Controls.Add(txtSoHopDong);

            // 
            // lblHoTenChuHo
            // 
            lblHoTenChuHo.Text = "Họ tên chủ hộ:";
            lblHoTenChuHo.Location = new Point(20, 30);
            lblHoTenChuHo.AutoSize = true;

            // 
            // txtHoTenChuHo
            // 
            txtHoTenChuHo.Location = new Point(120, 27);
            txtHoTenChuHo.Size = new Size(200, 23);

            // 
            // lblDiaChi
            // 
            lblDiaChi.Text = "Địa chỉ:";
            lblDiaChi.Location = new Point(380, 30);
            lblDiaChi.AutoSize = true;

            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(440, 27);
            txtDiaChi.Size = new Size(280, 23);

            // 
            // lblDienThoai
            // 
            lblDienThoai.Text = "Điện thoại:";
            lblDienThoai.Location = new Point(20, 70);
            lblDienThoai.AutoSize = true;

            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(120, 67);
            txtDienThoai.Size = new Size(200, 23);

            // 
            // lblSoHopDong
            // 
            lblSoHopDong.Text = "Số hợp đồng:";
            lblSoHopDong.Location = new Point(380, 70);
            lblSoHopDong.AutoSize = true;

            // 
            // txtSoHopDong
            // 
            txtSoHopDong.Location = new Point(480, 67);
            txtSoHopDong.Size = new Size(240, 23);

            // 
            // pnlButtons
            // 
            pnlButtons.Location = new Point(12, 140);
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
            // dgvKhachHang
            // 
            dgvKhachHang.Location = new Point(12, 190);
            dgvKhachHang.Size = new Size(760, 250);
            dgvKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.MultiSelect = false;

            // 
            // FormKhachHang
            // 
            ClientSize = new Size(784, 461);
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
