using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;
using System.Collections.Generic;
using System.Linq;
namespace Nhom11.QLQC.Pages
{
    public class QuangCaoVaLoaiQuangCaoModel : PageModel
    {
        private QC_LQCBLL bus;
        private LoaiQcBLL bus1;
        private QuangCaoBLL bus2;
        public List<QC_LQCDTO> lst;
        public List<QuangCaoDTO> lst2;
        public List<LoaiQcDTO> lst1;
        public QuangCaoVaLoaiQuangCaoModel()
        {
            bus = new QC_LQCBLL();
            bus1 = new LoaiQcBLL();
            bus2 = new QuangCaoBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
        }

    }
}
