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
    public class NhanVienDAL
    {
        private qlQcaoContext db;
        public NhanVienDAL()
        {
            db = new qlQcaoContext();
        }
        public IList<NhanVienDTO> GetAll()
        {
            List<NhanVienDTO> lst = new List<NhanVienDTO>();
            try
            {
                var ds = db.NhanViens.ToList();
                foreach (var d in ds)
                {
                    NhanVienDTO a = new NhanVienDTO();
                    a.MaNv = d.MaNv;
                    a.TenNv = d.TenNv;
                    a.MaNhom = d.MaNhom;
                    a.NgSinh = d.NgSinh;
                    a.NgVaoLam = d.NgVaoLam;
                    a.Email = d.Email;
                    a.Gt = d.Gt;
                    lst.Add(a);
                }
            }
            catch (Exception ex)
            {
                lst = null;
            }
            return lst;
        }
        public object GetNhanVienByPage(int page, int size)
        {
            List<NhanVienDTO> datanv = new List<NhanVienDTO>();
            var res = new
            {
                Data = datanv,
                TotalRecordNv = 0,
                TotalPageNv = 0,
                Page = page,
                Size = size
            };
            try
            {
                var ds = db.NhanViens.ToList();
                var offsetnv = (page - 1) * size;
                var totalRecordNv = ds.Count();
                int totalPageNv = (totalRecordNv % size) == 0 ? (int)(totalRecordNv / size) : (int)((totalRecordNv / size) + 1);
                var lsnv = ds.Skip(offsetnv).Take(size);
                foreach (var d in lsnv)
                {
                    NhanVienDTO a = new NhanVienDTO();
                    a.MaNv = d.MaNv;
                    a.TenNv = d.TenNv;
                    a.MaNhom = d.MaNhom;
                    a.NgSinh = d.NgSinh;
                    a.NgVaoLam = d.NgVaoLam;
                    a.Email = d.Email;
                    a.Gt = d.Gt;
                    datanv.Add(a);
                }
                res = new
                {
                    Data = datanv,
                    TotalRecordNv = totalRecordNv,
                    TotalPageNv = totalPageNv,
                    Page = page,
                    Size = size
                };
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;
        }

        public bool Update(NhanVienDTO nv)
        {
            bool res = false;
            var c = db.NhanViens.FirstOrDefault(x => x.MaNv == nv.MaNv);
            if (c.TenNv != nv.TenNv)
            {
                c.TenNv = nv.TenNv;
            }
            if (c.MaNhom != nv.MaNhom)
                c.MaNhom = nv.MaNhom;
            if (c.Email != nv.Email)
                c.Email = nv.Email;
            if (c.MaNv != nv.MaNv)
                c.MaNv = nv.MaNv;
            if (c.NgVaoLam != nv.NgVaoLam)
                c.NgVaoLam = nv.NgVaoLam;
            if (c.NgSinh != nv.NgSinh)
                c.NgSinh = nv.NgSinh;
            if (c.Gt != nv.Gt)
                c.Gt = nv.Gt;
            try
            {
                db.NhanViens.Update(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(string nv)
        {
            bool res = false;
            var c = db.NhanViens.FirstOrDefault(x => x.MaNv == nv);
            try
            {
                db.NhanViens.Remove(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public NhanVienDTO Add(NhanVienDTO nv)
        {
            NhanVienDTO res = new NhanVienDTO();
            var c = new NhanVien();
            c.TenNv = nv.TenNv;
            c.MaNhom = nv.MaNhom;
            c.Email = nv.Email;
            c.MaNv = nv.MaNv;
            c.NgVaoLam = nv.NgVaoLam;
            c.NgSinh = nv.NgSinh;
            c.Gt = nv.Gt;
            try
            {
                db.NhanViens.Add(c);
                db.SaveChanges();
                res.MaNv = c.MaNv;
                res.TenNv = c.TenNv;
                res.MaNhom = c.MaNhom;
                res.Email = c.Email;
                res.NgSinh = c.NgSinh;
                res.NgVaoLam = c.NgVaoLam;
                res.Gt = c.Gt;

            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
        public List<NhanVienStatic1> getNhanVien1()
        {
            var res = new List<NhanVienStatic1>();
            string cnStr = "Server=localhost;Database=qlQcao;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(cnStr);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "sp_SoNhanVienVaoTheoNam";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                var list = new List<NhanVienStatic1>();
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        var sts = new NhanVienStatic1
                        {
                            Year = row["Year"].ToString(),
                            NumberEmpl = int.Parse(row["NumberEmpl"].ToString())
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
        public List<NhanVienStatic2> getNhanVien2()
        {
            var res = new List<NhanVienStatic2>();
            string cnStr = "Server=localhost;Database=qlQcao;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(cnStr);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "sp_SoNhanVienTheoNhom";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                var list = new List<NhanVienStatic2>();
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        var sts = new NhanVienStatic2
                        {
                            MaNhom = row["MaNhom"].ToString(),
                            NumberEmpl = int.Parse(row["NumberEmpl"].ToString())
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
