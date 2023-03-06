namespace FibonacciSequence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fibonacciSequence = new FibonacciSequence();
            foreach (int index in fibonacciSequence)
            {
                if (index > 1000)
                    break;
                Console.WriteLine(index);
            }
        }
    }
}