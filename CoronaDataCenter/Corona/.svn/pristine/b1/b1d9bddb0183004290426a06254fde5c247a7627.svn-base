using CoronaDataCenter.Business;
using CoronaDataCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CoronaDataCenter.ApiConrollers.Controllers
{
    public class OperController : BaseApiController
    {
        TargetManager tarman= new TargetManager();
        #region Operationoptimization

        /// <summary>
        /// 添加配置
        /// </summary>
        /// <param name="User"></param>
        public int AddSupplyEnergy([FromBody]Tb_SupplyEnergyModel model)
        {
            SupplyEnergyManager man = new SupplyEnergyManager();
            return man.InsertSupplyEnergy(model);
        }

        public List<string> GetSEDate()
        {
            SupplyEnergyManager man = new SupplyEnergyManager();
            return man.GetDate();
        }

        public List<Tb_SupplyEnergyModel> GetSupplyEnergy(string SE_Date)
        {
            SupplyEnergyManager man = new SupplyEnergyManager();
            return man.GetSupplyEnergy(SE_Date);
        }

        #endregion

        #region Load

        /// <summary>
        /// 添加配置
        /// </summary>
        /// <param name="User"></param>
        public int AddLoad([FromBody]Tb_LoadModel model)
        {
            LoadManager man = new LoadManager();
            return man.InsertLoad(model);
        }

        public List<string> GetLoadDate()
        {
            LoadManager man = new LoadManager();
            return man.GetLoadDate();
        }

        public List<Tb_LoadModel> GetLoad(string Load_Date)
        {
            LoadManager man = new LoadManager();
            return man.GetLoad(Load_Date);
        }

        #endregion

        #region GetOptimize

        /// <summary>
        /// 添加配置
        /// </summary>
        /// <param name="User"></param>
        public int AddOSE([FromBody]Tb_Optimize_SEModel model)
        {
            OptimizeManager man = new OptimizeManager();
            return man.InsertOptimize(model);
        }

        public List<string> GetOSEDate()
        {
            OptimizeManager man = new OptimizeManager();
            return man.GetOSEDate();
        }

        public List<Tb_Optimize_SEModel> GetOSE(string OSE_Date)
        {
            OptimizeManager man = new OptimizeManager();
            return man.GetOptimize(OSE_Date);
        }

        #endregion
        #region 李元亨
        public List<Tb_TargetModel> GetTargetBySn(String sn)
        {
            List<Tb_TargetModel> list = new List<Tb_TargetModel>();
            list = tarman.GetTargetBySn(sn);
            return list;
        }
        public List<Tb_TargetModel> GetTarget()
        {
            List<Tb_TargetModel> list = new List<Tb_TargetModel>();
            list = tarman.GetTarget();
            return list;
        }
         
        #endregion
    }
}
