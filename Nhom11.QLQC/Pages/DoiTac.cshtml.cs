using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Nhom11.QLQC.Pages
{
    public class DoiTacModel : PageModel
    {
        private KhachHangBLL bus;

        public List<KhachHangDTO> lst;
        
        public DoiTacModel()
        {
            bus = new KhachHangBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
        }
        public IActionResult OnPostUpdate(string KH)
        {
            var obj = JsonSerializer.Deserialize<KhachHangDTO>(KH);
            var res = bus.Update(obj);
            if (res)
                return new ObjectResult(new { success=true, KH = obj }){ StatusCode = 200};
            else
                return new ObjectResult(new { success = false, }) { StatusCode = 500 };
        }

        public IActionResult OnPostDelete(string KHid)
        { 
            var res = bus.Delete(KHid);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }

        public IActionResult OnPostAdd(string KH)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<KhachHangDTO>(KH);
            var res = bus.Add(obj);
            if (res!=null)
                return new ObjectResult(new { success = true, KH = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false, }) { StatusCode = 500 };
        }
    }
}
