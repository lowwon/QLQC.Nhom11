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
        private NhomNhanVienBLL bus1;
        public List<NhomNhanVienDTO> lst1;
        public List<NhanVienDTO> lst;
        public List<NhanVienStatic1> lststatic1;
        public List<NhanVienStatic2> lststatic2;
        public int totalPageNv;
        public NhanVienModel()
        {
            bus = new NhanVienBLL();
            bus1 = new NhomNhanVienBLL();
        }
        public void OnGet()
        {
            lststatic1 = bus.getNhanVien1();
            lststatic2 = bus.getNhanVien2();
            int size = 10;
            lst = bus.GetAll().Take(10).ToList();
            lst1 = bus1.GetAll().ToList();
            var totalRecordNv = bus.GetAll().Count();
            totalPageNv = (totalRecordNv % size) == 0 ? (int)(totalRecordNv / size) : (int)((totalRecordNv / size) + 1);

        }
        public IActionResult OnPostList(string filter)
        {
            var obj = JsonSerializer.Deserialize<Filter>(filter);
            var Datanv = bus.GetNhanVienByPage(obj.Page, obj.Size);
            return new ObjectResult(new { success = true, data = Datanv }) { StatusCode = 200 };
        }
        public string mnv { get; private set; }
        public string mn { get; private set; }
        public string tnv { get; private set; }
        public string nvl { get; private set; }
        public void OnPost()
        {
            lststatic1 = bus.getNhanVien1();
            lststatic2 = bus.getNhanVien2();
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
            mnv = Request.Form["mnv"];
            mn = Request.Form["mn"];
            tnv = Request.Form["tnv"];
            nvl = Request.Form["nvl"];
            var temp1 = new List<NhanVienDTO>();
            var temp2 = new List<NhanVienDTO>();
            var temp3 = new List<NhanVienDTO>();
            var temp4 = new List<NhanVienDTO>();
            if (mnv != "")
            {
                temp1 = (from s in lst
                         where s.MaNv.ToLower().Contains(mnv.ToLower())
                         select s).ToList();
                lst = temp1;
            }
            if (tnv != "")
            {
                temp2 = (from s in lst
                         where s.TenNv.ToLower().Contains(tnv.ToLower())
                         select s).ToList();
                lst = temp2;
            }
            if (mn != "")
            {
                temp3 = (from s in lst
                         where s.MaNhom.ToLower().Contains(mn.ToLower())
                         select s).ToList();
                lst = temp3;
            }
            if (nvl != "")
            {
                if (nvl == "2014")
                {
                    temp4 = (from s in lst
                             where s.NgVaoLam.Value.Year < int.Parse(nvl)
                             select s).ToList();
                    lst = temp4;
                }
                else if (nvl == "2018")
                {
                    temp4 = (from s in lst
                             where s.NgVaoLam.Value.Year >= 2014 && s.NgVaoLam.Value.Year < int.Parse(nvl)
                             select s).ToList();
                    lst = temp4;
                }
                else if (nvl == "2021")
                {
                    temp4 = (from s in lst
                             where s.NgVaoLam.Value.Year >= 2021  && s.NgVaoLam.Value.Year < int.Parse(nvl)
                             select s).ToList();
                    lst = temp4;
                }
                else
                {
                    temp4 = (from s in lst
                             where s.NgVaoLam.Value.Year >= int.Parse(nvl)
                             select s).ToList();
                    lst = temp4;
                }
            }
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

