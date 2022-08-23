using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug23Exercises
{
    internal class addvoid
    {
        static void main(string[] args) {
            int a, b;
            Console.WriteLine("Enter Numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = addition(a,b);
            Console.WriteLine("Sum={0}",c);
            Console.ReadLine();
        }
        static int addition(int c,int k)
        {
            return(c + k);
           
        }
           
    }
}
