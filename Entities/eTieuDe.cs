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
        public string TenDanhMuc{ get; set; }

        public eTieuDe(string idTieuDe, string tenTieuDe, decimal phiThue, int soLuongDia, bool trangThaiXoa, int idDanhMuc)
        {
            IdTieuDe = idTieuDe;
            TenTieuDe = tenTieuDe;
            PhiThue = phiThue;
            SoLuongDia = soLuongDia;
            TrangThaiXoa = trangThaiXoa;
            IdDanhMuc = idDanhMuc;
           
        }

        //Dùng để hiển thị dtgv form quản lý danh mục
        public eTieuDe(string idTieuDe, string tenTieuDe, int soLuongDia, string tenDanhMuc,decimal phiThue)
        {
            IdTieuDe = idTieuDe;
            TenTieuDe = tenTieuDe;
            SoLuongDia = soLuongDia;
            TenDanhMuc = tenDanhMuc;
            PhiThue = phiThue;
        }
        //Dùng để hiển thị dtgv form quản lý kho đĩa
        public eTieuDe(string idTieuDe, string tenTieuDe, string tenDanhMuc, int soLuongDia)
        {
            IdTieuDe = idTieuDe;
            TenTieuDe = tenTieuDe;
            TenDanhMuc = tenDanhMuc;
            SoLuongDia = soLuongDia;
        }

        public eTieuDe(string tenTieuDe)
        {    
            TenTieuDe = tenTieuDe;
        }

        public eTieuDe()
        {
                
        }
      
   
    }
}
