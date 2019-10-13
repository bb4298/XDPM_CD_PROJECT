using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eTieuDe
    {
        public String IdTieuDe { get; set; }
        public String TenTieuDe { get; set; }
        public Decimal PhiThue { get; set; }
        public int SoLuongDia { get; set; }
        public bool TrangThaiXoa { get; set; }
        public int IdDanhMuc { get; set; }

        public eTieuDe(string idTieuDe, string tenTieuDe, decimal phiThue, int soLuongDia, bool trangThaiXoa, int idDanhMuc)
        {
            IdTieuDe = idTieuDe;
            TenTieuDe = tenTieuDe;
            PhiThue = phiThue;
            SoLuongDia = soLuongDia;
            TrangThaiXoa = trangThaiXoa;
            IdDanhMuc = idDanhMuc;
        }


        public eTieuDe()
        {
                
        }
    }
}
