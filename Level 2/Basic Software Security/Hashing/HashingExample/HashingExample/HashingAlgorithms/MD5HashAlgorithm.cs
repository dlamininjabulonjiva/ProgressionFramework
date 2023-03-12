using System.Security.Cryptography;
using System.Text;

namespace HashingExample.HashingAlgorithms
{
    public class MD5HashAlgorithm: IHashAlgorithm
    {
        public string ComputeHash(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                var stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("X2"));
                }
                return stringBuilder.ToString();
            }
        }
    }
}
