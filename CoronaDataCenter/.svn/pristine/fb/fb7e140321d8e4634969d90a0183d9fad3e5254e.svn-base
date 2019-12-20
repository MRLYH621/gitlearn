using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD;

namespace CoronaDataCenter.CommonTools
{
    public class EncryptionHelper
    {
        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        //public static string EncryptedSHA1(string text)
        //{
        //    return EasyEncryption.SHA.ComputeSHA1Hash(text);           
        //}
        /// <summary>
        /// SHA256加密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        //public static string EncryptedSHA256(string text)
        //{
        //    return EasyEncryption.SHA.ComputeSHA256Hash(text);
        //}
        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="text">被加密明文</param>
        /// <param name="key">密钥</param>
        /// <param name="iv">向量</param>
        /// <returns></returns>
        public static string EncryptedDES(string text, byte[] key, byte[] iv)
        {
            return (new TD.Security.DES()).Encode(key,iv,text);
        }
        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="encryptString">密文</param>
        /// <param name="key">密钥</param>
        /// <param name="iv">向量</param>
        /// <returns></returns>
        public static string DecryptedDES(string text, byte[] key, byte[] iv)
        {
            return (new TD.Security.DES()).Decode(key, iv, text);
        }
        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="text">被加密明文</param>
        /// <param name="key">密钥</param>
        /// <param name="iv">向量</param>
        /// <returns></returns>
        //public static string EncryptedAES(string text, string key, string iv)
        //{
        //   return EasyEncryption.AES.Encrypt(text, key, iv);
        //}
        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="encryptString">密文</param>
        /// <param name="key">密钥</param>
        /// <param name="iv">向量</param>
        /// <returns></returns>
        //public static string DecryptedAES(string encryptString, string key, string iv)
        //{
        //    return EasyEncryption.AES.Decrypt(encryptString, key, iv);
        //}
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string EncryptedMD5(string text)
        {
            TD.Security.MD5 md5 = new TD.Security.MD5();
            return md5.Encode(text);
        }
       
    }
}
