using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _12MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //202cb962ac59075b964b07152d234b70
            //202cb962ac59075b964b07152d234b70
            //202cb962ac5975b964b7152d234b70
            string str = "123";
            string md5Str = GetMD5(str);
            Console.WriteLine(md5Str);
            Console.ReadKey();
        }

        public static string GetMD5(string str)
        {
            //创建一个MD5加密的对象
            MD5 md5 = MD5.Create();//new MD5();
            byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
            //返回加密好的MD5字节数组
            byte[] md5Buffer = md5.ComputeHash(buffer);
            //将字节数组转换成字符串
          //  return md5Buffer.ToString();
            //将字节数组中的每个元素都ToString()并且转换成十六进制
            string strNew = null;
            for (int i = 0; i < md5Buffer.Length; i++)
            {
                strNew += md5Buffer[i].ToString("X2");
            }
            return strNew;
           // return System.Text.Encoding.Default.GetString(md5Buffer);

            //ToString GetString    12 21 23   我爱你
        }
    }
}
