using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class DanhMucBLL
    {
        QLCDDataContext db;
        public DanhMucBLL()
        {
            db = new QLCDDataContext();
        }
        public int layIdDanhMuc(string tenDanhMuc)
        {
            int maTD = (from a in db.DanhMucs
                           where a.TenDanhMuc == tenDanhMuc
                           select a.IdDanhMuc).FirstOrDefault();
            return maTD;
        }

        public int LayIdDanhMucCaoNhat()
        {
            string td = (from a in db.DanhMucs
                         orderby a.IdDanhMuc descending
                         select a.IdDanhMuc
                            ).Take(1).First().ToString();

            return Convert.ToInt32(td);
        }

        public bool ThemDanhMuc(DanhMuc dm)
        {
            if (!db.DanhMucs.Contains(dm))
            {
                db.DanhMucs.InsertOnSubmit(dm);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool SuaDanhMuc(DanhMuc edm)
        {
            DanhMuc td = new DanhMuc();
            td = db.DanhMucs.Where(a => a.IdDanhMuc== edm.IdDanhMuc).SingleOrDefault();
            if (td != null)
            {
                td.TenDanhMuc = edm.TenDanhMuc;

                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool XoaDanhMuc(TieuDe etd)
        {
            TieuDe td = new TieuDe();
            td = db.TieuDes.Where(a => a.IdTieuDe== etd.IdTieuDe).SingleOrDefault();
            if (td != null)
            {
                td.TrangThaiXoa = etd.TrangThaiXoa;

                db.SubmitChanges();
                return true;
            }
            return false;
        }

        //Kiểm tra khi thêm danh mục, chống trùng danh mục
        public bool kiemTraTrungDanhMuc(string tenDanhMuc)
        {
          
            List<DanhMuc> td = new List<DanhMuc>();
            td = db.DanhMucs.Where(a => a.TrangThaiXoa == false).ToList();
            foreach (var item in td)
            {
                if(item.TenDanhMuc == tenDanhMuc)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
