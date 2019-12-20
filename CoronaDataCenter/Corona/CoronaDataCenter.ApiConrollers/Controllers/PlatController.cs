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
    public class PlatController : BaseApiController
    {
        #region Assessmentmodelmanagement

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="User"></param>
        public int AddTarget([FromBody]Tb_TargetModel model)
        {
            TargetManager man = new TargetManager();
            return man.InsertTarget(model);
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="User"></param>
        public int UpdateTarget([FromBody]Tb_TargetModel model)
        {
            TargetManager man = new TargetManager();
            return man.UpdateTarget(model);
        }
        /// <summary>
        /// 查询
        /// </summary>
        public List<Tb_TargetModel> GetTarget()
        {
            TargetManager man = new TargetManager();
            return man.GetTarget();
        }
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="Name"></param>
        public List<Tb_TargetModel> GetTarget(string Name)
        {
            TargetManager man = new TargetManager();
            return man.GetTarget(Name);
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>  
        [System.Web.Http.HttpPost]
        public int DeleteTarget([FromBody]int ID)
        {
            TargetManager man = new TargetManager();
            return man.DeleteTarget(ID);
        }

        #endregion

        #region Economicparameter

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="User"></param>
        public int AddDatum([FromBody]Tb_DatumModel model)
        {
            DatumManager man = new DatumManager();
            return man.InsertDatum(model);
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="User"></param>
        public int UpdateDatum([FromBody]Tb_DatumModel model)
        {
            DatumManager man = new DatumManager();
            return man.UpdateDatum(model);
        }
        /// <summary>
        /// 查询
        /// </summary>
        public List<Tb_DatumModel> GetDatum()
        {
            DatumManager man = new DatumManager();
            return man.GetDatum();
        }
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="Name"></param>
        public List<Tb_DatumModel> GetDatum(string Name)
        {
            DatumManager man = new DatumManager();
            return man.GetDatum(Name);
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>  
        [System.Web.Http.HttpPost]
        public int DeleteDatum([FromBody]int ID)
        {
            DatumManager man = new DatumManager();
            return man.DeleteDatum(ID);
        }

        #endregion

        #region Datumparameter

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="User"></param>
        public int AddEconomy([FromBody]Tb_EconomyModel model)
        {
            EconomyManager man = new EconomyManager();
            return man.InsertEconomy(model);
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="User"></param>
        public int UpdateEconomy([FromBody]Tb_EconomyModel model)
        {
            EconomyManager man = new EconomyManager();
            return man.UpdateEconomy(model);
        }
        /// <summary>
        /// 查询
        /// </summary>
        public List<Tb_EconomyModel> GetEconomy()
        {
            EconomyManager man = new EconomyManager();
            return man.GetEconomy();
        }
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="Name"></param>
        public List<Tb_EconomyModel> GetEconomy(string Name)
        {
            EconomyManager man = new EconomyManager();
            return man.GetEconomy(Name);
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>  
        [System.Web.Http.HttpPost]
        public int DeleteEconomy([FromBody]int ID)
        {
            EconomyManager man = new EconomyManager();
            return man.DeleteEconomy(ID);
        }

        #endregion

        #region Timeallocation

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="User"></param>
        public int AddTOfPrice([FromBody]Tb_TOfPriceModel model)
        {
            EconomyManager man = new EconomyManager();
            return man.InsertTOfPrice(model);
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="User"></param>
        public int UpdateTOfPrice([FromBody]Tb_TOfPriceModel model)
        {
            EconomyManager man = new EconomyManager();
            return man.UpdateTOfPrice(model);
        }
        /// <summary>
        /// 查询
        /// </summary>
        public List<Tb_TOfPriceModel> GetTOfPrice()
        {
            EconomyManager man = new EconomyManager();
            return man.GetTOfPrice();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>  
        [System.Web.Http.HttpPost]
        public int DeleteTOfPrice([FromBody]int ID)
        {
            EconomyManager man = new EconomyManager();
            return man.DeleteTOfPrice(ID);
        }

        #endregion

        #region Evaluationindexsetting

        /// <summary>
        /// 查询
        /// </summary>
        public List<StationTypeModel> GetStationType()
        {
            StationInofManager man = new StationInofManager();
            return man.GetStationType();
        }

        /// <summary>
        /// 查询
        /// </summary>
        public List<StationModeModel> GetStationMode()
        {
            StationInofManager man = new StationInofManager();
            return man.GetStationMode();
        }

        /// <summary>
        /// 查询
        /// </summary>
        public List<StationInfoModel> GetStationInfos(int SysType, int SysMode)
        {
            StationInofManager man = new StationInofManager();
            return man.GetStationInfos(SysType, SysMode);
        }

        /// <summary>
        /// 查询
        /// </summary>
        public List<StationInfoModel> GetStationInfoBySysMode(int SysMode)
        {
            StationInofManager man = new StationInofManager();
            return man.GetStationInfoBySysMode(SysMode);
        }
        /// <summary>
        /// 查询
        /// </summary>
        public List<StationInfoModel> GetStationInfoBySysType(int SysType)
        {
            StationInofManager man = new StationInofManager();
            return man.GetStationInfoBySysType(SysType);
        }

        /// <summary>
        /// 查询
        /// </summary>
        public List<StationInfoModel> GetAllStationInfo()
        {
            StationInofManager man = new StationInofManager();
            return man.GetAllStationInfo();
        }

        /// <summary>
        /// 查询
        /// </summary>
        public List<FieldModel> GetDataSource(int Type)
        {
            TargetManager man = new TargetManager();
            return man.GetDataSource(Type);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="User"></param>
        public int AddTargetConf([FromBody]Tb_Target_ConfModel model)
        {
            TargetConfManager man = new TargetConfManager();
            return man.InsertTargetConf(model);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="User"></param>
        public int UpdateTargetConf([FromBody]Tb_Target_ConfModel model)
        {
            TargetConfManager man = new TargetConfManager();
            return man.UpdateTargetConf(model);
        }

        #endregion
    }
}
