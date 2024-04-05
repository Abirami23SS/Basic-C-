using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string n = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject1: ");
        double mark1 = double.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2: ");
        double mark2 = double.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject3: ");
        double mark3 = double.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char grade = char.Parse(Console.ReadLine());
        Console.Write("Enter mobile number: ");
        long phn = long.Parse(Console.ReadLine());
        Console.Write("Enter Mail id: ");
        string email = Console.ReadLine();
        double total = mark1 + mark2 + mark3;
        double avg = total / 3;

        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine("Name: " + n);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Mobile: " + phn);
        Console.WriteLine("Marks1: " + mark1);
        Console.WriteLine("Marks2: " + mark2);
        Console.WriteLine("Marks3: " + mark3);
        Console.WriteLine("Total: " + total);
        Console.WriteLine("Average: " + avg);
        //Console.WriteLine(mark1+mark2+mark3/3);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Mail id: " + email);
    }
}