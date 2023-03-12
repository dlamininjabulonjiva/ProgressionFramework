using System;

namespace HashingExample
{
    public interface IHashAlgorithm
    {
        string ComputeHash(string input);
    }
}
