using System;

namespace AdditionaTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 13;
            int stop = 12;
            for (int i = 1; i < stop; i++)
            {
                int sum = i * num;
                Console.WriteLine(stop + "x" + i + "=" + sum);
            }
        }
    }
}
