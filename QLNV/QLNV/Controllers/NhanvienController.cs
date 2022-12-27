using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QLNV.Models;
namespace QLNV.Controllers
{
    public class NhanvienController : ApiController
    {
        QLNVEntities db = new QLNVEntities();
        [HttpGet]
        public IEnumerable<Nhanvien> Danhsach()
        {
            IEnumerable<Nhanvien> dsnv = db.Nhanviens.ToList();
            return dsnv;
        }
        [HttpGet]
        public Nhanvien LayNVTheoMa(int ma)
        {
            Nhanvien nv = db.Nhanviens.FirstOrDefault(x => x.MaNV == ma);
            return nv;

        }
        //lay ds nhan vien theo hsluong
        public IEnumerable<Nhanvien> LaynvTheoHSL(int hsl)
        {
            IEnumerable<Nhanvien> query = db.Nhanviens.Where(x => x.HSLuong > hsl);
            return query;
        }

        // them nhan vien
        [HttpPost]

        public bool ThemV(int ma, string ten, int hsl)
        {
            Nhanvien nv = db.Nhanviens.FirstOrDefault(x => x.MaNV == ma);
            if (nv == null)
            {
                Nhanvien nvnew = new Nhanvien();
                nvnew.MaNV = ma;
                nvnew.TenNV = ten;
                nvnew.HSLuong = hsl;
                db.Nhanviens.Add(nvnew);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        // them nhan vien
        [HttpPut]

        public bool CapNhat(int ma, string ten, int hsl)
        {
            Nhanvien nv = db.Nhanviens.FirstOrDefault(x => x.MaNV == ma);
            if (nv != null)
            {
                nv.MaNV = ma;
                nv.TenNV = ten;
                nv.HSLuong = hsl;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpDelete]
        public bool XoaNV(int ma)
        {
            Nhanvien nv = db.Nhanviens.FirstOrDefault(x => x.MaNV == ma);
            if (nv != null)
            {
                db.Nhanviens.Remove(nv);
                db.SaveChanges();
                return true;
            }

            return false;
        }


    }
}
