using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DAL;
using QLQC.DTO;

namespace QLQC.BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL dal;
        public NhanVienBLL()
        {
            dal = new NhanVienDAL();
        }
        public IList<NhanVienDTO> GetAll()
        {
            return dal.GetAll();
        }
        public bool Update(NhanVienDTO nv)
        {
            return dal.Update(nv);
        }
        public bool Delete(string nv)
        {
            return dal.Delete(nv);
        }
        public NhanVienDTO Add(NhanVienDTO nv)
        {
            return dal.Add(nv);
        }

        public object GetNhanVienByPage(int page, int size)
        {
            return dal.GetNhanVienByPage(page, size);
        }
        public List<NhanVienStatic1> getNhanVien1()
        {
            return dal.getNhanVien1();
        }
        public List<NhanVienStatic2> getNhanVien2()
        {
            return dal.getNhanVien2();

        }
    }
}
