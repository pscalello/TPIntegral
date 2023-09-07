using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;



namespace Presentacion
    {
        internal class Utils
        {
            public static int PedirEntre(int x, int y, string mensaje)
            {
                //valida que el dato ingresado sea numero y se encuentre entre el rango x e y
                int numero;
                bool salida = true;
                Console.Write(mensaje);
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out int input))
                        Console.WriteLine("\n" + "El dato ingresado no es un número. Por favor, ingrese un nuevo número");
                    else if (input < x || input > y)
                        Console.WriteLine("\n" + "El valor debe encontrarse entre " + x + " y " + y + ". Por favor, ingrese un nuevo número.");
                    else
                        salida = false;
                    numero = input;
                } while (salida);
                return numero;
            }

            public static string PedirPalabra(string mensaje)
            {
                //valida que el dato ingresado sea un string no vacio
                string reviso;
                do
                {
                    Console.Write(mensaje);
                    reviso = Console.ReadLine();
                    if (string.IsNullOrEmpty(reviso))
                    {
                        Console.Write("El campo no puede estar vací­o." +
                                        "\nPor favor, intente nuevamente \n");
                    }
                } while (string.IsNullOrEmpty(reviso));
                return reviso;
            }

            public static DateTime PedirFechaEntre(DateTime fechaMinima, DateTime fechaMaxima, string mensaje)
            {
                // Valida que la fecha ingresada sea válida y se encuentre entre las fechas mínima y máxima
                DateTime fecha;
                bool salida = true;
                Console.Write(mensaje);

                do
                {
                    if (!DateTime.TryParse(Console.ReadLine(), out DateTime input))
                    {
                        Console.WriteLine("La fecha ingresada no es válida. Por favor, ingrese una nueva fecha (formato: YYYY-MM-DD)");
                    }
                    else if (input < fechaMinima || input > fechaMaxima)
                    {
                        Console.WriteLine($"La fecha debe estar entre {fechaMinima:yyyy-MM-dd} y {fechaMaxima:yyyy-MM-dd}. Por favor, ingrese una nueva fecha.");
                    }
                    else
                    {
                        salida = false;
                    }

                    fecha = input;
                } while (salida);

                return fecha;
            }


            public static string PedirEmail(string mensaje)
            {
                Console.Write(mensaje);

                string email;
                bool isValid;

                do
                {
                    email = Console.ReadLine();
                    isValid = new EmailAddressAttribute().IsValid(email);

                    if (isValid == false)
                    {
                        Console.WriteLine("El email ingresado no es válido. Ingrese un email válido.");
                    }

                } while (isValid != true);

                return email;
            }
        }
    }