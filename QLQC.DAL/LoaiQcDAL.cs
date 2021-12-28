using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DTO;
using QLQC.DAL.Models;
namespace QLQC.DAL
{
    public class LoaiQcDAL
    {
        private qlQcaoContext db;
        public LoaiQcDAL()
        {
            db = new qlQcaoContext();
        }
        public IList<LoaiQcDTO> GetAll()
        {
            List<LoaiQcDTO> lst = new List<LoaiQcDTO>();
            try
            {
                var ds = db.LoaiQcs.ToList();
                foreach (var d in ds)
                {
                    LoaiQcDTO a = new LoaiQcDTO();
                    a.MaLoai = d.MaLoai;
                    a.HinhThuc = d.HinhThuc;
                    a.MoTa = d.MoTa;
                    lst.Add(a);
                }
            }
            catch (Exception ex)
            {
                lst = null;
            }
            return lst;
        }
        public bool Update(LoaiQcDTO lqc)
        {
            bool res = false;
            var c = db.LoaiQcs.FirstOrDefault(x => x.MaLoai == lqc.MaLoai);
            if (c.MoTa != lqc.MoTa)
            {
                c.MoTa = lqc.MoTa;
            }
            if (c.HinhThuc != lqc.HinhThuc)
            {
                c.HinhThuc = lqc.HinhThuc;
            }
            try
            {
                db.LoaiQcs.Update(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(string mlqc)
        {
            bool res = false;
            var c = db.LoaiQcs.FirstOrDefault(x => x.MaLoai == mlqc);
            try
            {
                db.LoaiQcs.Remove(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public LoaiQcDTO Add(LoaiQcDTO lqc)
        {
            LoaiQcDTO res = new LoaiQcDTO();

            var c = new LoaiQc();
            c.MaLoai = lqc.MaLoai;
            c.MoTa = lqc.MoTa;
            c.HinhThuc = lqc.HinhThuc;
            try
            {
                db.LoaiQcs.Add(c);
                db.SaveChanges();
                res.MaLoai = c.MaLoai;
                res.MoTa = c.MoTa;
                res.HinhThuc = c.HinhThuc;
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;
        }
    }
}

