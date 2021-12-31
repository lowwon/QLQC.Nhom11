using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;
using System.Text.Json;
using Newtonsoft.Json;

namespace Nhom11.QLQC.Pages
{
    public class HopDongModel : PageModel
    {
        private HopDongBLL bus;
        public List<HopDongDTO> lst;

        public string mhd { get; private set; }
        public string mkh { get; private set; }
        public string mnv { get; private set; }
        public string nk { get; private set; }

        public HopDongModel()
        {
            bus = new HopDongBLL();
        }

        public void OnGet()
        {
            lst = bus.GetAll().ToList();
        }

        public void OnPost()
        {
            lst = bus.GetAll().ToList();
            mhd = Request.Form["mhd"];
            mkh = Request.Form["mkh"];
            mnv = Request.Form["mnv"];
            nk = Request.Form["nk"];
            var temp1 = new List<HopDongDTO>();
            var temp2 = new List<HopDongDTO>();
            var temp3 = new List<HopDongDTO>();
            if (mhd != "")
            {
                temp1 = (from c in lst
                         where c.MaHD.Trim() == mhd.Trim()
                         select c).ToList();
                lst = temp1;
            }
            if (mkh != "")
            {
                temp2 = (from c in lst
                         where c.MaKH.Trim() == mkh.Trim()
                         select c).ToList();
                lst = temp2;
            }
            if (mnv != "")
            {
                temp3 = (from c in lst
                         where c.MaNV.Trim() == mnv.Trim()
                         select c).ToList();
                lst = temp3;
            }
        }

        public IActionResult OnPostUpdate(string hd)
        {
            HopDongDTO obj = JsonConvert.DeserializeObject<HopDongDTO>(hd);
            var res = bus.Update(obj);
            if (res)
            {
                return new ObjectResult(new { success = true, hd = obj }) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(new { success = false, }) { StatusCode = 500 };
            }
        }

        public IActionResult OnPostDelete(string mhd)
        {
            var res = bus.Delete(mhd);
            if (res)
            {
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
            }
        }

        public IActionResult OnPostAdd(string hd)
        {
            HopDongDTO obj = JsonConvert.DeserializeObject<HopDongDTO>(hd);
            var res = bus.Add(obj);
            if (res != null)
            {
                return new ObjectResult(new { success = true, hd = obj }) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
            }
        }
    }
}
