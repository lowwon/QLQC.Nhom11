using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;
using System.Collections.Generic;
using System.Linq;

namespace Nhom11.QLQC.Pages
{
    public class QuangCaoModel : PageModel
    {
        private QuangCaoBLL bus;
        private QC_LQCBLL bus1;
        public List<QuangCaoDTO> lst;
        public List<QC_LQCDTO> lst1;
        public QuangCaoModel()
        {
            bus = new QuangCaoBLL();
            bus1 = new QC_LQCBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
        }
    }
}
