﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoronaDataCenter.Models;
using System.Data;

namespace CoronaDataCenter.Business
{
    public class EquipmentManager
    {
        public List<EquipmentInfoModel> GetAllEquipmentInfoBySn(String sn)
        {
            List<EquipmentInfoModel> list = new List<EquipmentInfoModel>();
            String sql = "SELECT * FROM dbo.Tb_Equipment_Info a WHERE  a.Sn='"+ sn + "' ";
            DataTable dt = DataAccess.ExecuteGetDataTable(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    EquipmentInfoModel model = new EquipmentInfoModel();
                    model.Sn = String.IsNullOrEmpty(Convert.ToString(dt.Rows[i]["Sn"])) ? "无" : Convert.ToString(dt.Rows[i]["Sn"]);
                    model.EQID = String.IsNullOrEmpty(Convert.ToString(dt.Rows[i]["EQID  "])) ? "无" : Convert.ToString(dt.Rows[i]["EQID  "]);
                    model.EqName = String.IsNullOrEmpty(Convert.ToString(dt.Rows[i]["EqName"])) ? "无" : Convert.ToString(dt.Rows[i]["EqName"]);
                    model.EqStatus = String.IsNullOrEmpty(dt.Rows[i]["EqStatus"].ToString()) ? 0 : Convert.ToInt16(dt.Rows[i]["EqStatus"]);
                    model.EqIsUsing = String.IsNullOrEmpty(dt.Rows[i]["EqIsUsing"].ToString()) ? 0 : Convert.ToInt16(dt.Rows[i]["EqIsUsing"]);
                    model.EqType = String.IsNullOrEmpty(dt.Rows[i]["EqType "].ToString()) ? 0 : Convert.ToInt16(dt.Rows[i]["EqType "]);
                    model.EqFaultInfo = String.IsNullOrEmpty(Convert.ToString(dt.Rows[i]["EqFaultInfo"])) ? "无" : Convert.ToString(dt.Rows[i]["EqFaultInfo"]);
                    model.Eqmodel = String.IsNullOrEmpty(Convert.ToString(dt.Rows[i]["Eqmodel"])) ? "无" : Convert.ToString(dt.Rows[i]["Eqmodel"]);
                    model.EqAdress = String.IsNullOrEmpty(Convert.ToString(dt.Rows[i]["EqAdress"])) ? "无" : Convert.ToString(dt.Rows[i]["EqAdress"]);
                    model.EqFactory = String.IsNullOrEmpty(Convert.ToString(dt.Rows[i]["EqFactory"])) ? "无" : Convert.ToString(dt.Rows[i]["EqFactory"]);
                    model.EqFacTele = String.IsNullOrEmpty(Convert.ToString(dt.Rows[i]["EqFacTele"])) ? "无" : Convert.ToString(dt.Rows[i]["EqFacTele"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}