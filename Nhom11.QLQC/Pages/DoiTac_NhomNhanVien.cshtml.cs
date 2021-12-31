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
    public class DoiTac_NhomNhanVienModel : PageModel
    {
        private KhachHangBLL bus;
        private QuangCaoBLL bus1;
        private NhomNhanVienBLL bus2;
        public List<KhachHangDTO> lst;
        public List<QuangCaoDTO> lst1;
        public List<NhomNhanVienDTO> lst2;
        public string gt { get; private set; }
        public string value { get; private set; }
        public DoiTac_NhomNhanVienModel()
        {
            bus = new KhachHangBLL();
            bus1 = new QuangCaoBLL();
            bus2 = new NhomNhanVienBLL();
        }
        public void OnGet()
        {
            lst = null;
            lst1 = null;
            lst2 = null;
        }
        public void OnPost()
        {
            gt = Request.Form["a"].ToString().Trim();
            if (gt != "")
            {
                lst2 = bus2.GetAll().ToList();
                lst1 = bus1.GetAll().ToList();
                lst = bus.GetAll().ToList();
                value = Request.Form["ass"];
                var temp1 = new List<KhachHangDTO>();
                if (gt == "tnnv")
                {
                    temp1 = (from s in lst
                             join q in lst1 on s.MaKH equals q.MaKh into f
                             from ff in f
                             join n in lst2 on ff.MaNhom equals n.MaNhom 
                             where n.TenNhom.Trim() == value.Trim()
                             select s
                            ).ToList();
                }
                else
                {
                    temp1 = (from s in lst
                             join q in lst1 on s.MaKH equals q.MaKh into f
                             from ff in f
                             join n in lst2 on ff.MaNhom equals n.MaNhom
                             where n.MaNhom.Trim() == value.Trim()  
                             select s
                             ).ToList();
                }
                lst = temp1;
            }
        }
    }
}
