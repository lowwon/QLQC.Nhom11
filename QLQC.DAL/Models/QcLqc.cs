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
    public partial class QcLqc
    {
        public string MaQc { get; set; }
        public string MaLoai { get; set; }

        public virtual LoaiQc MaLoaiNavigation { get; set; }
        public virtual QuangCao MaQcNavigation { get; set; }
    }
}
