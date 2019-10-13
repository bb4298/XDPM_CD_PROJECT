using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class DiaBLL
    {
        QLCDDataContext db;
        public DiaBLL()
        {
            db = new QLCDDataContext();
        }

        public string LayMaDiaCaoNhat()
        {
            string td = (from a in db.Dias
                         orderby a.IdDia descending
                         select a.IdDia
                            ).Take(1).First().ToString();
            return td;
        }
       
        public string LayTenNguoiThue(string idDia)
        {
        
            var tenNguoiThue = (from a in db.KhachHangs
                                join b in db.PhieuThues on a.IdKhachHang equals b.IdKhachHang
                                join c in db.ChiTietPhieuThues on b.IdPhieuThue equals c.IdPhieuThue
                                join d in db.Dias on c.IdDia equals d.IdDia
                                where c.IdDia == idDia && c.TrangThai == true
                                select new
                                {
                                    a.HoTen
                                }).FirstOrDefault();
            if(tenNguoiThue != null)
            {
                return tenNguoiThue.ToString();
            }
            return "Chưa được thuê";
        }
        //public string layIdDiaBangTenDia(string tenDia)
        //{
        //    string id = (from a in db.Dias
        //              join b in db.TieuDes on a.IdTieuDe equals b.IdTieuDe
        //              select  a.IdDia
        //              ).Take(1).First().ToString();
        //    return id;
        //}
        public bool kiemTraTrungDia(string idDia)
        {
            
            List<Dia> td = new List<Dia>();
            td = db.Dias.Where(a => a.TrangThaiXoa == false).ToList();
            foreach (var item in td)
            {
                if (item.IdDia == idDia)
                {
                    return false;
                }
            }
            return true;
        }
        public bool ThemDia(Dia d)
        {
            if (!db.Dias.Contains(d))
            {
                db.Dias.InsertOnSubmit(d);
                db.SubmitChanges();
                return true;
            }
            return false;
        }


        public bool XoaDia(Dia ed)
        {
            Dia d = new Dia();
            d = db.Dias.Where(a => a.IdDia == ed.IdDia).SingleOrDefault();
            if (d != null)
            {
                d.TrangThaiXoa = ed.TrangThaiXoa;

                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool kiemTraDiaTaiCuaHang(string idDia)
        {
            foreach (Dia item in db.Dias)
            { 
                if (item.IdDia == idDia && item.TrangThai == true)
                {
                    return true;
                    
                }   
            }
            return false;
        }
       
    }
}
