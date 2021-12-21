using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DTO;
using QLQC.DAL.Models;
namespace QLQC.DAL
{
    public class LoaiQcDAL
    {
        private qlQcaoContext db;
        public LoaiQcDAL()
        {
            db = new qlQcaoContext();
        }
        public IList<LoaiQcDTO> GetAll()
        {
            List<LoaiQcDTO> lst = new List<LoaiQcDTO>();
            try
            {
                var ds = db.LoaiQcs.ToList();
                foreach (var d in ds)
                {
                    LoaiQcDTO a = new LoaiQcDTO();
                    a.MaLoai = d.MaLoai;
                    a.HinhThuc = d.HinhThuc;
                    a.MoTa = d.MoTa;
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
