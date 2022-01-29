using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Nhom11.QLQC.Pages
{
    public class NhomNhanVienModel : PageModel
    {
        private NhomNhanVienBLL bus;
        public List<NhomNhanVienDTO> lst;
        //public List<NhomNhanVienDTO> lst1;
        public List<NhomNhanVienStatic> lststatic;
        public int TotalPage;
        public string mn { get; set; }
        public string tn { get; set; }
        public string mnt { get; set; }
        public NhomNhanVienModel()
        {
            bus = new NhomNhanVienBLL();
        }
        public void OnGet()
        {
            lststatic = bus.getNhomNhanVien();
            int size = 5;
            //lst1 = bus.GetAll().ToList();
            lst = bus.GetAll().ToList();
            var totalRecord = bus.GetAll().Count();
            TotalPage = (totalRecord % size) == 0 ? (int)(totalRecord / size) : (int)((totalRecord / size) + 1);


        }
        public void OnPost()
        {
            lststatic = bus.getNhomNhanVien();
            lst = bus.GetAll().ToList();
            List<NhomNhanVienDTO> lst2 = bus.GetAll().ToList();
            mn = Request.Form["mn"];
            tn = Request.Form["tn"];
            mnt = Request.Form["mnt"];
            var temp1 = new List<NhomNhanVienDTO>();
            if (mn != "")
            {
                temp1 = (from s in lst2
                         where s.MaNhom.Trim() == mn.Trim()
                         select s).ToList();
                lst2 = temp1;
            }
            if (tn != "")
            {
                temp1 = (from s in lst2
                         where s.TenNhom.Trim() == tn.Trim()
                         select s).ToList();
                lst2 = temp1;
            }
            if (mnt != "")
            {
                temp1 = (from s in lst2
                         where s.MaNT.Trim() == mnt.Trim()
                         select s).ToList();
                lst2 = temp1;
            }
            lst = lst2.ToList();

        }
        public IActionResult OnPostList(string filter)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Filter>(filter);
            var Data = bus.GetNhomNhanVienByPage(obj.Page, obj.Size);
            return new ObjectResult(new { success = true, data = Data }) { StatusCode = 200 };
        }

        public IActionResult OnPostUpdate(string nnv)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<NhomNhanVienDTO>(nnv);
            var res = bus.Update(obj);
            if (res)
            {
                return new ObjectResult(new { success = true, nnv = obj }) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
            }
        }
        public IActionResult OnPostDelete(string idnnv)
        {
            var res = bus.Delete(idnnv);
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
        public IActionResult OnGetTest()
        {
            return new ObjectResult(new { Id = 123, Name = "Hero" }) { StatusCode = 200 };
        }
    }
}

