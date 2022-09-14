using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encipher
{
    internal class ModularArtithmetic
    {
        internal static int Modulo(int Modulus, int NumberToModulo)
        {
            int CurrentNumber = NumberToModulo;

            while (CurrentNumber > Modulus)
            {
                CurrentNumber = CurrentNumber - Modulus;
            }

            return CurrentNumber;
        }
    }
}
