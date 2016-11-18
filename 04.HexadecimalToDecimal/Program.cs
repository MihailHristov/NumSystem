using System;

namespace _04.HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/04.%20Numeral-Systems/homework/04.%20Hexadecimal%20to%20decimal/README.md
            string input = Console.ReadLine();
            string result = HexToDecimal(input);
            Console.WriteLine(result);
        }

        static string HexToDecimal(string input)
        {
            int digit = 0;
            int position = 0;
            ulong tempSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'F')
                {
                    digit = input[i] - 'A' + 10;
                    position = input.Length - i - 1;
                    tempSum += (ulong)digit * (ulong)Math.Pow(16, position);
                }
                else //input[i] >= '0' && input[i] <= '9'
                {
                    digit = int.Parse(input[i].ToString());
                    position = input.Length - i - 1;
                    tempSum += (ulong)digit * (ulong)Math.Pow(16, position);
                }
            }
            return tempSum.ToString();
        }
    }
}
