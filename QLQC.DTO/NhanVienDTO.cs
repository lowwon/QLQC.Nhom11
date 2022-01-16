using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQC.DTO
{
    public class NhanVienDTO
    {
        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public string MaNhom { get; set; }
        public DateTime? NgSinh { get; set; }
        public DateTime? NgVaoLam { get; set; }
        public string Email { get; set; }
        public string Gt { get; set; }

    }
    public class NhanVienStatic1
    {
        public string Year { get; set; }
        public int NumberEmpl { get; set; }


    }
    public class NhanVienStatic2
    {
        public string MaNhom { get; set; }
        public int NumberEmpl { get; set; }

    }

}
