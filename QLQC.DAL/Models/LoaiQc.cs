using System;
using System.Collections.Generic;

#nullable disable

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
