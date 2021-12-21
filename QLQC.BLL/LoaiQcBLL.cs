using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DAL;
using QLQC.DTO;
namespace QLQC.BLL
{
    public class LoaiQcBLL
    {
        private LoaiQcDAL dal;
        public LoaiQcBLL()
        {
            dal = new LoaiQcDAL();  
        }
        public IList<LoaiQcDTO> GetAll()
        {
            return dal.GetAll();    
        }
    }
}
