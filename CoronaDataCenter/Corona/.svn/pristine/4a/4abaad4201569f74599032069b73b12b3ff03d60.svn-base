using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CoronaDataCenter.Models;

namespace CoronaDataCenter.Business
{
    public class DatumManager
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public List<Tb_DatumModel> GetDatum()
        {
            List<Tb_DatumModel> list = new List<Tb_DatumModel>();
            string sql = "select * from Tb_Datum ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_DatumModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_DatumModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    model.D_Name = dt.Rows[i]["D_Name"].ToString();
                    model.D_Code = dt.Rows[i]["D_Code"].ToString();
                    model.D_Value = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["D_Value"].ToString()) ? 0 : dt.Rows[i]["D_Value"]);
                    model.D_Unit = dt.Rows[i]["D_Unit"].ToString();

                    list.Add(model);
                }
            }
            return list;
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public List<Tb_DatumModel> GetDatum(string Name)
        {
            List<Tb_DatumModel> list = new List<Tb_DatumModel>();
            string sql = "select * from Tb_Datum WHERE D_Name LIKE '%" + Name + "%' ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_DatumModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_DatumModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    model.D_Name = dt.Rows[i]["D_Name"].ToString();
                    model.D_Code = dt.Rows[i]["D_Code"].ToString();
                    model.D_Value = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["D_Value"].ToString()) ? 0 : dt.Rows[i]["D_Value"]);
                    model.D_Unit = dt.Rows[i]["D_Unit"].ToString();

                    list.Add(model);
                }
            }
            return list;
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public int InsertDatum(Tb_DatumModel model)
        {
            int right = 0;
            string sql = @"INSERT INTO Tb_Datum(D_Name,D_Code,D_Value,D_Unit)VALUES('" + model.D_Name +
                "','" + model.D_Code + "'," + model.D_Value + ",'" + model.D_Unit + "')";
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public int UpdateDatum(Tb_DatumModel model)
        {
            int right = 0;
            string sql = @"UPDATE Tb_Datum  SET D_Name = '" + model.D_Name + "',D_Code = '" + model.D_Code + "',D_Value = " + model.D_Value +
                ",D_Unit = '" + model.D_Unit + "' WHERE ID = " + model.ID;
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public int DeleteDatum(int ID)
        {
            int right = 0;
            string sql = @"DELETE FROM Tb_Datum  WHERE ID = " + ID;
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }
    }
}
