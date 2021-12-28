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
    public partial class LoaiQc
    {
        public LoaiQc()
        {
            QcLqcs = new HashSet<QcLqc>();
        }

        public string MaLoai { get; set; }
        public string HinhThuc { get; set; }
        public string MoTa { get; set; }

        public virtual ICollection<QcLqc> QcLqcs { get; set; }
    }
}
