using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoronaDataCenter.Models;

namespace CoronaDataCenter.Business
{
    public class TargetManager
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public List<Tb_TargetModel> GetTarget()
        {
            List<Tb_TargetModel> list = new List<Tb_TargetModel>();
            string sql = "select * from Tb_Target ";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_TargetModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_TargetModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    model.T_Name = dt.Rows[i]["T_Name"].ToString();
                    model.T_Type = dt.Rows[i]["T_Type"].ToString();
                    model.T_Code = dt.Rows[i]["T_Code"].ToString();
                    model.T_Formula = dt.Rows[i]["T_Formula"].ToString();
                    model.listCodes = ResolveFormula(model.T_Formula);

                    model.listCodes = model.listCodes.Distinct().ToList();

                    //model.parm_002 = String.IsNullOrEmpty(Convert.ToString(dt.Rows[i]["parm_002"])) ? "无" : Convert.ToString(dt.Rows[i]["parm_002"]);
                    //model.pt_parm_004 = String.IsNullOrEmpty(dt.Rows[i]["pt_parm_004"].ToString()) ? 0 : Convert.ToSingle(dt.Rows[i]["pt_parm_004"].ToString());  // 指标值	
                    //model.pt_parm_005 = String.IsNullOrEmpty(dt.Rows[i]["pt_parm_005"].ToString()) ? 0 : Convert.ToSingle(dt.Rows[i]["pt_parm_005"].ToString());   //对标值		
                    //model.pt_parm_006 = String.IsNullOrEmpty(dt.Rows[i]["pt_parm_006"].ToString()) ? 0 : Convert.ToSingle(dt.Rows[i]["pt_parm_006"].ToString());   //指标权重	
                    list.Add(model);                                                                                                                               
                }
            }
            return list;
        }

        private List<string> ResolveFormula(string Formula)
        {
            List<string> listStr = new List<string>();
            if (!string.IsNullOrEmpty(Formula)) {
                if (Formula.IndexOf("+") > -1)
                {
                    for (int i = 0; i < Formula.Split('+').Length; i++)
                    {
                        listStr.AddRange(ResolveFormula(Formula.Split('+')[i]));
                    }
                }
                else if (Formula.IndexOf("-") > -1)
                {
                    for (int i = 0; i < Formula.Split('-').Length; i++)
                    {
                        listStr.AddRange(ResolveFormula(Formula.Split('-')[i]));
                    }
                }
                else if (Formula.IndexOf("*") > -1)
                {
                    for (int i = 0; i < Formula.Split('*').Length; i++)
                    {
                        listStr.AddRange(ResolveFormula(Formula.Split('*')[i]));
                    }
                }
                else if (Formula.IndexOf("/") > -1)
                {
                    for (int i = 0; i < Formula.Split('/').Length; i++)
                    {
                        listStr.AddRange(ResolveFormula(Formula.Split('/')[i]));
                    }
                }
                else if (Formula.IndexOf("(") > -1)
                {
                    for (int i = 0; i < Formula.Split('(').Length; i++)
                    {
                        listStr.AddRange(ResolveFormula(Formula.Split('(')[i]));
                    }
                }
                else if (Formula.IndexOf(")") > -1)
                {
                    for (int i = 0; i < Formula.Split(')').Length; i++)
                    {
                        listStr.AddRange(ResolveFormula(Formula.Split(')')[i]));
                    }
                }
                else 
                {
                    listStr.Add(Formula);
                }
            }
            return listStr;
        }

        public List<Tb_TargetModel> GetTargetBySn(String sn)
        {
            List<Tb_TargetModel> list = new List<Tb_TargetModel>();
            string sql = "select * from dbo.Tb_Target_Conf  a   INNER JOIN  dbo.Tb_Target b ON  a.ID=b.ID WHERE a.Sn='"+sn+"' ORDER BY a.ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_TargetModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_TargetModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    model.T_Name = dt.Rows[i]["T_Name"].ToString();
                    model.T_Type = dt.Rows[i]["T_Type"].ToString();
                    model.T_Code = dt.Rows[i]["T_Code"].ToString();
                    model.T_Formula = dt.Rows[i]["T_Formula"].ToString();

                    model.Sn = String.IsNullOrEmpty(Convert.ToString(dt.Rows[i]["Sn"])) ? "无" : Convert.ToString(dt.Rows[i]["Sn"]);
                    model.Value = String.IsNullOrEmpty(dt.Rows[i]["Value"].ToString()) ? 0 : Convert.ToSingle(dt.Rows[i]["Value"].ToString());  // 指标值	
                    model.Benchmarking = String.IsNullOrEmpty(dt.Rows[i]["Benchmarking"].ToString()) ? 0 : Convert.ToSingle(dt.Rows[i]["Benchmarking"].ToString());   //对标值		
                    model.Weight = String.IsNullOrEmpty(dt.Rows[i]["Weight"].ToString()) ? 0 : Convert.ToSingle(dt.Rows[i]["Weight"].ToString());   //指标权重	
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
        public List<Tb_TargetModel> GetTarget(string Name)
        {
            List<Tb_TargetModel> list = new List<Tb_TargetModel>();
            string sql = "select * from Tb_Target WHERE T_Name LIKE '%" + Name + "%' ORDER BY ID";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Tb_TargetModel model;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    model = new Tb_TargetModel();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    model.T_Name = dt.Rows[i]["T_Name"].ToString();
                    model.T_Type = dt.Rows[i]["T_Type"].ToString();
                    model.T_Code = dt.Rows[i]["T_Code"].ToString();
                    model.T_Formula = dt.Rows[i]["T_Formula"].ToString();

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
        public int InsertTarget(Tb_TargetModel model)
        {
            int right = 0;
            model.T_Formula = model.T_Formula.Replace("（","(");
            model.T_Formula = model.T_Formula.Replace("）", ")");
            string sql = @"INSERT INTO Tb_Target(T_Name,T_Type ,T_Code ,T_Formula)VALUES('" + model.T_Name +
                "','" + model.T_Type + "','" + model.T_Code + "','" + model.T_Formula + "')";
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public int UpdateTarget(Tb_TargetModel model)
        {
            int right = 0;
            model.T_Formula = model.T_Formula.Replace("（", "(");
            model.T_Formula = model.T_Formula.Replace("）", ")");
            string sql = @"UPDATE Tb_Target  SET T_Name = '" + model.T_Name + "',T_Type = '" + model.T_Type + "',T_Code = '" + model.T_Code +
                "' ,T_Formula = '" + model.T_Formula + "' WHERE ID = " + model.ID;
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public int DeleteTarget(int ID)
        {
            int right = 0;
            string sql = @"DELETE FROM Tb_Target  WHERE ID = " + ID;
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }

                /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public List<FieldModel> GetDataSource(int Type)
        {
            List<FieldModel> list = new List<FieldModel>();
            string sql = "";
            switch (Type)
            {
                case 1:
                    sql = @"SELECT FieldName,ChinaName FROM Tb_FieldConfiguration WHERE FieldName LIKE 'DZZ%'";
                    DataTable dt = DataAccess.ExecuteGetDataTable(sql);
                    if (dt.Rows.Count > 0)
                    {
                        FieldModel model;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            model = new FieldModel();
                            model.FieldName = dt.Rows[i]["FieldName"].ToString();
                            model.ChinaName = dt.Rows[i]["ChinaName"].ToString();
                            list.Add(model);
                        }
                    }
                    break;
                case 2:
                    DatumManager man = new DatumManager();
                    List<Tb_DatumModel> listD = man.GetDatum();
                    FieldModel model1;
                    foreach (Tb_DatumModel d in listD)
                    {
                        model1 = new FieldModel();
                        model1.FieldName = d.ID.ToString();
                        model1.ChinaName = d.D_Name;
                        list.Add(model1);
                    }
                    break;
                case 3:
                    EconomyManager eman = new EconomyManager();
                    List<Tb_EconomyModel> listE = eman.GetEconomy();
                    FieldModel modele;
                    foreach (Tb_EconomyModel d in listE)
                    {
                        modele = new FieldModel();
                        modele.FieldName = d.ID.ToString();
                        modele.ChinaName = d.P_NAME;
                        list.Add(modele);
                    }
                    break;
            }
            return list;
        }
    }
}
