using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT09_DE1_N8.Models
{
    public class DongHoNuoc
    {
        public int MaDongHo { get; set; }
        public int MaKH { get; set; }
        public string SoHieu { get; set; }
        public DateTime? NgayLapDat { get; set; }

        public string TenKH { get; set; } = "";
    }
}
