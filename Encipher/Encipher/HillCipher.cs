using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lightman210567.LetterToNumber;

namespace Encipher
{
    internal class HillCipher
    {
        internal static string HillCipherEncrypt(string PlainText, int K1, int K2, int K3, int k4)
        {
            char[] TextArray = PlainText.ToCharArray();

            // Checks if the TextArray's length is divisible by 2 or not.
            if (TextArray.Length % 2 != 0)
            {
                // If not divisible by 2, an extra padding letter is added to the end of the caracter array
                TextArray[TextArray.Length + 1] = 'x';
            }

            int RemainingBlocks = (int)TextArray.Length / 2;

            while (RemainingBlocks > 0)
            {
                RemainingBlocks = RemainingBlocks - 1;
            };
        }
    }
}
