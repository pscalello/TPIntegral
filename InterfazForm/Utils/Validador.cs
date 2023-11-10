using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace InterfazForm.Utils
{
    public static class Validador
    {
        public static bool ValidaPalabra(string input, int largoAdmitido)
        {
            return !string.IsNullOrWhiteSpace(input) && input.Length >= largoAdmitido && Regex.IsMatch(input, @"^[^\s]+$");
        }

        public static bool ValidaPalabraConCaracteresEspeciales(string input, int largoAdmitido)
        {
            return !string.IsNullOrWhiteSpace(input) && input.Length >= largoAdmitido;
        }

        public static bool ValidaEmail(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

        public static bool ValidaNumero(string input, int min, int max)
        {
            if (string.IsNullOrWhiteSpace(input) || !Regex.IsMatch(input, @"^[0-9]+$"))
            {
                return false; // No es un número válido.
            }

            int numero = int.Parse(input); // Parsea input
            return numero >= min && numero <= max; //Comprueba que el número esté entre los parámetros
        }

        public static bool ValidaNumeroLargo(string input, long min, long max)
        {
            if (string.IsNullOrWhiteSpace(input) || !Regex.IsMatch(input, @"^[0-9]+$"))
            {
                return false; // No es un número válido.
            }

            long numero = long.Parse(input); // Parsea input
            return numero >= min && numero <= max; //Comprueba que el número esté entre los parámetros
        }

    }
}
