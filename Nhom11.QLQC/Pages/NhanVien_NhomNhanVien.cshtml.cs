using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Nhom11.QLQC.Pages
{
    public class NhanVien_NhomNhanVienModel : PageModel
    {
        private NhanVienBLL bus;
        private NhomNhanVienBLL bus1;
        public List<NhomNhanVienDTO> lst1;
        public List<NhanVienDTO> lst;
        public NhanVien_NhomNhanVienModel()
        {
            bus = new NhanVienBLL();
            bus1 = new NhomNhanVienBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
        }
        public string mnnnv { get; private set; }
        public string tn { get; private set; }
        public void OnPost()
        {
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
            mnnnv = Request.Form["mnnnv"];
            tn = Request.Form["tn"];
            var temp1 = new List<NhanVienDTO>();
            var temp2 = new List<NhanVienDTO>();
            if (mnnnv != "")
            {
                temp1 = (from nv in lst
                         join nnv in lst1 on nv.MaNhom equals nnv.MaNhom
                         where nnv.MaNhom.ToLower().Contains(mnnnv.ToLower())
                         select nv).ToList();
                lst = temp1;
            }
            if (tn != "")
            {
                temp2 = (from nv in lst
                         join nnv in lst1 on nv.MaNhom equals nnv.MaNhom
                         where nnv.TenNhom.ToLower().Contains(tn.ToLower())
                         select nv).ToList();
                lst = temp2;
            }
        }
    }
}
