using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lightman210567.LetterToNumber;

namespace lightman210567.Encipher
{
    internal class InternalVigenereCipher
    {
        internal static string VigenereEncrypt(string Key, string PlainText)
        {
            char[] PlainTextArray = PlainText.ToCharArray();
            char[] CipherTextArray = new char[PlainTextArray.Length];
            char[] KeyArray = Key.ToCharArray();
            char[] ExtendedKeyArray = new char[PlainTextArray.Length];

            bool KeyExtended = false;

            if (KeyArray.Length == PlainTextArray.Length) // Check if the key is the same length as the plain text
            {

            }
            else
            {
                KeyExtended = true;

                int ArrayIndex = 0;
                foreach (char letter in KeyArray) // Copy KeyArray contents into ExtendedKeyArray
                {
                    ExtendedKeyArray[ArrayIndex] = KeyArray[ArrayIndex];
                    ArrayIndex++;
                }

                int Difference = PlainTextArray.Length - KeyArray.Length; // The number of key characters that need to be added

                while (Difference > 0) // Until the length of the plaintext is equal to the length of the new key array
                {
                    int KeyLength = KeyArray.Length;
                    int KeyArrayIndex = 0;

                    foreach (char KeyLetter in KeyArray) // for every character in the key array :
                    {
                        if (Difference > 0) // if difference is not equal to 0
                        {
                            ExtendedKeyArray[ArrayIndex] = KeyArray[KeyArrayIndex]; // Set the value of ExtendedKeyArray[ArrayIndex] to KeyArray[KeyArrayIndex]

                            ArrayIndex++;
                            KeyArrayIndex++;
                            Difference--;

                            if (KeyArrayIndex > KeyLength) // reset the KeyArrayIndex if it is greater than the KeyLength
                            {
                                KeyArrayIndex = 0;
                            }
                        }
                        else // if the difference is 0, break out of the loop
                        {
                            break;
                        }
                    }
                }
            }

            int ForEachIteration = 0;
            foreach (char Letter in PlainTextArray)
            {
                int LetterKey;

                if (KeyExtended)
                {
                    LetterKey = ExtendedKeyArray[ForEachIteration];
                }
                else
                {
                    LetterKey = KeyArray[ForEachIteration];
                }

                int NumberEquivalent = LetterConverter.LetterConvert(Letter);

                int EncipheredNumber = NumberEquivalent + LetterKey;

                char CipherLetter = LetterConverter.NumberConvert(EncipheredNumber);

                CipherTextArray[ForEachIteration] = CipherLetter;
            }

            string CipherText = CipherTextArray.ToString();

            return CipherText;
        }
    }
}
