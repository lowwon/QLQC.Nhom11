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
    public class QuangCaoDAL
    {
        private qlQcaoContext db;
        public QuangCaoDAL()
        {
            db = new qlQcaoContext();
        }
        public IList<QuangCaoDTO> GetAll()
        {
            List<QuangCaoDTO> lst = new List<QuangCaoDTO>();
            try
            {
                var ds = db.QuangCaos.ToList();
                foreach (var d in ds)
                {
                    QuangCaoDTO a = new QuangCaoDTO();
                    a.MaQc = d.MaQc;
                    a.MaKh = d.MaKh;
                    a.YeuCau = d.YeuCau;
                    a.SoTien = d.SoTien;
                    a.NgBd = d.NgBd;
                    a.NgKt = d.NgKt;
                    a.MaNhom = d.MaNhom;
                    lst.Add(a);
                }
            }
            catch (Exception ex)
            {
                lst = null;
            }
            return lst;
        }
        public object GetQuangCaoByPage(int page, int size)
        {
            List<QuangCaoDTO> data = new List<QuangCaoDTO>();
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
                var lst2 = db.QuangCaos.ToList();
                var offset = (page - 1) * size;
                var totalRecord = lst2.Count;
                int totalPage = (totalRecord % size) == 0 ? (int)(totalRecord / size) : (int)((totalRecord / size) + 1);
                var lst = lst2.Skip(offset).Take(size);
                foreach (var d in lst)
                {
                    QuangCaoDTO a = new QuangCaoDTO();
                    a.MaQc = d.MaQc;
                    a.MaKh = d.MaKh;
                    a.YeuCau = d.YeuCau;
                    a.SoTien = d.SoTien;
                    a.NgBd = d.NgBd;
                    a.NgKt = d.NgKt;
                    a.MaNhom = d.MaNhom;
                    data.Add(a);
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
            catch (Exception ex)
            {
                res = null;
            }
            return res;
        }
        public bool Update(QuangCaoDTO qc)
        {
            bool res = false;
            var c = db.QuangCaos.FirstOrDefault(x => x.MaQc == qc.MaQc);
            if (c.NgBd != qc.NgBd)
            {
                c.NgBd = qc.NgBd;
            }
            if (c.NgKt != qc.NgKt)
            {
                c.NgKt = qc.NgKt;
            }
            if (c.MaKh != qc.MaKh)
            {
                c.MaKh = qc.MaKh;
            }
            if (c.MaNhom != qc.MaNhom)
            {
                c.MaNhom = qc.MaNhom;
            }
            if (c.YeuCau != qc.YeuCau)
            {
                c.YeuCau = qc.YeuCau;
            }
            if (c.SoTien != qc.SoTien)
            {
                c.SoTien = qc.SoTien;
            }
            try
            {
                db.QuangCaos.Update(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(string mqc)
        {
            bool res = false;
            var c = db.QuangCaos.FirstOrDefault(x => x.MaQc.Trim() == mqc.Trim());
            try
            {
                db.QuangCaos.Remove(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public QuangCaoDTO Add(QuangCaoDTO qc)
        {
            QuangCaoDTO res = new QuangCaoDTO();
            var c = new QuangCao();
            c.MaQc = qc.MaQc;
            c.NgBd = qc.NgBd;

            c.NgKt = qc.NgKt;

            c.MaKh = qc.MaKh;

            c.MaNhom = qc.MaNhom;

            c.YeuCau = qc.YeuCau;

            c.SoTien = qc.SoTien;
            try
            {
                db.QuangCaos.Add(c);
                db.SaveChanges();
                res.MaQc = c.MaQc;
                res.NgBd = c.NgBd;

                res.NgKt = c.NgKt;

                res.MaKh = c.MaKh;

                res.MaNhom = c.MaNhom;

                res.YeuCau = c.YeuCau;

                res.SoTien = c.SoTien;
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;
        }
        public List<QuangCaoStatic> getQuangCao()
        {
            var res = new List<QuangCaoStatic>();
            string cnStr = "Server=localhost;Database=qlQcao;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(cnStr);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "sp_DemSoQuangCaoTrongNam";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                var list = new List<QuangCaoStatic>();
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        var sts = new QuangCaoStatic
                        {
                            Year = row["Year"].ToString(),
                            Number = int.Parse(row["Number"].ToString()),
                            SumPrice = int.Parse(row["SumPrice"].ToString()) / 1000000
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
