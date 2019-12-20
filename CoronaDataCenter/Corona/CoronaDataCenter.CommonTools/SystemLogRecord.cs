using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoronaDataCenter.Models;
using System.Web;
using System.IO;

namespace CoronaDataCenter.CommonTools
{
    public class SystemLogRecord
    {
        ///// <summary>
        ///// 操作日志记录
        ///// </summary>
        ///// <param name="sysModel"></param>        
        //public void InsertSYSLog(Tb_SysLog sysModel)
        //{

        //    using (var db = new ParkDataCenterEntities1())
        //    {
        //        Tb_SysLog model = new Tb_SysLog()
        //        {
        //            LogUser = 39,
        //            LogIP = sysModel.LogIP,
        //            LogStartTime = DateTime.Now,
        //            LogAction = sysModel.LogAction,
        //            LogContent = sysModel.LogContent,
        //            ModuleCode = sysModel.ModuleCode,
        //            LogEndTime = DateTime.Now
        //        };
        //        db.Tb_SysLog.Add(model);
        //        db.SaveChanges();
        //    }
        //}
    }
}
