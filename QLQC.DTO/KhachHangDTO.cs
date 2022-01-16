using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DTO;
namespace QLQC.DTO
{
    public class KhachHangDTO
    {

        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string GT { get; set; }
        public string Email { get; set; }
    }
    public class KhachHangStatic
    {
        public string GT { get; set;}
        public int SoKhachHang { get;set; }
    }
}
