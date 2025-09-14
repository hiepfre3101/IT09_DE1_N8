using IT09_DE1_N8.Models;
using IT09_DE1_N8.Services;

namespace IT09_DE1_N8.Forms
{
    public partial class FormChiSoNuoc : Form
    {
        private readonly ChiSoNuocServices service;

        public FormChiSoNuoc()
        {
            InitializeComponent();
            service = new ChiSoNuocServices("Data Source=DESKTOP-8U8QO0L\\SQLEXPRESS;Initial Catalog=IT09;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            LoadData();
        }

        private void LoadData()
        {
            dgvChiSo.DataSource = service.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var cs = new ChiSoNuoc
            {
                MaDongHo = int.Parse(txtMaDongHo.Text),
                Thang = int.Parse(txtThang.Text),
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
                cs.MaDongHo = int.Parse(txtMaDongHo.Text);
                cs.Thang = int.Parse(txtThang.Text);
                cs.ChiSoCu = int.Parse(txtChiSoCu.Text);
                cs.ChiSoMoi = int.Parse(txtChiSoMoi.Text);
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
                LoadData();
            }
        }
    }
}
