using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lightman210567.Encipher
{
    public class Encipher
    {
        public static string Caesar(string PlainText, int Key)
        {
            string CipherText = InternalCaesarCipher.CaesarCipherFunction(PlainText, Key);

            return CipherText;
        }

        public static string AtbashCipher(string PlainText)
        {
            string CipherText = InternalAtbashCipher.Atbash(PlainText);

            return CipherText;
        }

        public static string VigenereEncrypt(string PlainText, string Key)
        {
            string CipherText = InternalVigenereCipher.VigenereEncrypt(Key, PlainText);

            return CipherText;
        }
    }
}
