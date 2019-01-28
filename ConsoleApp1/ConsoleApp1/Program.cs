using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 1; t <= T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split('\n');
                double n = double.Parse(space[0]);
                if (IsperfectSquare(n))
                {
                    Console.WriteLine("Case {0}: YES",t);
                }
                else
                {
                    Console.WriteLine("Case {0}: NO",t);
                }
            }
        }
        public static bool IsperfectSquare(double n)
        {
            int root = (int)Math.Sqrt(n);
            return (int)Math.Pow(root, 2) == n;
        }
    }
}