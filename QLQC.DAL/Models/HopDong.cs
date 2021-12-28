using System;
using System.Collections.Generic;

#nullable disable

//<<<<<<< HEAD
//namespace QLQC.DAL
//=======
namespace QLQC.DAL.Models
//>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
{
    public partial class HopDong
    {
        public string MaHd { get; set; }
        public DateTime? NgayKy { get; set; }
        public string MaNv { get; set; }
        public string MaKh { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
