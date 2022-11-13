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
        internal static string HillCipherEncrypt(string PlainText, int K1, int K2, int K3, int K4)
        {
            if ((K1 * K4) - (K2 * K3) == -27)
            {
                
            } 
            else
            {
                throw new Exception("THe provided keys to not have a determinant of -27, please only supply valid keys");
            }

            char[] TextArray = PlainText.ToCharArray();

            // Checks if the TextArray's length is divisible by 2 or not.
            if (TextArray.Length % 2 != 0)
            {
                // If not divisible by 2, an extra padding letter is added to the end of the caracter array
                Array.Resize(ref TextArray, +1);
            }

            char[] EncipheredTextArray = new char[TextArray.Length];

            int RemainingBlocks = (int)TextArray.Length / 2;
            int LetterIteration = 0;

            while (RemainingBlocks > 0)
            {
                int P1 = LetterConverter.LetterConvert(TextArray[LetterIteration]);
                LetterIteration++;
                int P2 = LetterConverter.LetterConvert(TextArray[LetterIteration]);
                LetterIteration++;

                int C1 = (K1 * P1) + (K2 * P2);
                int C2 = (K3 * P1) + (K4 * P2);

                int C1Mod = ModularArtithmetic.Modulo(26, C1);
                int C2Mod = ModularArtithmetic.Modulo(26, C2);

                char C1Letter = LetterConverter.NumberConvert(C1Mod);
                char C2Letter = LetterConverter.NumberConvert(C2Mod);

                EncipheredTextArray[LetterIteration - 1] = C1Letter;
                EncipheredTextArray[LetterIteration] = C2Letter;

                RemainingBlocks = RemainingBlocks - 1;
            };

            string EncipheredText = EncipheredTextArray.ToString();
            return EncipheredText;
        }

        internal static string HillCipherDecrypt(string CipherText, int K1, int K2, int K3, int K4)
        {
            char[] CipherTextArray = CipherText.ToCharArray();
            char[] PlainTextArray = new char[CipherTextArray.Length];

            int RemainingBlocks = CipherTextArray.Length / 2;
            int LetterIteration = 0;

            while (RemainingBlocks > 0)
            {
                int C1 = LetterConverter.LetterConvert(CipherTextArray[LetterIteration]);
                LetterIteration++;
                int C2 = LetterConverter.LetterConvert(CipherTextArray[LetterIteration]);
                LetterIteration++;

                int P1 = ((K1 * K4) - (K2 * K3)) * ((K4 * C1) - (K2 * C2)); // The equation to decrypt C1
                int P2 = ((K1 * K4) - (K2 * K3)) * ((-K3 * C1) - (K1 * C2));

                int P1Mod = ModularArtithmetic.Modulo(26, P1);
                int P2Mod = ModularArtithmetic.Modulo(26, P2);

                char P1Letter = LetterConverter.NumberConvert(P1Mod);
                char P2Letter = LetterConverter.NumberConvert(P2Mod);

                PlainTextArray[LetterIteration - 1] = P1Letter;
                PlainTextArray[LetterIteration] = P2Letter;
            }

            string PlainText = PlainTextArray.ToString();
            return PlainText;
        }
    }
}
