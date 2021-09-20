using System;

namespace FizzBuzzCS
{
    class Program
    {
        static bool IsDivisable(int num, int mod) 
        {
            return num % mod == 0;
        }
        static string FizzRule(int num, int mod, string print)
        {
            if (IsDivisable(num, mod))
            {
                return print += "Fizz";
            }
          return print;
        }
        static string BuzzRule(int num, int mod, string print)
        {
            if (IsDivisable(num, mod))
            {
                return print += "Buzz";
            }
        return print;
        }



        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 100; i++)
            {
                string print = "";
                print = FizzRule(i, 3, print);
                print = BuzzRule(i, 5, print);
                Console.WriteLine(print == "" ? i.ToString() : print);   
            }
        }
    }
}
