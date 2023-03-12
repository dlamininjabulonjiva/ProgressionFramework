using System.Security.Cryptography;
using System.Text;

namespace HashingExample.HashingAlgorithms
{
    public class SHA1HashAlgorithm : IHashAlgorithm
    {
        public string ComputeHash(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
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
