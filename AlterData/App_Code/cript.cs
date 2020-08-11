using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Security.Cryptography;
using System.Text;



namespace AlterData.App_Code
{
    public class cript
    {
        public static TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();

        public static MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

        public static string strCryptKey = "53J35u53P0rN05Qu3mS3r4C0ntr4N05";

        public static string DeCrypt(string strString)
        {

            des.Key = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strCryptKey));

            des.Mode = CipherMode.ECB;

            ICryptoTransform desdencrypt = des.CreateDecryptor();


            //byte[] buff = Convert.FromBase64String(strString);
            byte[] buff = Convert.FromBase64String(strString);

            return ASCIIEncoding.ASCII.GetString(desdencrypt.TransformFinalBlock(buff, 0, buff.Length));

        }

        public static string Crypt(string strString)
        {

            des.Key = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strCryptKey));

            des.Mode = CipherMode.ECB;

            ICryptoTransform desdencrypt = des.CreateEncryptor();

            ASCIIEncoding MyASCIIEncoding = new ASCIIEncoding();

            byte[] buff = ASCIIEncoding.ASCII.GetBytes(strString);

            return Convert.ToBase64String(desdencrypt.TransformFinalBlock(buff, 0, buff.Length));

        }

        public static string MD5Encyrpt1(string strString)
        {

            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();

            byte[] hashedDataBytes = null;

            UTF8Encoding encoder = new UTF8Encoding();

            hashedDataBytes = md5Hasher.ComputeHash(encoder.GetBytes(strString));

            StringBuilder sb = new StringBuilder();

            int i = 0;

            int tempFor1 = hashedDataBytes.Length;

            for (i = 0; i < tempFor1; i = i + i + 1)
            {

                sb.Append(hashedDataBytes[i].ToString());

            }

            return sb.ToString();

        }
    }
}
