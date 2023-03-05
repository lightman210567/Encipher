using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encipher
{
    internal class AtbashCipher
    {
        internal static string Atbash(string PlainText) {
            char[] PlainTextLetters = PlainText.ToCharArray();

            char[] CipherTextLetters = new char[PlainTextLetters.Length];

            int i = 0;
            foreach (char Letter in PlainTextLetters)
            {
                char NewLetter = ReverseLetter(Letter);

                CipherTextLetters[i] = NewLetter;
                i++;
            }

            string CipherText = new string(CipherTextLetters);
            return CipherText;
        }

        internal static char ReverseLetter(char Letter)
        {
            Letter = Char.ToLower(Letter);

            switch (Letter)
            {
                case 'a':
                    return 'z';
                case 'b':
                    return 'y';
                case 'c':
                    return 'x';
                case 'd':
                    return 'w';
                case 'e':
                    return 'v';
                case 'f':
                    return 'u';
                case 'g':
                    return 't';
                case 'h':
                    return 's';
                case 'i':
                    return 'r';
                case 'j':
                    return 'q';
                case 'k':
                    return 'p';
                case 'l':
                    return 'o';
                case 'm':
                    return 'n';
                case 'n':
                    return 'm';
                case 'o':
                    return 'l';
                case 'p':
                    return 'k';
                case 'q':
                    return 'j';
                case 'r':
                    return 'i';
                case 's':
                    return 'h';
                case 't':
                    return 'g';
                case 'u':
                    return 'f';
                case 'v':
                    return 'e';
                case 'w':
                    return 'd';
                case 'x':
                    return 'c';
                case 'y':
                    return 'b';
                case 'z':
                    return 'a';
                case ' ':
                    return ' ';
                default:
                    return ' ';
            }
        }
    }
}
