using HashingExample.HashingAlgorithms;

namespace HashingExample
{
    public class HashAlgorithmFactory
    {
        public static IHashAlgorithm Create(HashType hashType)
        {
            switch (hashType)
            {
                case HashType.SHA256:
                    return new SHA256HashAlgorithm();
                case HashType.SHA1:
                    return new SHA1HashAlgorithm();
                case HashType.MD5:
                    return new MD5HashAlgorithm();
                default:
                    throw new ArgumentException("Unsupported hash algorithm name: " + hashType);
            }
        }
    }
}
