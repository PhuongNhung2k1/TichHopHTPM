using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QLSP.Models;
namespace QLSP.Controllers
{
    public class SanphamController : ApiController
    {
        QLSPEntities db = new QLSPEntities();
        [HttpGet]

        public IEnumerable<Sanpham> Danhsach()
        {
            IEnumerable<Sanpham> dssp = db.Sanphams.ToList();
            return dssp;
        }

        [HttpPost]
        public bool Themsp(int ma, string ten, int gia)
        {
            Sanpham sp = db.Sanphams.FirstOrDefault(x => x.MaSP == ma);
            if (sp == null)
            {
                Sanpham spnew = new Sanpham();
                spnew.MaSP = ma;
                spnew.TenSP = ten;
                spnew.DonGia = gia;
                db.Sanphams.Add(spnew);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpPut]
        public bool SuaSP(int ma, string ten, int gia)
        {
            Sanpham sp = db.Sanphams.FirstOrDefault(x => x.MaSP == ma);
            if (sp != null)
            {
                sp.MaSP = ma;
                sp.TenSP = ten;
                sp.DonGia = gia;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpDelete]
        public bool XoaSP(int ma)
        {
            Sanpham sp = db.Sanphams.FirstOrDefault(x => x.MaSP == ma);
            if (sp != null)
            {
                db.Sanphams.Remove(sp);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
