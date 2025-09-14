using IT09_DE1_N8.Models;
using IT09_DE1_N8.Services;

namespace IT09_DE1_N8.Forms
{
    public partial class FormKhachHang : Form
    {
        private readonly KhachHangServices service;
        public FormKhachHang()
        {
            InitializeComponent();
            service = new KhachHangServices("Data Source=DESKTOP-8U8QO0L\\SQLEXPRESS;Initial Catalog=IT09;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            LoadData();
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
                DienThoai = txtDienThoai.Text
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
    }
}
