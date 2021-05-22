using System;

namespace CsharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzClass result = new FizzBuzzClass("Fizz", "Buzz", "FizzBuzz");

            int num = 100;

            for(int i = 1; i < num; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(result.Fizz);
                } 
                if(i % 5 == 0)
                {
                    Console.WriteLine(result.Buzz);
                } 
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(result.FizzBuzz);
                } else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
