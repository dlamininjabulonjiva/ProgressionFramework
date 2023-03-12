using System.Security.Cryptography;
using System.Text;

namespace HashingExample.HashingAlgorithms
{
    public class SHA256HashAlgorithm : IHashAlgorithm
    {
        public string ComputeHash(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
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
