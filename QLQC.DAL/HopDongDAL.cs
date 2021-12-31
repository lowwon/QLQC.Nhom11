using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DTO;
using QLQC.DAL.Models;

namespace QLQC.DAL
{
    public class HopDongDAL
    {
        private qlQcaoContext db;

        public HopDongDAL()
        {
            db = new qlQcaoContext();
        }

        public IList<HopDongDTO> GetAll()
        {
            List<HopDongDTO> res = new List<HopDongDTO>();
            try
            {
                var ls = db.HopDongs.ToList();
                foreach (var c in ls)
                {
                    HopDongDTO hdDto = new HopDongDTO();
                    hdDto.MaHD = c.MaHd;
                    hdDto.NgayKy = c.NgayKy;
                    hdDto.MaNV = c.MaNv;
                    hdDto.MaKH = c.MaKh;
                    res.Add(hdDto);
                }
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
        public bool Update(HopDongDTO hd)
        {
            bool res = false;
            var c = db.HopDongs.FirstOrDefault(x => x.MaHd == hd.MaHD);
            if (c.NgayKy != hd.NgayKy)
            {
                c.NgayKy = hd.NgayKy;
            }
            if (c.MaKh != hd.MaKH)
            {
                c.MaKh = hd.MaKH;
            }
            if (c.MaNv != hd.MaNV)
            {
                c.MaNv = hd.MaNV;
            }
            try
            {
                db.HopDongs.Update(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(string mhd)
        {
            bool res = false;
            var c = db.HopDongs.FirstOrDefault(x => x.MaHd.Trim() == mhd.Trim());
            try
            {
                db.HopDongs.Remove(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public HopDongDTO Add(HopDongDTO hd)
        {
            HopDongDTO res = new HopDongDTO();
            var c = new HopDong();
            c.MaHd = hd.MaHD;
            c.NgayKy = hd.NgayKy;
            c.MaKh = hd.MaKH;
            c.MaNv = hd.MaNV;
            try
            {
                db.HopDongs.Add(c);
                db.SaveChanges();
                res.MaHD = c.MaHd;
                res.NgayKy = c.NgayKy;
                res.MaKH = c.MaKh;
                res.MaNV = c.MaNv;
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;
        }

    }
}
