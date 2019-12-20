using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoronaDataCenter.Models;

namespace CoronaDataCenter.Business
{
    public class LoadManager
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public List<Tb_LoadModel> GetLoad()
        {
            List<Tb_LoadModel> list = new List<Tb_LoadModel>();
            string sql = "select * from Tb_Load ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_LoadModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_LoadModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    model.Load_Type = Convert.ToInt32(string.IsNullOrEmpty(dt.Rows[i]["Load_Type"].ToString()) ? "0" : dt.Rows[i]["Load_Type"]);
                    model.Load_Date = Convert.ToDateTime(string.IsNullOrEmpty(dt.Rows[i]["Load_Date"].ToString()) ? "1900-01-01" : dt.Rows[i]["Load_Date"]).ToString("yyyy-MM-dd");
                    model.Load_Parm_001 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_001"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_001"]);
                    model.Load_Parm_002 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_002"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_002"]);
                    model.Load_Parm_003 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_003"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_003"]);
                    model.Load_Parm_004 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_004"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_004"]);
                    model.Load_Parm_005 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_005"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_005"]);
                    model.Load_Parm_006 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_006"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_006"]);
                    model.Load_Parm_007 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_007"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_007"]);
                    model.Load_Parm_008 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_008"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_008"]);
                    model.Load_Parm_009 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_009"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_009"]);
                    model.Load_Parm_010 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_010"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_010"]);
                    model.Load_Parm_011 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_011"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_011"]);
                    model.Load_Parm_012 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_012"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_012"]);
                    model.Load_Parm_013 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_013"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_013"]);
                    model.Load_Parm_014 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_014"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_014"]);
                    model.Load_Parm_015 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_015"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_015"]);
                    model.Load_Parm_016 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_016"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_016"]);
                    model.Load_Parm_017 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_017"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_017"]);
                    model.Load_Parm_018 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_018"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_018"]);
                    model.Load_Parm_019 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_019"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_019"]);
                    model.Load_Parm_020 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_020"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_020"]);
                    model.Load_Parm_021 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_021"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_021"]);
                    model.Load_Parm_022 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_022"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_022"]);
                    model.Load_Parm_023 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_023"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_023"]);
                    model.Load_Parm_024 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_024"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_024"]);

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
        public List<Tb_LoadModel> GetLoad(int Load_Type)
        {
            List<Tb_LoadModel> list = new List<Tb_LoadModel>();
            string sql = "select * from Tb_Load WHERE Load_Type = " + Load_Type + "  ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_LoadModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_LoadModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    model.Load_Type = Convert.ToInt32(string.IsNullOrEmpty(dt.Rows[i]["Load_Type"].ToString()) ? "0" : dt.Rows[i]["Load_Type"]);
                    model.Load_Date = Convert.ToDateTime(string.IsNullOrEmpty(dt.Rows[i]["Load_Date"].ToString()) ? "1900-01-01" : dt.Rows[i]["Load_Date"]).ToString("yyyy-MM-dd");
                    model.Load_Parm_001 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_001"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_001"]);
                    model.Load_Parm_002 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_002"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_002"]);
                    model.Load_Parm_003 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_003"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_003"]);
                    model.Load_Parm_004 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_004"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_004"]);
                    model.Load_Parm_005 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_005"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_005"]);
                    model.Load_Parm_006 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_006"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_006"]);
                    model.Load_Parm_007 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_007"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_007"]);
                    model.Load_Parm_008 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_008"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_008"]);
                    model.Load_Parm_009 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_009"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_009"]);
                    model.Load_Parm_010 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_010"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_010"]);
                    model.Load_Parm_011 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_011"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_011"]);
                    model.Load_Parm_012 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_012"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_012"]);
                    model.Load_Parm_013 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_013"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_013"]);
                    model.Load_Parm_014 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_014"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_014"]);
                    model.Load_Parm_015 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_015"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_015"]);
                    model.Load_Parm_016 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_016"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_016"]);
                    model.Load_Parm_017 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_017"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_017"]);
                    model.Load_Parm_018 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_018"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_018"]);
                    model.Load_Parm_019 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_019"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_019"]);
                    model.Load_Parm_020 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_020"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_020"]);
                    model.Load_Parm_021 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_021"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_021"]);
                    model.Load_Parm_022 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_022"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_022"]);
                    model.Load_Parm_023 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_023"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_023"]);
                    model.Load_Parm_024 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_024"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_024"]);

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
        public List<Tb_LoadModel> GetLoad(string Load_Date)
        {
            List<Tb_LoadModel> list = new List<Tb_LoadModel>();
            string sql = "select * from Tb_Load WHERE Load_Date = '" + Load_Date + "'  ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_LoadModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_LoadModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    model.Load_Type = Convert.ToInt32(string.IsNullOrEmpty(dt.Rows[i]["Load_Type"].ToString()) ? "0" : dt.Rows[i]["Load_Type"]);
                    model.Load_Date = Convert.ToDateTime(string.IsNullOrEmpty(dt.Rows[i]["Load_Date"].ToString()) ? "1900-01-01" : dt.Rows[i]["Load_Date"]).ToString("yyyy-MM-dd");
                    model.Load_Parm_001 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_001"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_001"]);
                    model.Load_Parm_002 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_002"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_002"]);
                    model.Load_Parm_003 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_003"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_003"]);
                    model.Load_Parm_004 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_004"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_004"]);
                    model.Load_Parm_005 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_005"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_005"]);
                    model.Load_Parm_006 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_006"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_006"]);
                    model.Load_Parm_007 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_007"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_007"]);
                    model.Load_Parm_008 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_008"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_008"]);
                    model.Load_Parm_009 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_009"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_009"]);
                    model.Load_Parm_010 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_010"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_010"]);
                    model.Load_Parm_011 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_011"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_011"]);
                    model.Load_Parm_012 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_012"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_012"]);
                    model.Load_Parm_013 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_013"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_013"]);
                    model.Load_Parm_014 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_014"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_014"]);
                    model.Load_Parm_015 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_015"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_015"]);
                    model.Load_Parm_016 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_016"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_016"]);
                    model.Load_Parm_017 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_017"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_017"]);
                    model.Load_Parm_018 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_018"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_018"]);
                    model.Load_Parm_019 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_019"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_019"]);
                    model.Load_Parm_020 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_020"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_020"]);
                    model.Load_Parm_021 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_021"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_021"]);
                    model.Load_Parm_022 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_022"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_022"]);
                    model.Load_Parm_023 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_023"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_023"]);
                    model.Load_Parm_024 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_024"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_024"]);

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
        public List<Tb_LoadModel> GetLoad(int Load_Type, string Load_Date)
        {
            List<Tb_LoadModel> list = new List<Tb_LoadModel>();
            string sql = "select * from Tb_Load WHERE Load_Type = " + Load_Type + " AND Load_Date='" + Load_Date + "'  ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_LoadModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_LoadModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    model.Load_Type = Convert.ToInt32(string.IsNullOrEmpty(dt.Rows[i]["Load_Type"].ToString()) ? "0" : dt.Rows[i]["Load_Type"]);
                    model.Load_Date = Convert.ToDateTime(string.IsNullOrEmpty(dt.Rows[i]["Load_Date"].ToString()) ? "1900-01-01" : dt.Rows[i]["Load_Date"]).ToString("yyyy-MM-dd");
                    model.Load_Parm_001 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_001"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_001"]);
                    model.Load_Parm_002 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_002"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_002"]);
                    model.Load_Parm_003 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_003"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_003"]);
                    model.Load_Parm_004 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_004"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_004"]);
                    model.Load_Parm_005 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_005"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_005"]);
                    model.Load_Parm_006 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_006"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_006"]);
                    model.Load_Parm_007 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_007"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_007"]);
                    model.Load_Parm_008 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_008"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_008"]);
                    model.Load_Parm_009 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_009"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_009"]);
                    model.Load_Parm_010 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_010"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_010"]);
                    model.Load_Parm_011 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_011"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_011"]);
                    model.Load_Parm_012 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_012"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_012"]);
                    model.Load_Parm_013 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_013"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_013"]);
                    model.Load_Parm_014 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_014"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_014"]);
                    model.Load_Parm_015 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_015"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_015"]);
                    model.Load_Parm_016 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_016"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_016"]);
                    model.Load_Parm_017 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_017"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_017"]);
                    model.Load_Parm_018 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_018"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_018"]);
                    model.Load_Parm_019 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_019"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_019"]);
                    model.Load_Parm_020 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_020"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_020"]);
                    model.Load_Parm_021 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_021"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_021"]);
                    model.Load_Parm_022 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_022"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_022"]);
                    model.Load_Parm_023 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_023"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_023"]);
                    model.Load_Parm_024 = Convert.ToSingle(string.IsNullOrEmpty(dt.Rows[i]["Load_Parm_024"].ToString()) ? "0" : dt.Rows[i]["Load_Parm_024"]);

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
        public int InsertLoad(Tb_LoadModel model)
        {
            int right = 0;
            string sql = "";
            //1  小于3  添加
            //  1  是否包含  是  修改
            //  2  是否包含  否  添加

            List<Tb_LoadModel> list = GetLoad();
            if (list.FindAll(a => a.Load_Type == model.Load_Type).Count < 3)
            {
                if (list.FindAll(a => a.Load_Type == model.Load_Type && Convert.ToDateTime(a.Load_Date).ToString("yyyy-M-d") == model.Load_Date).Count > 0)
                {
                    sql = @"UPDATE Tb_Load SET Load_Type = " + model.Load_Type + ",Load_Date = '" + model.Load_Date + "' ,Load_Parm_001 = " + model.Load_Parm_001 +
                          " ,Load_Parm_002 = " + model.Load_Parm_002 + ",Load_Parm_003 = " + model.Load_Parm_003 + ",Load_Parm_004 = " + model.Load_Parm_004 +
                          ",Load_Parm_005 =" + model.Load_Parm_005 + ",Load_Parm_006 = " + model.Load_Parm_006 + ",Load_Parm_007 = " + model.Load_Parm_007 +
                          ",Load_Parm_008 = " + model.Load_Parm_008 + ",Load_Parm_009 = " + model.Load_Parm_009 + ",Load_Parm_010 = " + model.Load_Parm_010 +
                          ",Load_Parm_011 = " + model.Load_Parm_011 + ",Load_Parm_012 =" + model.Load_Parm_012 + ",Load_Parm_013 =" + model.Load_Parm_013 +
                          ",Load_Parm_014 =" + model.Load_Parm_014 + ",Load_Parm_015 = " + model.Load_Parm_015 + ",Load_Parm_016 =" + model.Load_Parm_016 +
                          ",Load_Parm_017 = " + model.Load_Parm_017 + ",Load_Parm_018 =" + model.Load_Parm_018 + ",Load_Parm_019 =" + model.Load_Parm_019 +
                          ",Load_Parm_020 =" + model.Load_Parm_020 + ",Load_Parm_021 =" + model.Load_Parm_021 + ",Load_Parm_022 =" + model.Load_Parm_022 +
                          ",Load_Parm_023 =" + model.Load_Parm_023 + ",Load_Parm_024 =" + model.Load_Parm_024 + "WHERE Load_Date='" + model.Load_Date + "' AnD Load_Type=" + model.Load_Type;
                }
                else
                {
                    sql = @"INSERT INTO Tb_Load (Load_Type,Load_Date,Load_Parm_001,Load_Parm_002,Load_Parm_003,Load_Parm_004,Load_Parm_005,Load_Parm_006,Load_Parm_007 ,Load_Parm_008
                       ,Load_Parm_009,Load_Parm_010,Load_Parm_011,Load_Parm_012,Load_Parm_013 ,Load_Parm_014 ,Load_Parm_015,Load_Parm_016 ,Load_Parm_017 ,Load_Parm_018,Load_Parm_019,Load_Parm_020
                       ,Load_Parm_021,Load_Parm_022,Load_Parm_023,Load_Parm_024) VALUES(" + model.Load_Type + ",'" + model.Load_Date + "'," + model.Load_Parm_001 + "," + model.Load_Parm_002 + ","
                          + model.Load_Parm_003 + "," + model.Load_Parm_004 + "," + model.Load_Parm_005 + "," + model.Load_Parm_006 + "," + model.Load_Parm_007 + "," + model.Load_Parm_008 +
                           ", " + model.Load_Parm_009 + "," + model.Load_Parm_010 + "," + model.Load_Parm_011 + "," + model.Load_Parm_012 + "," + model.Load_Parm_013 + "," + model.Load_Parm_014 +
                           "," + model.Load_Parm_015 + "," + model.Load_Parm_016 + "," + model.Load_Parm_017 + "," + model.Load_Parm_018 + "," + model.Load_Parm_019 + "," + model.Load_Parm_020 +
                           "," + model.Load_Parm_021 + "," + model.Load_Parm_022 + "," + model.Load_Parm_023 + "," + model.Load_Parm_024 + ")";
                }
                right = DataAccess.ExecuteNoQueryGetValue(sql);
            }
            //2  大于3  删除添加
            //  1  是否包含  是  修改
            //  2  是否包含  否  删除添加
            else
            {
                List<string> listStr = new List<string>();
                if (list.FindAll(a => a.Load_Type == model.Load_Type && Convert.ToDateTime(a.Load_Date).ToString("yyyy-M-d") == model.Load_Date).Count > 0)
                {
                    sql = @"UPDATE Tb_Load SET Load_Type = " + model.Load_Type + ",Load_Date = '" + model.Load_Date + "' ,Load_Parm_001 = " + model.Load_Parm_001 +
                          " ,Load_Parm_002 = " + model.Load_Parm_002 + ",Load_Parm_003 = " + model.Load_Parm_003 + ",Load_Parm_004 = " + model.Load_Parm_004 +
                          ",Load_Parm_005 =" + model.Load_Parm_005 + ",Load_Parm_006 = " + model.Load_Parm_006 + ",Load_Parm_007 = " + model.Load_Parm_007 +
                          ",Load_Parm_008 = " + model.Load_Parm_008 + ",Load_Parm_009 = " + model.Load_Parm_009 + ",Load_Parm_010 = " + model.Load_Parm_010 +
                          ",Load_Parm_011 = " + model.Load_Parm_011 + ",Load_Parm_012 =" + model.Load_Parm_012 + ",Load_Parm_013 =" + model.Load_Parm_013 +
                          ",Load_Parm_014 =" + model.Load_Parm_014 + ",Load_Parm_015 = " + model.Load_Parm_015 + ",Load_Parm_016 =" + model.Load_Parm_016 +
                          ",Load_Parm_017 = " + model.Load_Parm_017 + ",Load_Parm_018 =" + model.Load_Parm_018 + ",Load_Parm_019 =" + model.Load_Parm_019 +
                          ",Load_Parm_020 =" + model.Load_Parm_020 + ",Load_Parm_021 =" + model.Load_Parm_021 + ",Load_Parm_022 =" + model.Load_Parm_022 +
                          ",Load_Parm_023 =" + model.Load_Parm_023 + ",Load_Parm_024 =" + model.Load_Parm_024 + "WHERE Load_Date='" + model.Load_Date + "' AnD Load_Type=" + model.Load_Type;
                    right = DataAccess.ExecuteNoQueryGetValue(sql);
                }
                else
                {
                    string sql1 = "DELETE FROM Tb_Load WHERE ID=" + list.Find(a => a.Load_Type == model.Load_Type).ID;
                    listStr.Add(sql1);
                    sql = @"INSERT INTO Tb_Load (Load_Type,Load_Date,Load_Parm_001,Load_Parm_002,Load_Parm_003,Load_Parm_004,Load_Parm_005,Load_Parm_006,Load_Parm_007 ,Load_Parm_008
                       ,Load_Parm_009,Load_Parm_010,Load_Parm_011,Load_Parm_012,Load_Parm_013 ,Load_Parm_014 ,Load_Parm_015,Load_Parm_016 ,Load_Parm_017 ,Load_Parm_018,Load_Parm_019,Load_Parm_020
                       ,Load_Parm_021,Load_Parm_022,Load_Parm_023,Load_Parm_024) VALUES(" + model.Load_Type + ",'" + model.Load_Date + "'," + model.Load_Parm_001 + "," + model.Load_Parm_002 + ","
                          + model.Load_Parm_003 + "," + model.Load_Parm_004 + "," + model.Load_Parm_005 + "," + model.Load_Parm_006 + "," + model.Load_Parm_007 + "," + model.Load_Parm_008 +
                           ", " + model.Load_Parm_009 + "," + model.Load_Parm_010 + "," + model.Load_Parm_011 + "," + model.Load_Parm_012 + "," + model.Load_Parm_013 + "," + model.Load_Parm_014 +
                           "," + model.Load_Parm_015 + "," + model.Load_Parm_016 + "," + model.Load_Parm_017 + "," + model.Load_Parm_018 + "," + model.Load_Parm_019 + "," + model.Load_Parm_020 +
                           "," + model.Load_Parm_021 + "," + model.Load_Parm_022 + "," + model.Load_Parm_023 + "," + model.Load_Parm_024 + ")";
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
        public List<string> GetLoadDate()
        {
            List<string> list = new List<string>();
            string sql = @"  SELECT DISTInCT(Load_Date) FROM Tb_Load ORDER BY Load_Date";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                string str;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    str = dt.Rows[i]["Load_Date"].ToString();
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
