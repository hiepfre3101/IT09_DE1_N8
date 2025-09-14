namespace IT09_DE1_N8.Forms
{
    partial class FormChiSoNuoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvChiSo;
        private System.Windows.Forms.TextBox txtMaDongHo, txtThang, txtNam, txtChiSoCu, txtChiSoMoi, txtMaNV;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete;
        private System.Windows.Forms.Label lblMaDongHo, lblThang, lblNam, lblChiSoCu, lblChiSoMoi, lblMaNV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvChiSo = new DataGridView();
            lblMaDongHo = new Label();
            txtMaDongHo = new TextBox();
            lblThang = new Label();
            txtThang = new TextBox();
            lblNam = new Label();
            txtNam = new TextBox();
            lblChiSoCu = new Label();
            txtChiSoCu = new TextBox();
            lblChiSoMoi = new Label();
            txtChiSoMoi = new TextBox();
            lblMaNV = new Label();
            txtMaNV = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiSo).BeginInit();
            SuspendLayout();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            // 
            // dgvChiSo
            // 
            dgvChiSo.Location = new Point(0, 0);
            dgvChiSo.Name = "dgvChiSo";
            dgvChiSo.Size = new Size(226, 150);
            dgvChiSo.TabIndex = 0;
            // 
            // lblMaDongHo
            // 
            lblMaDongHo.Location = new Point(0, 0);
            lblMaDongHo.Name = "lblMaDongHo";
            lblMaDongHo.Size = new Size(100, 23);
            lblMaDongHo.TabIndex = 1;
            // 
            // txtMaDongHo
            // 
            txtMaDongHo.Location = new Point(0, 0);
            txtMaDongHo.Name = "txtMaDongHo";
            txtMaDongHo.Size = new Size(100, 23);
            txtMaDongHo.TabIndex = 2;
            // 
            // lblThang
            // 
            lblThang.Location = new Point(0, 0);
            lblThang.Name = "lblThang";
            lblThang.Size = new Size(100, 23);
            lblThang.TabIndex = 3;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(0, 0);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(100, 23);
            txtThang.TabIndex = 4;
            // 
            // lblNam
            // 
            lblNam.Location = new Point(0, 0);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(100, 23);
            lblNam.TabIndex = 5;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(0, 0);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(100, 23);
            txtNam.TabIndex = 6;
            // 
            // lblChiSoCu
            // 
            lblChiSoCu.Location = new Point(0, 0);
            lblChiSoCu.Name = "lblChiSoCu";
            lblChiSoCu.Size = new Size(100, 23);
            lblChiSoCu.TabIndex = 7;
            // 
            // txtChiSoCu
            // 
            txtChiSoCu.Location = new Point(0, 0);
            txtChiSoCu.Name = "txtChiSoCu";
            txtChiSoCu.Size = new Size(100, 23);
            txtChiSoCu.TabIndex = 8;
            // 
            // lblChiSoMoi
            // 
            lblChiSoMoi.Location = new Point(0, 0);
            lblChiSoMoi.Name = "lblChiSoMoi";
            lblChiSoMoi.Size = new Size(100, 23);
            lblChiSoMoi.TabIndex = 9;
            // 
            // txtChiSoMoi
            // 
            txtChiSoMoi.Location = new Point(0, 0);
            txtChiSoMoi.Name = "txtChiSoMoi";
            txtChiSoMoi.Size = new Size(100, 23);
            txtChiSoMoi.TabIndex = 10;
            // 
            // lblMaNV
            // 
            lblMaNV.Location = new Point(0, 0);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(100, 23);
            lblMaNV.TabIndex = 11;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(0, 0);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(100, 23);
            txtMaNV.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(0, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(0, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormChiSoNuoc
            // 
            ClientSize = new Size(784, 511);
            Controls.Add(dgvChiSo);
            Controls.Add(lblMaDongHo);
            Controls.Add(txtMaDongHo);
            Controls.Add(lblThang);
            Controls.Add(txtThang);
            Controls.Add(lblNam);
            Controls.Add(txtNam);
            Controls.Add(lblChiSoCu);
            Controls.Add(txtChiSoCu);
            Controls.Add(lblChiSoMoi);
            Controls.Add(txtChiSoMoi);
            Controls.Add(lblMaNV);
            Controls.Add(txtMaNV);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "FormChiSoNuoc";
            Text = "Quản lý Chỉ số nước";
            ((System.ComponentModel.ISupportInitialize)dgvChiSo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
