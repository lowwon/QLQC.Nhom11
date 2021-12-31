using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using QLQC.BLL;
using QLQC.DTO;
using System.Collections.Generic;
using System.Linq;

namespace Nhom11.QLQC.Pages
{
    public class DoiTacModel : PageModel
    {
        private KhachHangBLL bus;
        public string maKH { get; private set; }
        public string tenKH { get; private set; }
        public List<KhachHangDTO> lst;


        public DoiTacModel()
        {
            bus = new KhachHangBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
        }
        public void OnPost()
        {
            lst = bus.GetAll().ToList();
            maKH = Request.Form["maKH"];
            tenKH = Request.Form["tenKH"];
            var temp1 = new List<KhachHangDTO>();
            var temp2 = new List<KhachHangDTO>();
            if (maKH != "")
            {
                temp1 = (from s in lst
                         where s.MaKH.Trim() == maKH.Trim()
                         select s).ToList();
                lst = temp1;
            }
            if(tenKH != "")
            {
                temp2 = (from s in lst
                         where s.TenKH.Contains(tenKH.Trim())
                         select s).ToList();
                lst = temp2;
            }

        }
        public IActionResult OnPostUpdate(string KH)
        {
            var obj = JsonConvert.DeserializeObject<KhachHangDTO>(KH);
            var res = bus.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, KH = obj }) { StatusCode = 200 };
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
            if (res != null)
                return new ObjectResult(new { success = true, KH = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false, }) { StatusCode = 500 };
        }
    }
}
