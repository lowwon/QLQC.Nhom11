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
    public class HopDong_NhanVienModel : PageModel
    {
        private HopDongBLL bus;
        private NhanVienBLL bus1;
        public List<HopDongDTO> lst;
        public List<NhanVienDTO> lst1;
        public string gt { get; private set; }
        public string value { get; private set; }
        public HopDong_NhanVienModel()
        {
            bus = new HopDongBLL();
            bus1 = new NhanVienBLL();
        }
        public void OnGet()
        {
            lst = null;
            lst1 = null;
        }
        public void OnPost()
        {
            gt = Request.Form["a"].ToString().Trim();

            if (gt == "")
            {
                lst = null;
                lst1 = null; 
            }
            else
            {
                lst1 = bus1.GetAll().ToList();
                lst = bus.GetAll().ToList();
                value = Request.Form["ass"];
                var temp1 = new List<HopDongDTO>();
                if (gt == "tnv")
                {
                    temp1 = (from hd in lst
                             join nv in lst1 on hd.MaNV equals nv.MaNv 
                             where nv.TenNv.Trim() == value.Trim()
                             select hd).ToList();
                }
                else
                {
                    temp1 = (from hd in lst
                             join nv in lst1 on hd.MaNV equals nv.MaNv
                             where nv.MaNv.Trim() == value.Trim()
                             select hd).ToList();
                }
                lst = temp1;
            }
        }
    }
}
