using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoronaDataCenter.Business;
using CoronaDataCenter.Models;
using System.Web.Http;
using CoronaDataCenter.ApiConrollers.Controllers;

namespace CoronaDataCenter.ApiConrollers.Controllers
{
    public class EquipmentController:BaseApiController
    {
        EquipmentManager eqman=new EquipmentManager();
        public List<EquipmentInfoModel> GetAllEquiInfoBySn(String sn)
        {
            List<EquipmentInfoModel> list = new List<EquipmentInfoModel>();
            list = eqman.GetAllEquipmentInfoBySn(sn);
            return list;
        }
    }
}