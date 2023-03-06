using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lightman210567.Encipher
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
