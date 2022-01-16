using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DAL;
using QLQC.DTO;

namespace QLQC.BLL
{
    public class HopDongBLL
    {
        private HopDongDAL dal;

        public HopDongBLL()
        {
            dal = new HopDongDAL();
        }

        public IList<HopDongDTO> GetAll()
        {
            return dal.GetAll();
        }

        public bool Update(HopDongDTO hd)
        {
            return dal.Update(hd);
        }
        public bool Delete(string mhd)
        {
            return dal.Delete(mhd);
        }
        public HopDongDTO Add(HopDongDTO hd)
        {
            return dal.Add(hd);
        }
        public List<HopDongStatic> getHopDong()
        {
            return dal.getHopDong();
        }
    }
}
