using CoronaDataCenter.ApiConrollers.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Routing;
using System.Web.Security;
using CoronaDataCenter.CommonTools;
using CoronaDataCenter.Models;
using Newtonsoft.Json;

namespace CoronaDataCenter.ApiConrollers
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            var ip1 = ConfigurationManager.AppSettings["ip1"];
            var ip2 = ConfigurationManager.AppSettings["ip2"];
            var ip3 = ConfigurationManager.AppSettings["ip3"];

            config.EnableCors(new EnableCorsAttribute(ip1, ip2, ip3));

            // Web API 路由
            //config.MapHttpAttributeRoutes();

            RouteTable.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "{controller}/{action}/{id}",
               defaults: new { id = RouteParameter.Optional }
               );
            //.RouteHandler = new SessionControllerRouteHandler();
        }
        //校验用户名密码（正式环境中应该是数据库校验）
        public static AccountModel GetTicket(string authorization)
        {
            //解密Ticket
            var strTicket = FormsAuthentication.Decrypt(authorization).UserData;

            //从Ticket里面获取用户名和密码
            var index = strTicket.IndexOf("&");
            string strUser = strTicket.Substring(0, index);
            string strPwd = strTicket.Substring(index + 1);
            strPwd = EncryptionHelper.EncryptedMD5(strPwd).Replace("-", "");
            return null;
            //string cache = RedisCacheHelper.GetSetValue(strUser).ToString();
            //if (string.IsNullOrEmpty(cache))
            //{
            //    return null;
            //}
            //else
            //{
            //    AccountModel userList = JsonConvert.DeserializeObject<AccountModel>(cache);
            //    if (userList != null && userList.Password.Equals(strPwd))
            //    {
            //        return userList;
            //    }
            //    else
            //    {
            //        return null;
            //    }
            //}
        }
    }
}
