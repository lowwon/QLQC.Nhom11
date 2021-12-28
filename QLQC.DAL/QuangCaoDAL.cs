using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DTO;
using QLQC.DAL.Models;
namespace QLQC.DAL
{
    public class QuangCaoDAL
    {
        private qlQcaoContext db;
        public QuangCaoDAL()
        {
            db = new qlQcaoContext();
        }
        public IList<QuangCaoDTO> GetAll()
        {
            List<QuangCaoDTO> lst = new List<QuangCaoDTO>();
            try
            {
                var ds = db.QuangCaos.ToList();
                foreach (var d in ds)
                {
                    QuangCaoDTO a = new QuangCaoDTO();
                    a.MaQc = d.MaQc;
                    a.MaKh = d.MaKh;
                    a.YeuCau = d.YeuCau;
                    a.SoTien = d.SoTien;
                    a.NgBd = d.NgBd;
                    a.NgKt = d.NgKt;
                    a.MaNhom = d.MaNhom;
                    lst.Add(a);
                }
            }
            catch (Exception ex)
            {
                lst = null;
            }
            return lst;
        }
        public bool Update(QuangCaoDTO qc)
        {
            bool res = false;
            var c = db.QuangCaos.FirstOrDefault(x => x.MaQc == qc.MaQc);    
            if(c.NgBd != qc.NgBd)
            {
                c.NgBd = qc.NgBd;
            }
            if(c.NgKt != qc.NgKt)
            {
                c.NgKt = qc.NgKt;
            }
            if (c.MaKh != qc.MaKh)
            {
                c.MaKh = qc.MaKh;
            }
            if (c.MaNhom != qc.MaNhom)
            {
                c.MaNhom = qc.MaNhom;
            }
            if (c.YeuCau != qc.YeuCau)
            {
                c.YeuCau = qc.YeuCau;
            }
            if (c.SoTien != qc.SoTien)
            {
                c.SoTien = qc.SoTien;
            }
            try
            {
                db.QuangCaos.Update(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(string mqc)
        {
            bool res = false;
            var c = db.QuangCaos.FirstOrDefault(x => x.MaQc.Trim() == mqc.Trim());           
            try
            {
                db.QuangCaos.Remove(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public QuangCaoDTO Add(QuangCaoDTO qc)
        {
            QuangCaoDTO res = new QuangCaoDTO();
            var c = new QuangCao();
            c.MaQc = qc.MaQc;
            c.NgBd = qc.NgBd;

            c.NgKt = qc.NgKt;

            c.MaKh = qc.MaKh;

            c.MaNhom = qc.MaNhom;

            c.YeuCau = qc.YeuCau;

            c.SoTien = qc.SoTien;
            try
            {
                db.QuangCaos.Add(c);
                db.SaveChanges();
                res.MaQc = c.MaQc;
                res.NgBd = c.NgBd;

                res.NgKt = c.NgKt;

                res.MaKh = c.MaKh;

                res.MaNhom = c.MaNhom;

                res.YeuCau = c.YeuCau;

                res.SoTien = c.SoTien;
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;
        }

    }
}
