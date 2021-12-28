using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Nhom11.QLQC.Pages
{
    public class QuangCaoVaLoaiQuangCaoModel : PageModel
    {
        private QC_LQCBLL bus;
        private LoaiQcBLL bus1;
        private QuangCaoBLL bus2;
        public List<QC_LQCDTO> lst;
        public List<LoaiQcDTO> lst1;
        public List<QuangCaoDTO> lst2;
        public string mqc { get; private set; }
        public string mlqc { get; private set; }
        public string ht { get; private set; }
        public QuangCaoVaLoaiQuangCaoModel()
        {
            bus = new QC_LQCBLL();
            bus1 = new LoaiQcBLL();
            bus2 = new QuangCaoBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
            lst2 = bus2.GetAll().ToList();
        }
        public void OnPost()
        {
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
            lst2 = bus2.GetAll().ToList();
            mqc = Request.Form["mqc"];
            mlqc = Request.Form["mlqc"];
            ht = Request.Form["ht"];
            var temp1 = new List<QC_LQCDTO>();
            var temp2 = new List<QC_LQCDTO>();
            var temp3 = new List<QC_LQCDTO>();
            if (mqc != "")
            {
                temp1 = (from s in lst
                         where s.MaQc.Trim() == mqc.Trim()
                         select s).ToList();
                lst = temp1;
            }
            if (mlqc != "")
            {
                temp2 = (from s in lst
                         where s.MaLoai.Trim() == mlqc.Trim()
                         select s).ToList();
                lst = temp2;
            }
            if (ht != "")
            {
                temp3 = (from s in lst
                         join c in lst1 on s.MaLoai equals c.MaLoai into fg
                         from fgi in (from f in fg
                                      where f.HinhThuc.Trim() == ht.Trim()
                                      select f)
                         select s).ToList();
                lst = temp3;
            }
        }
        public IActionResult OnPostUpdate(String qclqctemp, String qclqc)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<QC_LQCDTO>(qclqc);
            var objtemp = Newtonsoft.Json.JsonConvert.DeserializeObject<QC_LQCDTO>(qclqctemp);

            var res = bus.Update(objtemp, obj);
            if (res)
            {
                return new ObjectResult(new { success = true, qclqc = obj }) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
            }
        }
        public IActionResult OnPostDelete(String mqc, String mlqc)
        {
            var res = bus.Delete(mqc, mlqc);
            if (res)
            {
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
            }
        }

        public IActionResult OnPostAdd(String a)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<QC_LQCDTO>(a);

            var res = bus.Add(obj);
            if (res != null)
            {
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
            }
        }

    }
}
