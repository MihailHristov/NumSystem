using System;

namespace _06.BinaryToHexadecimal
{
    class Program
    {
        static string resultHex;

        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/04.%20Numeral-Systems/homework/06.%20Binary%20to%20hexadecimal/README.md
            string input = Console.ReadLine();
            Convert(input);
            Console.WriteLine(resultHex);
        }

        static void Convert(string input)
        {
            string halfByte = null;
            string temp = null;  //разделяме двоичното числло (подаено при входа) на полубайтове
            bool stopLoop = true;

            for (int i = input.Length - 1; i >= 0 && stopLoop == true; i = i - 4)
            {
                for (int subIndex = 0; subIndex < 4; subIndex++)
                {
                    if (i - subIndex >= 0)
                    {
                        temp = input[i - subIndex] + temp;
                    }
                    else //i - subIndex < 0
                    {
                        stopLoop = false;
                        break;
                    }
                }
                halfByte = System.Convert.ToString(temp.PadLeft(4, '0'));
                resultHex = BinToHex(ref halfByte) + resultHex;
                temp = null;
            }
        }

        static string BinToHex(ref string halfByte)
        {
            int digit = 0;
            int position = 0;
            int tempHalfByteResult = 0;
            //calc bin value
            for (int i = 0; i < 4; i++)
            {
                digit = halfByte[i] - '0';
                position = halfByte.Length - i - 1;
                tempHalfByteResult += digit * (int)Math.Pow(2, position);
            }
            //parse to Hexadecimal
            if (tempHalfByteResult > 9) // A <=> F
            {
                char letter = (char)((tempHalfByteResult - 9 - 1) + 'A');
                return letter.ToString();
            }
            else // 0 <=> 9
            {
                return tempHalfByteResult.ToString();
            }
        }
    }
}
