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
        static string BangRule(int num, int mod, string print)
        {
            if (IsDivisable(num, mod))
            {
                return print += "Bang";
            }
          return print;
        }
        static string BongRule(int num, int mod, string print)
        {
            if (IsDivisable(num, mod))
            {
                return print = "Bong";
            }
          return print;
        }
        static string FezzRule(int num, int mod, string print)
        {
            if (IsDivisable(num, mod))
            {
                if (print.StartsWith("B"))
                {
                    print = print.Insert(0,"Fezz");
                }
                else if (print.StartsWith("F"))
                {
                    print = print.Insert(4, "Fezz");
                }
                else if (print == "")
                {
                    print = "Fezz";
                } 

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
            
            for (int i = 65; i <= 200; i++)
            {
                string print = "";
                print = FizzRule(i, 3, print);
                print = BuzzRule(i, 5, print);
                print = BangRule(i, 7, print);
                print = BongRule(i, 11, print);
                print = FezzRule(i, 13, print);
                Console.WriteLine(print == "" ? i.ToString() : print);   
            }
        }
    }
}
