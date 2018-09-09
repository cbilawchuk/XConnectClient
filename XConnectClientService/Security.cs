using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace XConnectClientServices
{
    public static class Security
    {
        public static string ComputeMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            Byte[] bytes = ASCIIEncoding.Default.GetBytes(str);
            Byte[] encodedBytes = md5.ComputeHash(bytes);

            return BitConverter.ToString(encodedBytes).Replace("-", "").ToLower();
        }
    }
}