using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DAL;
using QLQC.DTO;

namespace QLQC.BLL
{
    public class NhomNhanVienBLL
    {
        private NhomNhanVienDAL dal;
        public  NhomNhanVienBLL()
        {
            dal = new NhomNhanVienDAL();
        }
        public IList<NhomNhanVienDTO> GetAll()
        {
            return dal.GetAll();
        }
        public bool Update(NhomNhanVienDTO nnv)
        {
            return dal.Update(nnv);
        }
        public bool Delete(string mn)
        {
            return dal.Delete(mn);
        }
        public NhomNhanVienDTO Add(NhomNhanVienDTO nnv)
        {
            return dal.Add(nnv);
        }
    }
}
