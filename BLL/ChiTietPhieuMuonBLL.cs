using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class ChiTietPhieuMuonBLL
    {
        QLCDDataContext db;
        public ChiTietPhieuMuonBLL()
        {
            db = new QLCDDataContext();
        }
    }
}
