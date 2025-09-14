using IT09_DE1_N8.Models;
using IT09_DE1_N8.Services;
using System;
using System.Windows.Forms;

namespace IT09_DE1_N8.Forms
{
    public partial class FormNhanVien : Form
    {
        private readonly NhanVienService service = new NhanVienService();
        private int? selectedMaNV = null;  // giữ MaNV đang chọn

        public FormNhanVien()
        {
            InitializeComponent();
            LoadData();

            // disable nút sửa, xóa lúc đầu
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            // gắn event chọn dòng
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
        }

        private void LoadData()
        {
            dgvNhanVien.DataSource = service.GetAll();
            ClearForm();
        }

        private void InitSearchControls()
        {
            txtSearch = new TextBox
            {
                Location = new System.Drawing.Point(20, 170),
                Width = 200,
                PlaceholderText = "Nhập tên nhân viên..."
            };

            btnSearch = new Button
            {
                Location = new System.Drawing.Point(230, 168),
                Text = "Tìm kiếm"
            };
            btnSearch.Click += btnSearch_Click;

            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
            }
            else
            {
                var list = service.GetAll()
                                  .Where(nv => nv.HoTen.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                                  .ToList();
                dgvNhanVien.DataSource = list;
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                selectedMaNV = Convert.ToInt32(row.Cells["MaNV"].Value);

                txtHoTen.Text = row.Cells["HoTen"].Value == null || row.Cells["HoTen"].Value == DBNull.Value
                    ? ""
                    : row.Cells["HoTen"].Value.ToString();

                if (row.Cells["NgaySinh"].Value != null && row.Cells["NgaySinh"].Value != DBNull.Value)
                    dtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                else
                    dtNgaySinh.Value = DateTime.Now;

                txtGioiTinh.Text = row.Cells["GioiTinh"].Value == null || row.Cells["GioiTinh"].Value == DBNull.Value
                    ? ""
                    : row.Cells["GioiTinh"].Value.ToString();

                txtDiaChi.Text = row.Cells["DiaChi"].Value == null || row.Cells["DiaChi"].Value == DBNull.Value
                    ? ""
                    : row.Cells["DiaChi"].Value.ToString();

                txtDienThoai.Text = row.Cells["DienThoai"].Value == null || row.Cells["DienThoai"].Value == DBNull.Value
                    ? ""
                    : row.Cells["DienThoai"].Value.ToString();

                txtChucVu.Text = row.Cells["ChucVu"].Value == null || row.Cells["ChucVu"].Value == DBNull.Value
                    ? ""
                    : row.Cells["ChucVu"].Value.ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var nv = new NhanVien
            {
                HoTen = txtHoTen.Text,
                NgaySinh = dtNgaySinh.Value,
                GioiTinh = txtGioiTinh.Text,
                DiaChi = txtDiaChi.Text,
                DienThoai = txtDienThoai.Text,
                ChucVu = txtChucVu.Text
            };

            service.Add(nv);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMaNV.HasValue)
            {
                var nv = new NhanVien
                {
                    MaNV = selectedMaNV.Value,
                    HoTen = txtHoTen.Text,
                    NgaySinh = dtNgaySinh.Value,
                    GioiTinh = txtGioiTinh.Text,
                    DiaChi = txtDiaChi.Text,
                    DienThoai = txtDienThoai.Text,
                    ChucVu = txtChucVu.Text
                };

                service.Update(nv);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMaNV.HasValue)
            {
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?",
                                              "Xác nhận",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    service.Delete(selectedMaNV.Value);
                    LoadData();
                }
            }
        }

        private void ClearForm()
        {
            selectedMaNV = null;
            txtHoTen.Clear();
            txtGioiTinh.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtChucVu.Clear();
            dtNgaySinh.Value = DateTime.Now;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
