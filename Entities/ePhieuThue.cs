using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ePhieuThue
    {
        public int IdPhieuThue { get; set; }
        public DateTime NgayTao { get; set; }
        public bool TrangThaiThanhToan { get; set; }
        public String IdKhachHang { get; set; }


        public ePhieuThue(int idPhieuThue, DateTime ngayTao, bool trangThaiThanhToan, string idKhachHang)
        {
            IdPhieuThue = idPhieuThue;
            NgayTao = ngayTao;
            TrangThaiThanhToan = trangThaiThanhToan;
            IdKhachHang = idKhachHang;
        }


        public ePhieuThue()
        {

        }
    }
}
