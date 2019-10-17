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
        public int SoNgayThue { get; set; }
        public decimal PhiThuePhaiTra { get; set; }
        public DateTime NgayTra { get; set; }
        public int SoNgayTreHan { get; set; }
        public decimal PhiTreHanQuyDinh { get; set; }
        public decimal PhiTreHanPhaiTra { get; set; }
        public bool TrangThaiThanhToan { get; set; }
        public int IdPhieuThue { get; set; }

        public eChiTietPhieuThue(int idChiTietPhieuThue, string idDia, DateTime ngayHetHan, int soNgayThue, decimal phiThuePhaiTra, DateTime ngayTra, int soNgayTreHan, decimal phiTreHanQuyDinh, decimal phiTreHanPhaiTra, bool trangThaiThanhToan, int idPhieuThue)
        {
            IdChiTietPhieuThue = idChiTietPhieuThue;
            IdDia = idDia;
            NgayHetHan = ngayHetHan;
            SoNgayThue = soNgayThue;
            PhiThuePhaiTra = phiThuePhaiTra;
            NgayTra = ngayTra;
            SoNgayTreHan = soNgayTreHan;
            PhiTreHanQuyDinh = phiTreHanQuyDinh;
            PhiTreHanPhaiTra = phiTreHanPhaiTra;
            TrangThaiThanhToan = trangThaiThanhToan;
            IdPhieuThue = idPhieuThue;
        }

        public eChiTietPhieuThue()
        {

        }

     
    }
}
