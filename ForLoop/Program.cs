//Calculate the sum of the square of the numbers present between the two number limit

using System;
namespace Forloop;
class Program
{
    public static void Main(string[] args)
    {
        int start=int.Parse(Console.ReadLine());
        int end=int.Parse(Console.ReadLine());
        for(int i=start;i<=end;i++)
        {
            int square= i*i;
            Console.WriteLine(square);
        }
    }
}
