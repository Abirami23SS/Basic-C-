// using System;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         double salary = double.Parse(Console.ReadLine());
//         double annual, takeHome, hra, da, taxes, insurance;
//         if (salary <= 10000)
//         {
//             hra = 0.2 * salary;
//             da = 0.8 * salary;
//         }
//         else if (salary <= 20000)
//         {
//             hra = 0.25 * salary;
//             da = 0.9 * salary;
//         }
//         else
//         {
//             hra = 0.3 * salary;
//             da = 0.95 * salary;
//         }
//         annual = salary + hra + da;
//         taxes = 0.06 * annual;
//         insurance = 0.01 * annual;

//         double grossSalary = annual - taxes - insurance;
//         takeHome = grossSalary / 12;

//         Console.WriteLine("Annual Gross Salary: " + grossSalary);
//         Console.WriteLine("Annual Take-Home Salary: " + takeHome);

//     }
// }

using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int n=int.Parse(Console.ReadLine());
                string num=Console.ReadLine();
                string[] str=num.Split(",");
                int[] a=new int[n];
                for(int i=0;i<n;i++)
                {
                    a[i]=int.Parse(str[i]);
                }
                string num1=Console.ReadLine();
                string[] str1=num.Split(",");
                int[] a1=new int[n];
                for(int i=0;i<n;i++)
                {
                    a1[i]=int.Parse(str1[i]);
                }
                string s="";
                string s1="";
                for(int i=0;i<n;i++)
                {
                    s+=str[i];
                }
                Console.WriteLine(s);
                for(int i=str1.Length-1;i>0;i--)
                {
                    s1+=str1[i];
                }
                Console.Write(s1);
            }
        }
            
