using System;
using System.Text;

namespace _01.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/04.%20Numeral-Systems/homework/01.%20Decimal%20to%20binary/README.md
            ulong inputDecimalNumb = ulong.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            DecimalToBinary(inputDecimalNumb, result);
            Console.WriteLine(result);
        }

        static void DecimalToBinary(ulong inputDecimalNumb, StringBuilder result)
        {
            ulong temp = 0;
            while (inputDecimalNumb != 0)
            {
                temp = inputDecimalNumb % 2;
                result.Append(temp);
                inputDecimalNumb = inputDecimalNumb / 2;
            }
            Reverse(result);
        }

        static void Reverse(StringBuilder result)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                temp.Append(result[result.Length - i - 1]);
            }
            result.Clear();
            result.Append(temp);
        }
    }
}
