using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class KhachHangBLL
    {
        QLCDDataContext db;
        public KhachHangBLL()
        {
            db = new QLCDDataContext();
        }
        #region Code mẫu ko xài
        //Lấy danh sách khách hàng
        public List<eKhachHang> LayDanhSachKhachHang()
        {
            var dskh = (from a in db.KhachHangs
                        select a
                        );
            List<eKhachHang> ekhs = new List<eKhachHang>();

            ekhs = DataToEntity(dskh.ToList());
            return ekhs;    
        }

        //Chuyển List Data thành Entity.
        public List<eKhachHang> DataToEntity(List<KhachHang> khs)
        {
            List<eKhachHang> ekhs = new List<eKhachHang>();

            foreach (eKhachHang ekh in ekhs)
            {
                foreach(KhachHang kh in khs)
                {
                    ekh.IdKhachHang = kh.IdKhachHang;
                    ekh.HoTen = kh.HoTen;
                    ekh.DiaChi = kh.DiaChi;
                    ekh.SoDienThoai = kh.SoDienThoai;
                }
            }
            return ekhs;
        }
        #endregion

        public string LayMaKhachHangCaoNhat()
        {
            string kh = (from a in db.KhachHangs
                            orderby a.IdKhachHang descending
                            select a.IdKhachHang
                            ).Take(1).First().ToString();
            return kh;
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            if (!db.KhachHangs.Contains(kh))
            {
                db.KhachHangs.InsertOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool SuaKhachHang(KhachHang ekh)
        {
            KhachHang kh = new KhachHang();
            kh = db.KhachHangs.Where(a => a.IdKhachHang == ekh.IdKhachHang).SingleOrDefault();
            if (kh != null)
            {            
                kh.HoTen = ekh.HoTen;
                kh.DiaChi = ekh.DiaChi;         
                kh.SoDienThoai = ekh.SoDienThoai;
             
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool XoaKhachHang(KhachHang ekh)
        {
            KhachHang kh = new KhachHang();
            kh = db.KhachHangs.Where(a => a.IdKhachHang == ekh.IdKhachHang).SingleOrDefault();
            if (kh != null)
            {
                kh.TrangThaiXoa = ekh.TrangThaiXoa;

                db.SubmitChanges();
                return true;
            }
            return false;
        }


    }
}
