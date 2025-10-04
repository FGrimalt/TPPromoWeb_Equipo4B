using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace negocio
{
    public static class Validacion
    {
        public static Boolean contieneSoloLetras(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) 
            { 
                return false;
            }
            if (contieneSoloNumeros(text)) 
            {
                return false;
            }
            return true;
        }

        public static Boolean contieneSoloNumeros(string text)
        {            
            return text.Any(c => char.IsDigit(c));
        }

    }
}
