using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DTO;
using QLQC.DAL.Models;
namespace QLQC.DAL
{
    public class QC_LQCDAL
    {
        private qlQcaoContext db;
        public QC_LQCDAL()
        {
            db = new qlQcaoContext();
        }
        public IList<QC_LQCDTO> GetAll()
        {
            List<QC_LQCDTO> lst = new List<QC_LQCDTO>();
            try
            {
                var ds = db.QcLqcs.ToList();
                foreach (var d in ds)
                {
                    QC_LQCDTO a = new QC_LQCDTO();
                    a.MaQc = d.MaQc;
                    a.MaLoai = d.MaLoai;
                    lst.Add(a);
                }
            }
            catch (Exception ex)
            {
                lst = null;
            }
            return lst;
        }
        public bool Update(QC_LQCDTO qc_lqct, QC_LQCDTO qc_lqc)
        {
            bool res = false;
            var c = db.QcLqcs.Where(x => (x.MaLoai == qc_lqct.MaLoai && x.MaQc == qc_lqct.MaQc)).FirstOrDefault();
            try
            {
                db.QcLqcs.Remove(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            var e = new QcLqc();
            e.MaLoai = qc_lqc.MaLoai;
            e.MaQc = qc_lqc.MaQc;
            try
            {
                db.QcLqcs.Add(e);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(string mqc, string mlqc)
        {
            bool res = false;
            //var c = from s in db.QcLqcs
            //        where s.MaQc == mqc && s.MaLoai == mlqc
            //        select s;
            var c = db.QcLqcs.Where(x => (x.MaLoai == mlqc && x.MaQc == mqc)).FirstOrDefault();

            try
            {
                db.QcLqcs.Remove(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public QC_LQCDTO Add(QC_LQCDTO lqc)
        {
            QC_LQCDTO res = new QC_LQCDTO();

            var c = new QcLqc();
            c.MaLoai = lqc.MaLoai;
            c.MaQc = lqc.MaQc;
            try
            {
                db.QcLqcs.Add(c);
                db.SaveChanges();
                res.MaLoai = c.MaLoai;
                res.MaQc = c.MaQc;
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;
        }
    }
}
