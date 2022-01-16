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
        public List<QuangCaoDTO> lst;
        public List<QuangCaoDTO> lst1;
        public List<QuangCaoStatic> lststatic;
        public string mqc { get; set; }
        public string mkh { get; set; }
        public string mn { get; set; }
        public string nbd { get; set; }
        public string nkt { get; set; }
        public string st { get; set; }
        public string sx1 { get; set; }
        public string sx2 { get; set; }
        public string temp { get; set; }
        public int TotalPage;
        public QuangCaoModel()
        {
            bus = new QuangCaoBLL();
        }
        public void OnGet()
        {
            lststatic = bus.getQuangCao();
            int size = 5;
            lst1 = bus.GetAll().ToList();
            lst = bus.GetAll().Take(size).ToList();
            var totalRecord = bus.GetAll().Count();
            TotalPage = (totalRecord % size) == 0 ? (int)(totalRecord / size) : (int)((totalRecord / size) + 1);
        }
        public void OnPost()
        {
            lststatic = bus.getQuangCao();
            lst1 = bus.GetAll().ToList();
            List<QuangCaoDTO> lst2 = bus.GetAll().ToList();
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
                temp1 = (from s in lst2
                         where s.MaQc.Trim() == mqc.Trim()
                         select s).ToList();
                lst2 = temp1;
            }
            if (nbd != "")
            {
                if (nbd == "2018")
                {
                    temp2 = (from s in lst2
                             where s.NgBd.Value.Year < int.Parse(nbd)
                             select s).ToList();
                    lst2 = temp2;
                }
                else if (nbd == "2019")
                {
                    temp2 = (from s in lst2
                             where s.NgBd.Value.Year >= 2018 && s.NgBd.Value.Year < int.Parse(nbd)
                             select s).ToList();
                    lst2 = temp2;
                }
                else if (nbd == "2020")
                {
                    temp2 = (from s in lst2
                             where s.NgBd.Value.Year >= 2019 && s.NgBd.Value.Year < int.Parse(nbd)
                             select s).ToList();
                    lst2 = temp2;
                }
                else
                {
                    temp2 = (from s in lst2
                             where s.NgBd.Value.Year >= int.Parse(nbd)
                             select s).ToList();
                    lst2 = temp2;
                }
            }
            if (st != "")
            {
                decimal a = decimal.Parse(st);
                temp3 = (from s in lst2
                         where s.SoTien <= a
                         select s).ToList();
                lst2 = temp3;
            }
            if (mn != "")
            {
                temp4 = (from s in lst2
                         where s.MaNhom.Trim() == mn.Trim()
                         select s).ToList();
                lst2 = temp4;
            }
            if (mkh != "")
            {
                temp5 = (from s in lst2
                         where s.MaKh.Trim() == mkh.Trim()
                         select s).ToList();
                lst2 = temp5;
            }
            if (sx1 != "")
            {
                if (sx1 == "tangdan")
                {
                    temp6 = lst2.OrderBy(x => x.NgBd).ToList();
                    //temp6 = (from s in lst2
                    //         orderby s.NgBd ascending
                    //         select s).ToList();
                }
                else
                {
                    temp6 = lst2.OrderByDescending(x => x.NgBd).ToList();

                    //temp6 = (from s in lst2
                    //         orderby s.NgBd descending
                    //         select s).ToList();
                }
                lst2 = temp6;
            }
            if (sx2 != "")
            {
                if (sx2 == "tangdan")
                {
                    temp7 = (from s in lst2
                             orderby s.SoTien ascending
                             select s).ToList();
                }
                else
                {
                    temp7 = (from s in lst2
                             orderby s.SoTien descending
                             select s).ToList();
                }
                lst2 = temp7;
            }
            lst = lst2.ToList();
           
        }
        public IActionResult OnPostList(string filter)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Filter>(filter);
            var Data = bus.GetQuangCaoByPage(obj.Page, obj.Size);
            return new ObjectResult(new { success = true, data = Data }) { StatusCode = 200 };
        }
        public IActionResult OnPostUpdate(String qc)
        {
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<QuangCaoDTO>(qc);
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
        public IActionResult OnPostDelete(String mqc)
        {
            var res = bus.Delete(mqc);
            if (res)
            {
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
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
