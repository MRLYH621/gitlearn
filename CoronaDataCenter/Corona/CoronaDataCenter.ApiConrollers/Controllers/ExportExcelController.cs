﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web;
using System.IO;
using System.Net.Http.Headers;
using Newtonsoft.Json;


namespace CoronaDataCenter.ApiConrollers.Controllers
{
    public class ExportExcelController : ApiController
    {
        // GET api/exportexcel
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/exportexcel/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/exportexcel
        public void Post([FromBody]string value)
        {
        }

        // PUT api/exportexcel/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/exportexcel/5
        public void Delete(int id)
        {
        }


        public IHttpActionResult GetFileFromWebApi(string serverpath)
        {
            //string serverpath="G:\\94SVN\\project\\区域能源管理系统\\源代码\\CoronaDataCenter\\CoronaDataCenter.ApiConrollers\\Report\\181221-181221.xlsx";
            var browser = String.Empty;
            if (HttpContext.Current.Request.UserAgent != null)
            {
                browser = HttpContext.Current.Request.UserAgent.ToUpper();
            }
          
            string filePath = Path.GetFileName(serverpath);
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK);
            FileStream fileStream = File.OpenRead(System.Web.Hosting.HostingEnvironment.MapPath("/") + "Report\\"+filePath);
            httpResponseMessage.Content = new StreamContent(fileStream);
            httpResponseMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            httpResponseMessage.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            {
                FileName =
                    browser.Contains("FIREFOX")
                        ? Path.GetFileName(filePath)
                        : HttpUtility.UrlEncode(Path.GetFileName(filePath))
                //FileName = HttpUtility.UrlEncode(Path.GetFileName(filePath))
            };

            return ResponseMessage(httpResponseMessage);
        }
    }
}