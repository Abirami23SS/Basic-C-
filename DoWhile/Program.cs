using System;
namespace DoWhile;
class Program
{
    public static void Main(string[] args)
    {
        bool temp1 = false;
        do
        {
            Console.WriteLine("enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
            Console.WriteLine("Do you want to continue? yes/no: ");
            string option = Console.ReadLine();
            if(option!= "yes" && option!="no")
            {
                Console.WriteLine("Invalid input : Enter valid input : ");
                option=Console.ReadLine();
            }if(option=="yes")
            {
                temp1=true;
            }else{
                temp1=false;
            }
        }while(temp1);
    }
}