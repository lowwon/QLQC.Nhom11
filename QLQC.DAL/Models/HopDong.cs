using System;
using System.Collections.Generic;

#nullable disable

namespace QLQC.DAL
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
