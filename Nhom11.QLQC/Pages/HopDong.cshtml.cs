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
    public class HopDongModel : PageModel
    {
        private HopDongBLL bus;
        public List<HopDongDTO> lst;
        public HopDongModel()
        {
            bus = new HopDongBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
        }
    }
}
