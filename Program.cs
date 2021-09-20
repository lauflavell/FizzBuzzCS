using System;

namespace FizzBuzzCS
{
    class Program
    {
        static bool IsDivisable(int n, int m) 
        {
            return n % m == 0;
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string print = "";

                if(IsDivisable(i,3))
                {
                    print += "Fizz";
                } 
                if (IsDivisable(i,5)) 
                {
                    print += "Buzz";
                } 
                else if (print == "")
                {
                    print = i.ToString();
                }
                Console.WriteLine(print);   
            }
        }
    }
}
