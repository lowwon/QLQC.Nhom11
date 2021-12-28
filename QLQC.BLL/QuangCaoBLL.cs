using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DAL;
using QLQC.DTO;
namespace QLQC.BLL
{
    public class QuangCaoBLL
    {
        private QuangCaoDAL dal;
        public QuangCaoBLL()
        {
            dal = new QuangCaoDAL();
        }
        public IList<QuangCaoDTO> GetAll()
        {
            return dal.GetAll();
        }
        public bool Update(QuangCaoDTO qc)
        {
            return dal.Update(qc);
        }
        public bool Delete(string mqc)
        {
            return dal.Delete(mqc);
        }
        public QuangCaoDTO Add(QuangCaoDTO qc)
        {
            return dal.Add(qc);
        }
    }
}
