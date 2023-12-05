using System.Reflection;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer1 = Add(0, 1, true);
            Console.WriteLine(answer1);
            var answer2 = Add(2,3);
            Console.WriteLine(answer2);
            var answer3 = Add(3.3m,4.1m);
            Console.WriteLine(answer3);
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool dollars)
            {
                if (dollars && (a + b) != 1)
                {
                    return $"{a + b} dollars";
                }
                else if (dollars && (a + b) == 1)
                {
                    return $"{a + b} dollar";
                }
                else
                {
                    return $"{a + b}";
                }
            }
        
    }
}
