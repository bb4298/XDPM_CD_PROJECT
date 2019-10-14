using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eChiTietPhieuThue
    {
        public int IdChiTietPhieuThue { get; set; }
        public String IdDia { get; set; }
        public DateTime NgayHetHan { get; set; }
        public DateTime NgayTra { get; set; }
        public decimal PhiThue { get; set; }
        public decimal PhiTreHan { get; set; }
        public bool TrangThai { get; set; }
        public int IdPhieuThue { get; set; }


        public eChiTietPhieuThue(int idChiTietPhieuThue, String idDia, DateTime ngayHetHan, DateTime ngayTra, decimal phiThue, decimal phiTreHan, bool trangThai, int idPhieuThue)
        {
            IdChiTietPhieuThue = idChiTietPhieuThue;
            IdDia = idDia;
            NgayHetHan = ngayHetHan;
            NgayTra = ngayTra;
            PhiThue = phiThue;
            PhiTreHan = phiTreHan;
            TrangThai = trangThai;
            IdPhieuThue = idPhieuThue;
        }

        public eChiTietPhieuThue()
        {

        }


    }
}
