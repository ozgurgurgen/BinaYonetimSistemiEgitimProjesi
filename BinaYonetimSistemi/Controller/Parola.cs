using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimSistemi.Controller
{
    internal class Parola
    {
        public string ParolaDogrula(string parola, string parolaDogrulama)
        {
            if (parola.Equals(parolaDogrulama))
            {
                return parola;
            }
            else
            {
                return null;
            }
        }
    }
}
