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
        public string GT { get; private set; }
        public List<KhachHangDTO> lst;
        public List<KhachHangDTO> lst1;
        public int TotalPage;

        public DoiTacModel()
        {
            bus = new KhachHangBLL();
        }
        public void OnGet()
        {
            int size = 5;
            lst = bus.GetAll().Take(size).ToList();
            var totalRecord = bus.GetAll().Count();
            TotalPage = (totalRecord % size) == 0 ? (int)(totalRecord / size) : (int)((totalRecord / size) + 1);

        }

        public IActionResult OnPostList(string filter)
        {
            var obj = JsonConvert.DeserializeObject<Filter>(filter);
            var Data = bus.GetKHbyPage(obj.Page, obj.Size);
            return new ObjectResult(new { success = true, data = Data }) { StatusCode = 200 };
        }

        public void OnPost()
        {
            lst = bus.GetAll().ToList();
            maKH = Request.Form["maKH"];
            tenKH = Request.Form["tenKH"];
            GT = Request.Form["GT"];
            var temp1 = new List<KhachHangDTO>();

            if (maKH != "")
            {
                temp1 = (from s in lst
                         where s.MaKH.Trim() == maKH.Trim()
                         select s).ToList();
                lst = temp1;
            }
            else if (tenKH != "")
            {
                temp1 = (from s in lst
                         where s.TenKH.Contains(tenKH.Trim())
                         select s).ToList();
                lst = temp1;
            }

            else if (GT != "")
            {
                temp1 = (from s in lst
                         where s.GT.Trim() == GT.Trim()
                         select s).ToList();
                lst = temp1;
            }
            else
            {
                int size = 5;
                lst = bus.GetAll().Take(size).ToList();
                var totalRecord = bus.GetAll().Count();
                TotalPage = (totalRecord % size) == 0 ? (int)(totalRecord / size) : (int)((totalRecord / size) + 1);

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
