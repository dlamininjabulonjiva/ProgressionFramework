using System.Collections;

namespace FibonacciSequence
{
    public class FibonacciSequence : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int num1 = 0, num2 = 1;
            while (true)
            {
                yield return num1;
                var tempNum = num1;
                num1 = num2;
                num2 = tempNum + num2;
            }
        }
    }
}
