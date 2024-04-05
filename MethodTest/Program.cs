// // Create an application to perform basic mathematical operations Like Addition, Subtraction, Multiplication and Division using return type methods that are with arguments .

// // Ask for two number to do the selected mathematical operation.
// // After accepting the numbers, Display the Menu like below and ask the user to choose an option.
// // Use Switch for the option selection.
// // Addition
// // Subtraction
// // Multiplication
// // Division
// // Use "Do while" to repeat do 
// //the above operation by asking the user whether he wants to continue. 
// //If he enters "Yes", then you need to repeat the process again from asking for the numbers.
// using System;
// namespace MethodTest;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         string choice;
//         do
//         {
//             double num1 = Convert.ToDouble(Console.ReadLine());
//             double num2 = Convert.ToDouble(Console.ReadLine());

//             Console.WriteLine("1. Addition");
//             Console.WriteLine("2. Subtraction");
//             Console.WriteLine("3. Multiplication");
//             Console.WriteLine("4. Division");
//             int ch = Convert.ToInt32(Console.ReadLine());
//             switch (ch)
//             {
//                 case 1:
//                     Console.WriteLine($"Result: {Addition(num1, num2)}");
//                     break;
//                 case 2:
//                     Console.WriteLine($"Result: {Subtraction(num1, num2)}");
//                     break;
//                 case 3:
//                     Console.WriteLine($"Result: {Multiplication(num1, num2)}");
//                     break;
//                 case 4:
//                     Console.WriteLine($"Result: {Division(num1, num2)}");
//                     break;
//             }
//             Console.WriteLine("do you want to continue? (Yes/No)");
//             choice = Console.ReadLine();
//         } while (choice.ToLower() == "yes");

//         static double Addition(double num1, double num2)
//         {
//             return num1 + num2;
//         }
//         static double Subtraction(double num1, double num2)
//         {
//             return num1 - num2;
//         }
//         static double Multiplication(double num1, double num2)
//         {
//             return num1 * num2;
//         }
//         static double Division(double num1, double num2)
//         {
//             if (num2 != 0)
//             {
//                 return num1 / num2;
//             }
//             else
//             {
//                 Console.WriteLine("Cannot divide by zero.");
//                 return double.NaN;
//             }
//         }

//     }
// }

using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int N=int.Parse(Console.ReadLine());
                int num=1;
                int space=N-1;
                do 
                { 
                    //spaces
                    for(int i=0;i<=space;i++)
                    {
                        Console.Write(" ");
                    }
                    //numbers
                    for(int i=0;i<num;i++)
                    {
                        Console.Write(num);
                    }
                    Console.WriteLine();
                    space--;
                    num++;
                }while(num<=N);
            }
        }
            