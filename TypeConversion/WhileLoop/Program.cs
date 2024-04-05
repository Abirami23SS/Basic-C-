//Create a while loop that print 0 to 25 even numbers    Need to get a valid number from the user.

// Using the while loop,  validate the number input.
// If the input number is a valid number, break the loop and print the number.
// If the input number is not in a valid format, 
//show the message as "Invalid input format. Please enter the input in number format".
// Until the user provides a valid number input.

using System;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        // Question 1
        int i = 0;
        while (i <= 25)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
            i++;
        }
      //ques 2
        Console.WriteLine("Enter a number: ");
        int number;
        bool temp1 = int.TryParse(Console.ReadLine(), out number);
        while (!temp1)
        {
            Console.WriteLine("InValid input. Enter a valid Input");
            temp1 = int.TryParse(Console.ReadLine(), out number);
            if (temp1)
            {
                Console.WriteLine("Valid input");
                break;
            }
        }
    }
}