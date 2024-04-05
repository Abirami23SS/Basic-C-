// You need to get two Input values from user and ask the user about which operation needed to perform
// If user enters '+' you need to perform addition with above data and print the result value,  
// If user enters '-' you need to perform subtraction with above data and print the result value,  
// If user enters '*' you need to perform multiplication with above data and print the result value,  
// If user enters '/' you need to perform division with above data and print the result value,  
// If user enters '%' you need to perform modulo division with above data and print the result value, 
// If user enters anything else you need to show the user that Operation is Invalid. 

using System;
namespace SwitchCase;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers: ");
        double number1=double.Parse(Console.ReadLine());
        double number2=double.Parse(Console.ReadLine());

        char ch=char.Parse(Console.ReadLine());
        switch(ch)
        {
            case '+':
            Console.WriteLine(number1+number2);
            break;
            case '-':
            Console.WriteLine(number1-number2);
            break;
            case '*':
            Console.WriteLine(number1*number2);
            break;
            case '/':
            Console.WriteLine(number1/number2);
            break;
            case '%':
            Console.WriteLine(number1%number2);
            break;
            default:
                Console.WriteLine("Invalid");
            break;
        }
    }
}