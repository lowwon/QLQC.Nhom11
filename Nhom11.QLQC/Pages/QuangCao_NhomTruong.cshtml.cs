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
    public class QuangCao_NhomTruongModel : PageModel
    {
        private QuangCaoBLL bus;
        private NhomNhanVienBLL bus1;
        private QC_LQCBLL bus2;
        public List<QuangCaoDTO> lst;
        public List<NhomNhanVienDTO> lst1;
        public List<QC_LQCDTO> lst2;    
        public string value { get; private set; }   
        public QuangCao_NhomTruongModel()
        {
            bus = new QuangCaoBLL();
            bus1 = new NhomNhanVienBLL();
            bus2 = new QC_LQCBLL();
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
            value = Request.Form["ass"];
            if (value == "")
            {
                lst = null;
            }
            else
            {
                lst = bus.GetAll().ToList();
                var temp1 = new List<QuangCaoDTO>();
                temp1 = (from s in lst
                        join n in lst1 on s.MaNhom equals n.MaNhom
                        where n.MaNT.Trim() == value.Trim()
                        select s).ToList();
                lst = temp1;
            }
        }
    }
}
