using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CoronaDataCenter.ApiConrollers.Controllers
{
    public class ExcelController : BaseApiController
    {
        //
        // GET: /Excel/

      
        //public FileResult Getdownload(string serverpath)
        //{
        //    var name = Path.GetFileName(serverpath);//客户端保存名
        //    string browser = Request.Headers.UserAgent.ToString().ToUpper();
        //    Encoding encoding;
        //    string outputFileName = null;
        //    if (browser.Contains("MS") == true && browser.Contains("IE") == true)
        //    {
        //        outputFileName = HttpUtility.UrlEncode(name);
        //        encoding = System.Text.Encoding.Default;
        //    }
        //    else if (browser.Contains("FIREFOX") == true)
        //    {
        //        encoding = System.Text.Encoding.UTF8;
        //        //encoding = System.Text.Encoding.GetEncoding("GB2312"); 
        //        outputFileName = name;
        //    }
        //    else
        //    {
        //        outputFileName = HttpUtility.UrlEncode(name, System.Text.Encoding.UTF8);
        //    }
        //    return file(serverpath, "application/ms-excel", outputFileName);
        //}

        public IHttpActionResult GetFileFromWebApi(string serverpath)
        {
            var browser = String.Empty;
            if (HttpContext.Current.Request.UserAgent != null)
            {
                browser = HttpContext.Current.Request.UserAgent.ToUpper();
            }
            string filePath = Path.GetFileName(serverpath);
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK);
            FileStream fileStream = File.OpenRead(filePath);
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
