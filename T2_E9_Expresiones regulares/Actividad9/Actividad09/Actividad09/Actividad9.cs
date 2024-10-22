using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Actividad09
{
    public class Actividad9
    {
        static void Main(string[] args)
        {
        }

        public static bool cadenaContenedora(string cadena, string valor)
        {
            return Regex.IsMatch(cadena, valor, RegexOptions.None);
        }

        public static bool numeroEntero(string v)
        {
            String patron = @"^\d{1,15}\z";

            return Regex.IsMatch(v, patron);
        }

        public static bool isSpanish(string telefono)
        {
            //\+((00)?34)
            throw new NotImplementedException();
        }

        public static bool isCorrectEmail(string email)
        {
            String patron = @"^([\w\.\-\+]+)@([\w\-]+)((\.(\w){2,})+)";

            return Regex.IsMatch(email, patron);
        }

        public static bool numeroPositivo(string v)
        {
            String patron = @"^\d{1,15}\z";

            return Regex.IsMatch(v, patron);
        }

        public static bool isOctal(string v)
        {
            String patron = @"^[0-7]+\z";

            return Regex.IsMatch(v, patron);
        }

        public static bool dni(string v)
        {
            String patron = @"^\d{8}[A-Z]\z";

            return Regex.IsMatch(v, patron);
        }

        public static bool fechaFormat(string v)
        {
            throw new NotImplementedException();
        }

        public static bool isBinario(string v)
        {
            String patron = @"^[1,0]+\z";

            return Regex.IsMatch(v, patron);
        }
    }
}
