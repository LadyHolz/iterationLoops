using System;

namespace whileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loopValue = 0;
            while (loopValue < 5)
            {
                Console.WriteLine("I'm a while loop");
                loopValue++;
            }
        }
    }
}
