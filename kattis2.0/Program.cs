using System;
namespace Tim
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string y = Console.ReadLine();
            string[] z = y.Split(' ');
            int[] q = new int[x];
            int sum = 0;

            for (int i = 0; i < x; i++)
            {
                q[i] = int.Parse(z[i]);
                sum += q[i];
            }
            Console.WriteLine(sum);
            
        }
    }
}