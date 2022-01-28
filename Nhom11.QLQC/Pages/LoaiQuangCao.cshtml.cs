using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Nhom11.QLQC.Pages
{
    public class LoaiQuangCaoModel : PageModel
    {
        private LoaiQcBLL bus;
        private QC_LQCBLL bus1;
        public List<LoaiQcDTO> lst;
        public List<QC_LQCDTO> lst1;
        public List<LoaiQcDTO> lst2;
        public string mlqc { get; private set; }
        public string ht { get; private set; }
        public LoaiQuangCaoModel()
        {
            bus = new LoaiQcBLL();
            bus1 = new QC_LQCBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
            lst2 = bus.GetAll().ToList();
        }
        public void OnPost()
        {
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
            lst2 = bus.GetAll().ToList();
            mlqc = Request.Form["mlqc"];
            ht = Request.Form["ht"];
            var temp1 = new List<LoaiQcDTO>();
            if(mlqc != "")
            {
                temp1 = (from s in lst
                         where s.MaLoai.Trim() == mlqc.Trim()
                         select s).ToList();
                lst = temp1;
            }
            if (ht != "")
            {
                temp1 = (from s in lst
                         where s.HinhThuc.Trim() == ht.Trim()
                         select s).ToList();
                lst = temp1;
            }
        }
        public IActionResult OnPostUpdate(String lqc)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<LoaiQcDTO>(lqc);
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
        public IActionResult OnPostDelete(String mlqc)
        {
            var res = bus.Delete(mlqc);
            if (res)
            {
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
            }
        }
        public IActionResult OnPostAdd(String lqc)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<LoaiQcDTO>(lqc);
            var res = bus.Add(obj);
            if (res != null)
            {
                return new ObjectResult(new { success = true, lqc = obj }) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
            }
        }
    }
}
