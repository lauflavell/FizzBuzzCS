using System;

namespace FizzBuzzCS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 100; i++)
            {
                string print = "";
                
                if(i % 3 == 0)
                {
                    print += "Fizz";
                } 
                if (i % 5 == 0) 
                {
                    print += "Buzz";
                } else print = i.ToString();

                Console.WriteLine(print);   
            }
        }
    }
}
