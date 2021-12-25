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
    public class QuangCaoModel : PageModel
    {
        private QuangCaoBLL bus;
        private QC_LQCBLL bus1;
        public List<QuangCaoDTO> lst;
        public List<QC_LQCDTO> lst1;
        public string mqc { get; private set; }
        public string mkh { get; private set; }
        public string mn { get; private set; }
        public string nbd { get; private set; }
        public string nkt { get; private set; }
        public string st { get; private set; }
        public string sx1 { get; private set; }
        public string sx2 { get; private set; }
        public QuangCaoModel()
        {
            bus = new QuangCaoBLL();
            bus1 = new QC_LQCBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
        }
        public void OnPost()
        {
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
            mqc = Request.Form["mqc"];
            nbd = Request.Form["nbd"];
            nkt = Request.Form["nkt"];
            st = Request.Form["tt"];
            mn = Request.Form["mn"];
            mkh = Request.Form["mkh"];
            sx1 = Request.Form["sx1"];
            sx2 = Request.Form["sx2"];
            var temp1 = new List<QuangCaoDTO>();
            var temp2 = new List<QuangCaoDTO>();
            var temp3 = new List<QuangCaoDTO>();
            var temp4 = new List<QuangCaoDTO>();
            var temp5 = new List<QuangCaoDTO>();
            var temp6 = new List<QuangCaoDTO>();
            var temp7 = new List<QuangCaoDTO>();
            if (mqc != "")
            {
                temp1 = (from s in lst
                         where s.MaQc.Trim() == mqc.Trim()
                         select s).ToList();
                lst = temp1;
            }
            if (nbd != "")
            {
                if (nbd == "2018")
                {
                    temp2 = (from s in lst
                             where s.NgBd.Value.Year < int.Parse(nbd)
                             select s).ToList();
                    lst = temp2;
                }
                else if (nbd == "2019")
                {
                    temp2 = (from s in lst
                             where s.NgBd.Value.Year >= 2018 && s.NgBd.Value.Year < int.Parse(nbd)
                             select s).ToList();
                    lst = temp2;
                }
                else if (nbd == "2020")
                {
                    temp2 = (from s in lst
                             where s.NgBd.Value.Year >= 2019 && s.NgBd.Value.Year < int.Parse(nbd)
                             select s).ToList();
                    lst = temp2;
                }
                else
                {
                    temp2 = (from s in lst
                             where s.NgBd.Value.Year >= int.Parse(nbd)
                             select s).ToList();
                    lst = temp2;
                }
            }
            if (st != "")
            {
                decimal a = decimal.Parse(st);
                temp3 = (from s in lst
                         where s.SoTien <= a
                         select s).ToList();
                lst = temp3;
            }
            if (mn != "")
            {
                temp4 = (from s in lst
                         where s.MaNhom.Trim() == mn.Trim()
                         select s).ToList();
                lst = temp4;
            }
            if (mkh != "")
            {
                temp5 = (from s in lst
                         where s.MaKh.Trim() == mkh.Trim()
                         select s).ToList();
                lst = temp5;
            }
            if( sx1 != "")
            {
                if (sx1 == "tangdan")
                {
                    temp6 = (from s in lst
                             orderby s.NgBd ascending
                             select s).ToList();
                }
                else
                {
                    temp6 = (from s in lst
                             orderby s.NgBd descending
                             select s).ToList();
                }
                lst = temp6;
            }
            if (sx2 != "")
            {
                if (sx2 == "tangdan")
                {
                    temp6 = (from s in lst
                             orderby s.SoTien ascending
                             select s).ToList();
                }
                else
                {
                    temp6 = (from s in lst
                             orderby s.SoTien descending
                             select s).ToList();
                }
                lst = temp6;
            }
        }
        public IActionResult OnPostUpdate(String qc)
        { 
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<QuangCaoDTO>(qc);
            var res = bus.Update(obj);
            if (res)
            {
                return new ObjectResult(new {success = true, qc = obj }) { StatusCode = 200};
            }
            else {
                return new ObjectResult(new { success = false}) { StatusCode = 500 };
            }
        }
        public IActionResult OnPostDelete(String mqc)
        {            
            var res = bus.Delete(mqc);
            if (res)
            {
                return new ObjectResult(new { success = true}) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(new { success = false}) { StatusCode = 500 };
            }
        }
        public IActionResult OnPostAdd(String qc)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<QuangCaoDTO>(qc);
            var res = bus.Add(obj);
            if (res != null)
            {
                return new ObjectResult(new { success = true, qc = obj }) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
            }
        }
    }
}
