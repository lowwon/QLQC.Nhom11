using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLQC.BLL;
using QLQC.DTO;

namespace Nhom11.QLQC.Pages
{
    public class HTQC_KhachHangModel : PageModel
    {
        private KhachHangBLL khbus;
        private QuangCaoBLL qcbus;
        private LoaiQcBLL lqcbus;
        private QC_LQCBLL qc_lqcbus;
        public List<KhachHangDTO> lstkh;
        public List<QuangCaoDTO> lstqc;
        public List<LoaiQcDTO> lstlqc;
        public List<QC_LQCDTO> lstqc_lqc;
        public string gt { get; set; }
        public string value { get; set; }

        public HTQC_KhachHangModel()
        {
            khbus = new KhachHangBLL();
            qcbus = new QuangCaoBLL();
            lqcbus = new LoaiQcBLL();
            qc_lqcbus = new QC_LQCBLL();
        }

        public void OnGet()
        {
            lstkh = null;
            lstqc = null;
            lstlqc = null;
            lstqc_lqc = null;
        }

        public void OnPost()
        {
            gt = Request.Form["a"].ToString().Trim();
            if (gt != "")
            {
                lstkh = khbus.GetAll().ToList();
                lstqc = qcbus.GetAll().ToList();
                lstlqc = lqcbus.GetAll().ToList();
                lstqc_lqc = qc_lqcbus.GetAll().ToList();

                value = Request.Form["ass"];
                var temp1 = new List<LoaiQcDTO>();
                var temp2 = new List<KhachHangDTO>();
                if (gt == "tkh")
                {
                    temp1 = (from lqc in lstlqc
                             join qc_lqc in lstqc_lqc on lqc.MaLoai equals qc_lqc.MaLoai into a
                             from x in a
                             join qc in lstqc on x.MaQc equals qc.MaQc into b
                             from y in b
                             join kh in lstkh on y.MaKh equals kh.MaKH
                             where kh.TenKH.Trim().Contains(value.Trim())
                             select lqc).ToList();
                    temp2 = (from kh in lstkh
                             join qc in lstqc on kh.MaKH equals qc.MaKh
                             where kh.TenKH.Trim().Contains(value.Trim())
                             select kh).ToList();
                }
                else
                {
                    temp1 = (from lqc in lstlqc
                             join qc_lqc in lstqc_lqc on lqc.MaLoai equals qc_lqc.MaLoai into a
                             from x in a
                             join qc in lstqc on x.MaQc equals qc.MaQc into b
                             from y in b
                             join kh in lstkh on y.MaKh equals kh.MaKH
                             where kh.MaKH.Trim().Contains(value.Trim())
                             select lqc).ToList();
                    temp2 = (from kh in lstkh
                             where kh.MaKH.Contains(value.Trim())
                             select kh).ToList();
                }
                lstlqc = temp1;
                lstkh = temp2;

            }
        }
    }
}
