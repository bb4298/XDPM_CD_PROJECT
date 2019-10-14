using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eDia
    {
        public String IdDia { get; set; }
        public bool TrangThai { get; set; }
        public bool TrangThaiXoa { get; set; }
        public String IdTieuDe { get; set; }


        public eDia(String idDia, bool trangThai, bool trangThaiXoa, String idTieuDe)
        {
            IdDia = idDia;
            TrangThai = trangThai;
            TrangThaiXoa = trangThaiXoa;
            IdTieuDe = idTieuDe;

        }


        //Dùng cho dtgv đĩa bên form quản lý kho đĩa
        public eDia(String idDia, bool trangThai)
        {
            IdDia = idDia;
            TrangThai = trangThai;           

        }

        public eDia()
        {

        }

    }
}
