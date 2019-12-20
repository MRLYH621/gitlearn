using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CoronaDataCenter.Models;

namespace CoronaDataCenter.Business
{
    public class EconomyManager
    {
        #region Tb_EconomyModel
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public List<Tb_EconomyModel> GetEconomy()
        {
            List<Tb_EconomyModel> list = new List<Tb_EconomyModel>();
            string sql = "SELECT E.*,T.P_NAME,T.P_STARTTIME,T.P_ENDTIME FROM Tb_Economy E LEFT JOIN Tb_TOfPrice T ON E.P_ID = T.ID ORDER BY E.ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_EconomyModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_EconomyModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    model.E_Name = dt.Rows[i]["E_Name"].ToString();
                    model.E_Code = dt.Rows[i]["E_Code"].ToString();
                    model.P_ID = Convert.ToInt32(dt.Rows[i]["P_ID"].ToString());

                    model.P_NAME = dt.Rows[i]["P_NAME"].ToString();
                    model.P_STARTTIME = dt.Rows[i]["P_STARTTIME"].ToString();
                    model.P_ENDTIME = dt.Rows[i]["P_ENDTIME"].ToString();

                    model.E_Region = dt.Rows[i]["E_Region"].ToString();
                    model.E_Value = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["E_Value"].ToString()) ? 0 : dt.Rows[i]["E_Value"]);
                    model.E_Unit = dt.Rows[i]["E_Unit"].ToString();

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
        public List<Tb_EconomyModel> GetEconomy(string Name)
        {
            List<Tb_EconomyModel> list = new List<Tb_EconomyModel>();
            string sql = "SELECT E.*,T.P_NAME,T.P_STARTTIME,T.P_ENDTIME FROM Tb_Economy E LEFT JOIN Tb_TOfPrice T ON E.P_ID = T.ID WHERE E.E_Name LIKE '%" + Name + "%' ORDER BY E.ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_EconomyModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_EconomyModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    model.E_Name = dt.Rows[i]["E_Name"].ToString();
                    model.E_Code = dt.Rows[i]["E_Code"].ToString();
                    model.P_ID = Convert.ToInt32(dt.Rows[i]["P_ID"].ToString());

                    model.P_NAME = dt.Rows[i]["P_NAME"].ToString();
                    model.P_STARTTIME = dt.Rows[i]["P_STARTTIME"].ToString();
                    model.P_ENDTIME = dt.Rows[i]["P_ENDTIME"].ToString();

                    model.E_Region = dt.Rows[i]["E_Region"].ToString();
                    model.E_Value = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["E_Value"].ToString()) ? 0 : dt.Rows[i]["E_Value"]);
                    model.E_Unit = dt.Rows[i]["E_Unit"].ToString();

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
        public int InsertEconomy(Tb_EconomyModel model)
        {
            int right = 0;
            string sql = @"INSERT INTO Tb_Economy(E_Name,E_Code,P_ID,E_Region,E_Value,E_Unit)VALUES('" + model.E_Name +
                "','" + model.E_Code + "','" + model.P_ID + "','" + model.E_Region + "'," + model.E_Value + ",'" + model.E_Unit + "')";
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public int UpdateEconomy(Tb_EconomyModel model)
        {
            int right = 0;
            string sql = @"UPDATE Tb_Economy  SET E_Name = '" + model.E_Name + "',E_Code = '" + model.E_Code + "',P_ID='" + model.P_ID +
                "',E_Region='" + model.E_Region + "',E_Value = " + model.E_Value +
                ",E_Unit = '" + model.E_Unit + "' WHERE ID = " + model.ID;
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public int DeleteEconomy(int ID)
        {
            int right = 0;
            string sql = @"DELETE FROM Tb_Economy  WHERE ID = " + ID;
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }

        #endregion

        #region Tb_TOfPriceModel
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public List<Tb_TOfPriceModel> GetTOfPrice()
        {
            List<Tb_TOfPriceModel> list = new List<Tb_TOfPriceModel>();
            string sql = "SELECT * FROM Tb_TOfPrice ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_TOfPriceModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_TOfPriceModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    model.P_Name = dt.Rows[i]["P_Name"].ToString();
                    model.P_StartTime = dt.Rows[i]["P_StartTime"].ToString();
                    model.P_EndTime = dt.Rows[i]["P_EndTime"].ToString();

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
        public int InsertTOfPrice(Tb_TOfPriceModel model)
        {
            int right = 0;
            string sql = @"INSERT INTO Tb_TOfPrice(P_Name,P_StartTime,P_EndTime)VALUES('" + model.P_Name +
                "','" + model.P_StartTime + "','" + model.P_EndTime + "')";
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public int UpdateTOfPrice(Tb_TOfPriceModel model)
        {
            int right = 0;
            string sql = @"UPDATE Tb_TOfPrice SET P_Name = '" + model.P_Name + "',P_StartTime = '" + model.P_StartTime + "',P_EndTime='" + model.P_EndTime +
                "' WHERE ID = " + model.ID;
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public int DeleteTOfPrice(int ID)
        {
            int right = 0;
            string sql = @"DELETE FROM Tb_TOfPrice  WHERE ID = " + ID;
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }

        #endregion
    }
}
