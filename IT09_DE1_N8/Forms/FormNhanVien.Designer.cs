namespace IT09_DE1_N8.Forms
{
    partial class FormNhanVien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtHoTen, txtGioiTinh, txtDiaChi, txtDienThoai, txtChucVu;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnSearch;
        private System.Windows.Forms.Label lblHoTen, lblNgaySinh, lblGioiTinh, lblDiaChi, lblDienThoai, lblChucVu, lblSearch;
        private System.Windows.Forms.TextBox txtSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvNhanVien = new DataGridView();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgaySinh = new Label();
            dtNgaySinh = new DateTimePicker();
            lblGioiTinh = new Label();
            txtGioiTinh = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblDienThoai = new Label();
            txtDienThoai = new TextBox();
            lblChucVu = new Label();
            txtChucVu = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.Location = new Point(20, 210);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(930, 250);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(20, 20);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 23);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(150, 20);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(200, 23);
            txtHoTen.TabIndex = 2;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new Point(20, 60);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(100, 23);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Location = new Point(150, 60);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(200, 23);
            dtNgaySinh.TabIndex = 4;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(20, 100);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(100, 23);
            lblGioiTinh.TabIndex = 5;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(150, 100);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(200, 23);
            txtGioiTinh.TabIndex = 6;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(20, 140);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(100, 23);
            lblDiaChi.TabIndex = 7;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(150, 140);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(400, 23);
            txtDiaChi.TabIndex = 8;
            // 
            // lblDienThoai
            // 
            lblDienThoai.Location = new Point(400, 20);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(100, 23);
            lblDienThoai.TabIndex = 9;
            lblDienThoai.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(500, 20);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(200, 23);
            txtDienThoai.TabIndex = 10;
            // 
            // lblChucVu
            // 
            lblChucVu.Location = new Point(400, 60);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(100, 23);
            lblChucVu.TabIndex = 11;
            lblChucVu.Text = "Chức vụ:";
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(500, 60);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(200, 23);
            txtChucVu.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(750, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(750, 60);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Sửa";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(750, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(20, 175);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 23);
            lblSearch.TabIndex = 16;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            txtSearch.AcceptsReturn = true;
            txtSearch.AcceptsTab = true;
            txtSearch.Location = new Point(150, 175);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên nhân viên";
            txtSearch.Size = new Size(319, 23);
            txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(475, 175);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Tìm";
            btnSearch.Click += btnSearch_Click;
            // 
            // FormNhanVien
            // 
            ClientSize = new Size(980, 480);
            Controls.Add(dgvNhanVien);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblNgaySinh);
            Controls.Add(dtNgaySinh);
            Controls.Add(lblGioiTinh);
            Controls.Add(txtGioiTinh);
            Controls.Add(lblDiaChi);
            Controls.Add(txtDiaChi);
            Controls.Add(lblDienThoai);
            Controls.Add(txtDienThoai);
            Controls.Add(lblChucVu);
            Controls.Add(txtChucVu);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Name = "FormNhanVien";
            Text = "Quản lý Nhân viên";
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
