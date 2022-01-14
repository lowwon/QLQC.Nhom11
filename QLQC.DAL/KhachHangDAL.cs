using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQC.DTO;
using QLQC.DAL.Models;

namespace QLQC.DAL
{
    public class KhachHangDAL
    {
        private qlQcaoContext db;

        public KhachHangDAL()
        {
            db = new qlQcaoContext();
        }

        public IList<KhachHangDTO> GetAll()
        {
            List<KhachHangDTO> res = new List<KhachHangDTO>();
            try
            {
                var ls = db.KhachHangs.ToList();
                foreach (var c in ls)
                {
                    KhachHangDTO khDto = new KhachHangDTO();
                    khDto.MaKH = c.MaKh;
                    khDto.TenKH = c.TenKh;
                    khDto.GT = c.Gt;
                    khDto.Email = c.Email;
                    res.Add(khDto);
                }
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }

        //Sửa
        public bool Update(KhachHangDTO KH)
        {
            bool res = false;
            var c = db.KhachHangs.FirstOrDefault(x => x.MaKh == KH.MaKH);
            if (c.TenKh != KH.TenKH)
                c.TenKh = KH.TenKH;

            if (c.Email != KH.Email)
                c.Email = KH.Email;

            if (c.Gt != KH.GT)
                c.Gt = KH.GT;
            try
            {
                db.KhachHangs.Update(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception)
            {

                res = false;
            }

            return res;
        }

        //Xóa
        public bool Delete(string KHid)
        {
            bool res = false;
            var c = db.KhachHangs.FirstOrDefault(x => x.MaKh.Trim() == KHid.Trim());

            try
            {
                db.KhachHangs.Remove(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {

                res = false;
            }

            return res;
        }

        //Thêm
        public KhachHangDTO Add(KhachHangDTO KH)
        {
            KhachHangDTO res = new KhachHangDTO();
            var c = new KhachHang();
            c.MaKh = KH.MaKH;
            c.TenKh = KH.TenKH;
            c.Email = KH.Email;
            c.Gt = KH.GT;
            try
            {
                db.KhachHangs.Add(c);
                db.SaveChanges();
                res.MaKH = c.MaKh;
                res.TenKH = c.TenKh;
                res.GT = c.Gt;
                res.Email = c.Email;
            }
            catch (Exception)
            {

                res = null;
            }

            return res;
        }
        //phân trang
        public object GetKHbyPage(int page, int size)
        {
            List<KhachHangDTO> data = new List<KhachHangDTO>();
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
                var ls = db.KhachHangs.ToList();
                var offset = (page - 1) * size;
                var totalRecord = ls.Count();
                var totalPage = (totalRecord % size) == 0 ? (int)(totalRecord / size) : (int)((totalRecord / size) + 1);
                var lst = ls.Skip(offset).Take(size);
                foreach (var c in lst)
                {
                    KhachHangDTO khDto = new KhachHangDTO();
                    khDto.MaKH = c.MaKh;
                    khDto.TenKH = c.TenKh;
                    khDto.GT = c.Gt;
                    khDto.Email = c.Email;
                    data.Add(khDto);
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
    }
}
