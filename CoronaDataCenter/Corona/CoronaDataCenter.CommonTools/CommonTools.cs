using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoronaDataCenter.Models;
using System.Collections;

namespace CoronaDataCenter.CommonTools
{
    public class CommonTools
    {
        ///// <summary>
        ///// 获得账户的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetUserSelectList(List<AccountModel> modelList)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (AccountModel item in modelList)
        //    {
        //        list.Add(new SelectListItem() { Text = item.FullName, Value = item.ID.ToString() });
        //    }
        //    return list;
        //}
        ///// 获得角色的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetRoleSelectList(List<RoleModel> modelList)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (RoleModel item in modelList)
        //    {
        //        list.Add(new SelectListItem() { Text = item.Name, Value = item.ID.ToString()  });
        //    }
        //    return list;
        //}
        ///// 根据站点SN获得用户组的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetGroupBySNSelectList(List<StationPermissionModel> modelList)
        //{
        //    GroupManager grMan = new GroupManager();
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (StationPermissionModel item in modelList)
        //    {
        //        if (item.GroupID != null && !string.IsNullOrEmpty(item.GroupID))
        //        {
        //            string[] strArray = item.GroupID.Split(',');    //拆分字符串
        //            for (int i = 0; i < strArray.Length; i++)       //遍历用户组数组
        //            {
        //                if (!string.IsNullOrEmpty(strArray[i]))
        //                {
        //                    GroupModel model = grMan.GetGroups().FirstOrDefault(t => t.ID == Convert.ToInt32(strArray[i]));
        //                    if (model != null)
        //                    {
        //                        list.Add(new SelectListItem() { Text = model.Name, Value = model.ID.ToString() });
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return list;
        //}
        ///// 获得组的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetGroupSelectList(List<GroupModel> modelList)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (GroupModel item in modelList)
        //    {
        //        list.Add(new SelectListItem() { Text = item.Name, Value = item.ID.ToString() });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得组的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetEquimentGroupSelectList(List<EquipmentGroupModel> modelList)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (EquipmentGroupModel item in modelList)
        //    {
        //        list.Add(new SelectListItem() { Text = item.GroupName, Value = item.ID.ToString() });
        //    }
        //    return list;
        //}


        ///// <summary>
        ///// 获得地区省的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetAreaSelectList(List<AreaModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.GroupBy(a => a.Province).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ToList().First().Province, Value = item.ToList().First().ID.ToString() });
        //    }
        //    return list;
        //}

        ///// <summary>
        ///// 获得设备类型的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetEquipTypeSelectList(List<EquipmentTypeModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.GroupBy(a => a.TypeName).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ToList().First().TypeName, Value = item.ToList().First().ID .ToString() });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得设备的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetEquipSelectList(List<EquipmentInfoModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.FindAll(f=>f.IsUsing!=0).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.Name, Value = item.ID.ToString() });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得设备的下拉列表,显示设备的名称及方阵
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetEquipSelectListAddGroup(List<EquipmentInfoModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.FindAll(f => f.IsUsing != 0).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.Name + "#" + item.EqGroupName, Value = item.ID.ToString() });
        //    }
        //    return list;
        //}
        //public static List<SelectListItem> GetGFEquipSelectList(List<EquipmentInfoModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.FindAll(f => f.IsUsing != 0).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.EqGroupName + "#" + item.Name, Value = item.ID.ToString() });
        //    }
        //    return list;
        //}

