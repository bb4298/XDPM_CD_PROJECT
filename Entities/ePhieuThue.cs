using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ePhieuThue
    {
        public int IdPhieuMuon { get; set; }
        public DateTime NgayTao { get; set; }
        public bool TrangThai { get; set; }
        public String IdKhachHang { get; set; }


        public ePhieuThue(int idPhieuMuon, DateTime ngayTao, bool trangThai, string idKhachHang)
        {
            IdPhieuMuon = idPhieuMuon;
            NgayTao = ngayTao;
            TrangThai = trangThai;
            IdKhachHang = idKhachHang;
        }


        public ePhieuThue()
        {

        }
    }
}
