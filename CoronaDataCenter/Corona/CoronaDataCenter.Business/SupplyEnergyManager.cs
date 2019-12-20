using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoronaDataCenter.Models;

namespace CoronaDataCenter.Business
{
    public class SupplyEnergyManager
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public List<Tb_SupplyEnergyModel> GetSupplyEnergy()
        {
            List<Tb_SupplyEnergyModel> list = new List<Tb_SupplyEnergyModel>();
            string sql = "select * from Tb_SupplyEnergy ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_SupplyEnergyModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_SupplyEnergyModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    model.SE_Type = Convert.ToInt32(string.IsNullOrEmpty(dt.Rows[i]["SE_Type"].ToString()) ? "0" : dt.Rows[i]["SE_Type"]);
                    model.SE_Date = Convert.ToDateTime(string.IsNullOrEmpty(dt.Rows[i]["SE_Date"].ToString()) ? "1900-01-01" : dt.Rows[i]["SE_Date"]).ToString("yyyy-MM-dd");
                    model.SE_Parm_001 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_001"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_001"]);
                    model.SE_Parm_002 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_002"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_002"]);
                    model.SE_Parm_003 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_003"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_003"]);
                    model.SE_Parm_004 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_004"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_004"]);
                    model.SE_Parm_005 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_005"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_005"]);
                    model.SE_Parm_006 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_006"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_006"]);
                    model.SE_Parm_007 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_007"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_007"]);
                    model.SE_Parm_008 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_008"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_008"]);
                    model.SE_Parm_009 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_009"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_009"]);
                    model.SE_Parm_010 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_010"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_010"]);
                    model.SE_Parm_011 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_011"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_011"]);
                    model.SE_Parm_012 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_012"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_012"]);
                    model.SE_Parm_013 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_013"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_013"]);
                    model.SE_Parm_014 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_014"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_014"]);
                    model.SE_Parm_015 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_015"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_015"]);
                    model.SE_Parm_016 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_016"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_016"]);
                    model.SE_Parm_017 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_017"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_017"]);
                    model.SE_Parm_018 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_018"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_018"]);
                    model.SE_Parm_019 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_019"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_019"]);
                    model.SE_Parm_020 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_020"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_020"]);
                    model.SE_Parm_021 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_021"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_021"]);
                    model.SE_Parm_022 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_022"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_022"]);
                    model.SE_Parm_023 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_023"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_023"]);
                    model.SE_Parm_024 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_024"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_024"]);

                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 根据能源类型获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public List<Tb_SupplyEnergyModel> GetSupplyEnergy(int SE_Type)
        {
            List<Tb_SupplyEnergyModel> list = new List<Tb_SupplyEnergyModel>();
            string sql = "select * from Tb_SupplyEnergy WHERE SE_Type = " + SE_Type + "  ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_SupplyEnergyModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_SupplyEnergyModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    model.SE_Type = Convert.ToInt32(string.IsNullOrEmpty(dt.Rows[i]["SE_Type"].ToString()) ? "0" : dt.Rows[i]["SE_Type"]);
                    model.SE_Date = Convert.ToDateTime(string.IsNullOrEmpty(dt.Rows[i]["SE_Date"].ToString()) ? "1900-01-01" : dt.Rows[i]["SE_Date"]).ToString("yyyy-MM-dd");
                    model.SE_Parm_001 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_001"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_001"]);
                    model.SE_Parm_002 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_002"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_002"]);
                    model.SE_Parm_003 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_003"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_003"]);
                    model.SE_Parm_004 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_004"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_004"]);
                    model.SE_Parm_005 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_005"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_005"]);
                    model.SE_Parm_006 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_006"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_006"]);
                    model.SE_Parm_007 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_007"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_007"]);
                    model.SE_Parm_008 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_008"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_008"]);
                    model.SE_Parm_009 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_009"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_009"]);
                    model.SE_Parm_010 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_010"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_010"]);
                    model.SE_Parm_011 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_011"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_011"]);
                    model.SE_Parm_012 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_012"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_012"]);
                    model.SE_Parm_013 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_013"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_013"]);
                    model.SE_Parm_014 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_014"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_014"]);
                    model.SE_Parm_015 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_015"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_015"]);
                    model.SE_Parm_016 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_016"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_016"]);
                    model.SE_Parm_017 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_017"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_017"]);
                    model.SE_Parm_018 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_018"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_018"]);
                    model.SE_Parm_019 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_019"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_019"]);
                    model.SE_Parm_020 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_020"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_020"]);
                    model.SE_Parm_021 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_021"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_021"]);
                    model.SE_Parm_022 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_022"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_022"]);
                    model.SE_Parm_023 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_023"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_023"]);
                    model.SE_Parm_024 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_024"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_024"]);

                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 根据日期获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public List<Tb_SupplyEnergyModel> GetSupplyEnergy(string SE_Date)
        {
            List<Tb_SupplyEnergyModel> list = new List<Tb_SupplyEnergyModel>();
            string sql = "select * from Tb_SupplyEnergy WHERE SE_Date = '" + SE_Date + "'  ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_SupplyEnergyModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_SupplyEnergyModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    model.SE_Type = Convert.ToInt32(string.IsNullOrEmpty(dt.Rows[i]["SE_Type"].ToString()) ? "0" : dt.Rows[i]["SE_Type"]);
                    model.SE_Date = Convert.ToDateTime(string.IsNullOrEmpty(dt.Rows[i]["SE_Date"].ToString()) ? "1900-01-01" : dt.Rows[i]["SE_Date"]).ToString("yyyy-MM-dd");
                    model.SE_Parm_001 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_001"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_001"]);
                    model.SE_Parm_002 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_002"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_002"]);
                    model.SE_Parm_003 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_003"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_003"]);
                    model.SE_Parm_004 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_004"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_004"]);
                    model.SE_Parm_005 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_005"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_005"]);
                    model.SE_Parm_006 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_006"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_006"]);
                    model.SE_Parm_007 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_007"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_007"]);
                    model.SE_Parm_008 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_008"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_008"]);
                    model.SE_Parm_009 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_009"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_009"]);
                    model.SE_Parm_010 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_010"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_010"]);
                    model.SE_Parm_011 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_011"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_011"]);
                    model.SE_Parm_012 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_012"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_012"]);
                    model.SE_Parm_013 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_013"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_013"]);
                    model.SE_Parm_014 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_014"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_014"]);
                    model.SE_Parm_015 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_015"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_015"]);
                    model.SE_Parm_016 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_016"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_016"]);
                    model.SE_Parm_017 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_017"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_017"]);
                    model.SE_Parm_018 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_018"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_018"]);
                    model.SE_Parm_019 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_019"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_019"]);
                    model.SE_Parm_020 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_020"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_020"]);
                    model.SE_Parm_021 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_021"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_021"]);
                    model.SE_Parm_022 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_022"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_022"]);
                    model.SE_Parm_023 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_023"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_023"]);
                    model.SE_Parm_024 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_024"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_024"]);

                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 根据能源类型、日期获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public List<Tb_SupplyEnergyModel> GetSupplyEnergy(int SE_Type,string SE_Date)
        {
            List<Tb_SupplyEnergyModel> list = new List<Tb_SupplyEnergyModel>();
            string sql = "select * from Tb_SupplyEnergy WHERE SE_Type = " + SE_Type + " AND SE_Date='" + SE_Date + "'  ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_SupplyEnergyModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_SupplyEnergyModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    model.SE_Type = Convert.ToInt32(string.IsNullOrEmpty(dt.Rows[i]["SE_Type"].ToString()) ? "0" : dt.Rows[i]["SE_Type"]);
                    model.SE_Date = Convert.ToDateTime(string.IsNullOrEmpty(dt.Rows[i]["SE_Date"].ToString()) ? "1900-01-01" : dt.Rows[i]["SE_Date"]).ToString("yyyy-MM-dd");
                    model.SE_Parm_001 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_001"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_001"]);
                    model.SE_Parm_002 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_002"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_002"]);
                    model.SE_Parm_003 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_003"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_003"]);
                    model.SE_Parm_004 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_004"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_004"]);
                    model.SE_Parm_005 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_005"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_005"]);
                    model.SE_Parm_006 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_006"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_006"]);
                    model.SE_Parm_007 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_007"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_007"]);
                    model.SE_Parm_008 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_008"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_008"]);
                    model.SE_Parm_009 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_009"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_009"]);
                    model.SE_Parm_010 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_010"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_010"]);
                    model.SE_Parm_011 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_011"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_011"]);
                    model.SE_Parm_012 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_012"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_012"]);
                    model.SE_Parm_013 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_013"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_013"]);
                    model.SE_Parm_014 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_014"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_014"]);
                    model.SE_Parm_015 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_015"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_015"]);
                    model.SE_Parm_016 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_016"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_016"]);
                    model.SE_Parm_017 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_017"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_017"]);
                    model.SE_Parm_018 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_018"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_018"]);
                    model.SE_Parm_019 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_019"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_019"]);
                    model.SE_Parm_020 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_020"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_020"]);
                    model.SE_Parm_021 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_021"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_021"]);
                    model.SE_Parm_022 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_022"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_022"]);
                    model.SE_Parm_023 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_023"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_023"]);
                    model.SE_Parm_024 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["SE_Parm_024"].ToString()) ? "0" : dt.Rows[i]["SE_Parm_024"]);

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
        public int InsertSupplyEnergy(Tb_SupplyEnergyModel model)
        {
            int right = 0;
            string sql = "";
              //1  小于3  添加
              //  1  是否包含  是  修改
              //  2  是否包含  否  添加

            List<Tb_SupplyEnergyModel> list = GetSupplyEnergy();
            if (list.FindAll(a => a.SE_Type == model.SE_Type).Count < 3)
            {
                if (list.FindAll(a => a.SE_Type == model.SE_Type && Convert.ToDateTime(a.SE_Date).ToString("yyyy-M-d") == model.SE_Date).Count > 0)
                {
                    sql = @"UPDATE Tb_SupplyEnergy SET SE_Type = " + model.SE_Type + ",SE_Date = '" + model.SE_Date + "' ,SE_Parm_001 = " + model.SE_Parm_001 +
                          " ,SE_Parm_002 = " + model.SE_Parm_002 + ",SE_Parm_003 = " + model.SE_Parm_003 + ",SE_Parm_004 = " + model.SE_Parm_004 +
                          ",SE_Parm_005 =" + model.SE_Parm_005 + ",SE_Parm_006 = " + model.SE_Parm_006 + ",SE_Parm_007 = " + model.SE_Parm_007 +
                          ",SE_Parm_008 = " + model.SE_Parm_008 + ",SE_Parm_009 = " + model.SE_Parm_009 + ",SE_Parm_010 = " + model.SE_Parm_010 +
                          ",SE_Parm_011 = " + model.SE_Parm_011 + ",SE_Parm_012 =" + model.SE_Parm_012 + ",SE_Parm_013 =" + model.SE_Parm_013 +
                          ",SE_Parm_014 =" + model.SE_Parm_014 + ",SE_Parm_015 = " + model.SE_Parm_015 + ",SE_Parm_016 =" + model.SE_Parm_016 +
                          ",SE_Parm_017 = " + model.SE_Parm_017 + ",SE_Parm_018 =" + model.SE_Parm_018 + ",SE_Parm_019 =" + model.SE_Parm_019 +
                          ",SE_Parm_020 =" + model.SE_Parm_020 + ",SE_Parm_021 =" + model.SE_Parm_021 + ",SE_Parm_022 =" + model.SE_Parm_022 +
                          ",SE_Parm_023 =" + model.SE_Parm_023 + ",SE_Parm_024 =" + model.SE_Parm_024 + "WHERE SE_Date='" + model.SE_Date + "' AnD SE_Type=" + model.SE_Type;
                }
                else
                {
                    sql = @"INSERT INTO Tb_SupplyEnergy (SE_Type,SE_Date,SE_Parm_001,SE_Parm_002,SE_Parm_003,SE_Parm_004,SE_Parm_005,SE_Parm_006,SE_Parm_007 ,SE_Parm_008
                       ,SE_Parm_009,SE_Parm_010,SE_Parm_011,SE_Parm_012,SE_Parm_013 ,SE_Parm_014 ,SE_Parm_015,SE_Parm_016 ,SE_Parm_017 ,SE_Parm_018,SE_Parm_019,SE_Parm_020
                       ,SE_Parm_021,SE_Parm_022,SE_Parm_023,SE_Parm_024) VALUES(" + model.SE_Type + ",'" + model.SE_Date + "'," + model.SE_Parm_001 + "," + model.SE_Parm_002 + ","
                          + model.SE_Parm_003 + "," + model.SE_Parm_004 + "," + model.SE_Parm_005 + "," + model.SE_Parm_006 + "," + model.SE_Parm_007 + "," + model.SE_Parm_008 +
                           ", " + model.SE_Parm_009 + "," + model.SE_Parm_010 + "," + model.SE_Parm_011 + "," + model.SE_Parm_012 + "," + model.SE_Parm_013 + "," + model.SE_Parm_014 +
                           "," + model.SE_Parm_015 + "," + model.SE_Parm_016 + "," + model.SE_Parm_017 + "," + model.SE_Parm_018 + "," + model.SE_Parm_019 + "," + model.SE_Parm_020 +
                           "," + model.SE_Parm_021 + "," + model.SE_Parm_022 + "," + model.SE_Parm_023 + "," + model.SE_Parm_024 + ")";
                }
                right = DataAccess.ExecuteNoQueryGetValue(sql);
            }              
              //2  大于3  删除添加
              //  1  是否包含  是  修改
              //  2  是否包含  否  删除添加
            else
            {
                List<string> listStr = new List<string>();
                if (list.FindAll(a => a.SE_Type == model.SE_Type && Convert.ToDateTime(a.SE_Date).ToString("yyyy-M-d") == model.SE_Date).Count > 0)
                {
                    sql = @"UPDATE Tb_SupplyEnergy SET SE_Type = " + model.SE_Type + ",SE_Date = '" + model.SE_Date + "' ,SE_Parm_001 = " + model.SE_Parm_001 +
                          " ,SE_Parm_002 = " + model.SE_Parm_002 + ",SE_Parm_003 = " + model.SE_Parm_003 + ",SE_Parm_004 = " + model.SE_Parm_004 +
                          ",SE_Parm_005 =" + model.SE_Parm_005 + ",SE_Parm_006 = " + model.SE_Parm_006 + ",SE_Parm_007 = " + model.SE_Parm_007 +
                          ",SE_Parm_008 = " + model.SE_Parm_008 + ",SE_Parm_009 = " + model.SE_Parm_009 + ",SE_Parm_010 = " + model.SE_Parm_010 +
                          ",SE_Parm_011 = " + model.SE_Parm_011 + ",SE_Parm_012 =" + model.SE_Parm_012 + ",SE_Parm_013 =" + model.SE_Parm_013 +
                          ",SE_Parm_014 =" + model.SE_Parm_014 + ",SE_Parm_015 = " + model.SE_Parm_015 + ",SE_Parm_016 =" + model.SE_Parm_016 +
                          ",SE_Parm_017 = " + model.SE_Parm_017 + ",SE_Parm_018 =" + model.SE_Parm_018 + ",SE_Parm_019 =" + model.SE_Parm_019 +
                          ",SE_Parm_020 =" + model.SE_Parm_020 + ",SE_Parm_021 =" + model.SE_Parm_021 + ",SE_Parm_022 =" + model.SE_Parm_022 +
                          ",SE_Parm_023 =" + model.SE_Parm_023 + ",SE_Parm_024 =" + model.SE_Parm_024 + "WHERE SE_Date='" + model.SE_Date + "' AnD SE_Type=" + model.SE_Type;
                    right = DataAccess.ExecuteNoQueryGetValue(sql);
                }
                else
                {
                    string sql1 = "DELETE FROM Tb_SupplyEnergy WHERE ID=" + list.Find(a => a.SE_Type == model.SE_Type).ID;
                    listStr.Add(sql1);
                    sql = @"INSERT INTO Tb_SupplyEnergy (SE_Type,SE_Date,SE_Parm_001,SE_Parm_002,SE_Parm_003,SE_Parm_004,SE_Parm_005,SE_Parm_006,SE_Parm_007 ,SE_Parm_008
                       ,SE_Parm_009,SE_Parm_010,SE_Parm_011,SE_Parm_012,SE_Parm_013 ,SE_Parm_014 ,SE_Parm_015,SE_Parm_016 ,SE_Parm_017 ,SE_Parm_018,SE_Parm_019,SE_Parm_020
                       ,SE_Parm_021,SE_Parm_022,SE_Parm_023,SE_Parm_024) VALUES(" + model.SE_Type + ",'" + model.SE_Date + "'," + model.SE_Parm_001 + "," + model.SE_Parm_002 + ","
                          + model.SE_Parm_003 + "," + model.SE_Parm_004 + "," + model.SE_Parm_005 + "," + model.SE_Parm_006 + "," + model.SE_Parm_007 + "," + model.SE_Parm_008 +
                           ", " + model.SE_Parm_009 + "," + model.SE_Parm_010 + "," + model.SE_Parm_011 + "," + model.SE_Parm_012 + "," + model.SE_Parm_013 + "," + model.SE_Parm_014 +
                           "," + model.SE_Parm_015 + "," + model.SE_Parm_016 + "," + model.SE_Parm_017 + "," + model.SE_Parm_018 + "," + model.SE_Parm_019 + "," + model.SE_Parm_020 +
                           "," + model.SE_Parm_021 + "," + model.SE_Parm_022 + "," + model.SE_Parm_023 + "," + model.SE_Parm_024 + ")";
                    listStr.Add(sql);
                    if (DataAccess.GetTransaction(listStr))
                    {
                        right = 1;
                    }
                    else
                    {
                        right = 0;
                    }
                }
            }

            return right;
        }

        /// <summary>
        /// 获取日期
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public List<string> GetDate() 
        {
            List<string> list = new List<string>();
            string sql = @"  SELECT DISTInCT(SE_Date) FROM Tb_SupplyEnergy ORDER BY SE_Date";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                string str;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    str = dt.Rows[i]["SE_Date"].ToString();
                    if (!string.IsNullOrEmpty(str))
                    {
                        try
                        {

                            list.Add(Convert.ToDateTime(str).ToString("yyyy-MM-dd"));
                        }
                        catch
                        {
                            list.Add(str);
                        }
                    }
                }
            }

            return list;
        }

    }
}
