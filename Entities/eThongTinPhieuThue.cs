using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eThongTinPhieuThue
    {  
        public String IdDia { get; set; }
        public String TenDia { get; set; }
        public String DanhMuc{ get; set; }
        public decimal PhiThue { get; set; }
        public DateTime NgayTra { get; set; }
        public decimal PhiTreHan { get; set; }

        public string IdKhachHang { get; set; }
        public DateTime NgayHetHan { get; set; }
        public bool TrangThai { get; set; }
        public int IdPhieuThue { get; set; }

        public eThongTinPhieuThue(string idDia, string tenDia, string danhMuc, decimal phiThue, decimal phiTreHan, DateTime ngayTra)
        {
            IdDia = idDia;
            TenDia = tenDia;
            DanhMuc = danhMuc;
            PhiThue = phiThue;            
            PhiTreHan = phiTreHan;
            NgayTra = ngayTra;
        }
        public eThongTinPhieuThue()
        {

        }
    }
}
