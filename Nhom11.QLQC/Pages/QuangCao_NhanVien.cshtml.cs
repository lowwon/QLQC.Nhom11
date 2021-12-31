using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
namespace Nhom11.QLQC.Pages
{
    public class QuangCao_NhanVienModel : PageModel
    {
        private QuangCaoBLL bus;
        private NhanVienBLL bus1;
        public List<QuangCaoDTO> lst;
        public List<NhanVienDTO> lst1;
        public string gt { get; private set; }
        public QuangCao_NhanVienModel()
        {
            bus = new QuangCaoBLL();
            bus1 = new NhanVienBLL();
        }
        public void OnGet()
        {
            lst = null;
            lst1 = null;
        }
        public void OnPost()
        {
            gt = Request.Form["a"].ToString().Trim();

            if (gt == "")
            {
                lst = null;
                lst1 = null;
            }
            else
                lst = bus.GetAll().ToList();
        }
    }
}
