using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encipher
{
    public class Encipher
    {
        public static string EncipherText(string PlainText, string CipherToUse)
        {
            string ResultingText;

            switch (CipherToUse)
            {
                case "caesar cipher":
                    Console.WriteLine("Please input your desired key for the caesar cipher. Only enter numbers.");
                    string KeyInput = Console.ReadLine();
                    int Key = int.Parse(KeyInput);
                    ResultingText = CaesarCipher.CaesarCipherFunction(PlainText, Key);
                    break;
                default:
                    throw new Exception("Cipher input not recognised. Please only enter supported cipher names from the documentation.");
            }

            return ResultingText
        }
    }
}
