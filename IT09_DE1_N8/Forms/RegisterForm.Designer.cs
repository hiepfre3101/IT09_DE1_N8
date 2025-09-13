namespace IT09_DE1_N8.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblHo = new Label();
            lblTen = new Label();
            lblChucVu = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            txtChucVu = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Location = new Point(30, 30);
            lblHo.Name = "lblHo";
            lblHo.Size = new Size(25, 15);
            lblHo.TabIndex = 0;
            lblHo.Text = "Họ:";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(30, 70);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(29, 15);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên:";
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(30, 110);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(54, 15);
            lblChucVu.TabIndex = 2;
            lblChucVu.Text = "Chức vụ:";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(130, 27);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(200, 23);
            txtHo.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(130, 67);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(200, 23);
            txtTen.TabIndex = 4;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(130, 107);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(200, 23);
            txtChucVu.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(130, 150);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 30);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            ClientSize = new Size(380, 210);
            Controls.Add(lblHo);
            Controls.Add(lblTen);
            Controls.Add(lblChucVu);
            Controls.Add(txtHo);
            Controls.Add(txtTen);
            Controls.Add(txtChucVu);
            Controls.Add(btnRegister);
            Name = "RegisterForm";
            Text = "Đăng ký nhân viên";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
