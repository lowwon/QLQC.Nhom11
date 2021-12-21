using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DTO;
using QLQC.DAL.Models;
namespace QLQC.DAL
{
    public class QuangCaoDAL
    {
        private qlQcaoContext db;
        public QuangCaoDAL()
        {
            db = new qlQcaoContext();
        }
        public IList<QuangCaoDTO> GetAll()
        {
            List<QuangCaoDTO> lst = new List<QuangCaoDTO>();
            try
            {
                var ds = db.QuangCaos.ToList();
                foreach (var d in ds)
                {
                    QuangCaoDTO a = new QuangCaoDTO();
                    a.MaQc = d.MaQc;
                    a.MaKh = d.MaKh;
                    a.YeuCau = d.YeuCau;
                    a.SoTien = d.SoTien;
                    a.NgBd = d.NgBd;
                    a.NgKt = d.NgKt;
                    a.MaNhom = d.MaNhom;
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
