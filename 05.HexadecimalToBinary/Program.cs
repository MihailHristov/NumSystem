using System;
using System.Text;

namespace _05.HexadecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/04.%20Numeral-Systems/homework/05.%20Hexadecimal%20to%20binary/README.md
            string inputHex = Console.ReadLine();
            string resultToBin = HexToBin(inputHex);
            Console.WriteLine(resultToBin);
        }

        static string HexToBin(string inputHex)
        {
            int currentDigit = 0;
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < inputHex.Length; i++)
            {
                if (inputHex[i] >= 'A' && inputHex[i] <= 'F')
                {
                    currentDigit = inputHex[i] - 'A' + 10;
                }
                else
                {
                    currentDigit = int.Parse(inputHex[i].ToString()); //работи само от 0-9
                }

                //parse
                if (i == 0)
                {
                    temp.Append(Convert.ToString(currentDigit, 2));
                }
                else
                {
                    temp.Append(Convert.ToString(currentDigit, 2).PadLeft(4, '0'));
                }
            }

            return temp.ToString();
        }
    }
}
