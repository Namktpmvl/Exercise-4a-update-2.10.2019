using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_continue
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = -145;
            Console.WriteLine(Absolute(n));
        }

        public static int Power(int x, int y)
        {
            if (y == 0)
                return 1;
            else if (y % 2 == 0)
                return Power(x, y / 2) * Power(x, y / 2);    
            else
                return x * Power(x, y / 2) * Power(x, y / 2); 
        }

        public static int Square(int n)
        {
            int a = n;
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return a * a;   
        }

        public static int Cube(int n1)
        {
            int a = n1;
            if (n1 == 0)
                return 0;
            else if (n1 == 1)
                return 1;
            else
                return a * a * a;
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true; 
        }

        public static int Absolute(int n)
        {
            if (n < 0)
                return n * -1 ;
            for (int i = 0; i < n; i++)
                if (n > i)
                    return n ;
            return n * -1  ; 

        }
    }
}
