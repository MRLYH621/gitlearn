using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoronaDataCenter.Models;

namespace CoronaDataCenter.Business
{
    public class OptimizeManager
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public List<Tb_Optimize_SEModel> GetOptimize()
        {
            List<Tb_Optimize_SEModel> list = new List<Tb_Optimize_SEModel>();
            string sql = "select * from Tb_Optimize_SE ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_Optimize_SEModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_Optimize_SEModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    model.OSE_Type = Convert.ToInt32(string.IsNullOrEmpty(dt.Rows[i]["OSE_Type"].ToString()) ? "0" : dt.Rows[i]["OSE_Type"]);
                    model.OSE_Date = Convert.ToDateTime(string.IsNullOrEmpty(dt.Rows[i]["OSE_Date"].ToString()) ? "1900-01-01" : dt.Rows[i]["OSE_Date"]).ToString("yyyy-MM-dd");
                    model.OSE_Parm_001 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_001"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_001"]);
                    model.OSE_Parm_002 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_002"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_002"]);
                    model.OSE_Parm_003 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_003"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_003"]);
                    model.OSE_Parm_004 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_004"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_004"]);
                    model.OSE_Parm_005 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_005"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_005"]);
                    model.OSE_Parm_006 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_006"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_006"]);
                    model.OSE_Parm_007 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_007"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_007"]);
                    model.OSE_Parm_008 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_008"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_008"]);
                    model.OSE_Parm_009 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_009"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_009"]);
                    model.OSE_Parm_010 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_010"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_010"]);
                    model.OSE_Parm_011 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_011"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_011"]);
                    model.OSE_Parm_012 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_012"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_012"]);
                    model.OSE_Parm_013 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_013"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_013"]);
                    model.OSE_Parm_014 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_014"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_014"]);
                    model.OSE_Parm_015 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_015"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_015"]);
                    model.OSE_Parm_016 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_016"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_016"]);
                    model.OSE_Parm_017 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_017"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_017"]);
                    model.OSE_Parm_018 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_018"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_018"]);
                    model.OSE_Parm_019 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_019"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_019"]);
                    model.OSE_Parm_020 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_020"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_020"]);
                    model.OSE_Parm_021 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_021"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_021"]);
                    model.OSE_Parm_022 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_022"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_022"]);
                    model.OSE_Parm_023 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_023"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_023"]);
                    model.OSE_Parm_024 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_024"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_024"]);

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
        public List<Tb_Optimize_SEModel> GetOptimize(int OSE_Type)
        {
            List<Tb_Optimize_SEModel> list = new List<Tb_Optimize_SEModel>();
            string sql = "select * from Tb_Optimize_SE WHERE OSE_Type = " + OSE_Type + "  ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_Optimize_SEModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_Optimize_SEModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    model.OSE_Type = Convert.ToInt32(string.IsNullOrEmpty(dt.Rows[i]["OSE_Type"].ToString()) ? "0" : dt.Rows[i]["OSE_Type"]);
                    model.OSE_Date = Convert.ToDateTime(string.IsNullOrEmpty(dt.Rows[i]["OSE_Date"].ToString()) ? "1900-01-01" : dt.Rows[i]["OSE_Date"]).ToString("yyyy-MM-dd");
                    model.OSE_Parm_001 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_001"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_001"]);
                    model.OSE_Parm_002 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_002"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_002"]);
                    model.OSE_Parm_003 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_003"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_003"]);
                    model.OSE_Parm_004 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_004"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_004"]);
                    model.OSE_Parm_005 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_005"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_005"]);
                    model.OSE_Parm_006 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_006"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_006"]);
                    model.OSE_Parm_007 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_007"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_007"]);
                    model.OSE_Parm_008 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_008"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_008"]);
                    model.OSE_Parm_009 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_009"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_009"]);
                    model.OSE_Parm_010 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_010"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_010"]);
                    model.OSE_Parm_011 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_011"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_011"]);
                    model.OSE_Parm_012 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_012"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_012"]);
                    model.OSE_Parm_013 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_013"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_013"]);
                    model.OSE_Parm_014 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_014"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_014"]);
                    model.OSE_Parm_015 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_015"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_015"]);
                    model.OSE_Parm_016 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_016"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_016"]);
                    model.OSE_Parm_017 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_017"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_017"]);
                    model.OSE_Parm_018 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_018"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_018"]);
                    model.OSE_Parm_019 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_019"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_019"]);
                    model.OSE_Parm_020 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_020"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_020"]);
                    model.OSE_Parm_021 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_021"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_021"]);
                    model.OSE_Parm_022 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_022"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_022"]);
                    model.OSE_Parm_023 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_023"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_023"]);
                    model.OSE_Parm_024 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_024"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_024"]);

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
        public List<Tb_Optimize_SEModel> GetOptimize(string OSE_Date)
        {
            List<Tb_Optimize_SEModel> list = new List<Tb_Optimize_SEModel>();
            string sql = "select * from Tb_Optimize_SE WHERE OSE_Date = '" + OSE_Date + "'  ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_Optimize_SEModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_Optimize_SEModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    model.OSE_Type = Convert.ToInt32(string.IsNullOrEmpty(dt.Rows[i]["OSE_Type"].ToString()) ? "0" : dt.Rows[i]["OSE_Type"]);
                    model.OSE_Date = Convert.ToDateTime(string.IsNullOrEmpty(dt.Rows[i]["OSE_Date"].ToString()) ? "1900-01-01" : dt.Rows[i]["OSE_Date"]).ToString("yyyy-MM-dd");
                    model.OSE_Parm_001 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_001"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_001"]);
                    model.OSE_Parm_002 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_002"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_002"]);
                    model.OSE_Parm_003 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_003"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_003"]);
                    model.OSE_Parm_004 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_004"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_004"]);
                    model.OSE_Parm_005 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_005"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_005"]);
                    model.OSE_Parm_006 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_006"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_006"]);
                    model.OSE_Parm_007 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_007"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_007"]);
                    model.OSE_Parm_008 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_008"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_008"]);
                    model.OSE_Parm_009 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_009"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_009"]);
                    model.OSE_Parm_010 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_010"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_010"]);
                    model.OSE_Parm_011 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_011"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_011"]);
                    model.OSE_Parm_012 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_012"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_012"]);
                    model.OSE_Parm_013 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_013"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_013"]);
                    model.OSE_Parm_014 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_014"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_014"]);
                    model.OSE_Parm_015 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_015"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_015"]);
                    model.OSE_Parm_016 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_016"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_016"]);
                    model.OSE_Parm_017 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_017"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_017"]);
                    model.OSE_Parm_018 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_018"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_018"]);
                    model.OSE_Parm_019 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_019"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_019"]);
                    model.OSE_Parm_020 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_020"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_020"]);
                    model.OSE_Parm_021 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_021"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_021"]);
                    model.OSE_Parm_022 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_022"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_022"]);
                    model.OSE_Parm_023 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_023"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_023"]);
                    model.OSE_Parm_024 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_024"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_024"]);

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
        public List<Tb_Optimize_SEModel> GetOptimize(int OSE_Type, string OSE_Date)
        {
            List<Tb_Optimize_SEModel> list = new List<Tb_Optimize_SEModel>();
            string sql = "select * from Tb_Optimize_SE WHERE OSE_Type = " + OSE_Type + " AND OSE_Date='" + OSE_Date + "'  ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_Optimize_SEModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_Optimize_SEModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    model.OSE_Type = Convert.ToInt32(string.IsNullOrEmpty(dt.Rows[i]["OSE_Type"].ToString()) ? "0" : dt.Rows[i]["OSE_Type"]);
                    model.OSE_Date = Convert.ToDateTime(string.IsNullOrEmpty(dt.Rows[i]["OSE_Date"].ToString()) ? "1900-01-01" : dt.Rows[i]["OSE_Date"]).ToString("yyyy-MM-dd");
                    model.OSE_Parm_001 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_001"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_001"]);
                    model.OSE_Parm_002 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_002"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_002"]);
                    model.OSE_Parm_003 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_003"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_003"]);
                    model.OSE_Parm_004 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_004"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_004"]);
                    model.OSE_Parm_005 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_005"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_005"]);
                    model.OSE_Parm_006 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_006"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_006"]);
                    model.OSE_Parm_007 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_007"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_007"]);
                    model.OSE_Parm_008 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_008"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_008"]);
                    model.OSE_Parm_009 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_009"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_009"]);
                    model.OSE_Parm_010 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_010"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_010"]);
                    model.OSE_Parm_011 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_011"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_011"]);
                    model.OSE_Parm_012 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_012"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_012"]);
                    model.OSE_Parm_013 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_013"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_013"]);
                    model.OSE_Parm_014 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_014"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_014"]);
                    model.OSE_Parm_015 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_015"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_015"]);
                    model.OSE_Parm_016 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_016"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_016"]);
                    model.OSE_Parm_017 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_017"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_017"]);
                    model.OSE_Parm_018 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_018"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_018"]);
                    model.OSE_Parm_019 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_019"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_019"]);
                    model.OSE_Parm_020 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_020"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_020"]);
                    model.OSE_Parm_021 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_021"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_021"]);
                    model.OSE_Parm_022 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_022"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_022"]);
                    model.OSE_Parm_023 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_023"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_023"]);
                    model.OSE_Parm_024 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["OSE_Parm_024"].ToString()) ? "0" : dt.Rows[i]["OSE_Parm_024"]);

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
        public int InsertOptimize(Tb_Optimize_SEModel model)
        {
            int right = 0;
            string sql = "";
            //1  小于3  添加
            //  1  是否包含  是  修改
            //  2  是否包含  否  添加

            List<Tb_Optimize_SEModel> list = GetOptimize();
            if (list.FindAll(a => a.OSE_Type == model.OSE_Type).Count < 3)
            {
                if (list.FindAll(a => a.OSE_Type == model.OSE_Type && Convert.ToDateTime(a.OSE_Date).ToString("yyyy-M-d") == model.OSE_Date).Count > 0)
                {
                    sql = @"UPDATE Tb_Optimize_SE SET OSE_Type = " + model.OSE_Type + ",OSE_Date = '" + model.OSE_Date + "' ,OSE_Parm_001 = " + model.OSE_Parm_001 +
                          " ,OSE_Parm_002 = " + model.OSE_Parm_002 + ",OSE_Parm_003 = " + model.OSE_Parm_003 + ",OSE_Parm_004 = " + model.OSE_Parm_004 +
                          ",OSE_Parm_005 =" + model.OSE_Parm_005 + ",OSE_Parm_006 = " + model.OSE_Parm_006 + ",OSE_Parm_007 = " + model.OSE_Parm_007 +
                          ",OSE_Parm_008 = " + model.OSE_Parm_008 + ",OSE_Parm_009 = " + model.OSE_Parm_009 + ",OSE_Parm_010 = " + model.OSE_Parm_010 +
                          ",OSE_Parm_011 = " + model.OSE_Parm_011 + ",OSE_Parm_012 =" + model.OSE_Parm_012 + ",OSE_Parm_013 =" + model.OSE_Parm_013 +
                          ",OSE_Parm_014 =" + model.OSE_Parm_014 + ",OSE_Parm_015 = " + model.OSE_Parm_015 + ",OSE_Parm_016 =" + model.OSE_Parm_016 +
                          ",OSE_Parm_017 = " + model.OSE_Parm_017 + ",OSE_Parm_018 =" + model.OSE_Parm_018 + ",OSE_Parm_019 =" + model.OSE_Parm_019 +
                          ",OSE_Parm_020 =" + model.OSE_Parm_020 + ",OSE_Parm_021 =" + model.OSE_Parm_021 + ",OSE_Parm_022 =" + model.OSE_Parm_022 +
                          ",OSE_Parm_023 =" + model.OSE_Parm_023 + ",OSE_Parm_024 =" + model.OSE_Parm_024 + "WHERE OSE_Date='" + model.OSE_Date + "' AnD OSE_Type=" + model.OSE_Type;
                }
                else
                {
                    sql = @"INSERT INTO Tb_Optimize_SE (OSE_Type,OSE_Date,OSE_Parm_001,OSE_Parm_002,OSE_Parm_003,OSE_Parm_004,OSE_Parm_005,OSE_Parm_006,OSE_Parm_007 ,OSE_Parm_008
                       ,OSE_Parm_009,OSE_Parm_010,OSE_Parm_011,OSE_Parm_012,OSE_Parm_013 ,OSE_Parm_014 ,OSE_Parm_015,OSE_Parm_016 ,OSE_Parm_017 ,OSE_Parm_018,OSE_Parm_019,OSE_Parm_020
                       ,OSE_Parm_021,OSE_Parm_022,OSE_Parm_023,OSE_Parm_024) VALUES(" + model.OSE_Type + ",'" + model.OSE_Date + "'," + model.OSE_Parm_001 + "," + model.OSE_Parm_002 + ","
                          + model.OSE_Parm_003 + "," + model.OSE_Parm_004 + "," + model.OSE_Parm_005 + "," + model.OSE_Parm_006 + "," + model.OSE_Parm_007 + "," + model.OSE_Parm_008 +
                           ", " + model.OSE_Parm_009 + "," + model.OSE_Parm_010 + "," + model.OSE_Parm_011 + "," + model.OSE_Parm_012 + "," + model.OSE_Parm_013 + "," + model.OSE_Parm_014 +
                           "," + model.OSE_Parm_015 + "," + model.OSE_Parm_016 + "," + model.OSE_Parm_017 + "," + model.OSE_Parm_018 + "," + model.OSE_Parm_019 + "," + model.OSE_Parm_020 +
                           "," + model.OSE_Parm_021 + "," + model.OSE_Parm_022 + "," + model.OSE_Parm_023 + "," + model.OSE_Parm_024 + ")";
                }
                right = DataAccess.ExecuteNoQueryGetValue(sql);
            }
            //2  大于3  删除添加
            //  1  是否包含  是  修改
            //  2  是否包含  否  删除添加
            else
            {
                List<string> listStr = new List<string>();
                if (list.FindAll(a => a.OSE_Type == model.OSE_Type && Convert.ToDateTime(a.OSE_Date).ToString("yyyy-M-d") == model.OSE_Date).Count > 0)
                {
                    sql = @"UPDATE Tb_Optimize_SE SET OSE_Type = " + model.OSE_Type + ",OSE_Date = '" + model.OSE_Date + "' ,OSE_Parm_001 = " + model.OSE_Parm_001 +
                          " ,OSE_Parm_002 = " + model.OSE_Parm_002 + ",OSE_Parm_003 = " + model.OSE_Parm_003 + ",OSE_Parm_004 = " + model.OSE_Parm_004 +
                          ",OSE_Parm_005 =" + model.OSE_Parm_005 + ",OSE_Parm_006 = " + model.OSE_Parm_006 + ",OSE_Parm_007 = " + model.OSE_Parm_007 +
                          ",OSE_Parm_008 = " + model.OSE_Parm_008 + ",OSE_Parm_009 = " + model.OSE_Parm_009 + ",OSE_Parm_010 = " + model.OSE_Parm_010 +
                          ",OSE_Parm_011 = " + model.OSE_Parm_011 + ",OSE_Parm_012 =" + model.OSE_Parm_012 + ",OSE_Parm_013 =" + model.OSE_Parm_013 +
                          ",OSE_Parm_014 =" + model.OSE_Parm_014 + ",OSE_Parm_015 = " + model.OSE_Parm_015 + ",OSE_Parm_016 =" + model.OSE_Parm_016 +
                          ",OSE_Parm_017 = " + model.OSE_Parm_017 + ",OSE_Parm_018 =" + model.OSE_Parm_018 + ",OSE_Parm_019 =" + model.OSE_Parm_019 +
                          ",OSE_Parm_020 =" + model.OSE_Parm_020 + ",OSE_Parm_021 =" + model.OSE_Parm_021 + ",OSE_Parm_022 =" + model.OSE_Parm_022 +
                          ",OSE_Parm_023 =" + model.OSE_Parm_023 + ",OSE_Parm_024 =" + model.OSE_Parm_024 + "WHERE OSE_Date='" + model.OSE_Date + "' AnD OSE_Type=" + model.OSE_Type;
                    right = DataAccess.ExecuteNoQueryGetValue(sql);
                }
                else
                {
                    string sql1 = "DELETE FROM Tb_Optimize_SE WHERE ID=" + list.Find(a => a.OSE_Type == model.OSE_Type).ID;
                    listStr.Add(sql1);
                    sql = @"INSERT INTO Tb_Optimize_SE (OSE_Type,OSE_Date,OSE_Parm_001,OSE_Parm_002,OSE_Parm_003,OSE_Parm_004,OSE_Parm_005,OSE_Parm_006,OSE_Parm_007 ,OSE_Parm_008
                       ,OSE_Parm_009,OSE_Parm_010,OSE_Parm_011,OSE_Parm_012,OSE_Parm_013 ,OSE_Parm_014 ,OSE_Parm_015,OSE_Parm_016 ,OSE_Parm_017 ,OSE_Parm_018,OSE_Parm_019,OSE_Parm_020
                       ,OSE_Parm_021,OSE_Parm_022,OSE_Parm_023,OSE_Parm_024) VALUES(" + model.OSE_Type + ",'" + model.OSE_Date + "'," + model.OSE_Parm_001 + "," + model.OSE_Parm_002 + ","
                          + model.OSE_Parm_003 + "," + model.OSE_Parm_004 + "," + model.OSE_Parm_005 + "," + model.OSE_Parm_006 + "," + model.OSE_Parm_007 + "," + model.OSE_Parm_008 +
                           ", " + model.OSE_Parm_009 + "," + model.OSE_Parm_010 + "," + model.OSE_Parm_011 + "," + model.OSE_Parm_012 + "," + model.OSE_Parm_013 + "," + model.OSE_Parm_014 +
                           "," + model.OSE_Parm_015 + "," + model.OSE_Parm_016 + "," + model.OSE_Parm_017 + "," + model.OSE_Parm_018 + "," + model.OSE_Parm_019 + "," + model.OSE_Parm_020 +
                           "," + model.OSE_Parm_021 + "," + model.OSE_Parm_022 + "," + model.OSE_Parm_023 + "," + model.OSE_Parm_024 + ")";
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
        public List<string> GetOSEDate()
        {
            List<string> list = new List<string>();
            string sql = @"  SELECT DISTInCT(OSE_Date) FROM Tb_Optimize_SE ORDER BY OSE_Date";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                string str;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    str = dt.Rows[i]["OSE_Date"].ToString();
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
