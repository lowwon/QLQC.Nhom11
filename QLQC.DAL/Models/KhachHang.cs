using System;
using System.Collections.Generic;

#nullable disable

//<<<<<<< HEAD
//namespace QLQC.DAL
//=======
namespace QLQC.DAL.Models
//>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HopDongs = new HashSet<HopDong>();
            QuangCaos = new HashSet<QuangCao>();
        }

        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public string Gt { get; set; }
        public string Email { get; set; }

        public virtual ICollection<HopDong> HopDongs { get; set; }
        public virtual ICollection<QuangCao> QuangCaos { get; set; }
    }
}
