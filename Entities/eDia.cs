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
        public bool TrangThaiThue { get; set; }
        public bool TrangThaiXoa { get; set; }
        public String IdTieuDe { get; set; }


        public eDia(String idDia, bool trangThaiThue, bool trangThaiXoa, String idTieuDe)
        {
            IdDia = idDia;
            TrangThaiThue = trangThaiThue;
            TrangThaiXoa = trangThaiXoa;
            IdTieuDe = idTieuDe;

        }


        //Dùng cho dtgv đĩa bên form quản lý kho đĩa
        public eDia(String idDia, bool trangThaiThue)
        {
            IdDia = idDia;
            TrangThaiThue = trangThaiThue;           

        }

        public eDia()
        {

        }

    }
}
