using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DTO;
using QLQC.DAL.Models;
using Microsoft.Data.SqlClient;
using System.Data;

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

        public object GetHDbyPage(int page, int size)
        {
            List<HopDongDTO> data = new List<HopDongDTO>();
            var res = new
            {
                Data = data,
                TotalRecord = 0,
                TotalPage = 0,
                Page = page,
                Size = size
            };
            try
            {
                var lst2 = db.HopDongs.ToList();
                var offset = (page - 1) * size;
                var totalRecord = lst2.Count();
                var totalPage = (totalRecord % size) == 0 ? (int)(totalRecord / size) : (int)((totalRecord / size) + 1);
                var lst = lst2.Skip(offset).Take(size);
                foreach (var c in lst)
                {
                    HopDongDTO hdDto = new HopDongDTO();
                    hdDto.MaHD = c.MaHd;
                    hdDto.MaKH = c.MaKh;
                    hdDto.MaNV = c.MaNv;
                    hdDto.NgayKy = c.NgayKy;
                    data.Add(hdDto);
                }
                res = new
                {
                    Data = data,
                    TotalRecord = totalRecord,
                    TotalPage = totalPage,
                    Page = page,
                    Size = size
                };
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
        public List<HopDongStatic> getHopDong()
        {
            var res = new List<HopDongStatic>();
            string cnStr = "Server=localhost;Database=qlQcao;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(cnStr);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "sp_HopDongTrongNam";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                var list = new List<HopDongStatic>();
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        var sts = new HopDongStatic
                        {
                            NgayKy = row["NgayKy"].ToString(),
                            SoHopDong = int.Parse(row["SoHopDong"].ToString())
                        };
                        list.Add(sts);
                    }
                }
                res = list;
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;
        }
    }
}
