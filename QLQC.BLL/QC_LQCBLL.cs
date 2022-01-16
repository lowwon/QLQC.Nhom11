using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DAL;
using QLQC.DTO;
namespace QLQC.BLL
{
    public class QC_LQCBLL
    {
        private QC_LQCDAL dal;
        public QC_LQCBLL()
        {
            dal = new QC_LQCDAL();
        }
        public IList<QC_LQCDTO> GetAll()
        {
            return dal.GetAll();
        }
        public bool Update(QC_LQCDTO qc_lqct, QC_LQCDTO qc_lqc)
        {
            return dal.Update(qc_lqct, qc_lqc);
        }
        public bool Delete(string mqc, string mlqc)
        {
            return dal.Delete(mqc, mlqc);
        }
        public QC_LQCDTO Add(QC_LQCDTO qc)
        {
            return dal.Add(qc);
        }
        public object GetQuangCaoByPage(int page, int size)
        {
            return dal.GetQuangCaoByPage(page, size);
        }
        public List<QC_LQCDTOStatic> getQC_lqc()
        {
            return dal.getQC_lqc();
        }
    }
}
