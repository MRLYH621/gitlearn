﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoronaDataCenter.Business;
using CoronaDataCenter.Models;
using System.Web.Http;
using CoronaDataCenter.ApiConrollers.Controllers;
namespace CoronaDataCenter.Controllers
{
    public class StationController : BaseApiController
    {
        //
        // GET: /Station/

        StationInofManager staman = new StationInofManager();

        /// <summary>
        /// 获取所有电站信息
        /// </summary>
        /// <returns></returns>
        public List<StationInfoModel> GetAllStationInfo()
        {
            List<StationInfoModel> list = new List<StationInfoModel>();
            list = staman.GetAllStationInfo();
            return list;
        }
        /// <summary>
        /// 获取所有电站数据信息
        /// </summary>
        /// <returns></returns>
        [RequestAuthorize]
        public List<StationDataModel> GetStationData()
        {
            List<StationDataModel> list = new List<StationDataModel>();
            list = staman.GetStation();
            return list;
        }
        /// <summary>
        /// 通过Sn获取该系统信息
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        public StationInfoModel GetStationInfoBySn(String sn)
        {
            StationInfoModel model = new StationInfoModel();
            model  = staman.GetAllStationInfo().Find(a=>a.Sn==sn);
            return  model;
        }
        /// <summary>
        /// 根据Sn获取运行评估概览信息:运行评估
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        public List<StationInfoModel> GetAllStaInfoAndEval()
        {
            List<StationInfoModel> model = new List<StationInfoModel>();
            model = staman.GetAllStaInfoAndEval();
            return model;
        }
        
        /// <summary>
        /// 通过Sn获取该系统数据
        /// 
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>

        public StationDataModel GetStationDataBySn(String sn)
        {
            StationDataModel model = new StationDataModel();
            model = staman.GetStation().Find(a=>a.parm_002==sn);
            return model;
        }

    }
}