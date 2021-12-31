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
    public class QuangCao_NhanVienModel : PageModel
    {
        private QuangCaoBLL bus;
        private NhomNhanVienBLL bus1;
        private NhanVienBLL bus2;
        private QC_LQCBLL bus3;
        public List<QuangCaoDTO> lst;
        public List<NhomNhanVienDTO> lst1;
        public List<NhanVienDTO> lst2;
        public List<QC_LQCDTO> lst3;
        public string gt { get; private set; }
        public string value { get; private set; }
        public QuangCao_NhanVienModel()
        {
            bus = new QuangCaoBLL();
            bus1 = new NhomNhanVienBLL();
            bus2 = new NhanVienBLL();
            bus3 = new QC_LQCBLL();
        }
        public void OnGet()
        {
            lst = null;
            lst1 = null;
            lst2 = null;
            lst3 = null;
        }
        public void OnPost()
        {
            gt = Request.Form["a"].ToString().Trim();

            if (gt == "")
            {
                lst = null;
                lst1 = null;
                lst2 = null;
                lst3 = null;
            }
            else
            {
                lst2 = bus2.GetAll().ToList();
                lst1 = bus1.GetAll().ToList();
                lst = bus.GetAll().ToList();
                lst3 = bus3.GetAll().ToList();
                value = Request.Form["ass"];
                var temp1 = new List<QuangCaoDTO>();
                if (gt == "tnv")
                {
                    temp1 = (from qc in lst
                             join nnv in lst1 on qc.MaNhom equals nnv.MaNhom into t
                             from x in t
                             join nv in lst2 on x.MaNhom equals nv.MaNhom
                             where nv.TenNv.Trim() == value.Trim()
                             select qc).ToList();
                }
                else
                {
                    temp1 = (from qc in lst
                             join nnv in lst1 on qc.MaNhom equals nnv.MaNhom into t
                             from x in t
                             join nv in lst2 on x.MaNhom equals nv.MaNhom
                             where nv.MaNv.Trim() == value.Trim()
                             select qc).ToList();
                }
                lst = temp1;
            }
        }
    }
}
