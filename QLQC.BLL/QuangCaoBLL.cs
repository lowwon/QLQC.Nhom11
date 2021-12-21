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
    }
}
