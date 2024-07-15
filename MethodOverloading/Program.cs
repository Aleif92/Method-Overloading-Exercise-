using System.Net.Sockets;

namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool withDollars)
        {
            if (withDollars && (a + b) != 1)
            {
                return $"{a + b} dollars";
            }
            else if (withDollars && (a + b) == 1)
            {
                return $"{a + b} dollar";
            }
            else
            {
                {
                    return $" {a + b}";
                }
            }
        }
        
        static void Main(string[] args)
        {


           var answer = Add(2, 2);
            Console.WriteLine(answer);

            var sum = Add(2.5m, 2.5m);
            Console.WriteLine(sum);

            var answer1 = Add(0, 1, true);
            Console.WriteLine(answer1);












        }
    }
}
