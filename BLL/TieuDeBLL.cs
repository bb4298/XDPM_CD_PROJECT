using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class TieuDeBLL
    {
        QLCDDataContext db;
        public TieuDeBLL()
        {
            db = new QLCDDataContext();
        }

        public string LayMaTieuDeCaoNhat()
        {
            string td = (from a in db.TieuDes
                         orderby a.IdTieuDe descending
                         select a.IdTieuDe
                            ).Take(1).First().ToString();
            return td;
        }
   
        public bool ThemTieuDe(TieuDe td)
        {
            if (!db.TieuDes.Contains(td))
            {
                db.TieuDes.InsertOnSubmit(td);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool SuaTieuDe(TieuDe etd)
        {
            TieuDe td = new TieuDe();
            td = db.TieuDes.Where(a => a.IdTieuDe== etd.IdTieuDe).SingleOrDefault();
            if (td != null)
            {
                td.TenTieuDe = etd.TenTieuDe;
                td.PhiThue = etd.PhiThue;
                td.IdDanhMuc= etd.IdDanhMuc;

                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool XoaTieuDe(TieuDe etd)
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

        public bool kiemTraTrungTieuDe(string tenTieuDe)
        {
            //var td = (from a in db.TieuDes
            //             where a.TrangThaiXoa == false
            //             select a.TenTieuDe);
            List<TieuDe> td = new List<TieuDe>();
            td = db.TieuDes.Where(a => a.TrangThaiXoa == false).ToList();
            foreach (var item in td)
            {
                if(item.TenTieuDe == tenTieuDe)
                {
                    return false;
                }
            }
            return true;
        }
        public string layIdTieuDeBangTenTieuDe(string tenTieuDe)
        {
            string id = (from a in db.TieuDes
                         where a.TenTieuDe == tenTieuDe
                         select a.IdTieuDe
                      ).FirstOrDefault();
            return id;
        }
        public string layTenTieuDeBangIdTieuDe(string idTieuDe)
        {
            string ten = (from a in db.TieuDes
                         where a.IdTieuDe == idTieuDe
                         select a.TenTieuDe
                      ).FirstOrDefault();
            return ten;
        }
    }
}
