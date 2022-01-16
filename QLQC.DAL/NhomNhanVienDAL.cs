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
    public class NhomNhanVienDAL
    {
        private qlQcaoContext db;
        public NhomNhanVienDAL()
        {
            db = new qlQcaoContext();
        }
        public IList<NhomNhanVienDTO> GetAll()
        {
            List<NhomNhanVienDTO> lst = new List<NhomNhanVienDTO>();
            try
            {
                var ds = db.NhomNvs.ToList();
                foreach (var d in ds)
                {
                    NhomNhanVienDTO a = new NhomNhanVienDTO();
                    a.MaNT = d.MaNT;
                    a.TenNhom = d.TenNhom;
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
        public bool Update(NhomNhanVienDTO nnv)
        {
            bool res = false;
            var c = db.NhomNvs.FirstOrDefault(x => x.MaNhom == nnv.MaNhom);
            if (c.TenNhom != nnv.TenNhom)
            {
                c.TenNhom = nnv.TenNhom;
            }
            if (c.MaNT != nnv.MaNT)
                c.MaNT = nnv.MaNT;
            if (c.MaNhom != nnv.MaNhom)
                c.MaNhom = nnv.MaNhom;
            try
            {
                db.NhomNvs.Update(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(string nnv)
        {
            bool res = false;
            var c = db.NhomNvs.FirstOrDefault(x => x.MaNhom == nnv);
            try
            {
                db.NhomNvs.Remove(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public NhomNhanVienDTO Add(NhomNhanVienDTO nnv)
        {
            NhomNhanVienDTO res = new NhomNhanVienDTO();
            var c = new NhomNv();
            c.TenNhom = nnv.TenNhom;
            c.MaNhom = nnv.MaNhom;
            c.MaNT = nnv.MaNT;
            try
            {
                db.NhomNvs.Add(c);
                db.SaveChanges();
                res.MaNhom = c.MaNhom;
                res.MaNT = c.MaNT;
                res.TenNhom = c.TenNhom;
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
        public List<NhomNhanVienStatic> getNhomNhanVien()
        {
            var res = new List<NhomNhanVienStatic>();
            string cnStr = "Server=localhost;Database=qlQcao;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(cnStr);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "sp_QuangCaoOfNhomNhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                var list = new List<NhomNhanVienStatic>();
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        var sts = new NhomNhanVienStatic
                        {
                            MaNhom = row["MaNhom"].ToString(),
                            SoQuangCao = int.Parse(row["SoQuangCao"].ToString())
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
