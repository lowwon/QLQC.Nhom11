using System;
using System.Collections.Generic;

#nullable disable

//<<<<<<< HEAD
//namespace QLQC.DAL
//=======
//namespace QLQC.DAL.Models
//>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
namespace QLQC.DAL.Models
{
    public partial class QuangCao
    {
        public QuangCao()
        {
            QcLqcs = new HashSet<QcLqc>();
        }

        public string MaQc { get; set; }
        public string MaKh { get; set; }
        public string MaNhom { get; set; }
        public DateTime? NgBd { get; set; }
        public DateTime? NgKt { get; set; }
        public string YeuCau { get; set; }
        public decimal? SoTien { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual NhomNv MaNhomNavigation { get; set; }
        public virtual ICollection<QcLqc> QcLqcs { get; set; }
    }
}
