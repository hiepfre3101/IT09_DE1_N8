using IT09_DE1_N8.Models;
using IT09_DE1_N8.Services;

namespace IT09_DE1_N8.Forms
{
    public partial class FormDongHoNuoc : Form
    {
        private readonly DongHoNuocServices service;
        private readonly KhachHangServices khService;

        public FormDongHoNuoc()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-8U8QO0L\\SQLEXPRESS;Initial Catalog=IT09;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            service = new DongHoNuocServices(connectionString);
            khService = new KhachHangServices(connectionString);
            LoadKhachHang();
            LoadData();
        }

        private void LoadKhachHang()
        {
            var listKH = khService.GetAll();
            cboKhachHang.DataSource = listKH;
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
        }

        private void LoadData()
        {
            dgvDongHo.DataSource = service.GetAll();

            // set header cho dễ nhìn
            dgvDongHo.Columns["MaDongHo"].HeaderText = "Mã đồng hồ";
            dgvDongHo.Columns["MaKH"].HeaderText = "Mã KH";
            dgvDongHo.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgvDongHo.Columns["SoHieu"].HeaderText = "Số hiệu";
            dgvDongHo.Columns["NgayLapDat"].HeaderText = "Ngày lắp đặt";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dh = new DongHoNuoc
            {
                SoHieu = txtSoHieu.Text,
                MaKH = (int)cboKhachHang.SelectedValue,
                NgayLapDat = dtNgayLapDat.Value
            };
            service.Add(dh);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDongHo.CurrentRow != null)
            {
                var dh = (DongHoNuoc)dgvDongHo.CurrentRow.DataBoundItem;
                dh.SoHieu = txtSoHieu.Text;
                dh.MaKH = (int)cboKhachHang.SelectedValue;
                dh.NgayLapDat = dtNgayLapDat.Value;

                service.Update(dh);
                LoadKhachHang();
                LoadData();
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDongHo.CurrentRow != null)
            {
                var dh = (DongHoNuoc)dgvDongHo.CurrentRow.DataBoundItem;
                service.Delete(dh.MaDongHo);
                ResetForm();
                LoadData();
               
            }
        }

        private void ResetForm()
        {
            txtSoHieu.Text = string.Empty;                
            cboKhachHang.SelectedIndex = -1;              
            dtNgayLapDat.Value = DateTime.Now;            

            btnUpdate.Enabled = false;                   
            btnDelete.Enabled = false;                    
        }

        private void dgvDongHo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDongHo.CurrentRow != null)
            {
                var dh = (DongHoNuoc)dgvDongHo.CurrentRow.DataBoundItem;
                txtSoHieu.Text = dh.SoHieu;
                dtNgayLapDat.Value = (DateTime)dh.NgayLapDat;
                cboKhachHang.SelectedValue = dh.MaKH;

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

            }
        }
    }
}
