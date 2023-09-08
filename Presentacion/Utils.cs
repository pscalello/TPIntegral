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
        
            /*no va acá**************************************************************************************************
             
            public static string PedirUsuario(string mensaje, string nombre, string apellido)
            {
                Console.WriteLine(mensaje);
                string usuario;
                bool isValid = false;

            
            do
            {
                usuario = Console.ReadLine();

                // El nombre de usuario debe de tener entre 8 y 15 caracteres
                if (usuario.Length < 8 || usuario.Length > 15)
                {
                    Console.WriteLine("El usuario debe tener entre 8 y 15 caracteres. Vuelva a intentar."); // Fuera del rango de caracteres permitidos
                }
                // El nombre de usuario no puede contener ni el nombre ni el apellido del usuario 
                else if (usuario.ToUpper().Contains(nombre.ToUpper()) || usuario.ToUpper().Contains(apellido.ToUpper()))
                {
                    Console.WriteLine("El usuario no puede contener el nombre y/o apellido. Vuelva a intentar."); // Contiene el nombre o apellido del usuario
                }
                else
                {
                    isValid = true;
                }

                // faltaria agregar la validacion de que el usuario no exista

                foreach (var usuarioEnLista in Usuarios)
                 {
                     if (usuarioEnLista.Usuario == usuario)
                     {
                         return false; ; // Nombre de usuario repetido
                     }
                 }

             


            } while (isValid == false);



                return usuario;

            }

            */
        }
}