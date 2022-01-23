using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;
using System.Text.Json;

namespace Nhom11.QLQC.Pages
{
    public class NhanVien_HopDong_DoiTacModel : PageModel
    {
        private NhanVienBLL bus;
        private HopDongBLL bus1;
        private KhachHangBLL bus2;
        public List<NhanVienDTO> lst;
        public List<HopDongDTO> lst1;
        public List<KhachHangDTO> lst2;
        public NhanVien_HopDong_DoiTacModel()
        {
            bus = new NhanVienBLL();
            bus1 = new HopDongBLL();
            bus2 = new KhachHangBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
            lst2 = bus2.GetAll().ToList();
        }
        public string mkhnv { get; private set; }
        public string tkhnv { get; private set; }
        public void OnPost()
        {
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
            lst2 = bus2.GetAll().ToList();
            mkhnv = Request.Form["mkhnv"];
            tkhnv = Request.Form["tkhnv"];
            var temp1 = new List<NhanVienDTO>();
            var temp2 = new List<NhanVienDTO>();
            if (mkhnv != "")
            {
                temp1 = (from n in lst
                         join h in lst1 on n.MaNv equals h.MaNV
                         join k in lst2 on h.MaKH equals k.MaKH
                         where k.MaKH.ToLower().Contains(mkhnv.ToLower())
                         select n).ToList();
                lst = temp1;
            }
            else if (tkhnv != "")
            {
                temp2 = (from n in lst
                         join h in lst1 on n.MaNv equals h.MaNV
                         join k in lst2 on h.MaKH equals k.MaKH
                         where k.TenKH.Contains(tkhnv.Trim())
                         select n).ToList();
                lst = temp2;
            }
            else
            {
                lst = null;
            }

        }
    }
}
