// using System;
// namespace DateAndTime;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         DateTime dob = new DateTime(2021, 8, 10, 10, 40, 32);
//         Console.WriteLine("Year: " + dob.Year);
//         Console.WriteLine("Month: " + dob.Month);
//         Console.WriteLine("date: " + dob.Date);
//         Console.WriteLine("Day: " + dob.Day);
//         Console.WriteLine("Hour: " + dob.Hour);
//         Console.WriteLine("Minutes: " + dob.Minute);

//         string str = dob.ToString("yyyy/MM/DD hh:mm:ss tt");
//         string[] s = str.Split(new char[]{'/', ':', ' '});

//         for (int i = s.Length - 1; i >= 0; i++)
//         {
//             Console.Write(s[i] + " ");
//         }
//         Console.WriteLine(" ");

//         DateTime date = new DateTime();
//         bool temp = DateTime.TryParseExact(Console.ReadLine(), "yyyy/MM/dd hh:mm:ss tt", null, System.Globalization.DateTimeStyles.None, out date);

//         while (temp)
//         {
//             Console.WriteLine("Invalid format");
//             temp = DateTime.TryParseExact(Console.ReadLine(), "yyyy/MM/dd hh:mm:ss tt", null, System.Globalization.DateTimeStyles.None, out date);
//         }

//         Console.WriteLine("Year: " + date.Year);
//         Console.WriteLine("Month: " + date.Month);
//         Console.WriteLine("Day: " + date.Day);

//     }
// }

using System;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime();
        bool temp = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date);

        if(temp==true)
        {
            Console.Write("yes");
        }
        else{
            Console.Write("no");
        }
    }
}