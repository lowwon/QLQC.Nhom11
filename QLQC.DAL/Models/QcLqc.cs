using System;
using System.Collections.Generic;

#nullable disable

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
