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
    public class DoiTac_NhanVienModel : PageModel
    {
        private KhachHangBLL bus;
        private HopDongBLL bus1;
        private NhanVienBLL bus2;
        public List<KhachHangDTO> lst;
        public List<HopDongDTO> lst1;
        public List<NhanVienDTO> lst2;
        public string gt { get; private set; }
        public string value { get; private set; }
        public DoiTac_NhanVienModel()
        {
            bus= new KhachHangBLL();
            bus1 = new HopDongBLL();
            bus2 = new NhanVienBLL();
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
                value = Request.Form["ass"];
                lst = bus.GetAll().ToList();
                var temp1 = new List<KhachHangDTO>();
                if (gt == "tnv")
                {
                    temp1 = (from d in lst
                             join h in lst1 on d.MaKH equals h.MaKH into f
                             from x in f
                             join n in lst2 on x.MaNV equals n.MaNv
                             where n.TenNv.Trim().Contains(value.Trim())
                             select d).ToList();
                }
                else
                {
                    temp1 = (from d in lst
                             join h in lst1 on d.MaKH equals h.MaKH into f
                             from x in f
                             join n in lst2 on x.MaNV equals n.MaNv
                             where n.MaNv == value
                             select d).ToList();
                }
                lst = temp1;
            }
        }
    }
}
