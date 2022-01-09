using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Nhom11.QLQC.Pages
{
    public class NhomNhanVienModel : PageModel
    {
        private NhomNhanVienBLL bus;
        public List<NhomNhanVienDTO> lst;
        public NhomNhanVienModel()
        {
            bus = new NhomNhanVienBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
        }
        public IActionResult OnGetTest()
        {
            return new ObjectResult(new { Id = 123, Name = "Hero" }) { StatusCode = 200 };
        }
        public IActionResult OnPostUpdate(string nnv)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<NhomNhanVienDTO>(nnv);
            var res = bus.Update(obj);
            if (res)
            {
                return new ObjectResult(new { success = true, qc = obj }) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
            }
        }
        public IActionResult OnPostDelete(string idnnv)
        {
            var cNnv = idnnv;
            var res = bus.Delete(cNnv);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(string nnv)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<NhomNhanVienDTO>(nnv);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, nnv = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}

