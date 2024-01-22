using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            if (isMale)         
          {
                Console.WriteLine("You are male.");
            
            }
            else
            {
                Console.WriteLine("You are female.");
            }
            bool isTall = false;
            if (isTall && isMale) 
            { 
             Console.WriteLine("You are both male and tall.");
            }
            else if (!isTall && isMale)
            { 
             Console.WriteLine("You are not tall but you are male.");
            }
            else {
                Console.WriteLine("You are either not tall or not a male");
            }
        }
    }
}
