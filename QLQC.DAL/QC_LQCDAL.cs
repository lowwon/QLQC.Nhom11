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
    }
}
