using IT09_DE1_N8.Models;
using IT09_DE1_N8.Services;

namespace IT09_DE1_N8.Forms
{
    public partial class FormKhachHang : Form
    {
        private readonly KhachHangServices service;
        private int? selectedMaKH = null;
        public FormKhachHang()
        {
            InitializeComponent();
            service = new KhachHangServices("Data Source=DESKTOP-8U8QO0L\\SQLEXPRESS;Initial Catalog=IT09;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            LoadData();
            // disable nút sửa, xóa lúc đầu
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            // gắn event chọn dòng
            dgvKhachHang.CellClick += dgvKhachHang_CellContentClick;
        }

        private void LoadData()
        {
            var list = service.GetAll();
            dgvKhachHang.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var kh = new KhachHang
            {
                HoTenChuHo = txtHoTenChuHo.Text,
                DiaChi = txtDiaChi.Text,
                DienThoai = txtDienThoai.Text,
                SoHopDong = txtSoHopDong.Text
            };
            service.Add(kh);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                var kh = (KhachHang)dgvKhachHang.CurrentRow.DataBoundItem;
                kh.HoTenChuHo = txtHoTenChuHo.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.DienThoai = txtDienThoai.Text;
                kh.SoHopDong = txtSoHopDong.Text;
                service.Update(kh);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                var kh = (KhachHang)dgvKhachHang.CurrentRow.DataBoundItem;
                service.Delete(kh.MaKH);
                LoadData();
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                selectedMaKH = Convert.ToInt32(row.Cells["MaKH"].Value);

                txtHoTenChuHo.Text = row.Cells["HoTenChuHo"].Value == null || row.Cells["HoTenChuHo"].Value == DBNull.Value
                    ? ""
                    : row.Cells["HoTenChuHo"].Value.ToString();

                txtDienThoai.Text = row.Cells["DienThoai"].Value == null || row.Cells["DienThoai"].Value == DBNull.Value
                    ? ""
                    : row.Cells["DienThoai"].Value.ToString();

                txtDiaChi.Text = row.Cells["DiaChi"].Value == null || row.Cells["DiaChi"].Value == DBNull.Value
                    ? ""
                    : row.Cells["DiaChi"].Value.ToString();

                txtSoHopDong.Text = row.Cells["SoHopDong"].Value == null || row.Cells["SoHopDong"].Value == DBNull.Value
                    ? ""
                    : row.Cells["SoHopDong"].Value.ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
