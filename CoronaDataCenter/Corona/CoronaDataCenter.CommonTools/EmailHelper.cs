using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;
using CoronaDataCenter.Models;
using System.Configuration;

namespace CoronaDataCenter.CommonTools
{
    public class EmailHelper
    {
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="mailTo">收件箱</param>
        /// <param name="mailSubject">邮箱主题</param>
        /// <param name="mailContent">邮箱内容</param>
        /// <param name="name">站点名称</param>
        /// <returns>返回发送邮箱的结果</returns>
        public static bool SendEmail(string mailTo, string mailSubject, string mailContent, string file, string name)
        {
            try
            {
                // 设置发送方的邮件信息,例如使用网易的smtp
                string smtpServer = string.IsNullOrEmpty(ConfigurationManager.AppSettings["SmtpServer"].ToString()) ? "smtp.163.com" : ConfigurationManager.AppSettings["SmtpServer"].ToString(); //SMTP服务器
                string mailFrom = string.IsNullOrEmpty(ConfigurationManager.AppSettings["EmailFrom"].ToString()) ? "SacredsunIEnergy@163.com" : ConfigurationManager.AppSettings["EmailFrom"].ToString();//登陆用户名
                string userPassword = string.IsNullOrEmpty(ConfigurationManager.AppSettings["EmailFromPWD"].ToString()) ? "sacredsun123" : ConfigurationManager.AppSettings["EmailFromPWD"].ToString();//登陆密码

                //MailAddress From = new MailAddress(mailTo);

                // 邮件服务设置
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
                smtpClient.Host = smtpServer; //指定SMTP服务器
                smtpClient.Credentials = new System.Net.NetworkCredential(mailFrom, userPassword);//用户名和密码
                //smtpClient.Port = 465;

                // 发送邮件设置        
                MailMessage mailMessage = new MailMessage(mailFrom, mailTo); // 发送人和收件人
                mailMessage.Subject = name + "     " + mailSubject;//主题
                mailMessage.Body = mailContent;//内容
                if (System.IO.File.Exists(file))
                {

                    Attachment item = new Attachment(file, MediaTypeNames.Text.Plain);

                    mailMessage.Attachments.Add(item);

                }


                mailMessage.BodyEncoding = Encoding.UTF8;//正文编码
                mailMessage.IsBodyHtml = true;//设置为HTML格式
                mailMessage.Priority = MailPriority.High;//优先级


                smtpClient.Send(mailMessage); // 发送邮件
                return true;
            }
            catch (SmtpException)
            {
                return false;
            }
        }
    }
}
