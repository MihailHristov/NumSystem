using System;

namespace _08.BinaryShort
{
    class Program
    {
        static void Main(string[] args)
        {  //condition:https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/04.%20Numeral-Systems/homework/08.%20Binary%20short/README.md
            short n = short.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        }
    }
}
