using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ClassLibrary_GurpoA.Utilidad
{
    internal class CifradoContrasena
    {
        public static CifradoContrasena singleton = new CifradoContrasena();

        public CifradoContrasena()
        {

        }

        public string encryptByMD5(string textToEncrypt)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(textToEncrypt));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
