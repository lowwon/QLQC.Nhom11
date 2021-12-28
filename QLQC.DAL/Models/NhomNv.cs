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
    public partial class NhomNv
    {
        public NhomNv()
        {
            NhanViens = new HashSet<NhanVien>();
            QuangCaos = new HashSet<QuangCao>();
        }

        public string MaNhom { get; set; }
        public string TenNhom { get; set; }
        public string MaNt { get; set; }

        public virtual NhanVien MaNtNavigation { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
        public virtual ICollection<QuangCao> QuangCaos { get; set; }
    }
}
