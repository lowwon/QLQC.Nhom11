using System;
using System.Collections.Generic;

#nullable disable

namespace QLQC.DAL.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HopDongs = new HashSet<HopDong>();
            NhomNvs = new HashSet<NhomNv>();
        }

        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public string MaNhom { get; set; }
        public DateTime? NgSinh { get; set; }
        public DateTime? NgVaoLam { get; set; }
        public string Email { get; set; }
        public string Gt { get; set; }

        public virtual NhomNv MaNhomNavigation { get; set; }
        public virtual ICollection<HopDong> HopDongs { get; set; }
        public virtual ICollection<NhomNv> NhomNvs { get; set; }
    }
}
