using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eDanhMuc
    {
        public int IdDanhMuc { get; set; }
        public String TenDanhMuc { get; set; }
        public bool TrangThaiXoa { get; set; }


        public eDanhMuc(int idDanhMuc, string tenDanhMuc, bool trangThaiXoa)
        {
            IdDanhMuc = idDanhMuc;
            TenDanhMuc = tenDanhMuc;
            TrangThaiXoa = trangThaiXoa;
        }

        public eDanhMuc(string tenDanhMuc)
        {
            TenDanhMuc = tenDanhMuc;
        }
        public eDanhMuc()
        {

        }

    }
}
