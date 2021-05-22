using System;

namespace CsharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;

            for(int i = 0; i < num; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                } else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } else if(i % 15 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                } else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
