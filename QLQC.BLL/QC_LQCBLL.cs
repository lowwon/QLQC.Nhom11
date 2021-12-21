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
    }
}
