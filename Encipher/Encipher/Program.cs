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
            string ResultingText = "";

            switch (CipherToUse)
            {
                case "caesar cipher":
                    Console.WriteLine("Please input your desired key for the caesar cipher. Only enter numbers.");
                    string KeyInput = Console.ReadLine();
                    int Key = int.Parse(KeyInput);
                    ResultingText = CaesarCipher.CaesarCipherFunction(PlainText, Key);
                    break;
                case "hill cipher":
                    Console.WriteLine("Please your keys (with no spaces, speparated by a '-'");
                    string Keys = Console.ReadLine();
                    string[] SplitKeys = Keys.Split('-');
                    int Key1 = int.Parse(SplitKeys[0]);
                    int Key2 = int.Parse(SplitKeys[1]);
                    int Key3 = int.Parse(SplitKeys[2]);
                    int Key4 = int.Parse(SplitKeys[3]);
                    Console.WriteLine("Would you like to encrypt (enter 'e') or decrypt (enter 'd')");
                    string Operation = Console.ReadLine();
                    Console.WriteLine("Please enter your text to encrypt/decrypt (only letters)");
                    string Text = Console.ReadLine();
                    if (Operation == "e")
                    {
                        ResultingText = HillCipher.HillCipherEncrypt(Text, Key1, Key2, Key3, Key4);
                    }
                    else if (Operation == "d")
                    {
                        ResultingText = HillCipher.HillCipherDecrypt(Text, Key1, Key2, Key3, Key4);
                    }
                    break;
                default:
                    throw new Exception("Cipher input not recognised. Please only enter supported cipher names from the documentation.");
            }

            return ResultingText;
        }
    }
}
