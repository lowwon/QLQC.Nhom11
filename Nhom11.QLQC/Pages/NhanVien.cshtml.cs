using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Nhom11.QLQC.Pages
{
    public class NhanVienModel : PageModel
    {
        private NhanVienBLL bus;
        public List<NhanVienDTO> lst;
        public NhanVienModel()
        {
            bus = new NhanVienBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
        }
        public IActionResult OnGetTest()
        {
            return new ObjectResult(new { Id = 123, Name = "Hero" }) { StatusCode = 200 };
        }
        public IActionResult OnPostUpdate(string nv)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<NhanVienDTO>(nv);
            var res = bus.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, nv = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(string idnv)
        {
            var cNv = idnv;
            var res = bus.Delete(cNv);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(string nv)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<NhanVienDTO>(nv);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, nv = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}

