using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoronaDataCenter.Models;

namespace CoronaDataCenter.Business
{
    public class TargetConfManager
    {
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public int InsertTargetConf(Tb_Target_ConfModel model)
        {
            int right = 0;
            string sql = @"INSERT INTO Tb_Target_Conf(S_ID,FormulaCode,BindType,DTColSour,DTColumn,Value) VALUES(" + model.S_ID +
                ",'" + model.FormulaCode + "'," + model.BindType + "," + model.DTColSour + ",'" + model.DTColumn + "'," + model.Value + ")";
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>  
        public int UpdateTargetConf(Tb_Target_ConfModel model)
        {
            int right = 0;
            string sql = @"UPDATE dbo.Tb_Target_Conf SET S_ID = " + model.S_ID + ",FormulaCode='" + model.FormulaCode + "' ,BindType = " + model.BindType + " ,DTColSour = " + model.DTColSour +
                " ,DTColumn = '" + model.DTColumn + "'  ,Value = " + model.Value + " WHERE ID=" + model.ID;
            right = DataAccess.ExecuteNoQueryGetValue(sql);
            return right;
        }
    }
}
