// 1.  Create a program that have an array with the size 5
// 2.   Add array of names that inclusive of your name
// 3.   Print all names using for loop
// 4.   Get a name from the user to search in array
// 5.   Ensure the presence of that name in the array for loop if name is present then print 
//"The name is present in array" and print the index value of that name. else "The name is not present in array"
// (Only one time)
// 6.   Find the presence of that name in the array using foreach loop and print 
//"The name is present in array" , else " The name is not present in array" (Only one time)
// Inputs: Mani, Ganesh, Venkat, Suresh, Venkat
using System;
namespace ArrayTest;
class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] array2 = new string[n];
        Console.WriteLine("Enter The Names:");
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = Console.ReadLine();
        }
        Console.WriteLine("The names are:");
        foreach (string i in array2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Input from user: ");
        string user = Console.ReadLine();
        bool temp = true;
        foreach (string i in array2)
        {
            if (user == i)
            {
                temp = false;
                Console.WriteLine("The name is present in array");
            }

        }
        if (temp)
            Console.WriteLine("The name is not present in array");

    }
}