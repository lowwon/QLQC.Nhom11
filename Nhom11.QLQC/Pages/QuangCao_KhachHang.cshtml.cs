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
    public class QuangCao_KhachHangModel : PageModel
    {
        private QuangCaoBLL bus;
        private QC_LQCBLL bus1;
        private KhachHangBLL bus2;
        public List<QuangCaoDTO> lst;
        public List<QC_LQCDTO> lst1;
        public List<KhachHangDTO> lst2;
        public string gt { get; private set; }
        public string value { get; private set; }
        public QuangCao_KhachHangModel()
        {
            bus = new QuangCaoBLL();
            bus1 = new QC_LQCBLL();
            bus2 = new KhachHangBLL();
        }
        public void OnGet()
        {
            lst = null;
            lst1 = null;
            lst2 = null;
        }
        public void OnPost()
        {
            lst2 = bus2.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
            gt = Request.Form["a"].ToString().Trim();
            if (gt == "")
            {
                lst = null;
            }
            else
            {
                value = Request.Form["ass"];
                lst = bus.GetAll().ToList();
                var temp1 = new List<QuangCaoDTO>();
                if (gt == "tkh")
                {
                    temp1 = (from s in lst
                             join c in lst2 on s.MaKh equals c.MaKH into t
                             from x in t
                             where x.TenKH.Trim().Contains(value.Trim())                       
                             select s).ToList();
                }
                else
                {
                    temp1 = (from s in lst
                             join c in lst2 on s.MaKh equals c.MaKH into t
                             from x in t
                             where x.MaKH.Trim() == value.Trim()
                             select s).ToList();
                }
                lst = temp1;
            }
                
        }
    }
}