        //public static List<SelectListItem> GetGFEquipSelectList(List<EquipmentInfoModel> modellist,string StaType)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    if (StaType == "0")
        //    {
        //        foreach (var item in modellist.FindAll(f => f.IsUsing != 0).Distinct())
        //        {
        //            list.Add(new SelectListItem() { Text = item.EqGroupName + "#" + item.Name, Value = item.ID.ToString() });
        //        }
        //    }
        //    else
        //    {
        //        foreach (var item in modellist.FindAll(f => f.IsUsing != 0).Distinct())
        //        {
        //            list.Add(new SelectListItem() { Text = item.Name, Value = item.ID.ToString() });
        //        }
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得设备类型的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetEquipGroupSelectList(List<EquipmentInfoModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.GroupBy(a => a.EqGroup).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ToList().First().EqGroupName.ToString(), Value = item.ToList().First().EqGroup.ToString() });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得设备状态的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>

        //public static List<SelectListItem> GetEquipStatusSelectList(List<EquipmentStatusModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.GroupBy(a => a.StatName).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ToList().First().StatName, Value = item.ToList().First().ID .ToString() });
        //    }
        //    return list;
        //}

        ///// <summary>
        ///// 获得城市的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetCitySelectList(List<AreaModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.GroupBy(a => a.City).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ToList().First().City, Value = item.ToList().First().ID.ToString() });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得城市的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetDistrictSelectList(List<AreaModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.GroupBy(a => a.District).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ToList().First().District, Value = item.ToList().First().ID.ToString() });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得业主的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetOwnerSelectList(List<OwnerModels> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.OrderBy(o=>o.OwnerShortName).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.OwnerShortName, Value = item.ID.ToString() });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得投资方的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetInvestorSelectList(List<InvestorModels> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.OrderBy(o => o.ShortName).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ShortName, Value = item.ID.ToString() });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得运维单位的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetUnitsSelectList(List<UnitsModels> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.OrderBy(o => o.UnitShortName).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.UnitShortName, Value = item.ID.ToString() });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得承建商的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetContractorSelectList(List<ContractorInfoModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.OrderBy(o => o.ContractShortName).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ContractShortName, Value = item.ID.ToString() });
        //    }
        //    return list;
        //}      
        ///// <summary>
        ///// 获得站点的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetStationSelectList(List<StationInfoModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.Name, Value = item.Sn.ToString()+","+item.StaType });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得系统模块的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetModuleSelectList(List<ModuleModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    ArrayList arlist = new ArrayList();
        //    foreach (var it in modellist)
        //    {
        //        if (!arlist.Contains(it.ModPrarent))
        //        {
        //            arlist.Add(it.ModPrarent);
        //        }
        //    }
        //    foreach (var item in modellist.FindAll(f => arlist.Contains(f.ID)).OrderBy(o => o.ModOrder).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ModName, Value = item.ID.ToString() });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得设备生产厂家的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetFactorySelectList(List<EquipmentFactory> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.OrderBy(o => o.FacShortName).Distinct())
        //    {
        //        if (string.IsNullOrEmpty(item.FacShortName))
        //        {
        //            list.Add(new SelectListItem() { Text = item.FacName, Value = item.ID.ToString() });
        //        }
        //        else
        //        {
        //            list.Add(new SelectListItem() { Text = item.FacShortName, Value = item.ID.ToString() });
        //        }
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得设备型号的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetVersionSelectList(List<EquipmentVersion> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.OrderBy(o => o.ModName).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ModName, Value = item.ID.ToString() });
        //    }
        //    return list;
        //}
        //public static string GetFX(double fxvalue)
        //{
        //    string fx = "无风";
        //    if (fxvalue == 0) { fx = "无风"; }
        //    if (fxvalue == 90) { fx = "东风"; }
        //    if (fxvalue == 180) { fx = "南风"; }
        //    if (fxvalue == 270) { fx = "西风"; }
        //    if (fxvalue == 360) { fx = "北风"; }
        //    if (fxvalue < 0)
        //    {
        //        fx = "故障";
        //    }
        //    if (fxvalue > 0 && fxvalue <= 90)
        //    {
        //        fx = "东北风";
        //    }
        //    if (fxvalue > 90 && fxvalue <= 180)
        //    {
        //        fx = "东南风";
        //    }
        //    if (fxvalue > 180 && fxvalue <= 270)
        //    {
        //        fx = "西南风";
        //    }
        //    if (fxvalue > 270 && fxvalue <= 360)
        //    {
        //        fx = "西北风";
        //    }
        //    return fx;
        //}
        ///// <summary>
        ///// 格式化时间 yyyy-MM-dd HH:mm:ss
        ///// </summary>
        ///// <returns></returns>
        //public static string SetTimeStr(string timeStr)
        //{
        //    if (!string.IsNullOrEmpty(timeStr) && timeStr.IndexOf("-") > 0)
        //    {
        //        string[] time = timeStr.Split('-');
        //        string year = time[0];
        //        string month = time[1];
        //        string day = time[2];
        //        if (int.Parse(month) < 10 && month.Length < 2)
        //        {
        //            month = "0" + month;
        //        }
        //        if (int.Parse(day.Split(' ')[0]) < 10 && day.Split(' ')[0].Length < 2)
        //        {
        //            day = "0" + day;
        //        }
        //        return year + "-" + month + "-" + day;
        //    }
        //    else
        //    {
        //        return "";
        //    }
        //}
        ///// <summary>
        ///// 获得月份的天数
        ///// </summary>
        ///// <param name="month"></param>
        ///// <returns></returns>
        //public static int GetDayCountOfMonth(int year,int month)
        //{
        //    int dayNum = 30;
        //    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        //    {
        //        dayNum = 31;
        //    }
        //    else if (month == 2)
        //    {
        //        if (year % 4 == 0 || year % 100 == 0)
        //        {
        //            dayNum = 29;
        //        }
        //        else
        //        {
        //            dayNum = 28;
        //        }
        //    }
        //    return dayNum;
        //}
        ///// <summary>
        ///// 使用特殊符号分隔的字符串返回ArrayList
        ///// </summary>
        ///// <param name="ids"></param>
        ///// <returns></returns>
        //public static ArrayList GetArrayByString(string ids)
        //{            
        //    string[] str = ids.Split(',');
        //    ArrayList arry = new ArrayList();
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        arry.Add(str[i]);
        //    }
        //    return arry;
        //}
        ///// <summary>
        ///// 使用特殊符号分隔ArrayList返回字符串
        ///// </summary>
        ///// <param name="ids"></param>
        ///// <returns></returns>
        //public static string GetStringByArray(ArrayList arrList)
        //{
        //    string str = "";
        //    for (int i = 0; i < arrList.Count; i++)
        //    {
        //        string value = arrList[i].ToString() == "" || arrList[i] == null ? "0" : arrList[i].ToString();
        //        if ("1.#INF -1.#IND".Contains(value)) value = "0";
        //        string itemVal = Convert.ToDouble(value == "1.#INF"?"0":value) <= 0 ? "0" : value.ToString();
        //        str += itemVal + ',';
        //    }
        //    str = str.Length > 0 ? str.Substring(0, str.Length - 1) : "";
        //    return str;
        //}
        ///// <summary>
        ///// 返回ArrayList的字符串
        ///// </summary>
        ///// <param name="ids"></param>
        ///// <returns></returns>
        //public static string GetStrByArray(ArrayList arrList)
        //{
        //    string str = "";
        //    if (arrList!=null&&arrList.Count > 0)
        //    {
        //        foreach (var item in arrList)
        //        {
        //            str += item + ",";
        //        }
        //    }
        //    str = str.Length > 0 ? str.Substring(0, str.Length - 1) : "";
        //    return str;
        //}
        ///// <summary>
        ///// 编码HTML字符串
        ///// </summary>
        ///// <param name="HtmlStr"></param>
        ///// <returns></returns>
        //public static string GetEncodeHtmlString(string HtmlStr)
        //{
        //    return HtmlStr.Replace("<", "〖").Replace(">", "〗");
        //}
        ///// <summary>
        ///// 解码HTML字符
        ///// </summary>
        ///// <param name="HtmlStr"></param>
        ///// <returns></returns>
        //public static string GetDecodeHtmlString(string HtmlStr)
        //{
        //    return HtmlStr.Replace("〖", "<").Replace("〗", ">");
        //}

        ///// <summary>
        ///// 客户端ip(访问用户)
        ///// </summary>
        //public static string GetUserIp
        //{
        //    get
        //    {
        //        string realRemoteIP = "";
        //        if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
        //        {
        //            realRemoteIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].Split(',')[0];
        //        }
        //        if (string.IsNullOrEmpty(realRemoteIP))
        //        {
        //            realRemoteIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
        //        }
        //        if (string.IsNullOrEmpty(realRemoteIP))
        //        {
        //            realRemoteIP = System.Web.HttpContext.Current.Request.UserHostAddress;
        //        }
        //        //if (realRemoteIP.Length<15)
        //        //    realRemoteIP = "localhost";
        //        return realRemoteIP;
        //    }
        //}
        ///// <summary>
        ///// 获得MD5加密的密文，MD5单向加密，即不能被解密
        ///// </summary>
        ///// <param name="getValue"></param>
        //public static string GetMD5(string getValue)
        //{
        //    return FormsAuthentication.HashPasswordForStoringInConfigFile(getValue,"MD5");
        //}

        ///// <summary>
        ///// 获得站点所属设备信息的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetEquInfoSelectList(List<EquipmentInfoModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.GroupBy(a => a.ID).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ToList().First().Name, Value = item.ToList().First().ID.ToString() });
        //    }
        //    return list;
        //}
        
        ///// <summary>
        ///// 获得任务配置的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetTaskSelectList(List<TaskModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.TaskName, Value = item.TaskID.ToString()});
        //    }
        //    return list;
        //}

        ///// <summary>
        ///// 获得任务下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetPlanSelectList(List<PlanModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.PlanName, Value = item.PlanID.ToString() });
        //    }
        //    return list;
        //}

        ///// <summary>
        ///// 获得通道的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetLineSelectList(List<NetLineInfoModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ClName, Value = item.ClID.ToString() });
        //    }
        //    return list;
        //}
        /////// <summary>
        /////// 获得接收人的下拉列表
        /////// </summary>
        /////// <param name="modelList"></param>
        /////// <returns></returns>
        ////public static List<SelectListItem> GetPlanReceiverSelectList(List<PlanModel> modellist)
        ////{
        ////    List<SelectListItem> list = new List<SelectListItem>();
        ////    foreach (var item in modellist.Distinct())
        ////    {
        ////        list.Add(new SelectListItem() { Text = item.PlanReceiverName, Value = item.PlanReceiver });
        ////    }
        ////    return list;
        ////}

        ///// <summary>
        ///// 获得接收人的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetPlanReceiverSelectList(List<TaskModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.PlanReceiverName, Value = item.PlanReceiver });
        //    }
        //    return list;
        //}

        ///// <summary>
        ///// 获取通讯状态的下拉列表
        ///// </summary>
        ///// <param name="modellist"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetNetNodeStatusSelectList(List<FlowStatusModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.GroupBy(a => a.ID).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ToList().First().StatusName, Value = item.ToList().First().ID.ToString() });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获取工作流类别的下拉列表
        ///// </summary>
        ///// <param name="modellist"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetFlowTypeSelectList(List<FlowType> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.GroupBy(a => a.ID).Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ToList().First().FlowsType, Value = item.ToList().First().ID.ToString() });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得资产仓库的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetStockStoreSelectList(List<StationStockStoreModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.StoreName, Value = item.ID });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得资产类型的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetStockTypeSelectList(List<StationStockTypeModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {                
        //        list.Add(new SelectListItem() { Text = item.TypeName, Value = item.ID });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得资产型号的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetStockModelSelectList(List<StationNewStockModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ModelName, Value = item.ID });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得资产生产厂家的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetStockfacturersSelectList(List<StationStockManufacturersModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.ManuName, Value = item.ID });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得资产供应商的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetStockSuppliersSelectList(List<StationStockSuppliersModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.SupName, Value = item.ID });
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获得资产名称的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetStockInfoNameSelectList(List<StationStockInformationModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.IMName+"-"+item.IMBrads+"-"+item.IMSpecifications+"|"+item.IMUnit, Value = item.ID });
        //    }
        //    return list;
        //}

        ///// <summary>
        ///// 获得上网类型下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetFeedInTypeSelectList(List<StationFeedInTypeModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.SftType, Value = item.SftID.ToString() });
        //    }
        //    return list;
        //}

        ///// <summary>
        ///// 获得收益类型下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetProfitTypeSelectList(List<StationProfitTypeModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.SptName, Value = item.SptID.ToString() });
        //    }
        //    return list;
        //}


        ///// <summary>
        ///// 获得通讯节点的下拉列表
        ///// </summary>
        ///// <param name="modelList"></param>
        ///// <returns></returns>
        //public static List<SelectListItem> GetNetNodeSelectList(List<NetNodesInfoModel> modellist)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.CnName, Value = item.CnID.ToString() });
        //    }
        //    return list;
        //}
        
        /// <summary>
        /// 获取工作流类别的下拉列表
        /// </summary>
        /// <param name="modellist"></param>
        /// <returns></returns>
        //public static List<SelectListItem> GetFlowTypeList()
        //{
        //    FlowManager fMan = new FlowManager();
        //    List<FlowType> modellist = fMan.GetFlowType();
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var item in modellist.Distinct())
        //    {
        //        list.Add(new SelectListItem() { Text = item.FlowsType, Value = item.ID.ToString() });
        //    }
        //    return list;
        //}
        /// <summary>
        /// 转换成socket通信数据包的值
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] HexStrTobyte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Trim(), 16);
            return returnBytes;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="DPU"></param>
        /// <param name="DPUID"></param>
        /// <param name="poolID"></param>
        /// <returns></returns>
        public static byte[] GetSocketBuffer(string content, string DPU, string DPUID, string poolID,string endtxt)
        {
            string start = "eb 68 eb 68 00 12 23 00 01 03 ";
            string poolid = Convert.ToInt32(poolID).ToString("X4");
            string[] poolidnum = new string[poolid.Length / 2];
            poolidnum[0] = poolid.Substring(0, 2);
            poolidnum[1] = poolid.Substring(2, 2);
            string pnum = "";
            for (int i = 0; i < poolidnum.Length; i++)
            {
                pnum += poolidnum[i].ToString() + " ";
            }
            string dpu = Convert.ToInt32(DPU).ToString("X8");
            string[] dpudnum = new string[dpu.Length / 2];
            dpudnum[0] = dpu.Substring(0, 2);
            dpudnum[1] = dpu.Substring(2, 2);
            dpudnum[2] = dpu.Substring(4, 2);
            dpudnum[3] = dpu.Substring(6, 2);
            string dnum = "";
            for (int i = 0; i < dpudnum.Length; i++)
            {
                dnum += dpudnum[i].ToString() + " ";
            }

            string dpuid = Convert.ToInt32(DPUID).ToString("X8");
            string[] dpuidnum = new string[dpuid.Length / 2];
            dpuidnum[0] = dpuid.Substring(0, 2);
            dpuidnum[1] = dpuid.Substring(2, 2);
            dpuidnum[2] = dpuid.Substring(4, 2);
            dpuidnum[3] = dpuid.Substring(6, 2);
            string dpnum = "";
            for (int i = 0; i < dpuidnum.Length; i++)
            {
                dpnum += dpuidnum[i].ToString() + " ";
            }

            string end = endtxt;

            float n = Convert.ToSingle(content);
            var b = BitConverter.GetBytes(n);
            string con = BitConverter.ToString(b.Reverse().ToArray()).Replace("-", "");

            string[] num = new string[con.Length / 2];
            num[0] = con.Substring(0, 2);
            num[1] = con.Substring(2, 2);
            num[2] = con.Substring(4, 2);
            num[3] = con.Substring(6, 2);
            string connum = "";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                connum += num[i].ToString() + " ";
            }
            string BW = start + pnum + dnum + dpnum + connum + end;

            return HexStrTobyte(BW);
        }


     

    }
}
