using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DAL;
using QLQC.DTO;

namespace QLQC.BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL dal;

        public KhachHangBLL()
        {
            dal = new KhachHangDAL();
        }

        public IList<KhachHangDTO> GetAll()
        {
            return dal.GetAll();
        }

        public bool Update(KhachHangDTO KH)
        {
            return dal.Update(KH);
        }

        public bool Delete(string KHid)
        {
            return dal.Delete(KHid);
        }

        public KhachHangDTO Add(KhachHangDTO kh)
        {
            return dal.Add(kh);
        }
    }
}
