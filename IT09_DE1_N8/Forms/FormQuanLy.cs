using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT09_DE1_N8.Forms
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
            this.Text = "Trang Quản Lý - Công ty Cấp Nước X";

            // Menu
            MenuStrip menu = new MenuStrip();

            ToolStripMenuItem mnNhanVien = new ToolStripMenuItem("Quản lý Nhân viên");
            ToolStripMenuItem mnKhachHang = new ToolStripMenuItem("Quản lý Khách hàng");
            ToolStripMenuItem mnChiSoNuoc = new ToolStripMenuItem("Cập nhật Chỉ số nước");
            ToolStripMenuItem mnBaoCao = new ToolStripMenuItem("Báo cáo - Hóa đơn");

            menu.Items.Add(mnNhanVien);
            menu.Items.Add(mnKhachHang);
            menu.Items.Add(mnChiSoNuoc);
            menu.Items.Add(mnBaoCao);

            this.MainMenuStrip = menu;
            this.Controls.Add(menu);
            mnNhanVien.Click += (s, e) => {
                FormNhanVien f = new FormNhanVien();
                f.ShowDialog();
            };

            mnKhachHang.Click += (s, e) => {
                FormKhachHang f = new FormKhachHang();
                f.ShowDialog();
            };

            mnChiSoNuoc.Click += (s, e) => {
                FormChiSoNuoc f = new FormChiSoNuoc();
                f.ShowDialog();
            };

            mnBaoCao.Click += (s, e) => {
                FormHoaDon f = new FormHoaDon();
                f.ShowDialog();
            };

        }

    }
}
