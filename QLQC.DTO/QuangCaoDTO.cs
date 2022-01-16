using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QLQC.DTO
{
    public class QuangCaoDTO
    {
        public string MaQc { get; set; }
        public string MaKh { get; set; }
        public string MaNhom { get; set; }
        public DateTime? NgBd { get; set; }
        public DateTime? NgKt { get; set; }
        public string YeuCau { get; set; }
        public decimal? SoTien { get; set; }
    }
    public class QuangCaoStatic
    {
        public string Year { get; set; }
        public int Number { get; set; }
        public int SumPrice { get; set; }
    }
}
