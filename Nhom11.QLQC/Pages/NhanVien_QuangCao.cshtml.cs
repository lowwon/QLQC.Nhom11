using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;

namespace Nhom11.QLQC.Pages
{
    public class NhanVien_QuangCaoModel : PageModel
    {
        private QuangCaoBLL bus1;
        private NhanVienBLL bus2;
        public List<QuangCaoDTO> lst1;
        public List<NhanVienDTO> lst2;
        public string gt { get; set; }
        public string value { get; set; }

        public NhanVien_QuangCaoModel()
        {
            bus1 = new QuangCaoBLL();
            bus2 = new NhanVienBLL();
        }
        public void OnGet()
        {
            lst1 = null;
            lst2 = null;
        }

        public void OnPost()
        {

            lst1 = bus1.GetAll().ToList();
            lst2 = bus2.GetAll().ToList();
            value = Request.Form["timkiem"];
            var temp = new List<NhanVienDTO>();
            if (value != "")
            {
                temp = (from qc in lst1
                        join nv in lst2 on qc.MaNhom equals nv.MaNhom
                        where qc.MaQc.Trim()==(value.Trim())
                        select nv
                        ).ToList();

                
            }
            lst2 = temp;
        }
    }
}
