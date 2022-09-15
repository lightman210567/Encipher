using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lightman210567.LetterToNumber;

namespace Encipher
{
    internal class CaesarCipher
    {
        internal static string CaesarCipherFunction(string PlainText, int Key)
        {
            char[] TextArray = PlainText.ToCharArray();
            char[] ShiftedTextArray = new char[TextArray.Length];

            int ForEachIteration = 0;
            foreach (char letter in TextArray)
            {
                int NumberEquivalent = LetterConverter.LetterConvert(letter);

                int ShiftedNumber = NumberEquivalent + Key;

                int ModuloNumber = ModularArtithmetic.Modulo(26, ShiftedNumber);

                char NewLetter = LetterConverter.NumberConvert(ModuloNumber);

                ShiftedTextArray[ForEachIteration] = NewLetter;

                ForEachIteration++;
            }

            string ShiftedText = ShiftedTextArray.ToString();
            return ShiftedText;
        }
    }
}
