using IT09_DE1_N8.Models;
using IT09_DE1_N8.Services;

namespace IT09_DE1_N8.Forms
{
    public partial class FormHoaDon : Form
    {
        private readonly HoaDonServices service;

        public FormHoaDon()
        {
            InitializeComponent();
            service = new HoaDonServices("Data Source=DESKTOP-8U8QO0L\\SQLEXPRESS;Initial Catalog=IT09;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            LoadData();
        }

        private void LoadData()
        {
            dgvHoaDon.DataSource = service.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var hd = new HoaDon
            {
                MaChiSo = int.Parse(txtMaChiSo.Text),
                SoTien = decimal.Parse(txtSoTien.Text),
                TrangThai = chkTrangThai.Checked ? "Đã thanh toán" : "Chưa thanh toán"
            };
            service.Add(hd);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                var hd = (HoaDon)dgvHoaDon.CurrentRow.DataBoundItem;
                hd.MaChiSo = int.Parse(txtMaChiSo.Text);
                hd.SoTien = decimal.Parse(txtSoTien.Text);
                hd.TrangThai = chkTrangThai.Checked ? "Đã thanh toán" : "Chưa thanh toán";
                service.Update(hd);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                var hd = (HoaDon)dgvHoaDon.CurrentRow.DataBoundItem;
                service.Delete(hd.MaHD);
                LoadData();
            }
        }
    }
}
