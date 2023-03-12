namespace HashingExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputString = "Hello, World!";

            DisplaySHA256(inputString);
            DisplaySHA1(inputString);
            DisplayMD5(inputString);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static void DisplaySHA256(string inputString)
        {
            IHashAlgorithm sha256 = HashAlgorithmFactory.Create(HashType.SHA256);
            string hashStringSHA256 = sha256.ComputeHash(inputString);
            Console.WriteLine("Input string: " + inputString);
            Console.WriteLine("Hash algorithm: SHA256");
            Console.WriteLine("Hash value: " + hashStringSHA256);
            Console.WriteLine("Hash length: " + hashStringSHA256.Length);
            Console.WriteLine("..............................................................................................................");
        }

        public static void DisplaySHA1(string inputString)
        {
            IHashAlgorithm sha1 = HashAlgorithmFactory.Create(HashType.SHA1);
            string hashStringSHA1 = sha1.ComputeHash(inputString);
            Console.WriteLine("Input string: " + inputString);
            Console.WriteLine("Hash algorithm: SHA1");
            Console.WriteLine("Hash value: " + hashStringSHA1);
            Console.WriteLine("Hash length: " + hashStringSHA1.Length);
            Console.WriteLine("..............................................................................................................");
        }

        public static void DisplayMD5(string inputString)
        {
            IHashAlgorithm md5 = HashAlgorithmFactory.Create(HashType.MD5);
            string hashStringMD5 = md5.ComputeHash(inputString);
            Console.WriteLine("Input string: " + inputString);
            Console.WriteLine("Hash algorithm: MD5");
            Console.WriteLine("Hash value: " + hashStringMD5);
            Console.WriteLine("Hash length: " + hashStringMD5.Length);
        }
    }
}