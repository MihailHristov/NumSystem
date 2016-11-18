using System;

namespace _03.DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/04.%20Numeral-Systems/homework/03.%20Decimal%20to%20hexadecimal/README.md
            string input = Console.ReadLine();
            long n = long.Parse(input);
            string result = null;
            DeciToHexCalc(input, ref n, ref result);
            Console.WriteLine(result);

        }

        static void DeciToHexCalc(string input, ref long n, ref string result)
        {
            long temp = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (n != 0)
                {
                    temp = n % 16;
                    n = n / 16;
                    if (temp > 9)
                    {
                        char letter = (char)((temp - 9 - 1) + 'A');
                        result = (letter.ToString()) + result;
                    }
                    else
                    {
                        result = temp + result;  //a little concatenation trick is used, to reverse string directly
                    }
                }
                else if (n == 0 & input.Length == 1) //if input value is only one "0"
                {
                    result = "0";
                }
            }
        }
    }
}
