using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class ChiTietPhieuThueBLL
    {
        QLCDDataContext db;
        public ChiTietPhieuThueBLL()
        {
            db = new QLCDDataContext();
        }

        public int LayIdChiTietPhieuThueLonNhat()
        {
            int idctpt = (from a in db.ChiTietPhieuThues
                        orderby a.IdChiTietPhieuThue descending
                        select a.IdChiTietPhieuThue
                            ).Take(1).First();
            return Convert.ToInt32(idctpt);
        }

        public eThongTinPhieuThue LayThongTinPhieuThue(string idDia,string idKhachHang)
        {
            eThongTinPhieuThue ettpt = new eThongTinPhieuThue();
            var ttpt = (from a in db.KhachHangs
                     join b in db.PhieuThues on a.IdKhachHang equals b.IdKhachHang
                     join c in db.ChiTietPhieuThues on b.IdPhieuThue equals c.IdPhieuThue
                     where a.IdKhachHang == idKhachHang && c.IdDia == idDia && c.TrangThaiThanhToan == false && c.TrangThaiTraDia == false
                     select new
                     {
                         c.IdChiTietPhieuThue,
                         b.NgayTao,
                         c.NgayTraDia,
                         c.SoNgayThue,
                         c.SoNgayTreHan,
                         c.PhiTreHanPhaiTra,
                         
                     }).Single();
            ettpt.IdChiTietPhieuThue = Convert.ToInt32(ttpt.IdChiTietPhieuThue);
            ettpt.NgayThue = Convert.ToDateTime( ttpt.NgayTao);
            ettpt.NgayTraDia = Convert.ToDateTime( ttpt.NgayTraDia);
            ettpt.SoNgayThue =Convert.ToInt32( ttpt.SoNgayThue);
            ettpt.SoNgayTreHan = Convert.ToInt32(ttpt.SoNgayTreHan);
            ettpt.PhiTreHan = Convert.ToDecimal(ttpt.PhiTreHanPhaiTra);
            return ettpt;
        }

        public bool ThemChiTietPhieuThue(List<eThongTinPhieuThue> listTtPT, int idPhieuThue)
        {
            foreach (eThongTinPhieuThue item in listTtPT)
            {
                ChiTietPhieuThue ctpt = new ChiTietPhieuThue();
                ctpt.IdChiTietPhieuThue = LayIdChiTietPhieuThueLonNhat()+1;
                ctpt.IdDia = item.IdDia;
                ctpt.NgayTraDia = item.NgayTraDia;
                ctpt.SoNgayThue = item.SoNgayThue;
                ctpt.PhiThuePhaiTra = item.PhiThue;
                ctpt.NgayTraDiaThucTe = null;
                ctpt.SoNgayTreHan = 0;
                ctpt.PhiTreHanQuyDinh = item.PhiTreHan;
                ctpt.PhiTreHanPhaiTra = 0;
                ctpt.TrangThaiTraDia = false;
                ctpt.TrangThaiThanhToan = false;
                ctpt.IdPhieuThue = idPhieuThue;
              
                db.ChiTietPhieuThues.InsertOnSubmit(ctpt);
                db.SubmitChanges();

                Dia dia = new Dia();               
                dia = db.Dias.Where(a => a.IdDia== item.IdDia).SingleOrDefault();                      
                dia.TrangThaiThue = true;
                db.SubmitChanges();
                 

            }
            return true;

        }

        public bool XacNhanTraDia(eChiTietPhieuThue ectpt)
        {
            ChiTietPhieuThue ctpt = new ChiTietPhieuThue();
            ctpt = db.ChiTietPhieuThues.Where(a => a.IdChiTietPhieuThue== ectpt.IdChiTietPhieuThue).SingleOrDefault();
            if (ctpt != null)
            {
                ctpt.NgayTraDiaThucTe = ectpt.NgayTraDiaThucTe;
                ctpt.TrangThaiTraDia = ectpt.TrangThaiTraDia;
                ctpt.TrangThaiThanhToan = ectpt.TrangThaiThanhToan;

                db.SubmitChanges();
                return true;
            }
            return false;
        }
      
        public bool CapNhatKhoanNoCuaKhachHang(string idKhachHang)
        {
            int count = 0;
            var khs = (from a in db.KhachHangs
                                   join b in db.PhieuThues on a.IdKhachHang equals b.IdKhachHang
                                   join c in db.ChiTietPhieuThues on b.IdPhieuThue equals c.IdPhieuThue
                                   where a.IdKhachHang == idKhachHang && c.TrangThaiThanhToan == false && c.TrangThaiTraDia == false
                       select new {
                                       b.NgayTao,
                                       c.NgayTraDia,
                                       c.NgayTraDiaThucTe,
                                       c.SoNgayTreHan,
                                       c.PhiTreHanQuyDinh,
                                       c.PhiTreHanPhaiTra,
                                       c.IdChiTietPhieuThue
                                   }).ToList();

            foreach (var item in khs)
            {
                ChiTietPhieuThue ctpt = new ChiTietPhieuThue();
                ctpt = db.ChiTietPhieuThues.Where(x => x.IdChiTietPhieuThue == item.IdChiTietPhieuThue).SingleOrDefault();
                int soNgayTreHan;
              
                //DateTime a = new DateTime(2019, 10, 15);//some datetime
                DateTime ngayHienTai = DateTime.Now;

                if(DateTime.Compare(ngayHienTai, Convert.ToDateTime(ctpt.NgayTraDia)) > 0)
                {
                    TimeSpan ts = ngayHienTai - Convert.ToDateTime(ctpt.NgayTraDia);
                    soNgayTreHan = Math.Abs(ts.Days);
                    if (soNgayTreHan > 0)
                    {
                        decimal phiTre = Convert.ToDecimal(item.PhiTreHanQuyDinh) * soNgayTreHan;
                        ctpt.SoNgayTreHan = soNgayTreHan;
                        ctpt.PhiTreHanPhaiTra = phiTre;
                        db.SubmitChanges();
                    }
                    count = count + 1;
                }                  

            }
            if(count > 0)
            {
                return true;
            }
            return false;

        }
      
        public decimal LayKhoanNoCuaKhachHang(string idKhachHang)
        {
            
            decimal phiPhaiTra = (from a in db.KhachHangs
                       join b in db.PhieuThues on a.IdKhachHang equals b.IdKhachHang
                       join c in db.ChiTietPhieuThues on b.IdPhieuThue equals c.IdPhieuThue
                       where a.IdKhachHang == idKhachHang && c.TrangThaiThanhToan == false
                       select (decimal) c.PhiTreHanPhaiTra).Sum();
            return phiPhaiTra;
        }

    }   
}
