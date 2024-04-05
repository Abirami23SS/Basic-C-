
// If mark is greater than 80, print “Grade A”
// If mark is 61 to 80, print “Grade B”
// If mark is 36 to 60, print “Grade C”
// If mark is less than 36, print “Grade D”
// For anything else print "Invalid Input"

using System;
namespace IfCondition;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter mark: ");
        double mark = double.Parse(Console.ReadLine());
        if (mark > 80 && mark <= 100)
        {
            Console.WriteLine("Grade A");
        }
        else if (mark >= 61 && mark <= 80)
        {
            Console.WriteLine("Grade B");
        }
        else if (mark >= 36 && mark <= 60)
        {
            Console.WriteLine("Grade C");
        }
        else if (mark > 1 && mark < 36)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}