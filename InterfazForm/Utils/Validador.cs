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

        public static bool ValidaEmail(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

        public static bool ValidaNumero(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, @"^[0-9]+$");
        }

    }
}
