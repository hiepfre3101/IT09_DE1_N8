using IT09_DE1_N8.Models;
using IT09_DE1_N8.Services;

namespace IT09_DE1_N8.Forms
{
    public partial class FormChiSoNuoc : Form
    {
        private readonly ChiSoNuocServices service;
        private readonly NhanVienService nvService;
        private readonly DongHoNuocServices dhService;
        public FormChiSoNuoc()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-8U8QO0L\\SQLEXPRESS;Initial Catalog=IT09;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            service = new ChiSoNuocServices(connectionString);
            nvService = new NhanVienService();
            dhService = new DongHoNuocServices(connectionString);
            LoadDongHo();
            LoadNhanVien();
            LoadData();
            ResetForm();
        }

        private void LoadDongHo()
        {
            var listDH = dhService.GetAll();
            cboMaDongHo.DataSource = listDH;
            cboMaDongHo.DisplayMember = "MaDongHo";
            cboMaDongHo.ValueMember = "MaDongHo";
        }

        private void LoadNhanVien()
        {
            var listNV = nvService.GetAll();
            cboMaNhanVien.DataSource = listNV;
            cboMaNhanVien.DisplayMember = "MaNV";
            cboMaNhanVien.ValueMember = "MaNV";
        }

        private void LoadData()
        {
            dgvChiSo.DataSource = service.GetAll();
        }

        private void ResetForm()
        {
            txtThangChiSo.Text = string.Empty;
            txtNamChiSo.Text = string.Empty;
            txtChiSoCu.Text = string.Empty;
            txtChiSoMoi.Text = string.Empty;                
            cboMaNhanVien.SelectedIndex = -1;              
            cboMaDongHo.SelectedIndex = -1;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var cs = new ChiSoNuoc
            {
                MaDongHo = (int)cboMaDongHo.SelectedValue,
                MaNV = (int)cboMaNhanVien.SelectedValue,
                Thang = int.Parse(txtThangChiSo.Text),
                Nam = int.Parse(txtNamChiSo.Text),
                ChiSoCu = int.Parse(txtChiSoCu.Text),
                ChiSoMoi = int.Parse(txtChiSoMoi.Text)
            };
            service.Add(cs);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvChiSo.CurrentRow != null)
            {
                var cs = (ChiSoNuoc)dgvChiSo.CurrentRow.DataBoundItem;
                cs.ChiSoCu = int.Parse(txtChiSoCu.Text);
                cs.ChiSoMoi = int.Parse(txtChiSoMoi.Text);
                cs.Nam = int.Parse(txtNamChiSo.Text);
                cs.Thang = int.Parse(txtThangChiSo.Text);
                cs.MaDongHo = (int)cboMaDongHo.SelectedValue;
                cs.MaNV = (int)cboMaNhanVien.SelectedValue;
                service.Update(cs);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvChiSo.CurrentRow != null)
            {
                var cs = (ChiSoNuoc)dgvChiSo.CurrentRow.DataBoundItem;
                service.Delete(cs.MaChiSo);
                ResetForm();
                LoadData();
            }
        }

        private void dgvChiSo_CellContentClick(object sender, EventArgs e)
        {
            if (dgvChiSo.CurrentRow != null)
            {
                var cs = (ChiSoNuoc)dgvChiSo.CurrentRow.DataBoundItem;
                txtChiSoCu.Text = cs.ChiSoCu.ToString();
                txtChiSoMoi.Text = cs.ChiSoMoi.ToString();
                txtNamChiSo.Text = cs.Nam.ToString();
                txtThangChiSo.Text = cs.Thang.ToString();
                cboMaDongHo.SelectedValue = cs.MaDongHo;
                cboMaNhanVien.SelectedValue = cs.MaNV;

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

            }
        }

    }
}
